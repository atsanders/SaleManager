using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;
using SaleManager.db;

namespace SaleManager.UI.OrderManagement
{
    public partial class OrderSearch : Form
    {
        public OrderSearch()
        {
            InitializeComponent();
        }

        private int _saleId;

        private void OrderSearch_Load(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();
            _saleId = (int)saleController.GetOpenSale().id;
            LoadOrderData();
        }

        public void LoadOrderData()
        {
            OrderController orderController = new OrderController();
            List<Order> orders = orderController.GetCompletedOrdersBySaleId(_saleId);

            orders.ForEach(e => e.completedDate = GetCompletedDate(e.number));
            OrderGrid.DataSource = orders;
            SetUpGrid();
        }

        private string GetCompletedDate(string number)
        {
            string hr = number.Substring(0, 2);
            string min = number.Substring(2, 2);
            string sec = number.Substring(4, 2);
            string day = number.Substring(7, 2);
            string month = number.Substring(9, 2);
            string year = number.Substring(11);

            int hour = Convert.ToInt32(hr);
            string ampm = "AM";
            if (hour > 12)
            {
                hour = Convert.ToInt32(hr) - 12;
                ampm = "PM";
            }
            hr = hour.ToString();

            return month + "\\" + day + "\\" + year + " " + hr + ":" + min + ":" + sec + " " + ampm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUpGrid()
        {
            OrderGrid.Columns[1].Visible = false;
            OrderGrid.Columns[2].Visible = false;
            OrderGrid.Columns[3].Visible = false;
            OrderGrid.Columns[5].Visible = false;
            OrderGrid.Columns[4].DisplayIndex = 0;

            OrderGrid.Columns[0].HeaderText = "Order Completed";
            OrderGrid.Columns[0].Width = 150;
            OrderGrid.Columns[4].HeaderText = "Order Number";
            OrderGrid.Columns[4].Width = 100;
            OrderGrid.Columns[6].HeaderText = "Order Total";
            OrderGrid.Columns[6].DefaultCellStyle.Format = "C2";
            OrderGrid.Columns[6].Width = 100;
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            if (OrderGrid.SelectedRows != null && OrderGrid.SelectedRows.Count > 0)
            {
                int orderId;

                int.TryParse(OrderGrid.SelectedRows[0].Cells[2].Value.ToString(), out orderId);

                if (orderId > 0)
                {
                    OrderManagement orderManagementForm = new OrderManagement();
                    orderManagementForm.OrderId = orderId;
                    orderManagementForm.MdiParent = Application.OpenForms.Cast<Form>().SingleOrDefault(f=>f.Name.ToLower() == "form1");
                    this.Hide();
                    orderManagementForm.Show();
                    this.Close();
                }
            }
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnViewItems_Click(null, null);
        }

        private void OrderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnViewItems_Click(null, null);
        }
    }
}

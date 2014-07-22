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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        public int SaleId { private get; set; }
        private Order _order;
        public int OrderId = 0;

        private void ToolStripClose_Click(object sender, EventArgs e)
        {
            if (OrderGrid.Rows.Count == 0)
            {
                OrderController orderController = new OrderController();
                orderController.Cancel();
            }

            this.Close();
        }

        private void ToolStripCompleteOrderButton_Click(object sender, EventArgs e)
        {
            CompleteOrder completeOrderForm = new CompleteOrder();
            completeOrderForm.OrderId = (int)_order.id;
            completeOrderForm.ShowDialog();

            if (completeOrderForm.DialogResult == DialogResult.OK) 
                this.Close();
        }

        private void LoadOrderData()
        {
            OrderItemController orderItemController = new OrderItemController();
            int currentRow = 0;

            if (OrderGrid.CurrentRow != null)
            {
                currentRow = OrderGrid.CurrentRow.Index;
            }

            OrderGrid.DataSource = orderItemController.GetAllByOrderId((int)_order.id);
            SetUpGrid();

            if (OrderGrid.Rows.Count > 0)
            {
                if (OrderGrid.Rows.Count > currentRow)
                {
                    OrderGrid.CurrentCell = OrderGrid.Rows[currentRow].Cells[0];
                }
                else
                {
                    OrderGrid.CurrentCell = OrderGrid.Rows[0].Cells[0];
                }
            }

            if (!Convert.ToBoolean(_order.complete))
            {
                ToolStripCompleteOrderButton.Enabled = OrderGrid.Rows.Count != 0;
                ToolStripRemItemButton.Enabled = OrderGrid.Rows.Count != 0;
                RemoveItemToolStripMenuItem.Enabled = OrderGrid.Rows.Count != 0;
                ToolStripEditItemButton.Enabled = OrderGrid.Rows.Count != 0;
                EditItemToolStripMenuItem.Enabled = OrderGrid.Rows.Count != 0;
            }
            else
            {
                ToolStripCompleteOrderButton.Enabled = false;
                ToolStripRemItemButton.Enabled = false;
                RemoveItemToolStripMenuItem.Enabled = false;
                ToolStripEditItemButton.Enabled = false;
                EditItemToolStripMenuItem.Enabled = false;
                toolStripCancelButton.Enabled = false;
                ToolStripAddItemButton.Enabled = false;

                OrderGrid.Enabled = false;
            }

            ShowTotal();
        }

        private void SetUpGrid()
        {
            OrderGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            OrderGrid.Columns[1].Visible = false;
            OrderGrid.Columns[2].Visible = false;
            OrderGrid.Columns[3].Visible = false;
            OrderGrid.Columns[4].Visible = false;
            OrderGrid.Columns[5].Visible = false;
            OrderGrid.Columns[0].Width = 100;
            OrderGrid.Columns[0].HeaderText = "Seller Name";
            OrderGrid.Columns[6].DefaultCellStyle.Format = "C2";
            OrderGrid.Columns[6].HeaderText = "Item Price";
            OrderGrid.Columns[7].Width = 250;
            OrderGrid.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            OrderGrid.Columns[7].HeaderText = "Item Description";
        }

        private void ToolStripAddItemButton_Click(object sender, EventArgs e)
        {
            OrderItemController.onItemAdded += new OrderItemController.onItemAddedHandler(LoadOrderData);

            AddItem addItemForm = new AddItem();
            addItemForm.OrderId = (int)_order.id;
            addItemForm.ShowDialog();
            string x = "s";
        }

        private void ShowTotal()
        {
            OrderController orderController = new OrderController();

            Form1 mainForm = (Form1)this.MdiParent;

            if (mainForm == null)
            {
                mainForm = (Form1)Application.OpenForms.Cast<Form>().SingleOrDefault(f => f.Name.ToLower() == "form1");
            }

            mainForm.StatusStrip1.Items[1].Text = "Order Total: " + orderController.GetTotal((int)_order.id).ToString("C2");
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            OrderController orderController = new OrderController();

            if (OrderId == 0)
            {
                if (orderController.HasOpenOrder())
                {
                    //alert user
                }

                _order = orderController.Create(SaleId);
            }
            else
            {
                _order = orderController.GetById(OrderId);
            }

            this.Text = "Order: " + _order.number;

            LoadOrderData();
        }

        private void ToolStripEditItemButton_Click(object sender, EventArgs e)
        {
            if (OrderGrid.SelectedRows != null && OrderGrid.SelectedRows.Count > 0)
            {
                int orderItemId;
                double price;
                int sellerId;
                string description;

                int.TryParse(OrderGrid.SelectedRows[0].Cells[3].Value.ToString(), out orderItemId);
                double.TryParse(OrderGrid.SelectedRows[0].Cells[6].Value.ToString(), out price);
                int.TryParse(OrderGrid.SelectedRows[0].Cells[5].Value.ToString(), out sellerId);
                description = OrderGrid.SelectedRows[0].Cells[7].Value.ToString();

                if (orderItemId > 0 && sellerId > 0)
                {
                    EditItem editItemForm = new EditItem();
                    editItemForm.OrderItemId = orderItemId;
                    editItemForm.Price = price;
                    editItemForm.SellerId = sellerId;
                    editItemForm.Description = description;
                    editItemForm.ShowDialog();
                    LoadOrderData();
                }
            }
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripAddItemButton_Click(null, null);
        }

        private void EditItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripEditItemButton_Click(null, null);
        }

        private void OrderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripEditItemButton_Click(null, null);
        }

        private void ToolStripRemItemButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to remove this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (OrderGrid.SelectedRows != null && OrderGrid.SelectedRows.Count > 0)
                {
                    int orderItemId;

                    int.TryParse(OrderGrid.SelectedRows[0].Cells[3].Value.ToString(), out orderItemId);

                    if (orderItemId > 0)
                    {
                        OrderItemController orderItemController = new OrderItemController();
                        orderItemController.Remove(orderItemId);
                        LoadOrderData();
                    }
                }
            }
        }

        private void RemoveItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripRemItemButton_Click(null, null);
        }

        private void toolStripCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;

            if (OrderGrid.Rows.Count > 0)
            {
                dr = MessageBox.Show("Are you sure you wish to cancel this order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dr == DialogResult.Yes)
            {
                OrderController orderController = new OrderController();
                orderController.Cancel();

                this.Close();
            }
        }

        private void OrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 mainForm = (Form1)this.MdiParent;

            mainForm.StatusStrip1.Items[1].Text = "";
        }

        private void OrderGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End && OrderGrid.Rows.Count > 0)
            {
                ToolStripCompleteOrderButton_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                toolStripCancelButton_Click(null, null);
            }
        }
    }
}

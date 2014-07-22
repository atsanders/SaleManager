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
    public partial class AddItem : Form
    {
        public int OrderId { private get; set; }
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            PopulateSellerDropdown();
        }

        private void PopulateSellerDropdown()
        {
            SellerController sellerController = new SellerController();

            cboSeller.DisplayMember = "name";
            cboSeller.ValueMember = "id";
            cboSeller.DataSource = sellerController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboSeller.SelectedIndex > -1)
            {
                if (txtPrice.Text.Trim().Length > 0)
                {
                    OrderItem orderItem = new OrderItem();

                    double price;
                    int sellerId;
                    double.TryParse(txtPrice.Text, out price);
                    int.TryParse(cboSeller.SelectedValue.ToString(), out sellerId);

                    orderItem.price = price;
                    orderItem.sellerId = sellerId;
                    orderItem.description = txtDesc.Text;
                    orderItem.orderId = OrderId;

                    if (orderItem.IsValid)
                    {
                        OrderItemController orderItemController = new OrderItemController();
                        orderItemController.Add(orderItem);

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(orderItem.Validator().ErrorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a price.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid seller.", "Invalid Seller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSeller.Focus();
            }
        }

        private void ClearFields()
        {
            txtPrice.Text = "";
            cboSeller.SelectedIndex = 0;
            txtDesc.Text = "";
            txtPrice.Focus();
        }

        private void AddItem_Shown(object sender, EventArgs e)
        {

            txtPrice.Focus();
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex reMoney = new System.Text.RegularExpressions.Regex(Utility.Validators.Money);

            if (txtPrice.Text.Trim().Length > 0 && !reMoney.IsMatch(txtPrice.Text))
            {
                MessageBox.Show("Please check the price. Ex: 9.99","Invalid Price",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.SelectAll();
                txtPrice.Focus();
            }
        }
    }
}

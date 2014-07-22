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
using SaleManager.Utility;

namespace SaleManager.UI.OrderManagement
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        public double Price { private get; set; }
        public int SellerId { private get; set; }
        public string Description { private get; set; }
        public int OrderItemId { private get; set; }

        private void EditItem_Load(object sender, EventArgs e)
        {
            SellerController sellerController = new SellerController();

            cboSeller.DisplayMember = "name";
            cboSeller.ValueMember = "id";
            cboSeller.DataSource = sellerController.GetAll();
        }

        private void EditItem_Shown(object sender, EventArgs e)
        {
            txtPrice.Text = Price.ToString("C2");
            txtPrice.SelectAll();
            txtPrice.Focus();
            //cboSeller.SelectedValue = SellerId;  //Not sure why this didn't work :(
            int i = 0;
            foreach (Seller seller in cboSeller.Items)
            {
                if (seller.id == SellerId)
                {
                    cboSeller.SelectedIndex = i;
                }
                i++;
            }
            txtDesc.Text = Description;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSeller.SelectedIndex > -1)
            {
                if (txtPrice.Text.Trim().Length > 0)
                {
                    OrderItem orderItem = new OrderItem();

                    double price;
                    int sellerId;
                    double.TryParse(txtPrice.Text.Replace("$", ""), out price);
                    int.TryParse(cboSeller.SelectedValue.ToString(), out sellerId);

                    orderItem.price = price;
                    orderItem.sellerId = sellerId;
                    orderItem.description = txtDesc.Text;
                    orderItem.id = OrderItemId;

                    if (orderItem.IsValid)
                    {
                        OrderItemController orderItemController = new OrderItemController();
                        orderItemController.Edit(orderItem);

                        this.Close();
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
                MessageBox.Show("Please enter a valid seller.", "Invalid Seller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSeller.Focus();
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex reMoney = new System.Text.RegularExpressions.Regex(Utility.Validators.Money);
            
            if (txtPrice.Text.Trim().Length > 0 && !reMoney.IsMatch(txtPrice.Text))
            {
                MessageBox.Show("Please check the price. Ex: 9.99", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.SelectAll();
                txtPrice.Focus();
            }
        }
    }
}

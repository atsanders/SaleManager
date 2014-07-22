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

namespace SaleManager.UI.SellerManagement
{
    public partial class AddSeller : Form
    {
        public AddSeller()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.name = txtName.Text;

            if (seller.IsValid)
            {
                SellerController sellerController = new SellerController();
                sellerController.Add(seller);

                this.Close();
            }
            else
            {
                MessageBox.Show(seller.Validator().ErrorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.SelectAll();
                txtName.Focus();
            }
        }

        private void AddSeller_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.db;
using SaleManager.Controllers;

namespace SaleManager.UI.SellerManagement
{
    public partial class EditSeller : Form
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EditSeller()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSeller_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.id = Id;
            seller.name = txtName.Text;

            if (seller.IsValid)
            {
                SellerController sellerController = new SellerController();
                sellerController.Edit(seller);

                this.Close();
            }
            else
            {
                MessageBox.Show(seller.Validator().ErrorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.SelectAll();
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void EditSeller_Shown(object sender, EventArgs e)
        {
            txtName.SelectAll();
            txtName.Focus();
        }
    }
}

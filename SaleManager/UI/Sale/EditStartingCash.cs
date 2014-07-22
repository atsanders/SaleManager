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

namespace SaleManager.UI.Sale
{
    public partial class EditStartingCash : Form
    {
        public EditStartingCash()
        {
            InitializeComponent();
        }

        public int SellerId { get; set; }
        public int Id { get; set; }
        public double Cash { get; set; }

        private void EditStartingCash_Load(object sender, EventArgs e)
        {
            SellerController sellerController = new SellerController();

            cboContBy.DisplayMember = "name";
            cboContBy.ValueMember = "id";
            cboContBy.DataSource = sellerController.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStartingCash_Shown(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Seller seller in cboContBy.Items)
            {
                if (seller.id == SellerId)
                {
                    cboContBy.SelectedIndex = i;
                }
                i++;
            }
            txtAmount.Text = Cash.ToString("C2");
            cboContBy.SelectAll();
            cboContBy.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboContBy.SelectedIndex > -1)
            {
                if (txtAmount.Text.Trim().Length > 0)
                {
                    StartCash startCash = new StartCash();

                    double amount;
                    int sellerId;
                    double.TryParse(txtAmount.Text.Replace("$", ""), out amount);
                    int.TryParse(cboContBy.SelectedValue.ToString(), out sellerId);

                    startCash.cashAmount = amount;
                    startCash.sellerId = sellerId;
                    startCash.id = Id;

                    if (startCash.IsValid)
                    {
                        StartCashController startCashController = new StartCashController();
                        startCashController.Edit(startCash);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(startCash.Validator().ErrorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an amount.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid seller.", "Invalid Seller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboContBy.Focus();
            }
        }

        
    }
}

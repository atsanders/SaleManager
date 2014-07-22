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
    public partial class AddStartingCash : Form
    {
        public AddStartingCash()
        {
            InitializeComponent();
        }

        public int SaleId { private get; set; }
        public bool KeepOpenOnAdd { private get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboContBy.SelectedIndex > -1)
            {
                if (txtAmount.Text.Trim().Length > 0)
                {
                    int contBy;
                    double cash;

                    int.TryParse(cboContBy.SelectedValue.ToString(), out contBy);
                    double.TryParse(txtAmount.Text.Trim(), out cash);

                    if (contBy > 0 && cash > 0)
                    {
                        StartCash startCash = new StartCash();
                        startCash.saleId = SaleId;
                        startCash.sellerId = contBy;
                        startCash.cashAmount = cash;

                        if (startCash.IsValid)
                        {
                            StartCashController startCashController = new StartCashController();
                            startCashController.Add(startCash);

                            if (!KeepOpenOnAdd)
                            {
                                this.Close();
                            }
                            else
                            {
                                ClearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show(startCash.Validator().ErrorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ClearFields()
        {
            cboContBy.SelectedIndex = 0;
            txtAmount.Text = "";
            cboContBy.Focus();
        }

        private void StartingCash_Load(object sender, EventArgs e)
        {
            SellerController sellerController = new SellerController();

            cboContBy.DisplayMember = "name";
            cboContBy.ValueMember = "id";
            cboContBy.DataSource = sellerController.GetAll();
        }
    }
}

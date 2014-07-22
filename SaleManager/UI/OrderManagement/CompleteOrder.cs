using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;

namespace SaleManager.UI.OrderManagement
{
    public partial class CompleteOrder : Form
    {
        public CompleteOrder()
        {
            InitializeComponent();
        }

        public int OrderId { private get; set; }
        private double _total = 0;

        private void CompleteOrder_Load(object sender, EventArgs e)
        {
            OrderController orderController = new OrderController();
            _total = orderController.GetTotal(OrderId);

            lblTotal.Text = _total.ToString("C2");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OrderController orderController = new OrderController();
            orderController.Complete(OrderId);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetChange();
        }

        private void GetChange()
        {
            lblChange.Text = "";

            if (txtAmountTend.Text.Trim().Length > 0)
            {
                System.Text.RegularExpressions.Regex reMoney = new System.Text.RegularExpressions.Regex(Utility.Validators.Money);
                if (reMoney.IsMatch(txtAmountTend.Text.Trim()))
                {
                    double amountTend;
                    double.TryParse(txtAmountTend.Text.Trim(), out amountTend);

                    if (amountTend > 0)
                    {
                        if (amountTend < _total)
                        {
                            MessageBox.Show("Amount tendered should be greater or equal to order total.", "Amount Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            try
                            {
                                lblChange.Text = CalcChange(amountTend).ToString("C2");
                            }
                            catch
                            {
                                MessageBox.Show("Error calculating change, please check amount.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please check the amount tendered.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmountTend.SelectAll();
                    txtAmountTend.Focus();
                }
            }
        }

        private double CalcChange(double amtTend)
        {
            return amtTend - _total;
        }
    }
}

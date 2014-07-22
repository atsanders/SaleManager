using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;
using SaleManager.UI.OrderManagement;
using SaleManager.UI.SellerManagement;
using SaleManager.UI.Sale;

namespace SaleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();

            if (saleController.IsOpen)
            {
                NewSaleToolStripMenuItem.Enabled = false;
                toolStripOrderButton.Enabled = true;
                NewOrderToolStripMenuItem.Enabled = true;
                ViewTotalsToolStripMenuItem.Enabled = true;
                ToolStripTotals.Enabled = true;
                CloseCurrentSaleToolStripMenuItem.Enabled = true;
                toolStripStartingCash.Enabled = true;
                initialSaleContributionsToolStripMenuItem.Enabled = true;

                StatusStrip1.Items[0].Text = "Sale Created: " + Convert.ToDateTime(saleController.GetOpenSale().startDate).ToLongDateString();
            }
            else
            {
                NewSaleToolStripMenuItem.Enabled = true;
                NewOrderToolStripMenuItem.Enabled = false;
                toolStripOrderButton.Enabled = false;
                ViewTotalsToolStripMenuItem.Enabled = false;
                ToolStripTotals.Enabled = false;
                CloseCurrentSaleToolStripMenuItem.Enabled = false;
                toolStripStartingCash.Enabled = false;
                initialSaleContributionsToolStripMenuItem.Enabled = false;

                StatusStrip1.Items[0].Text = "No sale currently open. To start a new sale, click New Sale under File menu.";
            }
        }

        private void NewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();
            saleController.Open();

            NewSaleToolStripMenuItem.Enabled = false;
            NewOrderToolStripMenuItem.Enabled = true;
            ViewTotalsToolStripMenuItem.Enabled = true;
            ToolStripTotals.Enabled = true;
            CloseCurrentSaleToolStripMenuItem.Enabled = true;
            toolStripOrderButton.Enabled = true;
            toolStripStartingCash.Enabled = true;
            initialSaleContributionsToolStripMenuItem.Enabled = true;

            StatusStrip1.Items[0].Text = "Sale Created: " + Convert.ToDateTime(saleController.GetOpenSale().startDate).ToLongDateString();

            DialogResult dr = MessageBox.Show("Would you like to enter initial contributions?", "Sale Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                AddStartingCash startingCashForm = new AddStartingCash();
                startingCashForm.KeepOpenOnAdd = true;
                startingCashForm.SaleId = (int)saleController.GetOpenSale().id;
                startingCashForm.ShowDialog();
            }
        }

        private void ToolStripManageUsersButton_Click(object sender, EventArgs e)
        {
            SellerManagement sellerManageForm = (SellerManagement)this.MdiChildren.SingleOrDefault<Form>(c => c.Name.ToLower() == "sellermanagement");

            if (sellerManageForm == null)
            {
                sellerManageForm = new SellerManagement();
                sellerManageForm.MdiParent = this;
                sellerManageForm.Show();
            }
            else
            {
                sellerManageForm.BringToFront();
            }
        }

        private void CloseCurrentSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr= MessageBox.Show("Are you sure you wish to close this sale?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                OrderController orderController = new OrderController();
                if (!orderController.HasOpenOrder())
                {
                    CloseSale();
                }
                else
                {
                    dr = MessageBox.Show("There is an open order in this sale. Would you like to cancel the order? If not, click No to go back and complete it.", "Incomplete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        orderController.Cancel();

                        CloseSale();
                    }
                }
            }
        }

        private void CloseSale()
        {
            SaleController saleController = new SaleController();
            saleController.Close();

            NewSaleToolStripMenuItem.Enabled = true;
            NewOrderToolStripMenuItem.Enabled = false;
            ViewTotalsToolStripMenuItem.Enabled = false;
            ToolStripTotals.Enabled = false;
            CloseCurrentSaleToolStripMenuItem.Enabled = false;
            toolStripOrderButton.Enabled = false;
            toolStripStartingCash.Enabled = false;
            initialSaleContributionsToolStripMenuItem.Enabled = false;
            StatusStrip1.Items[0].Text = "No sale currently open. To start a new sale, click New Sale under File menu.";

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void ToolStripNewOrderButton_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagementForm = (OrderManagement)this.MdiChildren.SingleOrDefault<Form>(c => c.Name.ToLower() == "ordermanagement");

            if (orderManagementForm == null)
            {
                SaleController saleController = new SaleController();
                int saleId = (int)saleController.GetOpenSale().id;

                orderManagementForm = new OrderManagement();
                orderManagementForm.SaleId = saleId;
                orderManagementForm.MdiParent = this;
                orderManagementForm.Show();
            }
            else
            {
                orderManagementForm.BringToFront();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            this.Close();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripNewOrderButton_Click(null, null);
        }

        private void ManageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripManageUsersButton_Click(null, null);
        }

        private void ToolStripTotals_Click(object sender, EventArgs e)
        {
            ViewTotal viewTotalForm = new ViewTotal();
            viewTotalForm.ShowDialog();
        }

        private void initialSaleContributionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStartingCash_Click(null, null);
        }

        private void toolStripStartingCash_Click(object sender, EventArgs e)
        {
            StartingCashManagement startingCashManageForm = (StartingCashManagement)this.MdiChildren.SingleOrDefault(c => c.Name.ToLower() == "startingcashmanagement");

            if (startingCashManageForm == null)
            {
                startingCashManageForm = new StartingCashManagement();
                startingCashManageForm.MdiParent = this;
                startingCashManageForm.Show();
            }
            else
            {
                startingCashManageForm.BringToFront();
            }
        }

        private void toolStripOrderButton_Click(object sender, EventArgs e)
        {
            ToolStripNewOrderButton_Click(null, null);
        }

        private void toolStripOrderButton_ButtonClick(object sender, EventArgs e)
        {
            ToolStripNewOrderButton_Click(null, null);
        }

        private void toolStripOrderNew_Click_1(object sender, EventArgs e)
        {
            ToolStripNewOrderButton_Click(null, null);
        }

        private void toolStripOrderComplete_Click(object sender, EventArgs e)
        {
            OrderSearch orderSearchForm = new OrderSearch();
            orderSearchForm.ShowDialog();
        }

        private void ViewTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripTotals_Click(null, null);
        }

        private void newOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripNewOrderButton_Click(null, null);
        }

        private void completedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripOrderComplete_Click(null, null);
        }
    }
}
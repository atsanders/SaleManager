using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;
using SaleManager.Models;

namespace SaleManager.UI.Sale
{
    public partial class ViewTotal : Form
    {
        public ViewTotal()
        {
            InitializeComponent();
        }

        private void ViewTotal_Load(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();
            int saleId = (int)saleController.GetOpenSale().id;

            CompileTotals(saleId);
        }

        private void CompileTotals(int saleId)
        {
            TotalController totalController = new TotalController();
            List<Total> totals = totalController.GetTotalsBySaleId(saleId);

            Total t = new Total();
            t.name = "";
            t.startingContribution = totals.Sum(e => e.startingContribution);
            t.saleTotal = totals.Sum(e => e.saleTotal);
            t.total = totals.Sum(e => e.total);
            totals.Add(t);

            TotalGrid.DataSource = totals;
            SetUpGrid();
        }

        private void SetUpGrid()
        {
            TotalGrid.Columns[0].HeaderText = "Seller Name";
            TotalGrid.Columns[0].Width = 150;
            TotalGrid.Columns[1].HeaderText = "Initial Contributions";
            TotalGrid.Columns[1].Width = 120;
            TotalGrid.Columns[1].DefaultCellStyle.Format = "C2";
            TotalGrid.Columns[2].HeaderText = "Sale Total";
            TotalGrid.Columns[2].DefaultCellStyle.Format = "C2";
            TotalGrid.Columns[2].Width = 100;
            TotalGrid.Columns[3].HeaderText = "Total";
            TotalGrid.Columns[3].DefaultCellStyle.Format = "C2";
            TotalGrid.Columns[3].Width = 100;
        }

        private void ToolStripCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


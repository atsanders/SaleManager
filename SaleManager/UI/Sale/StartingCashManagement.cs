using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;

namespace SaleManager.UI.Sale
{
    public partial class StartingCashManagement : Form
    {
        public StartingCashManagement()
        {
            InitializeComponent();
        }

        public int _saleId;

        private void StartingCashManagement_Load(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();
            _saleId = (int)saleController.GetOpenSale().id;

            LoadStartCashData();
        }

        private void LoadStartCashData()
        {
            int currentRow = 0;

            if (CashGrid.CurrentRow != null)
            {
                currentRow = CashGrid.CurrentRow.Index;
            }

            StartCashController startCashController = new StartCashController();
            CashGrid.DataSource = startCashController.GetAllBySaleId(_saleId);
            SetUpGrid();

            if (CashGrid.Rows.Count > 0)
            {
                if (CashGrid.Rows.Count > currentRow)
                {
                    CashGrid.CurrentCell = CashGrid.Rows[currentRow].Cells[0];
                }
                else
                {
                    CashGrid.CurrentCell = CashGrid.Rows[0].Cells[0];
                }

                ToolStripEditButton.Enabled = true;
                ToolStripDeleteButton.Enabled = true;
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                ToolStripEditButton.Enabled = false;
                ToolStripDeleteButton.Enabled = false;
                EditToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
        }

        private void ToolStripCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUpGrid()
        {
            for (int i = 1; i < 6; i++)
            {
                CashGrid.Columns[i].Visible = false;
            }
            CashGrid.Columns[6].HeaderText = "Amount";
            CashGrid.Columns[6].DefaultCellStyle.Format = "C2";
            CashGrid.Columns[0].Width = 200;
            CashGrid.Columns[0].HeaderText = "Seller Name";

           // CashGrid.Columns[6].Visible = false;
        }

        private void ToolStripAddButton_Click(object sender, EventArgs e)
        {
            AddStartingCash addStartingCashForm = new AddStartingCash();
            addStartingCashForm.KeepOpenOnAdd = false;
            addStartingCashForm.SaleId = _saleId;
            addStartingCashForm.ShowDialog();

            LoadStartCashData();
        }

        private void ToolStripEditButton_Click(object sender, EventArgs e)
        {
            if (CashGrid.SelectedRows != null && CashGrid.SelectedRows.Count > 0)
            {
                int id;
                int sellerId;
                double cash;
                int.TryParse(CashGrid.SelectedRows[0].Cells[3].Value.ToString(), out id);
                int.TryParse(CashGrid.SelectedRows[0].Cells[4].Value.ToString(), out sellerId);
                double.TryParse(CashGrid.SelectedRows[0].Cells[6].Value.ToString(), out cash);

                if (id > 0)
                {
                    EditStartingCash editStartCashForm = new EditStartingCash();
                    editStartCashForm.Id = id;
                    editStartCashForm.SellerId = sellerId;
                    editStartCashForm.Cash = cash;
                    editStartCashForm.ShowDialog();
                    LoadStartCashData();
                }
            }
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete this contribution?", "Cofirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (CashGrid.SelectedRows != null && CashGrid.SelectedRows.Count > 0)
                {
                    int id;
                    int.TryParse(CashGrid.SelectedRows[0].Cells[3].Value.ToString(), out id);

                    if (id > 0)
                    {
                        StartCashController startCashController = new StartCashController();
                        startCashController.Remove(id);
                        LoadStartCashData();
                    }
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripEditButton_Click(null, null);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDeleteButton_Click(null, null);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripAddButton_Click(null, null);
        }

        private void CashGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripEditButton_Click(null, null);
        }       
    }
}

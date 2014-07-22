using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaleManager.Controllers;

namespace SaleManager.UI.SellerManagement
{
    public partial class SellerManagement : Form
    {
        public SellerManagement()
        {
            InitializeComponent();
        }

        private void SellerManagement_Load(object sender, EventArgs e)
        {
            LoadSellers();
        }

        private void LoadSellers()
        {
            int currentRow = 0;

            if (SellerGrid.CurrentRow != null)
            {
                currentRow = SellerGrid.CurrentRow.Index;
            }

            SellerController sellerController = new SellerController();
            SellerGrid.DataSource = sellerController.GetAll();
            SetUpGrid();

            if (SellerGrid.Rows.Count > 0)
            {
                if (SellerGrid.Rows.Count > currentRow)
                {
                    SellerGrid.CurrentCell = SellerGrid.Rows[currentRow].Cells[3];
                }
                else
                {
                    SellerGrid.CurrentCell = SellerGrid.Rows[0].Cells[3];
                }

                ToolStripEditButton.Enabled = true;
                ToolStripDeleteButton.Enabled = true;
                EditUserToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                ToolStripEditButton.Enabled = false;
                ToolStripDeleteButton.Enabled = false;
                EditUserToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
        }

        private void SetUpGrid()
        {
            SellerGrid.Columns[0].Visible = false;
            SellerGrid.Columns[1].Visible = false;
            SellerGrid.Columns[2].Visible = false;
            SellerGrid.Columns[3].HeaderText = "Name";
            SellerGrid.Columns[3].Width = 250;
        }

        private void ToolStripCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripAddButton_Click(object sender, EventArgs e)
        {
            AddSeller addSellerForm = new AddSeller();
            addSellerForm.ShowDialog();
            LoadSellers();
        }

        private void ToolStripEditButton_Click(object sender, EventArgs e)
        {
            if (SellerGrid.SelectedRows != null && SellerGrid.SelectedRows.Count > 0)
            {
                int id;
                int.TryParse(SellerGrid.SelectedRows[0].Cells[2].Value.ToString(), out id);

                if (id > 0)
                {
                    string name = (string)SellerGrid.SelectedRows[0].Cells[3].Value;
                    EditSeller editSellerForm = new EditSeller();
                    editSellerForm.Id = id;
                    editSellerForm.Name = name;
                    editSellerForm.ShowDialog();
                    LoadSellers();
                }
            }
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();

            if (!saleController.IsOpen)
            {
                DialogResult dr = MessageBox.Show("Are you sure you wish to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (SellerGrid.SelectedRows != null && SellerGrid.SelectedRows.Count > 0)
                    {
                        int id;
                        int.TryParse(SellerGrid.SelectedRows[0].Cells[2].Value.ToString(), out id);

                        if (id > 0)
                        {
                            SellerController sellerController = new SellerController();
                            sellerController.Remove(id);
                            LoadSellers();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot delete a seller while a sale is open. Please complete the sale and try again.", "Delete Seller", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SellerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripEditButton_Click(null, null);
        }
    }
}

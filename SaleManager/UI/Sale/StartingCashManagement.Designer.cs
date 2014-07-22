namespace SaleManager.UI.Sale
{
    partial class StartingCashManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingCashManagement));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripAddButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripEditButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripCloseButton = new System.Windows.Forms.ToolStripButton();
            this.CashGrid = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashGrid)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAddButton,
            this.ToolStripEditButton,
            this.ToolStripDeleteButton,
            this.ToolStripSeparator1,
            this.ToolStripCloseButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(696, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripAddButton
            // 
            this.ToolStripAddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAddButton.Name = "ToolStripAddButton";
            this.ToolStripAddButton.Size = new System.Drawing.Size(107, 22);
            this.ToolStripAddButton.Text = "Add Contribution";
            this.ToolStripAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripAddButton.Click += new System.EventHandler(this.ToolStripAddButton_Click);
            // 
            // ToolStripEditButton
            // 
            this.ToolStripEditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripEditButton.Name = "ToolStripEditButton";
            this.ToolStripEditButton.Size = new System.Drawing.Size(106, 22);
            this.ToolStripEditButton.Text = "Edit Contribution";
            this.ToolStripEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripEditButton.Click += new System.EventHandler(this.ToolStripEditButton_Click);
            // 
            // ToolStripDeleteButton
            // 
            this.ToolStripDeleteButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteButton.Name = "ToolStripDeleteButton";
            this.ToolStripDeleteButton.Size = new System.Drawing.Size(121, 22);
            this.ToolStripDeleteButton.Text = "Delete Contribution";
            this.ToolStripDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripDeleteButton.Click += new System.EventHandler(this.ToolStripDeleteButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripCloseButton
            // 
            this.ToolStripCloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCloseButton.Name = "ToolStripCloseButton";
            this.ToolStripCloseButton.Size = new System.Drawing.Size(43, 22);
            this.ToolStripCloseButton.Text = "Close";
            this.ToolStripCloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripCloseButton.ToolTipText = "Close Form";
            this.ToolStripCloseButton.Click += new System.EventHandler(this.ToolStripCloseButton_Click);
            // 
            // CashGrid
            // 
            this.CashGrid.AllowUserToAddRows = false;
            this.CashGrid.AllowUserToDeleteRows = false;
            this.CashGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashGrid.ContextMenuStrip = this.ContextMenuStrip1;
            this.CashGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashGrid.Location = new System.Drawing.Point(0, 25);
            this.CashGrid.MultiSelect = false;
            this.CashGrid.Name = "CashGrid";
            this.CashGrid.ReadOnly = true;
            this.CashGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CashGrid.Size = new System.Drawing.Size(696, 431);
            this.CashGrid.TabIndex = 7;
            this.CashGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CashGrid_CellDoubleClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // StartingCashManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 456);
            this.Controls.Add(this.CashGrid);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartingCashManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Contributions Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartingCashManagement_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashGrid)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripAddButton;
        internal System.Windows.Forms.ToolStripButton ToolStripEditButton;
        internal System.Windows.Forms.ToolStripButton ToolStripDeleteButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripCloseButton;
        internal System.Windows.Forms.DataGridView CashGrid;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}
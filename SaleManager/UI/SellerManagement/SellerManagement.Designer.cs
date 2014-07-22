namespace SaleManager.UI.SellerManagement
{
    partial class SellerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerManagement));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripAddButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripEditButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripCloseButton = new System.Windows.Forms.ToolStripButton();
            this.SellerGrid = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem,
            this.EditUserToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(180, 70);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.AddUserToolStripMenuItem.Text = "Add Seller";
            // 
            // EditUserToolStripMenuItem
            // 
            this.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem";
            this.EditUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditUserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.EditUserToolStripMenuItem.Text = "Edit Seller";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.DeleteToolStripMenuItem.Text = "Delete Seller";
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
            this.ToolStrip1.Size = new System.Drawing.Size(646, 25);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripAddButton
            // 
            this.ToolStripAddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAddButton.Name = "ToolStripAddButton";
            this.ToolStripAddButton.Size = new System.Drawing.Size(71, 22);
            this.ToolStripAddButton.Text = "Add Seller";
            this.ToolStripAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripAddButton.Click += new System.EventHandler(this.ToolStripAddButton_Click);
            // 
            // ToolStripEditButton
            // 
            this.ToolStripEditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripEditButton.Name = "ToolStripEditButton";
            this.ToolStripEditButton.Size = new System.Drawing.Size(70, 22);
            this.ToolStripEditButton.Text = "Edit Seller";
            this.ToolStripEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripEditButton.Click += new System.EventHandler(this.ToolStripEditButton_Click);
            // 
            // ToolStripDeleteButton
            // 
            this.ToolStripDeleteButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteButton.Name = "ToolStripDeleteButton";
            this.ToolStripDeleteButton.Size = new System.Drawing.Size(85, 22);
            this.ToolStripDeleteButton.Text = "Delete Seller";
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
            // SellerGrid
            // 
            this.SellerGrid.AllowUserToAddRows = false;
            this.SellerGrid.AllowUserToDeleteRows = false;
            this.SellerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerGrid.ContextMenuStrip = this.ContextMenuStrip1;
            this.SellerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellerGrid.Location = new System.Drawing.Point(0, 25);
            this.SellerGrid.MultiSelect = false;
            this.SellerGrid.Name = "SellerGrid";
            this.SellerGrid.ReadOnly = true;
            this.SellerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerGrid.Size = new System.Drawing.Size(646, 373);
            this.SellerGrid.TabIndex = 6;
            this.SellerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerGrid_CellDoubleClick);
            // 
            // SellerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 398);
            this.Controls.Add(this.SellerGrid);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seller Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellerManagement_Load);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditUserToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripAddButton;
        internal System.Windows.Forms.ToolStripButton ToolStripEditButton;
        internal System.Windows.Forms.ToolStripButton ToolStripDeleteButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripCloseButton;
        internal System.Windows.Forms.DataGridView SellerGrid;
    }
}
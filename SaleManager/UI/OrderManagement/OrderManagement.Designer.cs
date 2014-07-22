namespace SaleManager.UI.OrderManagement
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCancelButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripCompleteOrderButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripAddItemButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripEditItemButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripRemItemButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripClose = new System.Windows.Forms.ToolStripButton();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem,
            this.EditItemToolStripMenuItem,
            this.RemoveItemToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(180, 70);
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.AddItemToolStripMenuItem.Text = "Add Item";
            this.AddItemToolStripMenuItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // EditItemToolStripMenuItem
            // 
            this.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem";
            this.EditItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.EditItemToolStripMenuItem.Text = "Edit Item";
            this.EditItemToolStripMenuItem.Click += new System.EventHandler(this.EditItemToolStripMenuItem_Click);
            // 
            // RemoveItemToolStripMenuItem
            // 
            this.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem";
            this.RemoveItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RemoveItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.RemoveItemToolStripMenuItem.Text = "Remove Item";
            this.RemoveItemToolStripMenuItem.Click += new System.EventHandler(this.RemoveItemToolStripMenuItem_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCancelButton,
            this.ToolStripCompleteOrderButton,
            this.toolStripSeparator2,
            this.ToolStripAddItemButton,
            this.ToolStripEditItemButton,
            this.ToolStripRemItemButton,
            this.ToolStripSeparator1,
            this.ToolStripClose});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(675, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripCancelButton
            // 
            this.toolStripCancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCancelButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelButton.Image")));
            this.toolStripCancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelButton.Name = "toolStripCancelButton";
            this.toolStripCancelButton.Size = new System.Drawing.Size(87, 22);
            this.toolStripCancelButton.Text = "Cancel Order";
            this.toolStripCancelButton.Click += new System.EventHandler(this.toolStripCancelButton_Click);
            // 
            // ToolStripCompleteOrderButton
            // 
            this.ToolStripCompleteOrderButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripCompleteOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCompleteOrderButton.Name = "ToolStripCompleteOrderButton";
            this.ToolStripCompleteOrderButton.Size = new System.Drawing.Size(103, 22);
            this.ToolStripCompleteOrderButton.Text = "Complete Order";
            this.ToolStripCompleteOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripCompleteOrderButton.Click += new System.EventHandler(this.ToolStripCompleteOrderButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripAddItemButton
            // 
            this.ToolStripAddItemButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripAddItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAddItemButton.Name = "ToolStripAddItemButton";
            this.ToolStripAddItemButton.Size = new System.Drawing.Size(64, 22);
            this.ToolStripAddItemButton.Text = "&Add Item";
            this.ToolStripAddItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripAddItemButton.Click += new System.EventHandler(this.ToolStripAddItemButton_Click);
            // 
            // ToolStripEditItemButton
            // 
            this.ToolStripEditItemButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripEditItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripEditItemButton.Name = "ToolStripEditItemButton";
            this.ToolStripEditItemButton.Size = new System.Drawing.Size(63, 22);
            this.ToolStripEditItemButton.Text = "&Edit Item";
            this.ToolStripEditItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripEditItemButton.Click += new System.EventHandler(this.ToolStripEditItemButton_Click);
            // 
            // ToolStripRemItemButton
            // 
            this.ToolStripRemItemButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripRemItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripRemItemButton.Name = "ToolStripRemItemButton";
            this.ToolStripRemItemButton.Size = new System.Drawing.Size(88, 22);
            this.ToolStripRemItemButton.Text = "&Remove Item";
            this.ToolStripRemItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripRemItemButton.Click += new System.EventHandler(this.ToolStripRemItemButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripClose
            // 
            this.ToolStripClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripClose.Name = "ToolStripClose";
            this.ToolStripClose.Size = new System.Drawing.Size(43, 22);
            this.ToolStripClose.Text = "Close";
            this.ToolStripClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripClose.ToolTipText = "Close Form";
            this.ToolStripClose.Click += new System.EventHandler(this.ToolStripClose_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.Green;
            this.lblOrderTotal.Location = new System.Drawing.Point(103, 46);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(0, 18);
            this.lblOrderTotal.TabIndex = 7;
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToAddRows = false;
            this.OrderGrid.AllowUserToDeleteRows = false;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.ContextMenuStrip = this.ContextMenuStrip1;
            this.OrderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGrid.Location = new System.Drawing.Point(0, 25);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(675, 355);
            this.OrderGrid.TabIndex = 8;
            this.OrderGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellDoubleClick);
            this.OrderGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OrderGrid_KeyUp);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 380);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderManagement_FormClosing);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AddItemToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditItemToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveItemToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripAddItemButton;
        internal System.Windows.Forms.ToolStripButton ToolStripEditItemButton;
        internal System.Windows.Forms.ToolStripButton ToolStripRemItemButton;
        internal System.Windows.Forms.ToolStripButton ToolStripCompleteOrderButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripClose;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.ToolStripButton toolStripCancelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
namespace SaleManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOrderButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripOrderNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOrderComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStartingCash = new System.Windows.Forms.ToolStripButton();
            this.ToolStripTotals = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripManageUsersButton = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialSaleContributionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseCurrentSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.completedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTotalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 507);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(827, 22);
            this.StatusStrip1.TabIndex = 8;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(812, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOrderButton,
            this.toolStripStartingCash,
            this.ToolStripTotals,
            this.ToolStripSeparator1,
            this.ToolStripManageUsersButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(827, 25);
            this.ToolStrip1.TabIndex = 7;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripOrderButton
            // 
            this.toolStripOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOrderButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOrderNew,
            this.toolStripOrderComplete});
            this.toolStripOrderButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.toolStripOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOrderButton.Image")));
            this.toolStripOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOrderButton.Name = "toolStripOrderButton";
            this.toolStripOrderButton.Size = new System.Drawing.Size(63, 22);
            this.toolStripOrderButton.Text = "Orders";
            this.toolStripOrderButton.ButtonClick += new System.EventHandler(this.toolStripOrderButton_ButtonClick);
            // 
            // toolStripOrderNew
            // 
            this.toolStripOrderNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOrderNew.Name = "toolStripOrderNew";
            this.toolStripOrderNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripOrderNew.Size = new System.Drawing.Size(224, 22);
            this.toolStripOrderNew.Text = "New Order";
            this.toolStripOrderNew.Click += new System.EventHandler(this.toolStripOrderNew_Click_1);
            // 
            // toolStripOrderComplete
            // 
            this.toolStripOrderComplete.Name = "toolStripOrderComplete";
            this.toolStripOrderComplete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripOrderComplete.Size = new System.Drawing.Size(224, 22);
            this.toolStripOrderComplete.Text = "Completed Orders";
            this.toolStripOrderComplete.Click += new System.EventHandler(this.toolStripOrderComplete_Click);
            // 
            // toolStripStartingCash
            // 
            this.toolStripStartingCash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStartingCash.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.toolStripStartingCash.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStartingCash.Image")));
            this.toolStripStartingCash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStartingCash.Name = "toolStripStartingCash";
            this.toolStripStartingCash.Size = new System.Drawing.Size(171, 22);
            this.toolStripStartingCash.Text = "Manage Initial Contributions";
            this.toolStripStartingCash.Click += new System.EventHandler(this.toolStripStartingCash_Click);
            // 
            // ToolStripTotals
            // 
            this.ToolStripTotals.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripTotals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripTotals.Name = "ToolStripTotals";
            this.ToolStripTotals.Size = new System.Drawing.Size(79, 22);
            this.ToolStripTotals.Text = "View Totals";
            this.ToolStripTotals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripTotals.Click += new System.EventHandler(this.ToolStripTotals_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripManageUsersButton
            // 
            this.ToolStripManageUsersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripManageUsersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripManageUsersButton.Name = "ToolStripManageUsersButton";
            this.ToolStripManageUsersButton.Size = new System.Drawing.Size(100, 22);
            this.ToolStripManageUsersButton.Text = "Manage Sellers";
            this.ToolStripManageUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripManageUsersButton.Click += new System.EventHandler(this.ToolStripManageUsersButton_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(827, 24);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSaleToolStripMenuItem,
            this.initialSaleContributionsToolStripMenuItem,
            this.CloseCurrentSaleToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.NewOrderToolStripMenuItem,
            this.ViewTotalsToolStripMenuItem,
            this.ManageUsersToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewSaleToolStripMenuItem
            // 
            this.NewSaleToolStripMenuItem.Name = "NewSaleToolStripMenuItem";
            this.NewSaleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.NewSaleToolStripMenuItem.Text = "New Sale";
            this.NewSaleToolStripMenuItem.Click += new System.EventHandler(this.NewSaleToolStripMenuItem_Click);
            // 
            // initialSaleContributionsToolStripMenuItem
            // 
            this.initialSaleContributionsToolStripMenuItem.Name = "initialSaleContributionsToolStripMenuItem";
            this.initialSaleContributionsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.initialSaleContributionsToolStripMenuItem.Text = "Manage Contributions";
            this.initialSaleContributionsToolStripMenuItem.Click += new System.EventHandler(this.initialSaleContributionsToolStripMenuItem_Click);
            // 
            // CloseCurrentSaleToolStripMenuItem
            // 
            this.CloseCurrentSaleToolStripMenuItem.Name = "CloseCurrentSaleToolStripMenuItem";
            this.CloseCurrentSaleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.CloseCurrentSaleToolStripMenuItem.Text = "Complete Current Sale";
            this.CloseCurrentSaleToolStripMenuItem.Click += new System.EventHandler(this.CloseCurrentSaleToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // NewOrderToolStripMenuItem
            // 
            this.NewOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem1,
            this.completedOrdersToolStripMenuItem});
            this.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem";
            this.NewOrderToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.NewOrderToolStripMenuItem.Text = "Orders";
            this.NewOrderToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem1
            // 
            this.newOrderToolStripMenuItem1.Name = "newOrderToolStripMenuItem1";
            this.newOrderToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newOrderToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.newOrderToolStripMenuItem1.Text = "New Order";
            this.newOrderToolStripMenuItem1.Click += new System.EventHandler(this.newOrderToolStripMenuItem1_Click);
            // 
            // completedOrdersToolStripMenuItem
            // 
            this.completedOrdersToolStripMenuItem.Name = "completedOrdersToolStripMenuItem";
            this.completedOrdersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.completedOrdersToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.completedOrdersToolStripMenuItem.Text = "Completed Orders";
            this.completedOrdersToolStripMenuItem.Click += new System.EventHandler(this.completedOrdersToolStripMenuItem_Click);
            // 
            // ViewTotalsToolStripMenuItem
            // 
            this.ViewTotalsToolStripMenuItem.Name = "ViewTotalsToolStripMenuItem";
            this.ViewTotalsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ViewTotalsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ViewTotalsToolStripMenuItem.Text = "View Totals";
            this.ViewTotalsToolStripMenuItem.Click += new System.EventHandler(this.ViewTotalsToolStripMenuItem_Click);
            // 
            // ManageUsersToolStripMenuItem
            // 
            this.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem";
            this.ManageUsersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.ManageUsersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ManageUsersToolStripMenuItem.Text = "Manage Sellers";
            this.ManageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsersToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExitToolStripMenuItem.Text = "Close";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 529);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripTotals;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripManageUsersButton;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewSaleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseCurrentSaleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem NewOrderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewTotalsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ManageUsersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton toolStripStartingCash;
        private System.Windows.Forms.ToolStripMenuItem initialSaleContributionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripOrderButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripOrderNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripOrderComplete;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem completedOrdersToolStripMenuItem;
    }
}


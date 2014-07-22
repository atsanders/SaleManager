namespace SaleManager.UI.Sale
{
    partial class ViewTotal
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
            this.TotalGrid = new System.Windows.Forms.DataGridView();
            this.ToolStripCloseButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalGrid
            // 
            this.TotalGrid.AllowUserToAddRows = false;
            this.TotalGrid.AllowUserToDeleteRows = false;
            this.TotalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalGrid.Location = new System.Drawing.Point(0, 25);
            this.TotalGrid.MultiSelect = false;
            this.TotalGrid.Name = "TotalGrid";
            this.TotalGrid.ReadOnly = true;
            this.TotalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TotalGrid.Size = new System.Drawing.Size(627, 386);
            this.TotalGrid.TabIndex = 2;
            // 
            // ToolStripCloseButton
            // 
            this.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCloseButton.Name = "ToolStripCloseButton";
            this.ToolStripCloseButton.Size = new System.Drawing.Size(39, 22);
            this.ToolStripCloseButton.Text = "Close";
            this.ToolStripCloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripCloseButton.Click += new System.EventHandler(this.ToolStripCloseButton_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCloseButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(627, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ViewTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 411);
            this.Controls.Add(this.TotalGrid);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totals";
            this.Load += new System.EventHandler(this.ViewTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView TotalGrid;
        internal System.Windows.Forms.ToolStripButton ToolStripCloseButton;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
    }
}
namespace BookmarksStocker.Source.Views
{
    partial class FrmExternalBrowserList
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
            this.cntxtMnBrowsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdBrowsers = new BookmarksStocker.Source.UserControls.LightGridView();
            this.cntxtMnBrowsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBrowsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cntxtMnBrowsers
            // 
            this.cntxtMnBrowsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cntxtMnBrowsers.Name = "cntxtMnBrowsers";
            this.cntxtMnBrowsers.Size = new System.Drawing.Size(113, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // grdBrowsers
            // 
            this.grdBrowsers.AllowUserToAddRows = false;
            this.grdBrowsers.AllowUserToDeleteRows = false;
            this.grdBrowsers.AllowUserToResizeColumns = false;
            this.grdBrowsers.AllowUserToResizeRows = false;
            this.grdBrowsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBrowsers.ColumnHeaderDeLimiter = '-';
            this.grdBrowsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdBrowsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBrowsers.ColumnHeaderTextList = "Id[i]-Tarayıcı Adı-Tarayıcı Yolu-A[i]-B[i]";
            this.grdBrowsers.ColumnInVisibilityString = "[i]";
            this.grdBrowsers.ContextMenuStrip = this.cntxtMnBrowsers;
            this.grdBrowsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBrowsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdBrowsers.Location = new System.Drawing.Point(0, 0);
            this.grdBrowsers.Name = "grdBrowsers";
            this.grdBrowsers.ReadOnly = true;
            this.grdBrowsers.RowHeadersVisible = false;
            this.grdBrowsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBrowsers.Size = new System.Drawing.Size(565, 300);
            this.grdBrowsers.TabIndex = 0;
            // 
            // FrmExternalBrowserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 300);
            this.Controls.Add(this.grdBrowsers);
            this.Name = "FrmExternalBrowserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Browser List";
            this.cntxtMnBrowsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBrowsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LightGridView grdBrowsers;
        private System.Windows.Forms.ContextMenuStrip cntxtMnBrowsers;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
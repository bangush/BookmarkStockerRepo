namespace BookmarksStocker.Source.Views
{
    partial class FrmRunWith
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
            this.cmbxBrowsers = new System.Windows.Forms.ComboBox();
            this.lblBrowsers = new System.Windows.Forms.Label();
            this.btnRunWith = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxBrowsers
            // 
            this.cmbxBrowsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBrowsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbxBrowsers.FormattingEnabled = true;
            this.cmbxBrowsers.Location = new System.Drawing.Point(167, 64);
            this.cmbxBrowsers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxBrowsers.Name = "cmbxBrowsers";
            this.cmbxBrowsers.Size = new System.Drawing.Size(160, 25);
            this.cmbxBrowsers.TabIndex = 0;
            // 
            // lblBrowsers
            // 
            this.lblBrowsers.AutoSize = true;
            this.lblBrowsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblBrowsers.Location = new System.Drawing.Point(51, 67);
            this.lblBrowsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrowsers.Name = "lblBrowsers";
            this.lblBrowsers.Size = new System.Drawing.Size(74, 17);
            this.lblBrowsers.TabIndex = 1;
            this.lblBrowsers.Text = "Browsers :";
            // 
            // btnRunWith
            // 
            this.btnRunWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRunWith.Location = new System.Drawing.Point(128, 124);
            this.btnRunWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunWith.Name = "btnRunWith";
            this.btnRunWith.Size = new System.Drawing.Size(124, 50);
            this.btnRunWith.TabIndex = 2;
            this.btnRunWith.Text = "Run With";
            this.btnRunWith.UseVisualStyleBackColor = true;
            this.btnRunWith.Click += new System.EventHandler(this.btnRunWith_Click);
            // 
            // FrmRunWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 230);
            this.Controls.Add(this.btnRunWith);
            this.Controls.Add(this.lblBrowsers);
            this.Controls.Add(this.cmbxBrowsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(395, 269);
            this.MinimumSize = new System.Drawing.Size(395, 269);
            this.Name = "FrmRunWith";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run With";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxBrowsers;
        private System.Windows.Forms.Label lblBrowsers;
        private System.Windows.Forms.Button btnRunWith;
    }
}
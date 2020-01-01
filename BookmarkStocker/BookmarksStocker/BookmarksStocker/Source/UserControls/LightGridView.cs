using Net.Light.Framework.Logic.Extensions;
using System;
using System.Windows.Forms;

namespace BookmarksStocker.Source.UserControls
{
    class LightGridView : DataGridView
    {
        private string _ColumnHeaderTextList = string.Empty;
        private string _ColumnInVisibilityString = "[i]";
        private char _ColumnHeaderDeLimiter = '-';


        public LightGridView()
            : base()
        {
            InitComp();
        }

        protected void InitComp()
        {
            this.SuspendLayout();
            //
            this.AllowDrop = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 10.0f, System.Drawing.FontStyle.Regular);
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Text = string.Empty;
            //
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        /// <summary>
        /// Gets, Sets ColumnHeaderTextList.
        /// </summary>
        public string ColumnHeaderTextList
        {
            get { return _ColumnHeaderTextList; }
            set
            {
                if (value.IsNullOrSpace() == false)
                {
                    _ColumnHeaderTextList = value;
                    SetColumnHeaders();
                }
            }
        }

        /// <summary>
        /// Gets, Sets ColumnHeaderDeLimiter char for setting ColumnHeaderText List.
        /// </summary>
        public char ColumnHeaderDeLimiter
        {
            get { return _ColumnHeaderDeLimiter; }
            set
            {
                if (Char.ToString(value).IsNullOrSpace() == false)
                {
                    _ColumnHeaderDeLimiter = value;
                    SetColumnHeaders();
                }
            }
        }


        /// <summary>
        /// Gets, Sets ColumnInVisibilityString for setting InVisibility of Column. 
        /// if ColumnHeaderText contains this string that column is invisible.
        /// </summary>
        public string ColumnInVisibilityString
        {
            get { return _ColumnInVisibilityString; }
            set
            {
                if (value.IsNullOrSpace() == false)
                {
                    _ColumnInVisibilityString = value;
                    SetColumnHeaders();
                }
            }
        }

        protected void SetColumnHeaders()
        {
            try
            {
                if (_ColumnHeaderTextList.IsNullOrSpace() == false)
                {
                    string[] cols = _ColumnHeaderTextList.Split(_ColumnHeaderDeLimiter);
                    if (cols != null)
                    {
                        int counter = cols.Length > ColumnCount ? ColumnCount : cols.Length;
                        for (int i = 0; i < counter; i++)
                        {
                            this.Columns[i].HeaderText = cols[i];
                            this.Columns[i].Visible = this.Columns[i].HeaderText.Contains(_ColumnInVisibilityString) == false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            try
            {
                base.OnDataSourceChanged(e);
                SetColumnHeaders();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Refresh()
        {
            try
            {
                base.Refresh();
                SetColumnHeaders();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }

}

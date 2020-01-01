using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.Management;
using BookmarksStocker.Source.Util;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookmarksStocker.Source.Views
{
    public partial class FrmExternalBrowserList : Form
    {
        DataTable browserList = new DataTable();
        BookmarkManager bookMan;

        public FrmExternalBrowserList()
        {
            try
            {
                InitializeComponent();
                bookMan = new BookmarkManager();
                RefreshSource();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RefreshSource()
        {
            try
            {
                browserList = bookMan.GetExternalBrowserList();
                SetDataSourceOfGRid();
            }
            catch (Exception)
            {
                throw;
            }
        }


        #region [ SetDataSourceOfGRid method ]

        private void SetDataSourceOfGRid()
        {
            try
            {
                grdBrowsers.AllowUserToOrderColumns = true;
                grdBrowsers.AllowUserToResizeColumns = true;
                grdBrowsers.DataSource = null;
                grdBrowsers.DataSource = browserList;
                grdBrowsers.Refresh();
                //grdBrowsers.ColumnHeaderTextList = "ID[i]-Name-Descriptiom-Url-Creation Time-Update Time-Table[i]-ChangeSetCount[i]";
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddObj();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateObj();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteObj();
        }

        void AddObj()
        {
            FrmExternalBrowser frmExtBrowser = new FrmExternalBrowser(browserList);
            frmExtBrowser.ExternalBrowserChanged += new FrmExternalBrowser.ExternalBrowserChage(this.UpdateForm);
            frmExtBrowser.ShowDialog();
        }

        void UpdateForm()
        {
            try
            {
                RefreshSource();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "UpdateForm");

                MessageUtil.Error("List could not be refreshed.");
            }
        }

        void UpdateObj()
        {
            if (grdBrowsers.SelectedRows.Count > 0)
            {
                int browserId = grdBrowsers.SelectedRows[0].Cells["Id"].Value.ToInt();
                FrmExternalBrowser frmExtBrowser = new FrmExternalBrowser(browserId, browserList);
                frmExtBrowser.ExternalBrowserChanged += new FrmExternalBrowser.ExternalBrowserChage(this.UpdateForm);
                frmExtBrowser.ShowDialog();
            }
        }

        void DeleteObj()
        {
            try
            {
                if (grdBrowsers.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageUtil.Confirm("External Browser will be deleted. are you sure?");
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        int browserId = grdBrowsers.SelectedRows[0].Cells["Id"].Value.ToInt();
                        Browser br = new Browser { Id = browserId };
                        br.Delete();
                        UpdateForm();
                    }
                    return;
                }
                return;
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "DeleteObj");

                MessageUtil.Error("Object could not be deleted.");
            }
        }

        private void addBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrowser();
        }

        void AddBrowser()
        {
            AddObj();
        }

    }
}

using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.DL;
using BookmarksStocker.Source.Management;
using BookmarksStocker.Source.Util;
using IWshRuntimeLibrary;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookmarksStocker.Source.Views
{
    public partial class FrmBookmarkList : Form
    {
        #region [ Private Fields ]

        private bool _isFromClosing = false;
        private BookmarkManager bookMan;
        private List<Bookmark> bookmarkList = new List<Bookmark>();
        private ExportManager exportMan;
        private int isCreationToggle = 1;
        private int isStartToggle = 1;

        #endregion


        #region [ FrmBookmarkList Ctor ]

        public FrmBookmarkList()
        {
            try
            {
                bookMan = new BookmarkManager();
                exportMan = new ExportManager();
                InitializeComponent();
                rdbtnCreationtime.Checked = true;
                rdbtnStartsWith.Checked = true;
                IsDateFilteringChecked(false);
                grdVwBookmarks.ColumnHeaderTextList = "ID[i]-Name-Description-Url-Creation Time-Update Time-Table[i]-ChangeSetCount[i]";
                cmbxSearchType.SetItemSource("Name*Name-Url*Url-Description*Description", '-', '*');

                if (cmbxSearchType.Items.Count > 0)
                    cmbxSearchType.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Ctor");

                MessageUtil.Error("Bookmark List could not be opened.");
            }
        }

        #endregion


        #region [ Add method ]

        private void Add()
        {
            try
            {
                FrmBookmark bkrmrk = new FrmBookmark();
                bkrmrk.BookmarkChanged += new FrmBookmark.BookmarkChange(this.BkmrkChanged);
                bkrmrk.ShowDialog();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Add");
            }
        }

        #endregion


        #region [ addToolStripMenuItem_Click method ]

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        #endregion


        #region [ BkmrkChanged method ]

        private void BkmrkChanged(Bookmark bkmrk, bool isInsert)
        {
            try
            {
                if (isInsert)
                {
                    bookmarkList.Add(bkmrk);
                }
                else
                {
                    Bookmark bk = bookMan.GetById((int)bkmrk.ID);

                    for (int bookmarkCounter = 0; bookmarkCounter < bookmarkList.Count; bookmarkCounter++)
                    {
                        if (bookmarkList[bookmarkCounter].ID == bkmrk.ID)
                        {
                            bookmarkList[bookmarkCounter].Name = bk.Name;
                            bookmarkList[bookmarkCounter].Description = bk.Description;
                            bookmarkList[bookmarkCounter].Url = bk.Url;
                            bookmarkList[bookmarkCounter].UpdateTime = bk.UpdateTime;
                        }
                    }
                }

                SetDataSourceOfGRid();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "BkmrkChanged");
            }
        }

        #endregion


        #region [ btnAdd_Click method ]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        #endregion


        #region [ btnDelete_Click method ]

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion


        #region [ btnUpdate_Click method ]

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateObj();
        }

        #endregion


        #region [ Delete method ]

        private void Delete()
        {
            try
            {
                if (grdVwBookmarks.SelectedRows.Count > 0)
                {
                    if (MessageUtil.Confirm("Bookmark will be deleted. Are you sure?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        int bkmrkId = grdVwBookmarks.SelectedRows[0].Cells["ID"].Value.ToInt();
                        Bookmark bkmrk = null;
                        for (int bookmarkCounter = 0; bookmarkCounter < bookmarkList.Count; bookmarkCounter++)
                        {
                            if (bkmrkId == bookmarkList[bookmarkCounter].ID)
                            {
                                bkmrk = bookmarkList[bookmarkCounter];
                                break;
                            }
                        }

                        if (bkmrk != null)
                        {
                            bkmrk.Delete();
                            bookmarkList.Remove(bkmrk);
                            SetDataSourceOfGRid();
                            MessageUtil.Message("Bookmark deleted successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Delete");

                MessageUtil.Error("Object could not be deleted.");
            }
        }

        #endregion


        #region [ deleteToolStripMenuItem_Click method ]

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion


        #region [ FormLoad method ]

        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                using (BookmarksDL bookmrksDL = new BookmarksDL())
                {
                    bookmarkList = bookmrksDL.GetTableAsList<Bookmark>();

                    SetDataSourceOfGRid();
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "FormLoad");

                MessageUtil.Error("Bookmark List could not be loaded.");
            }
        }

        #endregion


        #region [ SetDataSourceOfGRid method ]

        private void SetDataSourceOfGRid()
        {
            try
            {
                SetDataSourceOfGRid(bookmarkList);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetDataSourceOfGRid(List<Bookmark> lstBookmarks)
        {
            try
            {
                grdVwBookmarks.AllowUserToOrderColumns = true;
                grdVwBookmarks.AllowUserToResizeColumns = true;
                grdVwBookmarks.DataSource = null;
                grdVwBookmarks.DataSource = lstBookmarks;
                grdVwBookmarks.Refresh();
                //grdVwBookmarks.ColumnHeaderTextList = "ID[i]-Name-Descriptiom-Url-Creation Time-Update Time-Table[i]-ChangeSetCount[i]";
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ UpdateObj method ]

        private void UpdateObj()
        {
            try
            {
                if (grdVwBookmarks.SelectedRows.Count > 0)
                {
                    int bkmrkId = grdVwBookmarks.SelectedRows[0].Cells["ID"].Value.ToInt();
                    FrmBookmark bkrmrk = new FrmBookmark(bkmrkId);
                    bkrmrk.BookmarkChanged += new FrmBookmark.BookmarkChange(this.BkmrkChanged);
                    bkrmrk.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Update");

                MessageUtil.Error("Object could not be updated");
            }
        }

        #endregion


        #region [ updateToolStripMenuItem_Click method ]

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateObj();
        }

        #endregion


        #region [ runWithToolStripMenuItem_Click method ]

        private void runWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunWithForm(true);
        }

        #endregion


        #region [ RunWithForm method ]

        public void RunWithForm(bool isRegistered)
        {
            try
            {
                string url = string.Empty;
                if (grdVwBookmarks.SelectedRows.Count > 0)
                {
                    url = grdVwBookmarks.SelectedRows[0].Cells["Url"].Value.ToStr();
                }
                if (url.IsNullOrSpace() == false)
                {
                    FrmRunWith frw = new FrmRunWith(url, isRegistered);
                    frw.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "RunWithForm");

                MessageUtil.Error("Object could not be runned.");
            }
        }

        #endregion


        #region [ IsDatefilterchecked method ]

        void IsDatefilterchecked(object sender, EventArgs e)
        {
            bool isChecked = chkDateFiltering.Checked;
            IsDateFilteringChecked(isChecked);
            Search();
        }

        #endregion


        #region [ IsDateFilteringChecked method ]

        private void IsDateFilteringChecked(bool isChecked)
        {

            rdbtnCreationtime.Enabled = isChecked;
            rdbtnUpdatetime.Enabled = isChecked;

            rdbtnStartsWith.Enabled = isChecked;
            rdbtnBetween.Enabled = isChecked;
            rdbtnEndsWith.Enabled = isChecked;

            dtpStartDate.Enabled = isChecked;
            dtpStartTime.Enabled = isChecked;

            dtpEndDate.Enabled = isChecked;
            dtpEndTime.Enabled = isChecked;
        }

        #endregion


        #region [ IsCreationtimeToggleChanged method ]

        void IsCreationtimeToggleChanged(object sender, EventArgs e)
        {
            try
            {
                isCreationToggle = (sender as RadioButton).Tag.ToInt();
            }
            catch (Exception ex)
            {
                isCreationToggle = 0;
                LightLogger.LogMethod(ex, this.Name, "IsCreationtimeToggleChanged");
            }
            finally
            {
                Search();
            }
        }

        #endregion


        #region [ IsStartToggleChanged method ]

        void IsStartToggleChanged(object sender, EventArgs e)
        {
            try
            {
                isStartToggle = (sender as RadioButton).Tag.ToInt();
            }
            catch (Exception ex)
            {
                isStartToggle = 0;
                LightLogger.LogMethod(ex, this.Name, "IsStartToggleChanged");
            }
            finally
            {
                Search();
            }
        }

        #endregion


        #region [ DateChanged method ]

        void DateChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ Search method ]

        private void Search(string strSearch, string searchColumn,
            bool isDateFiltering, int isCreationTime, int dateFilterSelection)
        {
            try
            {
                List<Bookmark> searchList = new List<Bookmark>();
                searchList = bookmarkList;
                if (searchList != null)
                {
                    try
                    {
                        if (strSearch.IsNullOrSpace() == false)
                        {
                            switch (searchColumn)
                            {
                                case "Name":
                                    searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.Name.Contains(strSearch)).ToList<Bookmark>();
                                    break;

                                case "Description":
                                    searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.Description.Contains(strSearch)).ToList<Bookmark>();
                                    break;

                                case "Url":
                                    searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.Url.Contains(strSearch)).ToList<Bookmark>();
                                    break;

                                default:
                                    break;
                            }
                        }

                        if (isDateFiltering)
                        {
                            DateTime dtStart = new DateTime(dtpStartDate.Value.Year,
                                dtpStartDate.Value.Month,
                                dtpStartDate.Value.Day,
                                dtpStartTime.Value.Hour,
                                dtpStartTime.Value.Minute,
                                dtpStartTime.Value.Second);

                            DateTime dtEnd = new DateTime(dtpEndDate.Value.Year,
                                dtpEndDate.Value.Month,
                                dtpEndDate.Value.Day,
                                dtpEndTime.Value.Hour,
                                dtpEndTime.Value.Minute,
                                dtpEndTime.Value.Second);

                            switch (isCreationTime)
                            {
                                case 1:
                                    switch (dateFilterSelection)
                                    {
                                        case 1:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.CreationTime >= dtStart).ToList<Bookmark>();
                                            break;

                                        case 2:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.CreationTime >= dtStart && b.CreationTime <= dtEnd).ToList<Bookmark>();
                                            break;

                                        case 3:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.CreationTime <= dtEnd).ToList<Bookmark>();
                                            break;

                                        default:
                                            break;
                                    }
                                    break;

                                case 2:
                                    switch (dateFilterSelection)
                                    {
                                        case 1:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.UpdateTime >= dtStart).ToList<Bookmark>();
                                            break;

                                        case 2:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.UpdateTime >= dtStart && b.UpdateTime <= dtEnd).ToList<Bookmark>();
                                            break;

                                        case 3:
                                            searchList = searchList.AsQueryable<Bookmark>().Where<Bookmark>(b => b.UpdateTime <= dtEnd).ToList<Bookmark>();
                                            break;

                                        default:
                                            break;
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception exInner)
                    {
                        searchList = new List<Bookmark>();
                        LightLogger.LogMethod(exInner, this.Name, "Search_Inner");
                    }
                }

                SetDataSourceOfGRid(searchList);
            }
            catch (Exception exOuter)
            {
                LightLogger.LogMethod(exOuter, this.Name, "Search_Outer");
            }
        }

        #endregion


        #region [ txtSearch_TextChanged method ]

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ Search method ]

        private void Search()
        {
            Search(txtSearch.Text, cmbxSearchType.SelectedValue.ToStr(), chkDateFiltering.Checked, isCreationToggle, isStartToggle);
        }

        #endregion


        #region [ cmbxSearchType_SelectedIndexChanged method ]

        private void cmbxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion


        #region [ grdVwBookmarks_SelectionChanged method ]

        private void grdVwBookmarks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtDetails.Text = string.Empty;
                if (grdVwBookmarks.SelectedRows.Count > 0)
                {
                    StringBuilder strBuilder = new StringBuilder();
                    strBuilder.AppendLine(string.Format("{0} : {1}", "İsim", grdVwBookmarks.SelectedRows[0].Cells["Name"].Value.ToStr()));
                    strBuilder.AppendLine("-------------------");
                    strBuilder.AppendLine(string.Format("{0} : {1}", "Açıklama", grdVwBookmarks.SelectedRows[0].Cells["Description"].Value.ToStr()));
                    strBuilder.AppendLine("-------------------");
                    strBuilder.AppendLine(string.Format("{0} : {1}", "Adres", grdVwBookmarks.SelectedRows[0].Cells["Url"].Value.ToStr()));
                    txtDetails.Text = strBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "grdVwBookmarks_SelectionChanged");
            }
        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageUtil.Confirm("Program will be closed. Are you sure?");
            if (dR == System.Windows.Forms.DialogResult.Yes)
            {
                _isFromClosing = true;
                this.Close();
            }
            return;
        }

        #region [ ExportToExcel method ]

        private void ExportToExcel()
        {
            try
            {
                DataTable dt2Export = new DataTable();
                using (BookmarksDL bkmrkDL = new BookmarksDL())
                {
                    dt2Export = bkmrkDL.GetTable(new Bookmark { });
                }
                exportMan.Export2Excel(dt2Export, "Bookmarks", "D:/Bookmarks.xls");
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "ExportToExcel");
                MessageUtil.Error("Export Operation failed");
            }
        }

        #endregion


        #region [ ExportToExcelSearch method ]

        private void ExportToExcelSearch()
        {
            try
            {
                DataTable dt2Export = new DataTable();
                int rowCount = grdVwBookmarks.Rows.Count;
                if (rowCount > 0)
                {
                    int colCount = grdVwBookmarks.ColumnCount;
                    for (int colCounter = 0; colCounter < colCount; colCounter++)
                    {
                        if (object.ReferenceEquals(typeof(Bookmark).GetProperty(grdVwBookmarks.Columns[colCounter].Name).PropertyType, typeof(DateTime)) == false &&
                            grdVwBookmarks.Columns[colCounter].Visible == true)
                        {
                            dt2Export.Columns.Add(grdVwBookmarks.Columns[colCounter].Name, typeof(string));
                        }
                    }
                    colCount = dt2Export.Columns.Count;
                    DataRow row;
                    for (int rowCounter = 0; rowCounter < rowCount; rowCounter++)
                    {
                        row = null;
                        row = dt2Export.NewRow();

                        for (int colcounter = 0; colcounter < colCount; colcounter++)
                        {
                            row[dt2Export.Columns[colcounter].ColumnName] = grdVwBookmarks.Rows[rowCounter].Cells[dt2Export.Columns[colcounter].ColumnName].Value.ToStr();
                        }

                        dt2Export.Rows.Add(row);
                    }
                }

                exportMan.Export2Excel(dt2Export, "Bookmarks", "D:/Bookmarks.xls");
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "ExportToExcel");
                MessageUtil.Error("Export Operation failed");
            }
        }

        #endregion

        private void externalBrowserListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExternalBrowsers();
        }

        private void externalBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunWithForm(false);
        }

        private void FrmBookmarkList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isFromClosing == false)
            {
                DialogResult dR = MessageUtil.Confirm("Program will be closed. Are you sure?");
                if (dR != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        void OpenExternalBrowsers()
        {
            FrmExternalBrowserList browserList = new FrmExternalBrowserList();
            browserList.ShowDialog();
        }
        private void shortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShortCut();
        }


        #region [ CreateShortCut method ]

        private void CreateShortCut()
        {
            CreateShortCut(Environment.SpecialFolder.Desktop, @"\BookmarkStocker.lnk");
            return;
        }

        private void CreateShortCut(Environment.SpecialFolder flder, string filePath)
        {
            try
            {
                IWshRuntimeLibrary.IWshShortcut shortCut;
                WshShell ws = new WshShell();
                shortCut = (IWshShortcut)ws.CreateShortcut(Environment.GetFolderPath(flder) + filePath);
                shortCut.TargetPath = Application.ExecutablePath;
                shortCut.Description = "This software has been made for managing all bookmarks in one program. Use for good days.\nMade By : Nusty\nPath : " + Application.ExecutablePath;
                shortCut.IconLocation = Application.StartupPath + @"\monitor.ico";
                shortCut.Save();
            }
            catch (Exception ex)
            {
                MessageUtil.Error("Shortcut could not be created.");
                LightLogger.LogMethod(ex, this.Name, "CreateShortCut");
            }
        }

        #endregion [ CreateShortCut method ]

        private void allBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void selectedBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelSearch();
        }
    }
}
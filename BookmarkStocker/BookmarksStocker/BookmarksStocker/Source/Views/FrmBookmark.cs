using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.Management;
using BookmarksStocker.Source.Util;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Windows.Forms;

namespace BookmarksStocker.Source.Views
{
    public partial class FrmBookmark : Form
    {
        #region [ Public Fields ]

        public delegate void BookmarkChange(Bookmark bookmark, bool isInsert);
        public BookmarkChange BookmarkChanged;

        #endregion


        #region [ Private Fields ]

        private int _bookmarkId = -1;
        private bool _isFormLoaded = false;
        private Bookmark bookmark;
        private BookmarkManager bookMan;

        private bool isUpdated = false;

        #endregion


        #region [ FrmBookmark Ctors ]

        public FrmBookmark()
            : this(-1)
        { }


        public FrmBookmark(int bookmarkId)
        {
            try
            {
                InitializeComponent();
                bookmark = new Bookmark();
                bookMan = new BookmarkManager();
                _bookmarkId = bookmarkId;
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "FrmBookmark Ctor");

                MessageUtil.Error("Bookmark could not be opened.");
            }
        }

        #endregion


        #region [ FormLoad method ]

        private void FormLoad(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion


        #region [ LoadForm method ]

        private void LoadForm()
        {
            try
            {
                _isFormLoaded = false;
                if (_bookmarkId != -1)
                {
                    bookmark = bookMan.GetById(_bookmarkId);
                    if (bookmark != null)
                    {
                        txtName.Text = bookmark.Name;
                        txtDescription.Text = bookmark.Description;
                        txtUrl.Text = bookmark.Url;
                    }
                }
                _isFormLoaded = true;
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "FormLoad");

                MessageUtil.Error("Bookmark could not be loaded.");
            }
            finally
            {
                bookmark = new Bookmark();

                if (_bookmarkId != -1)
                    bookmark.ID = _bookmarkId;
            }
        }

        #endregion


        #region [ btnSave_Click method ]

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


        #region [ Save method ]

        private void Save()
        {
            try
            {
                if (txtUrl.Text.IsNullOrSpace())
                {
                    MessageUtil.Warn("Url can not be empty.");
                    return;
                }

                if (txtName.Text.IsNullOrSpace())
                {
                    MessageUtil.Warn("Name can not be empty.");
                    return;
                }
                long id = bookMan.GetBookmarkIDByName(bookmark.Name);
                if (id != -1 && id != _bookmarkId)
                {
                    MessageUtil.Warn("Bookmark is exist with given name.");
                    return;
                }

                id = bookMan.GetBookmarkIDByUrl(bookmark.Url);
                if (id != -1 && id != _bookmarkId)
                {
                    MessageUtil.Warn("Bookmark is exist with given Url.");
                    return;
                }

                if (_bookmarkId == -1)
                {
                    bookmark.CreationTime = DateTime.Now;
                    bookmark.ID = bookmark.InsertAndGetId();
                    if (BookmarkChanged != null)
                    {
                        BookmarkChanged(bookmark, true);
                    }

                    txtName.ResetText();
                    txtDescription.ResetText();
                    txtUrl.ResetText();

                    bookmark = new Bookmark();
                }
                else
                {
                    if (bookmark.ChangeSetCount > 1)
                    {
                        bookmark.UpdateTime = DateTime.Now;
                        bookmark.Update();
                        isUpdated = true;
                        if (BookmarkChanged != null)
                        {
                            BookmarkChanged(bookmark, false);
                        }

                        btnSave.Enabled = false;
                        btnCancel.Text = "Close";
                    }
                }
                MessageUtil.Message("Boomark Saved.");
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Save");
            }
        }

        #endregion


        #region [ btnCancel_Click method ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region [ FrmBookmark_FormClosing method ]

        private void FrmBookmark_FormClosing(object sender, FormClosingEventArgs e)
        {
            int changeCount = _bookmarkId == -1 ? 0 : 1;
            if (bookmark.ChangeSetCount > changeCount && isUpdated == false)
            {
                DialogResult dr = MessageUtil.Confirm("Form will be Closed, Are you sure?");
                if (dr != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion


        #region [ TextChanged methods ]

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (_isFormLoaded)
                bookmark.Name = txtName.Text;
        }


        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (_isFormLoaded)
                bookmark.Description = txtDescription.Text;
        }


        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (_isFormLoaded)
                bookmark.Url = txtUrl.Text;
        }

        #endregion

    }
}
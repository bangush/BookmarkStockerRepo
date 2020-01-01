using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.Management;
using BookmarksStocker.Source.Util;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;

namespace BookmarksStocker.Source.Views
{
    public partial class FrmExternalBrowser : Form
    {
        int _browserId = -1;

        public delegate void ExternalBrowserChage();
        public ExternalBrowserChage ExternalBrowserChanged;

        private Browser browser = null;
        private DataTable dtBrowserList = null;
        private bool isFormLoaded = false;
        private OpenFileDialog opFileDialog = null;

        public FrmExternalBrowser(DataTable dtBrowsers) : this(-1, dtBrowsers) { }

        public FrmExternalBrowser(int browserId, DataTable dtBrowsers)
        {
            try
            {
                InitializeComponent();
                _browserId = browserId;
                dtBrowserList = dtBrowsers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void Frm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        void FormLoad()
        {
            try
            {
                isFormLoaded = false;
                if (_browserId != -1)
                {
                    if (dtBrowserList != null)
                    {
                        for (int rowCounter = 0; rowCounter < dtBrowserList.Rows.Count; rowCounter++)
                        {
                            if (dtBrowserList.Rows[rowCounter]["Id"].ToInt() == _browserId)
                            {
                                txtName.Text = dtBrowserList.Rows[rowCounter]["Name"].ToStr();
                                txtPath.Text = dtBrowserList.Rows[rowCounter]["Path"].ToStr();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "FormLoad");

                MessageUtil.Error("Browser List could not be loaded.");
            }
            finally
            {
                isFormLoaded = true;

                browser = new Browser();
                if (_browserId != -1)
                    browser.Id = _browserId;
            }
        }


        void TxtNameChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                browser.Name = txtName.Text;
        }

        void TxtPathChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
                browser.Path = txtPath.Text;
        }

        void Save()
        {
            try
            {
                if (browser.Name.Replace(" ", "").Length == 0)
                {
                    MessageUtil.Message("Browser name can not be empty.");
                    return;
                }

                if (browser.Path.Replace(" ", "").Length == 0)
                {
                    MessageUtil.Message("Browser path can not be empty.");
                    return;
                }

                if (_browserId == -1)
                {
                    browser.Insert();
                    if (ExternalBrowserChanged != null)
                        ExternalBrowserChanged();
                }
                else
                {
                    if (browser.ChangeSetCount > 1)
                    {
                        browser.Update();

                        if (ExternalBrowserChanged != null)
                            ExternalBrowserChanged();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Save");

                MessageUtil.Error("Browser could not be saved.");
            }
        }

        void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                opFileDialog = new OpenFileDialog();
                opFileDialog.FileName = string.Empty;
                opFileDialog.Title = "Please Select Application Path";
                opFileDialog.Filter = "(*.exe)|*.exe|(*.lnk)|*.lnk";
                opFileDialog.FilterIndex = 1; // varsayılan olarak jpg uzantıları göster
                opFileDialog.InitialDirectory = Environment.GetFolderPath(
                    Environment.SpecialFolder.DesktopDirectory);//,Environment.SpecialFolderOption.None);
                opFileDialog.ShowDialog();

                if (string.IsNullOrWhiteSpace(opFileDialog.FileName) == false)
                {
                    txtPath.Text = opFileDialog.FileName;
                }
                return;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                opFileDialog = null;
            }
        }
    }
}

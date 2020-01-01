using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.Management;
using BookmarksStocker.Source.Util;
using Microsoft.Win32;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace BookmarksStocker.Source.Views
{
    public partial class FrmRunWith : Form
    {
        private string _url = string.Empty;
        private bool _isRegistered = true;
        private BookmarkManager bookMan;

        public FrmRunWith(string url, bool isRegistered)
        {
            try
            {
                InitializeComponent();
                bookMan = new BookmarkManager();
                _isRegistered = isRegistered;
                _url = url;
                List<Browser> browsers = new List<Browser>();

                if (_isRegistered)
                {
                    browsers = GetBrowsers();
                }
                else
                {
                    browsers = bookMan.GetExternalBrowsers();
                }

                cmbxBrowsers.DataSource = browsers;
                cmbxBrowsers.DisplayMember = "Name";
                cmbxBrowsers.ValueMember = "Path";
                cmbxBrowsers.SelectedIndex = -1;
                cmbxBrowsers.Refresh();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "Ctor");

                MessageUtil.Error("Run With Form could not be opened.");
            }
        }

        private List<Browser> GetBrowsers()
        {
            List<Browser> _browsers = new List<Browser>();
            try
            {
                string browserListKey = @"SOFTWARE\Clients\StartMenuInternet";
                using (var clients = Registry.LocalMachine.OpenSubKey(browserListKey))
                {
                    foreach (var client in clients.GetSubKeyNames())
                    {
                        using (var clientKey = clients.OpenSubKey(client))
                        {
                            string name = (string)clientKey.GetValue(string.Empty);
                            using (var commandKey = clientKey.OpenSubKey(@"shell\open\command"))
                            {
                                string exe = (string)commandKey.GetValue(string.Empty);
                                _browsers.Add(new Browser() { Name = name, Path = exe });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, "GetBrowsers");
                _browsers = new List<Browser>();
            }
            return _browsers;
        }

        private void btnRunWith_Click(object sender, EventArgs e)
        {
            RunWith();
        }

        private void RunWith()
        {
            try
            {
                if (_url.IsNullOrSpace())
                {
                    MessageUtil.Message("Url can not be null!..");
                    return;
                }
                if (cmbxBrowsers.SelectedIndex == -1)
                {
                    MessageUtil.Message("Select Browser!..");
                    return;
                }
                if (cmbxBrowsers.SelectedValue == null)
                {
                    MessageUtil.Message("Select Browser!..");
                    return;
                }

                using (Process p = new Process())
                {
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.FileName = cmbxBrowsers.SelectedValue.ToString();
                    p.StartInfo.Arguments = "\"" + _url + "\"";
                    p.Start();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, this.Name, MethodBase.GetCurrentMethod().Name); // "RunWith"

                MessageUtil.Error("Object could not be runned.");
            }
        }
    }
}

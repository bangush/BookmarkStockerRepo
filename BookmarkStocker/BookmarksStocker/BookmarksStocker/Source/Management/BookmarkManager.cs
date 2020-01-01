using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.DL;
using Net.Light.Framework.ErrorHandling;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookmarksStocker.Source.Management
{
    internal class BookmarkManager
    {
        public long GetBookmarkIDByName(string bookmarkName)
        {
            long result = -1;
            try
            {
                using (BookmarksDL _bookmarksDL = new BookmarksDL())
                {
                    Bookmark bkmrk = new Bookmark
                    {
                        Name = bookmarkName
                    };

                    DataTable dt = _bookmarksDL.GetChangeColumnList(bkmrk);
                    foreach (DataRow item in dt.Rows)
                    {
                        result = item["ID"].ToLong();
                    }
                }
            }
            catch (Exception ex)
            {
                result = -1;
                LightLogger.LogMethod(ex, "BookmarkManager", "GetBookmarkIDByName");
            }
            return result;
        }

        public long GetBookmarkIDByUrl(string bookmarkUrl)
        {
            long result = -1;
            try
            {
                using (BookmarksDL _bookmarksDL = new BookmarksDL())
                {
                    Bookmark bkmrk = new Bookmark
                    {
                        Url = bookmarkUrl
                    };

                    DataTable dt = _bookmarksDL.GetChangeColumnList(bkmrk);
                    foreach (DataRow item in dt.Rows)
                    {
                        result = item["ID"].ToLong();
                    }
                }
            }
            catch (Exception ex)
            {
                result = -1;
                LightLogger.LogMethod(ex, "BookmarkManager", "GetBookmarkIDByUrl");
            }
            return result;
        }

        public Bookmark GetById(int bookmarkId)
        {
            Bookmark bkmrk = null;
            try
            {
                using (BookmarksDL bkmrksDL = new BookmarksDL())
                {
                    bkmrk = bkmrksDL.GetObjectById<Bookmark>(bookmarkId);
                }
            }
            catch (Exception ex)
            {
                bkmrk = null;
                LightLogger.LogMethod(ex, "BookmarkManager", "GetById");
            }
            return bkmrk;
        }

        public List<Browser> GetExternalBrowsers()
        {
            List<Browser> _browsers = new List<Browser>();
            try
            {
                using (BookmarksDL bkmrksDL = new BookmarksDL())
                {
                    _browsers = bkmrksDL.GetTableAsList<Browser>();
                }
            }
            catch (Exception ex)
            {
                LightLogger.LogMethod(ex, "BookmarkManager", "GetExternalBrowsers");
                _browsers = new List<Browser>();
            }
            return _browsers;
        }

        public DataTable GetExternalBrowserList()
        {
            DataTable result = null;
            try
            {
                using (BookmarksDL bookmrksDL = new BookmarksDL())
                {
                    result = bookmrksDL.GetTable(new Browser());
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
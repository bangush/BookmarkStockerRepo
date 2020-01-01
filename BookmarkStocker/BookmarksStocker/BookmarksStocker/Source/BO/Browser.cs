namespace BookmarksStocker.Source.BO
{
    using BookmarksStocker.Source.DL;
    using Net.Light.Framework.Entity.Base;
    using System;

    class Browser : BaseBO
    {

        public Browser()
        {
            tableProp.TableName = "Browsers";
            tableProp.IdCol = "Id";
        }

        private long _Id;
        public long Id
        {
            set { _Id = value; tableProp.Put("Id", _Id); }
            get { return _Id; }
        }

        private string _Name;
        public string Name
        {
            set { _Name = value; tableProp.Put("Name", _Name); }
            get { return _Name; }
        }

        private string _Path;
        public string Path
        {
            set { _Path = value; tableProp.Put("Path", _Path); }
            get { return _Path; }
        }

        public override string ToString()
        {
            return Name;
        }


        internal int Insert()
        {
            try
            {
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Insert(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.InsertAndGetId(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Update(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

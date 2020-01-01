namespace BookmarksStocker.Source.UserControls
{

    #region [ LightObject struct ]

    /// <summary>
    /// Description of LightObject.
    /// </summary>
    internal struct LightObject
    {
        private string _Text;
        private object _Value;

        public LightObject(string text, object value)
        {
            _Text = text;
            _Value = value;
        }

        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }
    }

    #endregion

}
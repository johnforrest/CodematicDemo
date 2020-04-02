using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// exportinfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class exportinfo
    {
        public exportinfo()
        { }
        #region Model
        private int _id;
        private string _address;
        private string _basin;
        private string _strname;
        private string _plot;
        private string _filename;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Basin
        {
            set { _basin = value; }
            get { return _basin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Strname
        {
            set { _strname = value; }
            get { return _strname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plot
        {
            set { _plot = value; }
            get { return _plot; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileName
        {
            set { _filename = value; }
            get { return _filename; }
        }
        #endregion Model

    }
}


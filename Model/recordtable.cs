using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// recordtable:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class recordtable
    {
        public recordtable()
        { }
        #region Model
        private int _id;
        private string _type;
        private string _year;
        private string _strnolast5;
        private int? _inteno;
        private int? _serino;
        private string _typeyear;
        private string _typeyearstrnolast5;
        private string _typeyearstrnolast5inteno;
        private string _inteserino;
        private string _exp_no;
        private string _lno;
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
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string year
        {
            set { _year = value; }
            get { return _year; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string strnolast5
        {
            set { _strnolast5 = value; }
            get { return _strnolast5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? inteno
        {
            set { _inteno = value; }
            get { return _inteno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? serino
        {
            set { _serino = value; }
            get { return _serino; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string typeYear
        {
            set { _typeyear = value; }
            get { return _typeyear; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string typeYearStrnolast5
        {
            set { _typeyearstrnolast5 = value; }
            get { return _typeyearstrnolast5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string typeYearStrnolast5Inteno
        {
            set { _typeyearstrnolast5inteno = value; }
            get { return _typeyearstrnolast5inteno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string inteserino
        {
            set { _inteserino = value; }
            get { return _inteserino; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Exp_No
        {
            set { _exp_no = value; }
            get { return _exp_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Lno
        {
            set { _lno = value; }
            get { return _lno; }
        }
        #endregion Model

    }
}


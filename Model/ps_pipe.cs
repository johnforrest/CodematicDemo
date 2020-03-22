using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// ps_pipe:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ps_pipe
    {
        public ps_pipe()
        { }
        #region Model
        private string _prj_no;
        private string _prj_name;
        private string _lno;
        private string _grade;
        private string _s_point;
        private decimal? _s_deep;
        private decimal? _in_elev;
        private string _e_point;
        private decimal? _e_deep;
        private decimal? _out_elev;
        private string _sewagesystem_id;
        private string _stormsystem_id;
        private string _type;
        private string _code;
        private string _pressure_type;
        private string _invert_silphon;
        private string _material;
        private string _servicelife;
        private string _shapetype;
        private string _psize;
        private decimal? _pipelength;
        private string _flowdir;
        private string _embed;
        private string _interface;
        private string _address;
        private string _datasource;
        private string _sunit;
        private string _sdate;
        private string _updatetime;
        private string _mdate;
        private string _plan;
        private string _pipe_type;
        private string _status;
        private string _ename;
        private string _design_dept;
        private string _conster_dept;
        private string _belong;
        private string _operator;
        private string _note;
        private string _exp_no0;
        private string _exp_no1;
        private string _filename;
        private string _uploadtime;
        /// <summary>
        /// 
        /// </summary>
        public string Prj_No
        {
            set { _prj_no = value; }
            get { return _prj_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Prj_Name
        {
            set { _prj_name = value; }
            get { return _prj_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Lno
        {
            set { _lno = value; }
            get { return _lno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_Point
        {
            set { _s_point = value; }
            get { return _s_point; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? S_Deep
        {
            set { _s_deep = value; }
            get { return _s_deep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? In_Elev
        {
            set { _in_elev = value; }
            get { return _in_elev; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_Point
        {
            set { _e_point = value; }
            get { return _e_point; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? E_Deep
        {
            set { _e_deep = value; }
            get { return _e_deep; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Out_Elev
        {
            set { _out_elev = value; }
            get { return _out_elev; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SewageSystem_ID
        {
            set { _sewagesystem_id = value; }
            get { return _sewagesystem_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StormSystem_ID
        {
            set { _stormsystem_id = value; }
            get { return _stormsystem_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pressure_Type
        {
            set { _pressure_type = value; }
            get { return _pressure_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Invert_Silphon
        {
            set { _invert_silphon = value; }
            get { return _invert_silphon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Material
        {
            set { _material = value; }
            get { return _material; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceLife
        {
            set { _servicelife = value; }
            get { return _servicelife; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShapeType
        {
            set { _shapetype = value; }
            get { return _shapetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PSize
        {
            set { _psize = value; }
            get { return _psize; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PipeLength
        {
            set { _pipelength = value; }
            get { return _pipelength; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FlowDir
        {
            set { _flowdir = value; }
            get { return _flowdir; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmBed
        {
            set { _embed = value; }
            get { return _embed; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Interface
        {
            set { _interface = value; }
            get { return _interface; }
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
        public string DataSource
        {
            set { _datasource = value; }
            get { return _datasource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sunit
        {
            set { _sunit = value; }
            get { return _sunit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sdate
        {
            set { _sdate = value; }
            get { return _sdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mdate
        {
            set { _mdate = value; }
            get { return _mdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan
        {
            set { _plan = value; }
            get { return _plan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pipe_Type
        {
            set { _pipe_type = value; }
            get { return _pipe_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ename
        {
            set { _ename = value; }
            get { return _ename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Design_Dept
        {
            set { _design_dept = value; }
            get { return _design_dept; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Conster_Dept
        {
            set { _conster_dept = value; }
            get { return _conster_dept; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Belong
        {
            set { _belong = value; }
            get { return _belong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Operator
        {
            set { _operator = value; }
            get { return _operator; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            set { _note = value; }
            get { return _note; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Exp_No0
        {
            set { _exp_no0 = value; }
            get { return _exp_no0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Exp_No1
        {
            set { _exp_no1 = value; }
            get { return _exp_no1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileName
        {
            set { _filename = value; }
            get { return _filename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Uploadtime
        {
            set { _uploadtime = value; }
            get { return _uploadtime; }
        }
        #endregion Model

    }
}


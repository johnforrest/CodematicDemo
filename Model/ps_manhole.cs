using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ps_manhole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ps_manhole
	{
		public ps_manhole()
		{}
		#region Model
		private string _prj_no;
		private string _prj_name;
		private string _exp_no;
		private string _mapcode;
		private string _sewagesystem_id;
		private string _stormsystem_id;
		private string _type;
		private decimal? _x;
		private decimal? _y;
		private decimal? _high;
		private decimal? _welldeep;
		private string _offset;
		private decimal? _rotation;
		private string _code;
		private string _model;
		private string _wellshape;
		private string _wellsize;
		private string _wellmaterial;
		private int? _wellpipes;
		private decimal? _waterdeep;
		private decimal? _muddeep;
		private string _address;
		private int? _pointposition;
		private string _datasource;
		private string _visibility;
		private string _sunit;
		private string _sdate;
		private string _updatetime;
		private string _mdate;
		private string _manhole_type;
		private string _status;
		private string _ename;
		private string _design_dept;
		private string _conster_dept;
		private string _belong;
		private string _operator;
		private string _note;
		private string _exp_noori;
		private string _filename;
		private string _update;
		/// <summary>
		/// 
		/// </summary>
		public string Prj_No
		{
			set{ _prj_no=value;}
			get{return _prj_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Prj_Name
		{
			set{ _prj_name=value;}
			get{return _prj_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exp_No
		{
			set{ _exp_no=value;}
			get{return _exp_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MapCode
		{
			set{ _mapcode=value;}
			get{return _mapcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SewageSystem_ID
		{
			set{ _sewagesystem_id=value;}
			get{return _sewagesystem_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StormSystem_ID
		{
			set{ _stormsystem_id=value;}
			get{return _stormsystem_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? X
		{
			set{ _x=value;}
			get{return _x;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y
		{
			set{ _y=value;}
			get{return _y;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? High
		{
			set{ _high=value;}
			get{return _high;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WellDeep
		{
			set{ _welldeep=value;}
			get{return _welldeep;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Offset
		{
			set{ _offset=value;}
			get{return _offset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Rotation
		{
			set{ _rotation=value;}
			get{return _rotation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellShape
		{
			set{ _wellshape=value;}
			get{return _wellshape;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellSize
		{
			set{ _wellsize=value;}
			get{return _wellsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellMaterial
		{
			set{ _wellmaterial=value;}
			get{return _wellmaterial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WellPipes
		{
			set{ _wellpipes=value;}
			get{return _wellpipes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WaterDeep
		{
			set{ _waterdeep=value;}
			get{return _waterdeep;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MudDeep
		{
			set{ _muddeep=value;}
			get{return _muddeep;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointPosition
		{
			set{ _pointposition=value;}
			get{return _pointposition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataSource
		{
			set{ _datasource=value;}
			get{return _datasource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Visibility
		{
			set{ _visibility=value;}
			get{return _visibility;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sunit
		{
			set{ _sunit=value;}
			get{return _sunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sdate
		{
			set{ _sdate=value;}
			get{return _sdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mdate
		{
			set{ _mdate=value;}
			get{return _mdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Manhole_Type
		{
			set{ _manhole_type=value;}
			get{return _manhole_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ename
		{
			set{ _ename=value;}
			get{return _ename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Design_Dept
		{
			set{ _design_dept=value;}
			get{return _design_dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Conster_Dept
		{
			set{ _conster_dept=value;}
			get{return _conster_dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Belong
		{
			set{ _belong=value;}
			get{return _belong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exp_NoOri
		{
			set{ _exp_noori=value;}
			get{return _exp_noori;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string filename
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string update
		{
			set{ _update=value;}
			get{return _update;}
		}
		#endregion Model

	}
}


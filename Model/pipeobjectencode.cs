using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// pipeobjectencode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class pipeobjectencode
	{
		public pipeobjectencode()
		{}
		#region Model
		private int _number;
		private string _objcate;
		private string _code;
		private string _objname;
		private string _note;
		private string _tablename;
		private string _objtype;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string objcate
		{
			set{ _objcate=value;}
			get{return _objcate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string objname
		{
			set{ _objname=value;}
			get{return _objname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tablename
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string objtype
		{
			set{ _objtype=value;}
			get{return _objtype;}
		}
		#endregion Model

	}
}


using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// sewpartition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sewpartition
	{
		public sewpartition()
		{}
		#region Model
		private int _number;
		private string _sewpartname;
		private string _code;
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
		public string Sewpartname
		{
			set{ _sewpartname=value;}
			get{return _sewpartname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		#endregion Model

	}
}


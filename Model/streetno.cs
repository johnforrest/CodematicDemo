using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// streetno:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class streetno
	{
		public streetno()
		{}
		#region Model
		private int _number;
		private string _strname;
		private string _strno;
		private string _strnolast5;
		/// <summary>
		/// 
		/// </summary>
		public int number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string strname
		{
			set{ _strname=value;}
			get{return _strname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string strno
		{
			set{ _strno=value;}
			get{return _strno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string strnolast5
		{
			set{ _strnolast5=value;}
			get{return _strnolast5;}
		}
		#endregion Model

	}
}


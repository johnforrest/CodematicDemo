using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:pipeobjectencode
	/// </summary>
	public partial class pipeobjectencode
	{
		public pipeobjectencode()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("number", "pipeobjectencode"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int number)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pipeobjectencode");
			strSql.Append(" where number=@number");
			MySqlParameter[] parameters = {
					new MySqlParameter("@number", MySqlDbType.Int32)
			};
			parameters[0].Value = number;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.pipeobjectencode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pipeobjectencode(");
			strSql.Append("objcate,code,objname,note,tablename,objtype)");
			strSql.Append(" values (");
			strSql.Append("@objcate,@code,@objname,@note,@tablename,@objtype)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@objcate", MySqlDbType.VarChar,10),
					new MySqlParameter("@code", MySqlDbType.VarChar,10),
					new MySqlParameter("@objname", MySqlDbType.VarChar,100),
					new MySqlParameter("@note", MySqlDbType.VarChar,255),
					new MySqlParameter("@tablename", MySqlDbType.VarChar,150),
					new MySqlParameter("@objtype", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.objcate;
			parameters[1].Value = model.code;
			parameters[2].Value = model.objname;
			parameters[3].Value = model.note;
			parameters[4].Value = model.tablename;
			parameters[5].Value = model.objtype;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.pipeobjectencode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pipeobjectencode set ");
			strSql.Append("objcate=@objcate,");
			strSql.Append("code=@code,");
			strSql.Append("objname=@objname,");
			strSql.Append("note=@note,");
			strSql.Append("tablename=@tablename,");
			strSql.Append("objtype=@objtype");
			strSql.Append(" where number=@number");
			MySqlParameter[] parameters = {
					new MySqlParameter("@objcate", MySqlDbType.VarChar,10),
					new MySqlParameter("@code", MySqlDbType.VarChar,10),
					new MySqlParameter("@objname", MySqlDbType.VarChar,100),
					new MySqlParameter("@note", MySqlDbType.VarChar,255),
					new MySqlParameter("@tablename", MySqlDbType.VarChar,150),
					new MySqlParameter("@objtype", MySqlDbType.VarChar,255),
					new MySqlParameter("@number", MySqlDbType.Int32,11)};
			parameters[0].Value = model.objcate;
			parameters[1].Value = model.code;
			parameters[2].Value = model.objname;
			parameters[3].Value = model.note;
			parameters[4].Value = model.tablename;
			parameters[5].Value = model.objtype;
			parameters[6].Value = model.number;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pipeobjectencode ");
			strSql.Append(" where number=@number");
			MySqlParameter[] parameters = {
					new MySqlParameter("@number", MySqlDbType.Int32)
			};
			parameters[0].Value = number;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string numberlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pipeobjectencode ");
			strSql.Append(" where number in ("+numberlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.pipeobjectencode GetModel(int number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select number,objcate,code,objname,note,tablename,objtype from pipeobjectencode ");
			strSql.Append(" where number=@number");
			MySqlParameter[] parameters = {
					new MySqlParameter("@number", MySqlDbType.Int32)
			};
			parameters[0].Value = number;

			Maticsoft.Model.pipeobjectencode model=new Maticsoft.Model.pipeobjectencode();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.pipeobjectencode DataRowToModel(DataRow row)
		{
			Maticsoft.Model.pipeobjectencode model=new Maticsoft.Model.pipeobjectencode();
			if (row != null)
			{
				if(row["number"]!=null && row["number"].ToString()!="")
				{
					model.number=int.Parse(row["number"].ToString());
				}
				if(row["objcate"]!=null)
				{
					model.objcate=row["objcate"].ToString();
				}
				if(row["code"]!=null)
				{
					model.code=row["code"].ToString();
				}
				if(row["objname"]!=null)
				{
					model.objname=row["objname"].ToString();
				}
				if(row["note"]!=null)
				{
					model.note=row["note"].ToString();
				}
				if(row["tablename"]!=null)
				{
					model.tablename=row["tablename"].ToString();
				}
				if(row["objtype"]!=null)
				{
					model.objtype=row["objtype"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select number,objcate,code,objname,note,tablename,objtype ");
			strSql.Append(" FROM pipeobjectencode ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM pipeobjectencode ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.number desc");
			}
			strSql.Append(")AS Row, T.*  from pipeobjectencode T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "pipeobjectencode";
			parameters[1].Value = "number";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}


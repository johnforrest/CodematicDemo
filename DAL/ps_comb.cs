using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ps_comb
	/// </summary>
	public partial class ps_comb
	{
		public ps_comb()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Exp_No)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ps_comb");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Exp_No;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.ps_comb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ps_comb(");
			strSql.Append("Prj_No,Prj_Name,Exp_No,MapCode,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,WellDeep,Offset,Rotation,Code,Inlet_Type,WellShape,WellSize,WellMaterial,Model,WellPipes,Address,PointPosition,DataSource,Visibility,Sunit,Sdate,UpdateTime,Mdate,Comb_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,filename,update)");
			strSql.Append(" values (");
			strSql.Append("@Prj_No,@Prj_Name,@Exp_No,@MapCode,@SewageSystem_ID,@StormSystem_ID,@Type,@X,@Y,@High,@WellDeep,@Offset,@Rotation,@Code,@Inlet_Type,@WellShape,@WellSize,@WellMaterial,@Model,@WellPipes,@Address,@PointPosition,@DataSource,@Visibility,@Sunit,@Sdate,@UpdateTime,@Mdate,@Comb_Type,@Status,@Ename,@Design_Dept,@Conster_Dept,@Belong,@Operator,@Note,@Exp_NoOri,@filename,@update)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
					new MySqlParameter("@MapCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,4),
					new MySqlParameter("@X", MySqlDbType.Decimal,10),
					new MySqlParameter("@Y", MySqlDbType.Decimal,10),
					new MySqlParameter("@High", MySqlDbType.Decimal,10),
					new MySqlParameter("@WellDeep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Offset", MySqlDbType.VarChar,50),
					new MySqlParameter("@Rotation", MySqlDbType.Decimal,10),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Inlet_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@WellShape", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellSize", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellMaterial", MySqlDbType.VarChar,50),
					new MySqlParameter("@Model", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellPipes", MySqlDbType.Int32,10),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@PointPosition", MySqlDbType.Int32,10),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Visibility", MySqlDbType.VarChar,4),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Comb_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
					new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
					new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.Exp_No;
			parameters[3].Value = model.MapCode;
			parameters[4].Value = model.SewageSystem_ID;
			parameters[5].Value = model.StormSystem_ID;
			parameters[6].Value = model.Type;
			parameters[7].Value = model.X;
			parameters[8].Value = model.Y;
			parameters[9].Value = model.High;
			parameters[10].Value = model.WellDeep;
			parameters[11].Value = model.Offset;
			parameters[12].Value = model.Rotation;
			parameters[13].Value = model.Code;
			parameters[14].Value = model.Inlet_Type;
			parameters[15].Value = model.WellShape;
			parameters[16].Value = model.WellSize;
			parameters[17].Value = model.WellMaterial;
			parameters[18].Value = model.Model;
			parameters[19].Value = model.WellPipes;
			parameters[20].Value = model.Address;
			parameters[21].Value = model.PointPosition;
			parameters[22].Value = model.DataSource;
			parameters[23].Value = model.Visibility;
			parameters[24].Value = model.Sunit;
			parameters[25].Value = model.Sdate;
			parameters[26].Value = model.UpdateTime;
			parameters[27].Value = model.Mdate;
			parameters[28].Value = model.Comb_Type;
			parameters[29].Value = model.Status;
			parameters[30].Value = model.Ename;
			parameters[31].Value = model.Design_Dept;
			parameters[32].Value = model.Conster_Dept;
			parameters[33].Value = model.Belong;
			parameters[34].Value = model.Operator;
			parameters[35].Value = model.Note;
			parameters[36].Value = model.Exp_NoOri;
			parameters[37].Value = model.filename;
			parameters[38].Value = model.update;

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
		public bool Update(Maticsoft.Model.ps_comb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ps_comb set ");
			strSql.Append("Prj_No=@Prj_No,");
			strSql.Append("Prj_Name=@Prj_Name,");
			strSql.Append("MapCode=@MapCode,");
			strSql.Append("SewageSystem_ID=@SewageSystem_ID,");
			strSql.Append("StormSystem_ID=@StormSystem_ID,");
			strSql.Append("Type=@Type,");
			strSql.Append("X=@X,");
			strSql.Append("Y=@Y,");
			strSql.Append("High=@High,");
			strSql.Append("WellDeep=@WellDeep,");
			strSql.Append("Offset=@Offset,");
			strSql.Append("Rotation=@Rotation,");
			strSql.Append("Code=@Code,");
			strSql.Append("Inlet_Type=@Inlet_Type,");
			strSql.Append("WellShape=@WellShape,");
			strSql.Append("WellSize=@WellSize,");
			strSql.Append("WellMaterial=@WellMaterial,");
			strSql.Append("Model=@Model,");
			strSql.Append("WellPipes=@WellPipes,");
			strSql.Append("Address=@Address,");
			strSql.Append("PointPosition=@PointPosition,");
			strSql.Append("DataSource=@DataSource,");
			strSql.Append("Visibility=@Visibility,");
			strSql.Append("Sunit=@Sunit,");
			strSql.Append("Sdate=@Sdate,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("Mdate=@Mdate,");
			strSql.Append("Comb_Type=@Comb_Type,");
			strSql.Append("Status=@Status,");
			strSql.Append("Ename=@Ename,");
			strSql.Append("Design_Dept=@Design_Dept,");
			strSql.Append("Conster_Dept=@Conster_Dept,");
			strSql.Append("Belong=@Belong,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("Note=@Note,");
			strSql.Append("Exp_NoOri=@Exp_NoOri,");
			strSql.Append("filename=@filename,");
			strSql.Append("update=@update");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@MapCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,4),
					new MySqlParameter("@X", MySqlDbType.Decimal,10),
					new MySqlParameter("@Y", MySqlDbType.Decimal,10),
					new MySqlParameter("@High", MySqlDbType.Decimal,10),
					new MySqlParameter("@WellDeep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Offset", MySqlDbType.VarChar,50),
					new MySqlParameter("@Rotation", MySqlDbType.Decimal,10),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Inlet_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@WellShape", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellSize", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellMaterial", MySqlDbType.VarChar,50),
					new MySqlParameter("@Model", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellPipes", MySqlDbType.Int32,10),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@PointPosition", MySqlDbType.Int32,10),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Visibility", MySqlDbType.VarChar,4),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Comb_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
					new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
					new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.MapCode;
			parameters[3].Value = model.SewageSystem_ID;
			parameters[4].Value = model.StormSystem_ID;
			parameters[5].Value = model.Type;
			parameters[6].Value = model.X;
			parameters[7].Value = model.Y;
			parameters[8].Value = model.High;
			parameters[9].Value = model.WellDeep;
			parameters[10].Value = model.Offset;
			parameters[11].Value = model.Rotation;
			parameters[12].Value = model.Code;
			parameters[13].Value = model.Inlet_Type;
			parameters[14].Value = model.WellShape;
			parameters[15].Value = model.WellSize;
			parameters[16].Value = model.WellMaterial;
			parameters[17].Value = model.Model;
			parameters[18].Value = model.WellPipes;
			parameters[19].Value = model.Address;
			parameters[20].Value = model.PointPosition;
			parameters[21].Value = model.DataSource;
			parameters[22].Value = model.Visibility;
			parameters[23].Value = model.Sunit;
			parameters[24].Value = model.Sdate;
			parameters[25].Value = model.UpdateTime;
			parameters[26].Value = model.Mdate;
			parameters[27].Value = model.Comb_Type;
			parameters[28].Value = model.Status;
			parameters[29].Value = model.Ename;
			parameters[30].Value = model.Design_Dept;
			parameters[31].Value = model.Conster_Dept;
			parameters[32].Value = model.Belong;
			parameters[33].Value = model.Operator;
			parameters[34].Value = model.Note;
			parameters[35].Value = model.Exp_NoOri;
			parameters[36].Value = model.filename;
			parameters[37].Value = model.update;
			parameters[38].Value = model.Exp_No;

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
		public bool Delete(string Exp_No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ps_comb ");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Exp_No;

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
		public bool DeleteList(string Exp_Nolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ps_comb ");
			strSql.Append(" where Exp_No in ("+Exp_Nolist + ")  ");
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
		public Maticsoft.Model.ps_comb GetModel(string Exp_No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,WellDeep,Offset,Rotation,Code,Inlet_Type,WellShape,WellSize,WellMaterial,Model,WellPipes,Address,PointPosition,DataSource,Visibility,Sunit,Sdate,UpdateTime,Mdate,Comb_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,filename,update from ps_comb ");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Exp_No;

			Maticsoft.Model.ps_comb model=new Maticsoft.Model.ps_comb();
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
		public Maticsoft.Model.ps_comb DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ps_comb model=new Maticsoft.Model.ps_comb();
			if (row != null)
			{
				if(row["Prj_No"]!=null)
				{
					model.Prj_No=row["Prj_No"].ToString();
				}
				if(row["Prj_Name"]!=null)
				{
					model.Prj_Name=row["Prj_Name"].ToString();
				}
				if(row["Exp_No"]!=null)
				{
					model.Exp_No=row["Exp_No"].ToString();
				}
				if(row["MapCode"]!=null)
				{
					model.MapCode=row["MapCode"].ToString();
				}
				if(row["SewageSystem_ID"]!=null)
				{
					model.SewageSystem_ID=row["SewageSystem_ID"].ToString();
				}
				if(row["StormSystem_ID"]!=null)
				{
					model.StormSystem_ID=row["StormSystem_ID"].ToString();
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["X"]!=null && row["X"].ToString()!="")
				{
					model.X=decimal.Parse(row["X"].ToString());
				}
				if(row["Y"]!=null && row["Y"].ToString()!="")
				{
					model.Y=decimal.Parse(row["Y"].ToString());
				}
				if(row["High"]!=null && row["High"].ToString()!="")
				{
					model.High=decimal.Parse(row["High"].ToString());
				}
				if(row["WellDeep"]!=null && row["WellDeep"].ToString()!="")
				{
					model.WellDeep=decimal.Parse(row["WellDeep"].ToString());
				}
				if(row["Offset"]!=null)
				{
					model.Offset=row["Offset"].ToString();
				}
				if(row["Rotation"]!=null && row["Rotation"].ToString()!="")
				{
					model.Rotation=decimal.Parse(row["Rotation"].ToString());
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Inlet_Type"]!=null)
				{
					model.Inlet_Type=row["Inlet_Type"].ToString();
				}
				if(row["WellShape"]!=null)
				{
					model.WellShape=row["WellShape"].ToString();
				}
				if(row["WellSize"]!=null)
				{
					model.WellSize=row["WellSize"].ToString();
				}
				if(row["WellMaterial"]!=null)
				{
					model.WellMaterial=row["WellMaterial"].ToString();
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["WellPipes"]!=null && row["WellPipes"].ToString()!="")
				{
					model.WellPipes=int.Parse(row["WellPipes"].ToString());
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["PointPosition"]!=null && row["PointPosition"].ToString()!="")
				{
					model.PointPosition=int.Parse(row["PointPosition"].ToString());
				}
				if(row["DataSource"]!=null)
				{
					model.DataSource=row["DataSource"].ToString();
				}
				if(row["Visibility"]!=null)
				{
					model.Visibility=row["Visibility"].ToString();
				}
				if(row["Sunit"]!=null)
				{
					model.Sunit=row["Sunit"].ToString();
				}
				if(row["Sdate"]!=null)
				{
					model.Sdate=row["Sdate"].ToString();
				}
				if(row["UpdateTime"]!=null)
				{
					model.UpdateTime=row["UpdateTime"].ToString();
				}
				if(row["Mdate"]!=null)
				{
					model.Mdate=row["Mdate"].ToString();
				}
				if(row["Comb_Type"]!=null)
				{
					model.Comb_Type=row["Comb_Type"].ToString();
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["Ename"]!=null)
				{
					model.Ename=row["Ename"].ToString();
				}
				if(row["Design_Dept"]!=null)
				{
					model.Design_Dept=row["Design_Dept"].ToString();
				}
				if(row["Conster_Dept"]!=null)
				{
					model.Conster_Dept=row["Conster_Dept"].ToString();
				}
				if(row["Belong"]!=null)
				{
					model.Belong=row["Belong"].ToString();
				}
				if(row["Operator"]!=null)
				{
					model.Operator=row["Operator"].ToString();
				}
				if(row["Note"]!=null)
				{
					model.Note=row["Note"].ToString();
				}
				if(row["Exp_NoOri"]!=null)
				{
					model.Exp_NoOri=row["Exp_NoOri"].ToString();
				}
				if(row["filename"]!=null)
				{
					model.filename=row["filename"].ToString();
				}
				if(row["update"]!=null)
				{
					model.update=row["update"].ToString();
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
			strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,WellDeep,Offset,Rotation,Code,Inlet_Type,WellShape,WellSize,WellMaterial,Model,WellPipes,Address,PointPosition,DataSource,Visibility,Sunit,Sdate,UpdateTime,Mdate,Comb_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,filename,update ");
			strSql.Append(" FROM ps_comb ");
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
			strSql.Append("select count(1) FROM ps_comb ");
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
				strSql.Append("order by T.Exp_No desc");
			}
			strSql.Append(")AS Row, T.*  from ps_comb T ");
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
			parameters[0].Value = "ps_comb";
			parameters[1].Value = "Exp_No";
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


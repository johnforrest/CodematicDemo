using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:cjplp
	/// </summary>
	public partial class cjplp
	{
		public cjplp()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Exp_No)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from cjplp");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,255)			};
			parameters[0].Value = Exp_No;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.cjplp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into cjplp(");
			strSql.Append("MapCode,StormSystem_ID,Exp_No,Type,X,Y,High,WellDeep,Offset,Feature,Subsid,Model,WellPipes,WellShape,WellSize,WellMaterial,WaterDeep,MudDeep,Inlet_Type,OutfallType,ReceiveWater,Flap,Flap_Diameter,Flap_TopEle,Flap_BotEle,Flap_Material,Address,PointPosition,DataSource,Visibility,Sdate,Mdate,Manhole_Type,status,Note)");
			strSql.Append(" values (");
			strSql.Append("@MapCode,@StormSystem_ID,@Exp_No,@Type,@X,@Y,@High,@WellDeep,@Offset,@Feature,@Subsid,@Model,@WellPipes,@WellShape,@WellSize,@WellMaterial,@WaterDeep,@MudDeep,@Inlet_Type,@OutfallType,@ReceiveWater,@Flap,@Flap_Diameter,@Flap_TopEle,@Flap_BotEle,@Flap_Material,@Address,@PointPosition,@DataSource,@Visibility,@Sdate,@Mdate,@Manhole_Type,@status,@Note)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MapCode", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,100),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,255),
					new MySqlParameter("@Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@X", MySqlDbType.Decimal,10),
					new MySqlParameter("@Y", MySqlDbType.Decimal,10),
					new MySqlParameter("@High", MySqlDbType.Decimal,10),
					new MySqlParameter("@WellDeep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Offset", MySqlDbType.VarChar,255),
					new MySqlParameter("@Feature", MySqlDbType.VarChar,255),
					new MySqlParameter("@Subsid", MySqlDbType.VarChar,255),
					new MySqlParameter("@Model", MySqlDbType.VarChar,255),
					new MySqlParameter("@WellPipes", MySqlDbType.VarChar,10),
					new MySqlParameter("@WellShape", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellSize", MySqlDbType.VarChar,150),
					new MySqlParameter("@WellMaterial", MySqlDbType.VarChar,255),
					new MySqlParameter("@WaterDeep", MySqlDbType.Decimal,10),
					new MySqlParameter("@MudDeep", MySqlDbType.Decimal,10),
					new MySqlParameter("@Inlet_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@OutfallType", MySqlDbType.VarChar,10),
					new MySqlParameter("@ReceiveWater", MySqlDbType.VarChar,255),
					new MySqlParameter("@Flap", MySqlDbType.VarChar,10),
					new MySqlParameter("@Flap_Diameter", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_TopEle", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_BotEle", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_Material", MySqlDbType.VarChar,255),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@PointPosition", MySqlDbType.VarChar,10),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Visibility", MySqlDbType.VarChar,50),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Manhole_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.MapCode;
			parameters[1].Value = model.StormSystem_ID;
			parameters[2].Value = model.Exp_No;
			parameters[3].Value = model.Type;
			parameters[4].Value = model.X;
			parameters[5].Value = model.Y;
			parameters[6].Value = model.High;
			parameters[7].Value = model.WellDeep;
			parameters[8].Value = model.Offset;
			parameters[9].Value = model.Feature;
			parameters[10].Value = model.Subsid;
			parameters[11].Value = model.Model;
			parameters[12].Value = model.WellPipes;
			parameters[13].Value = model.WellShape;
			parameters[14].Value = model.WellSize;
			parameters[15].Value = model.WellMaterial;
			parameters[16].Value = model.WaterDeep;
			parameters[17].Value = model.MudDeep;
			parameters[18].Value = model.Inlet_Type;
			parameters[19].Value = model.OutfallType;
			parameters[20].Value = model.ReceiveWater;
			parameters[21].Value = model.Flap;
			parameters[22].Value = model.Flap_Diameter;
			parameters[23].Value = model.Flap_TopEle;
			parameters[24].Value = model.Flap_BotEle;
			parameters[25].Value = model.Flap_Material;
			parameters[26].Value = model.Address;
			parameters[27].Value = model.PointPosition;
			parameters[28].Value = model.DataSource;
			parameters[29].Value = model.Visibility;
			parameters[30].Value = model.Sdate;
			parameters[31].Value = model.Mdate;
			parameters[32].Value = model.Manhole_Type;
			parameters[33].Value = model.status;
			parameters[34].Value = model.Note;

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
		public bool Update(Maticsoft.Model.cjplp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update cjplp set ");
			strSql.Append("MapCode=@MapCode,");
			strSql.Append("StormSystem_ID=@StormSystem_ID,");
			strSql.Append("Type=@Type,");
			strSql.Append("X=@X,");
			strSql.Append("Y=@Y,");
			strSql.Append("High=@High,");
			strSql.Append("WellDeep=@WellDeep,");
			strSql.Append("Offset=@Offset,");
			strSql.Append("Feature=@Feature,");
			strSql.Append("Subsid=@Subsid,");
			strSql.Append("Model=@Model,");
			strSql.Append("WellPipes=@WellPipes,");
			strSql.Append("WellShape=@WellShape,");
			strSql.Append("WellSize=@WellSize,");
			strSql.Append("WellMaterial=@WellMaterial,");
			strSql.Append("WaterDeep=@WaterDeep,");
			strSql.Append("MudDeep=@MudDeep,");
			strSql.Append("Inlet_Type=@Inlet_Type,");
			strSql.Append("OutfallType=@OutfallType,");
			strSql.Append("ReceiveWater=@ReceiveWater,");
			strSql.Append("Flap=@Flap,");
			strSql.Append("Flap_Diameter=@Flap_Diameter,");
			strSql.Append("Flap_TopEle=@Flap_TopEle,");
			strSql.Append("Flap_BotEle=@Flap_BotEle,");
			strSql.Append("Flap_Material=@Flap_Material,");
			strSql.Append("Address=@Address,");
			strSql.Append("PointPosition=@PointPosition,");
			strSql.Append("DataSource=@DataSource,");
			strSql.Append("Visibility=@Visibility,");
			strSql.Append("Sdate=@Sdate,");
			strSql.Append("Mdate=@Mdate,");
			strSql.Append("Manhole_Type=@Manhole_Type,");
			strSql.Append("status=@status,");
			strSql.Append("Note=@Note");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MapCode", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,100),
					new MySqlParameter("@Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@X", MySqlDbType.Decimal,10),
					new MySqlParameter("@Y", MySqlDbType.Decimal,10),
					new MySqlParameter("@High", MySqlDbType.Decimal,10),
					new MySqlParameter("@WellDeep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Offset", MySqlDbType.VarChar,255),
					new MySqlParameter("@Feature", MySqlDbType.VarChar,255),
					new MySqlParameter("@Subsid", MySqlDbType.VarChar,255),
					new MySqlParameter("@Model", MySqlDbType.VarChar,255),
					new MySqlParameter("@WellPipes", MySqlDbType.VarChar,10),
					new MySqlParameter("@WellShape", MySqlDbType.VarChar,50),
					new MySqlParameter("@WellSize", MySqlDbType.VarChar,150),
					new MySqlParameter("@WellMaterial", MySqlDbType.VarChar,255),
					new MySqlParameter("@WaterDeep", MySqlDbType.Decimal,10),
					new MySqlParameter("@MudDeep", MySqlDbType.Decimal,10),
					new MySqlParameter("@Inlet_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@OutfallType", MySqlDbType.VarChar,10),
					new MySqlParameter("@ReceiveWater", MySqlDbType.VarChar,255),
					new MySqlParameter("@Flap", MySqlDbType.VarChar,10),
					new MySqlParameter("@Flap_Diameter", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_TopEle", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_BotEle", MySqlDbType.Decimal,10),
					new MySqlParameter("@Flap_Material", MySqlDbType.VarChar,255),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@PointPosition", MySqlDbType.VarChar,10),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Visibility", MySqlDbType.VarChar,50),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Manhole_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.MapCode;
			parameters[1].Value = model.StormSystem_ID;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.X;
			parameters[4].Value = model.Y;
			parameters[5].Value = model.High;
			parameters[6].Value = model.WellDeep;
			parameters[7].Value = model.Offset;
			parameters[8].Value = model.Feature;
			parameters[9].Value = model.Subsid;
			parameters[10].Value = model.Model;
			parameters[11].Value = model.WellPipes;
			parameters[12].Value = model.WellShape;
			parameters[13].Value = model.WellSize;
			parameters[14].Value = model.WellMaterial;
			parameters[15].Value = model.WaterDeep;
			parameters[16].Value = model.MudDeep;
			parameters[17].Value = model.Inlet_Type;
			parameters[18].Value = model.OutfallType;
			parameters[19].Value = model.ReceiveWater;
			parameters[20].Value = model.Flap;
			parameters[21].Value = model.Flap_Diameter;
			parameters[22].Value = model.Flap_TopEle;
			parameters[23].Value = model.Flap_BotEle;
			parameters[24].Value = model.Flap_Material;
			parameters[25].Value = model.Address;
			parameters[26].Value = model.PointPosition;
			parameters[27].Value = model.DataSource;
			parameters[28].Value = model.Visibility;
			parameters[29].Value = model.Sdate;
			parameters[30].Value = model.Mdate;
			parameters[31].Value = model.Manhole_Type;
			parameters[32].Value = model.status;
			parameters[33].Value = model.Note;
			parameters[34].Value = model.Exp_No;

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
			strSql.Append("delete from cjplp ");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,255)			};
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
			strSql.Append("delete from cjplp ");
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
		public Maticsoft.Model.cjplp GetModel(string Exp_No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MapCode,StormSystem_ID,Exp_No,Type,X,Y,High,WellDeep,Offset,Feature,Subsid,Model,WellPipes,WellShape,WellSize,WellMaterial,WaterDeep,MudDeep,Inlet_Type,OutfallType,ReceiveWater,Flap,Flap_Diameter,Flap_TopEle,Flap_BotEle,Flap_Material,Address,PointPosition,DataSource,Visibility,Sdate,Mdate,Manhole_Type,status,Note from cjplp ");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,255)			};
			parameters[0].Value = Exp_No;

			Maticsoft.Model.cjplp model=new Maticsoft.Model.cjplp();
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
		public Maticsoft.Model.cjplp DataRowToModel(DataRow row)
		{
			Maticsoft.Model.cjplp model=new Maticsoft.Model.cjplp();
			if (row != null)
			{
				if(row["MapCode"]!=null)
				{
					model.MapCode=row["MapCode"].ToString();
				}
				if(row["StormSystem_ID"]!=null)
				{
					model.StormSystem_ID=row["StormSystem_ID"].ToString();
				}
				if(row["Exp_No"]!=null)
				{
					model.Exp_No=row["Exp_No"].ToString();
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
				if(row["Feature"]!=null)
				{
					model.Feature=row["Feature"].ToString();
				}
				if(row["Subsid"]!=null)
				{
					model.Subsid=row["Subsid"].ToString();
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["WellPipes"]!=null)
				{
					model.WellPipes=row["WellPipes"].ToString();
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
				if(row["WaterDeep"]!=null && row["WaterDeep"].ToString()!="")
				{
					model.WaterDeep=decimal.Parse(row["WaterDeep"].ToString());
				}
				if(row["MudDeep"]!=null && row["MudDeep"].ToString()!="")
				{
					model.MudDeep=decimal.Parse(row["MudDeep"].ToString());
				}
				if(row["Inlet_Type"]!=null)
				{
					model.Inlet_Type=row["Inlet_Type"].ToString();
				}
				if(row["OutfallType"]!=null)
				{
					model.OutfallType=row["OutfallType"].ToString();
				}
				if(row["ReceiveWater"]!=null)
				{
					model.ReceiveWater=row["ReceiveWater"].ToString();
				}
				if(row["Flap"]!=null)
				{
					model.Flap=row["Flap"].ToString();
				}
				if(row["Flap_Diameter"]!=null && row["Flap_Diameter"].ToString()!="")
				{
					model.Flap_Diameter=decimal.Parse(row["Flap_Diameter"].ToString());
				}
				if(row["Flap_TopEle"]!=null && row["Flap_TopEle"].ToString()!="")
				{
					model.Flap_TopEle=decimal.Parse(row["Flap_TopEle"].ToString());
				}
				if(row["Flap_BotEle"]!=null && row["Flap_BotEle"].ToString()!="")
				{
					model.Flap_BotEle=decimal.Parse(row["Flap_BotEle"].ToString());
				}
				if(row["Flap_Material"]!=null)
				{
					model.Flap_Material=row["Flap_Material"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["PointPosition"]!=null)
				{
					model.PointPosition=row["PointPosition"].ToString();
				}
				if(row["DataSource"]!=null)
				{
					model.DataSource=row["DataSource"].ToString();
				}
				if(row["Visibility"]!=null)
				{
					model.Visibility=row["Visibility"].ToString();
				}
				if(row["Sdate"]!=null)
				{
					model.Sdate=row["Sdate"].ToString();
				}
				if(row["Mdate"]!=null)
				{
					model.Mdate=row["Mdate"].ToString();
				}
				if(row["Manhole_Type"]!=null)
				{
					model.Manhole_Type=row["Manhole_Type"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["Note"]!=null)
				{
					model.Note=row["Note"].ToString();
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
			strSql.Append("select MapCode,StormSystem_ID,Exp_No,Type,X,Y,High,WellDeep,Offset,Feature,Subsid,Model,WellPipes,WellShape,WellSize,WellMaterial,WaterDeep,MudDeep,Inlet_Type,OutfallType,ReceiveWater,Flap,Flap_Diameter,Flap_TopEle,Flap_BotEle,Flap_Material,Address,PointPosition,DataSource,Visibility,Sdate,Mdate,Manhole_Type,status,Note ");
			strSql.Append(" FROM cjplp ");
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
			strSql.Append("select count(1) FROM cjplp ");
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
			strSql.Append(")AS Row, T.*  from cjplp T ");
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
			parameters[0].Value = "cjplp";
			parameters[1].Value = "Exp_No";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
	}
}


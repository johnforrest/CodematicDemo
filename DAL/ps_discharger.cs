using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ps_discharger
	/// </summary>
	public partial class ps_discharger
	{
		public ps_discharger()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Exp_No)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ps_discharger");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Exp_No;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.ps_discharger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ps_discharger(");
			strSql.Append("Prj_No,Prj_Name,Exp_No,Code,Address,Name,CodeID,Representative,Tel,Manager,Licence_ID,Licence_Issue_Date,Sort,Conn_ManholeID,Business,Process,Pollutant_Name,Treatment_Method,Treatment_Facilities,Treatment_Capacity,Water_Daily_Consumption,Water_Self_Supply_Daily,Water_Discharge_Quantity,Production_Waste_Quantity,Sanitary_Waste_Quantity,Temp,pH,SS,BOD5,CODcr,NH3_N,TN,TP,Sunit,Sdate,UpdateTime,Note,Exp_NoOri,filename,update)");
			strSql.Append(" values (");
			strSql.Append("@Prj_No,@Prj_Name,@Exp_No,@Code,@Address,@Name,@CodeID,@Representative,@Tel,@Manager,@Licence_ID,@Licence_Issue_Date,@Sort,@Conn_ManholeID,@Business,@Process,@Pollutant_Name,@Treatment_Method,@Treatment_Facilities,@Treatment_Capacity,@Water_Daily_Consumption,@Water_Self_Supply_Daily,@Water_Discharge_Quantity,@Production_Waste_Quantity,@Sanitary_Waste_Quantity,@Temp,@pH,@SS,@BOD5,@CODcr,@NH3_N,@TN,@TP,@Sunit,@Sdate,@UpdateTime,@Note,@Exp_NoOri,@filename,@update)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@CodeID", MySqlDbType.VarChar,255),
					new MySqlParameter("@Representative", MySqlDbType.VarChar,50),
					new MySqlParameter("@Tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@Manager", MySqlDbType.VarChar,50),
					new MySqlParameter("@Licence_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Licence_Issue_Date", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sort", MySqlDbType.VarChar,50),
					new MySqlParameter("@Conn_ManholeID", MySqlDbType.VarChar,10),
					new MySqlParameter("@Business", MySqlDbType.VarChar,100),
					new MySqlParameter("@Process", MySqlDbType.VarChar,255),
					new MySqlParameter("@Pollutant_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Treatment_Method", MySqlDbType.VarChar,200),
					new MySqlParameter("@Treatment_Facilities", MySqlDbType.VarChar,200),
					new MySqlParameter("@Treatment_Capacity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Daily_Consumption", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Self_Supply_Daily", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Discharge_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Production_Waste_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Sanitary_Waste_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Temp", MySqlDbType.Decimal,7),
					new MySqlParameter("@pH", MySqlDbType.Decimal,7),
					new MySqlParameter("@SS", MySqlDbType.Decimal,7),
					new MySqlParameter("@BOD5", MySqlDbType.Decimal,7),
					new MySqlParameter("@CODcr", MySqlDbType.Decimal,7),
					new MySqlParameter("@NH3_N", MySqlDbType.Decimal,7),
					new MySqlParameter("@TN", MySqlDbType.Decimal,7),
					new MySqlParameter("@TP", MySqlDbType.Decimal,7),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.Exp_No;
			parameters[3].Value = model.Code;
			parameters[4].Value = model.Address;
			parameters[5].Value = model.Name;
			parameters[6].Value = model.CodeID;
			parameters[7].Value = model.Representative;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.Manager;
			parameters[10].Value = model.Licence_ID;
			parameters[11].Value = model.Licence_Issue_Date;
			parameters[12].Value = model.Sort;
			parameters[13].Value = model.Conn_ManholeID;
			parameters[14].Value = model.Business;
			parameters[15].Value = model.Process;
			parameters[16].Value = model.Pollutant_Name;
			parameters[17].Value = model.Treatment_Method;
			parameters[18].Value = model.Treatment_Facilities;
			parameters[19].Value = model.Treatment_Capacity;
			parameters[20].Value = model.Water_Daily_Consumption;
			parameters[21].Value = model.Water_Self_Supply_Daily;
			parameters[22].Value = model.Water_Discharge_Quantity;
			parameters[23].Value = model.Production_Waste_Quantity;
			parameters[24].Value = model.Sanitary_Waste_Quantity;
			parameters[25].Value = model.Temp;
			parameters[26].Value = model.pH;
			parameters[27].Value = model.SS;
			parameters[28].Value = model.BOD5;
			parameters[29].Value = model.CODcr;
			parameters[30].Value = model.NH3_N;
			parameters[31].Value = model.TN;
			parameters[32].Value = model.TP;
			parameters[33].Value = model.Sunit;
			parameters[34].Value = model.Sdate;
			parameters[35].Value = model.UpdateTime;
			parameters[36].Value = model.Note;
			parameters[37].Value = model.Exp_NoOri;
			parameters[38].Value = model.filename;
			parameters[39].Value = model.update;

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
		public bool Update(Maticsoft.Model.ps_discharger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ps_discharger set ");
			strSql.Append("Prj_No=@Prj_No,");
			strSql.Append("Prj_Name=@Prj_Name,");
			strSql.Append("Code=@Code,");
			strSql.Append("Address=@Address,");
			strSql.Append("Name=@Name,");
			strSql.Append("CodeID=@CodeID,");
			strSql.Append("Representative=@Representative,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Manager=@Manager,");
			strSql.Append("Licence_ID=@Licence_ID,");
			strSql.Append("Licence_Issue_Date=@Licence_Issue_Date,");
			strSql.Append("Sort=@Sort,");
			strSql.Append("Conn_ManholeID=@Conn_ManholeID,");
			strSql.Append("Business=@Business,");
			strSql.Append("Process=@Process,");
			strSql.Append("Pollutant_Name=@Pollutant_Name,");
			strSql.Append("Treatment_Method=@Treatment_Method,");
			strSql.Append("Treatment_Facilities=@Treatment_Facilities,");
			strSql.Append("Treatment_Capacity=@Treatment_Capacity,");
			strSql.Append("Water_Daily_Consumption=@Water_Daily_Consumption,");
			strSql.Append("Water_Self_Supply_Daily=@Water_Self_Supply_Daily,");
			strSql.Append("Water_Discharge_Quantity=@Water_Discharge_Quantity,");
			strSql.Append("Production_Waste_Quantity=@Production_Waste_Quantity,");
			strSql.Append("Sanitary_Waste_Quantity=@Sanitary_Waste_Quantity,");
			strSql.Append("Temp=@Temp,");
			strSql.Append("pH=@pH,");
			strSql.Append("SS=@SS,");
			strSql.Append("BOD5=@BOD5,");
			strSql.Append("CODcr=@CODcr,");
			strSql.Append("NH3_N=@NH3_N,");
			strSql.Append("TN=@TN,");
			strSql.Append("TP=@TP,");
			strSql.Append("Sunit=@Sunit,");
			strSql.Append("Sdate=@Sdate,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("Note=@Note,");
			strSql.Append("Exp_NoOri=@Exp_NoOri,");
			strSql.Append("filename=@filename,");
			strSql.Append("update=@update");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@CodeID", MySqlDbType.VarChar,255),
					new MySqlParameter("@Representative", MySqlDbType.VarChar,50),
					new MySqlParameter("@Tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@Manager", MySqlDbType.VarChar,50),
					new MySqlParameter("@Licence_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Licence_Issue_Date", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sort", MySqlDbType.VarChar,50),
					new MySqlParameter("@Conn_ManholeID", MySqlDbType.VarChar,10),
					new MySqlParameter("@Business", MySqlDbType.VarChar,100),
					new MySqlParameter("@Process", MySqlDbType.VarChar,255),
					new MySqlParameter("@Pollutant_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Treatment_Method", MySqlDbType.VarChar,200),
					new MySqlParameter("@Treatment_Facilities", MySqlDbType.VarChar,200),
					new MySqlParameter("@Treatment_Capacity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Daily_Consumption", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Self_Supply_Daily", MySqlDbType.Decimal,7),
					new MySqlParameter("@Water_Discharge_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Production_Waste_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Sanitary_Waste_Quantity", MySqlDbType.Decimal,7),
					new MySqlParameter("@Temp", MySqlDbType.Decimal,7),
					new MySqlParameter("@pH", MySqlDbType.Decimal,7),
					new MySqlParameter("@SS", MySqlDbType.Decimal,7),
					new MySqlParameter("@BOD5", MySqlDbType.Decimal,7),
					new MySqlParameter("@CODcr", MySqlDbType.Decimal,7),
					new MySqlParameter("@NH3_N", MySqlDbType.Decimal,7),
					new MySqlParameter("@TN", MySqlDbType.Decimal,7),
					new MySqlParameter("@TP", MySqlDbType.Decimal,7),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.Code;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Name;
			parameters[5].Value = model.CodeID;
			parameters[6].Value = model.Representative;
			parameters[7].Value = model.Tel;
			parameters[8].Value = model.Manager;
			parameters[9].Value = model.Licence_ID;
			parameters[10].Value = model.Licence_Issue_Date;
			parameters[11].Value = model.Sort;
			parameters[12].Value = model.Conn_ManholeID;
			parameters[13].Value = model.Business;
			parameters[14].Value = model.Process;
			parameters[15].Value = model.Pollutant_Name;
			parameters[16].Value = model.Treatment_Method;
			parameters[17].Value = model.Treatment_Facilities;
			parameters[18].Value = model.Treatment_Capacity;
			parameters[19].Value = model.Water_Daily_Consumption;
			parameters[20].Value = model.Water_Self_Supply_Daily;
			parameters[21].Value = model.Water_Discharge_Quantity;
			parameters[22].Value = model.Production_Waste_Quantity;
			parameters[23].Value = model.Sanitary_Waste_Quantity;
			parameters[24].Value = model.Temp;
			parameters[25].Value = model.pH;
			parameters[26].Value = model.SS;
			parameters[27].Value = model.BOD5;
			parameters[28].Value = model.CODcr;
			parameters[29].Value = model.NH3_N;
			parameters[30].Value = model.TN;
			parameters[31].Value = model.TP;
			parameters[32].Value = model.Sunit;
			parameters[33].Value = model.Sdate;
			parameters[34].Value = model.UpdateTime;
			parameters[35].Value = model.Note;
			parameters[36].Value = model.Exp_NoOri;
			parameters[37].Value = model.filename;
			parameters[38].Value = model.update;
			parameters[39].Value = model.Exp_No;

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
			strSql.Append("delete from ps_discharger ");
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
			strSql.Append("delete from ps_discharger ");
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
		public Maticsoft.Model.ps_discharger GetModel(string Exp_No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Prj_No,Prj_Name,Exp_No,Code,Address,Name,CodeID,Representative,Tel,Manager,Licence_ID,Licence_Issue_Date,Sort,Conn_ManholeID,Business,Process,Pollutant_Name,Treatment_Method,Treatment_Facilities,Treatment_Capacity,Water_Daily_Consumption,Water_Self_Supply_Daily,Water_Discharge_Quantity,Production_Waste_Quantity,Sanitary_Waste_Quantity,Temp,pH,SS,BOD5,CODcr,NH3_N,TN,TP,Sunit,Sdate,UpdateTime,Note,Exp_NoOri,filename,update from ps_discharger ");
			strSql.Append(" where Exp_No=@Exp_No ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Exp_No;

			Maticsoft.Model.ps_discharger model=new Maticsoft.Model.ps_discharger();
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
		public Maticsoft.Model.ps_discharger DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ps_discharger model=new Maticsoft.Model.ps_discharger();
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
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["CodeID"]!=null)
				{
					model.CodeID=row["CodeID"].ToString();
				}
				if(row["Representative"]!=null)
				{
					model.Representative=row["Representative"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Manager"]!=null)
				{
					model.Manager=row["Manager"].ToString();
				}
				if(row["Licence_ID"]!=null)
				{
					model.Licence_ID=row["Licence_ID"].ToString();
				}
				if(row["Licence_Issue_Date"]!=null)
				{
					model.Licence_Issue_Date=row["Licence_Issue_Date"].ToString();
				}
				if(row["Sort"]!=null)
				{
					model.Sort=row["Sort"].ToString();
				}
				if(row["Conn_ManholeID"]!=null)
				{
					model.Conn_ManholeID=row["Conn_ManholeID"].ToString();
				}
				if(row["Business"]!=null)
				{
					model.Business=row["Business"].ToString();
				}
				if(row["Process"]!=null)
				{
					model.Process=row["Process"].ToString();
				}
				if(row["Pollutant_Name"]!=null)
				{
					model.Pollutant_Name=row["Pollutant_Name"].ToString();
				}
				if(row["Treatment_Method"]!=null)
				{
					model.Treatment_Method=row["Treatment_Method"].ToString();
				}
				if(row["Treatment_Facilities"]!=null)
				{
					model.Treatment_Facilities=row["Treatment_Facilities"].ToString();
				}
				if(row["Treatment_Capacity"]!=null && row["Treatment_Capacity"].ToString()!="")
				{
					model.Treatment_Capacity=decimal.Parse(row["Treatment_Capacity"].ToString());
				}
				if(row["Water_Daily_Consumption"]!=null && row["Water_Daily_Consumption"].ToString()!="")
				{
					model.Water_Daily_Consumption=decimal.Parse(row["Water_Daily_Consumption"].ToString());
				}
				if(row["Water_Self_Supply_Daily"]!=null && row["Water_Self_Supply_Daily"].ToString()!="")
				{
					model.Water_Self_Supply_Daily=decimal.Parse(row["Water_Self_Supply_Daily"].ToString());
				}
				if(row["Water_Discharge_Quantity"]!=null && row["Water_Discharge_Quantity"].ToString()!="")
				{
					model.Water_Discharge_Quantity=decimal.Parse(row["Water_Discharge_Quantity"].ToString());
				}
				if(row["Production_Waste_Quantity"]!=null && row["Production_Waste_Quantity"].ToString()!="")
				{
					model.Production_Waste_Quantity=decimal.Parse(row["Production_Waste_Quantity"].ToString());
				}
				if(row["Sanitary_Waste_Quantity"]!=null && row["Sanitary_Waste_Quantity"].ToString()!="")
				{
					model.Sanitary_Waste_Quantity=decimal.Parse(row["Sanitary_Waste_Quantity"].ToString());
				}
				if(row["Temp"]!=null && row["Temp"].ToString()!="")
				{
					model.Temp=decimal.Parse(row["Temp"].ToString());
				}
				if(row["pH"]!=null && row["pH"].ToString()!="")
				{
					model.pH=decimal.Parse(row["pH"].ToString());
				}
				if(row["SS"]!=null && row["SS"].ToString()!="")
				{
					model.SS=decimal.Parse(row["SS"].ToString());
				}
				if(row["BOD5"]!=null && row["BOD5"].ToString()!="")
				{
					model.BOD5=decimal.Parse(row["BOD5"].ToString());
				}
				if(row["CODcr"]!=null && row["CODcr"].ToString()!="")
				{
					model.CODcr=decimal.Parse(row["CODcr"].ToString());
				}
				if(row["NH3_N"]!=null && row["NH3_N"].ToString()!="")
				{
					model.NH3_N=decimal.Parse(row["NH3_N"].ToString());
				}
				if(row["TN"]!=null && row["TN"].ToString()!="")
				{
					model.TN=decimal.Parse(row["TN"].ToString());
				}
				if(row["TP"]!=null && row["TP"].ToString()!="")
				{
					model.TP=decimal.Parse(row["TP"].ToString());
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
			strSql.Append("select Prj_No,Prj_Name,Exp_No,Code,Address,Name,CodeID,Representative,Tel,Manager,Licence_ID,Licence_Issue_Date,Sort,Conn_ManholeID,Business,Process,Pollutant_Name,Treatment_Method,Treatment_Facilities,Treatment_Capacity,Water_Daily_Consumption,Water_Self_Supply_Daily,Water_Discharge_Quantity,Production_Waste_Quantity,Sanitary_Waste_Quantity,Temp,pH,SS,BOD5,CODcr,NH3_N,TN,TP,Sunit,Sdate,UpdateTime,Note,Exp_NoOri,filename,update ");
			strSql.Append(" FROM ps_discharger ");
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
			strSql.Append("select count(1) FROM ps_discharger ");
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
			strSql.Append(")AS Row, T.*  from ps_discharger T ");
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
			parameters[0].Value = "ps_discharger";
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


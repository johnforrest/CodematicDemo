﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:ps_retention
    /// </summary>
    public partial class ps_retention
    {
        public ps_retention()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Exp_No)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ps_retention");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)          };
            parameters[0].Value = Exp_No;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.ps_retention model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ps_retention(");
            strSql.Append("Prj_No,Prj_Name,Exp_No,MapCode,Name,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,Inflow_Type,Outflow_Type,Total_Vol,B_Level,Max_Level,Min_Level,Design_Time,Ps_Num,FlowDir,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime)");
            strSql.Append(" values (");
            strSql.Append("@Prj_No,@Prj_Name,@Exp_No,@MapCode,@Name,@SewageSystem_ID,@StormSystem_ID,@Type,@X,@Y,@High,@Inflow_Type,@Outflow_Type,@Total_Vol,@B_Level,@Max_Level,@Min_Level,@Design_Time,@Ps_Num,@FlowDir,@Code,@Address,@DataSource,@Sunit,@Sdate,@UpdateTime,@Mdate,@DataListID,@Status,@Ename,@Design_Dept,@Conster_Dept,@Belong,@Operator,@Note,@Exp_NoOri,@FileName,@Uploadtime)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
                    new MySqlParameter("@MapCode", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,4),
                    new MySqlParameter("@X", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Y", MySqlDbType.Decimal,10),
                    new MySqlParameter("@High", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Inflow_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Outflow_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Total_Vol", MySqlDbType.Decimal,7),
                    new MySqlParameter("@B_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Max_Level", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Min_Level", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Design_Time", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Ps_Num", MySqlDbType.VarChar,10),
                    new MySqlParameter("@FlowDir", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Code", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Address", MySqlDbType.VarChar,100),
                    new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
                    new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
                    new MySqlParameter("@DataListID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Status", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Note", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FileName", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Uploadtime", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.Prj_No;
            parameters[1].Value = model.Prj_Name;
            parameters[2].Value = model.Exp_No;
            parameters[3].Value = model.MapCode;
            parameters[4].Value = model.Name;
            parameters[5].Value = model.SewageSystem_ID;
            parameters[6].Value = model.StormSystem_ID;
            parameters[7].Value = model.Type;
            parameters[8].Value = model.X;
            parameters[9].Value = model.Y;
            parameters[10].Value = model.High;
            parameters[11].Value = model.Inflow_Type;
            parameters[12].Value = model.Outflow_Type;
            parameters[13].Value = model.Total_Vol;
            parameters[14].Value = model.B_Level;
            parameters[15].Value = model.Max_Level;
            parameters[16].Value = model.Min_Level;
            parameters[17].Value = model.Design_Time;
            parameters[18].Value = model.Ps_Num;
            parameters[19].Value = model.FlowDir;
            parameters[20].Value = model.Code;
            parameters[21].Value = model.Address;
            parameters[22].Value = model.DataSource;
            parameters[23].Value = model.Sunit;
            parameters[24].Value = model.Sdate;
            parameters[25].Value = model.UpdateTime;
            parameters[26].Value = model.Mdate;
            parameters[27].Value = model.DataListID;
            parameters[28].Value = model.Status;
            parameters[29].Value = model.Ename;
            parameters[30].Value = model.Design_Dept;
            parameters[31].Value = model.Conster_Dept;
            parameters[32].Value = model.Belong;
            parameters[33].Value = model.Operator;
            parameters[34].Value = model.Note;
            parameters[35].Value = model.Exp_NoOri;
            parameters[36].Value = model.FileName;
            parameters[37].Value = model.Uploadtime;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Maticsoft.Model.ps_retention model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ps_retention set ");
            strSql.Append("Prj_No=@Prj_No,");
            strSql.Append("Prj_Name=@Prj_Name,");
            strSql.Append("MapCode=@MapCode,");
            strSql.Append("Name=@Name,");
            strSql.Append("SewageSystem_ID=@SewageSystem_ID,");
            strSql.Append("StormSystem_ID=@StormSystem_ID,");
            strSql.Append("Type=@Type,");
            strSql.Append("X=@X,");
            strSql.Append("Y=@Y,");
            strSql.Append("High=@High,");
            strSql.Append("Inflow_Type=@Inflow_Type,");
            strSql.Append("Outflow_Type=@Outflow_Type,");
            strSql.Append("Total_Vol=@Total_Vol,");
            strSql.Append("B_Level=@B_Level,");
            strSql.Append("Max_Level=@Max_Level,");
            strSql.Append("Min_Level=@Min_Level,");
            strSql.Append("Design_Time=@Design_Time,");
            strSql.Append("Ps_Num=@Ps_Num,");
            strSql.Append("FlowDir=@FlowDir,");
            strSql.Append("Code=@Code,");
            strSql.Append("Address=@Address,");
            strSql.Append("DataSource=@DataSource,");
            strSql.Append("Sunit=@Sunit,");
            strSql.Append("Sdate=@Sdate,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("Mdate=@Mdate,");
            strSql.Append("DataListID=@DataListID,");
            strSql.Append("Status=@Status,");
            strSql.Append("Ename=@Ename,");
            strSql.Append("Design_Dept=@Design_Dept,");
            strSql.Append("Conster_Dept=@Conster_Dept,");
            strSql.Append("Belong=@Belong,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("Note=@Note,");
            strSql.Append("Exp_NoOri=@Exp_NoOri,");
            strSql.Append("FileName=@FileName,");
            strSql.Append("Uploadtime=@Uploadtime");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@MapCode", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,4),
                    new MySqlParameter("@X", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Y", MySqlDbType.Decimal,10),
                    new MySqlParameter("@High", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Inflow_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Outflow_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Total_Vol", MySqlDbType.Decimal,7),
                    new MySqlParameter("@B_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Max_Level", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Min_Level", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Design_Time", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Ps_Num", MySqlDbType.VarChar,10),
                    new MySqlParameter("@FlowDir", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Code", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Address", MySqlDbType.VarChar,100),
                    new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
                    new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
                    new MySqlParameter("@DataListID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Status", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Note", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_NoOri", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FileName", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Uploadtime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)};
            parameters[0].Value = model.Prj_No;
            parameters[1].Value = model.Prj_Name;
            parameters[2].Value = model.MapCode;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.SewageSystem_ID;
            parameters[5].Value = model.StormSystem_ID;
            parameters[6].Value = model.Type;
            parameters[7].Value = model.X;
            parameters[8].Value = model.Y;
            parameters[9].Value = model.High;
            parameters[10].Value = model.Inflow_Type;
            parameters[11].Value = model.Outflow_Type;
            parameters[12].Value = model.Total_Vol;
            parameters[13].Value = model.B_Level;
            parameters[14].Value = model.Max_Level;
            parameters[15].Value = model.Min_Level;
            parameters[16].Value = model.Design_Time;
            parameters[17].Value = model.Ps_Num;
            parameters[18].Value = model.FlowDir;
            parameters[19].Value = model.Code;
            parameters[20].Value = model.Address;
            parameters[21].Value = model.DataSource;
            parameters[22].Value = model.Sunit;
            parameters[23].Value = model.Sdate;
            parameters[24].Value = model.UpdateTime;
            parameters[25].Value = model.Mdate;
            parameters[26].Value = model.DataListID;
            parameters[27].Value = model.Status;
            parameters[28].Value = model.Ename;
            parameters[29].Value = model.Design_Dept;
            parameters[30].Value = model.Conster_Dept;
            parameters[31].Value = model.Belong;
            parameters[32].Value = model.Operator;
            parameters[33].Value = model.Note;
            parameters[34].Value = model.Exp_NoOri;
            parameters[35].Value = model.FileName;
            parameters[36].Value = model.Uploadtime;
            parameters[37].Value = model.Exp_No;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ps_retention ");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)          };
            parameters[0].Value = Exp_No;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Exp_Nolist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ps_retention ");
            strSql.Append(" where Exp_No in (" + Exp_Nolist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public Maticsoft.Model.ps_retention GetModel(string Exp_No)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,Name,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,Inflow_Type,Outflow_Type,Total_Vol,B_Level,Max_Level,Min_Level,Design_Time,Ps_Num,FlowDir,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime from ps_retention ");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)          };
            parameters[0].Value = Exp_No;

            Maticsoft.Model.ps_retention model = new Maticsoft.Model.ps_retention();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public Maticsoft.Model.ps_retention DataRowToModel(DataRow row)
        {
            Maticsoft.Model.ps_retention model = new Maticsoft.Model.ps_retention();
            if (row != null)
            {
                if (row["Prj_No"] != null)
                {
                    model.Prj_No = row["Prj_No"].ToString();
                }
                if (row["Prj_Name"] != null)
                {
                    model.Prj_Name = row["Prj_Name"].ToString();
                }
                if (row["Exp_No"] != null)
                {
                    model.Exp_No = row["Exp_No"].ToString();
                }
                if (row["MapCode"] != null)
                {
                    model.MapCode = row["MapCode"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["SewageSystem_ID"] != null)
                {
                    model.SewageSystem_ID = row["SewageSystem_ID"].ToString();
                }
                if (row["StormSystem_ID"] != null)
                {
                    model.StormSystem_ID = row["StormSystem_ID"].ToString();
                }
                if (row["Type"] != null)
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["X"] != null && row["X"].ToString() != "")
                {
                    model.X = decimal.Parse(row["X"].ToString());
                }
                if (row["Y"] != null && row["Y"].ToString() != "")
                {
                    model.Y = decimal.Parse(row["Y"].ToString());
                }
                if (row["High"] != null && row["High"].ToString() != "")
                {
                    model.High = decimal.Parse(row["High"].ToString());
                }
                if (row["Inflow_Type"] != null)
                {
                    model.Inflow_Type = row["Inflow_Type"].ToString();
                }
                if (row["Outflow_Type"] != null)
                {
                    model.Outflow_Type = row["Outflow_Type"].ToString();
                }
                if (row["Total_Vol"] != null && row["Total_Vol"].ToString() != "")
                {
                    model.Total_Vol = decimal.Parse(row["Total_Vol"].ToString());
                }
                if (row["B_Level"] != null && row["B_Level"].ToString() != "")
                {
                    model.B_Level = decimal.Parse(row["B_Level"].ToString());
                }
                if (row["Max_Level"] != null && row["Max_Level"].ToString() != "")
                {
                    model.Max_Level = decimal.Parse(row["Max_Level"].ToString());
                }
                if (row["Min_Level"] != null && row["Min_Level"].ToString() != "")
                {
                    model.Min_Level = decimal.Parse(row["Min_Level"].ToString());
                }
                if (row["Design_Time"] != null && row["Design_Time"].ToString() != "")
                {
                    model.Design_Time = decimal.Parse(row["Design_Time"].ToString());
                }
                if (row["Ps_Num"] != null)
                {
                    model.Ps_Num = row["Ps_Num"].ToString();
                }
                if (row["FlowDir"] != null)
                {
                    model.FlowDir = row["FlowDir"].ToString();
                }
                if (row["Code"] != null)
                {
                    model.Code = row["Code"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["DataSource"] != null)
                {
                    model.DataSource = row["DataSource"].ToString();
                }
                if (row["Sunit"] != null)
                {
                    model.Sunit = row["Sunit"].ToString();
                }
                if (row["Sdate"] != null)
                {
                    model.Sdate = row["Sdate"].ToString();
                }
                if (row["UpdateTime"] != null)
                {
                    model.UpdateTime = row["UpdateTime"].ToString();
                }
                if (row["Mdate"] != null)
                {
                    model.Mdate = row["Mdate"].ToString();
                }
                if (row["DataListID"] != null)
                {
                    model.DataListID = row["DataListID"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
                }
                if (row["Ename"] != null)
                {
                    model.Ename = row["Ename"].ToString();
                }
                if (row["Design_Dept"] != null)
                {
                    model.Design_Dept = row["Design_Dept"].ToString();
                }
                if (row["Conster_Dept"] != null)
                {
                    model.Conster_Dept = row["Conster_Dept"].ToString();
                }
                if (row["Belong"] != null)
                {
                    model.Belong = row["Belong"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["Note"] != null)
                {
                    model.Note = row["Note"].ToString();
                }
                if (row["Exp_NoOri"] != null)
                {
                    model.Exp_NoOri = row["Exp_NoOri"].ToString();
                }
                if (row["FileName"] != null)
                {
                    model.FileName = row["FileName"].ToString();
                }
                if (row["Uploadtime"] != null)
                {
                    model.Uploadtime = row["Uploadtime"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,Name,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,Inflow_Type,Outflow_Type,Total_Vol,B_Level,Max_Level,Min_Level,Design_Time,Ps_Num,FlowDir,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime ");
            strSql.Append(" FROM ps_retention ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ps_retention ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Exp_No desc");
            }
            strSql.Append(")AS Row, T.*  from ps_retention T ");
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
			parameters[0].Value = "ps_retention";
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


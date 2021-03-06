﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:cjpllback
    /// </summary>
    public partial class cjpllback
    {
        public cjpllback()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Exp_No0, string Exp_No1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from cjpllback");
            strSql.Append(" where Exp_No0=@Exp_No0 and Exp_No1=@Exp_No1 ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,150),
                    new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,150)         };
            parameters[0].Value = Exp_No0;
            parameters[1].Value = Exp_No1;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.cjpllback model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into cjpllback(");
            strSql.Append("StormSystem_ID,Exp_No0,S_Deep,S_Elev,Exp_No1,E_Deep,E_Elev,Type,Pressure_Type,Invert_Silphon,Material,ShapeType,Grade,Psize,FlowDir,ConduitStyle,Address,DataSource,Sdate,Mdate,Pipe_Type,Status,Note,FileName,Uploadtime,Lno,S_Point,E_Point,LnoTime,PipeLength)");
            strSql.Append(" values (");
            strSql.Append("@StormSystem_ID,@Exp_No0,@S_Deep,@S_Elev,@Exp_No1,@E_Deep,@E_Elev,@Type,@Pressure_Type,@Invert_Silphon,@Material,@ShapeType,@Grade,@Psize,@FlowDir,@ConduitStyle,@Address,@DataSource,@Sdate,@Mdate,@Pipe_Type,@Status,@Note,@FileName,@Uploadtime,@Lno,@S_Point,@E_Point,@LnoTime,@PipeLength)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,150),
                    new MySqlParameter("@S_Deep", MySqlDbType.Decimal,10),
                    new MySqlParameter("@S_Elev", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,150),
                    new MySqlParameter("@E_Deep", MySqlDbType.Decimal,10),
                    new MySqlParameter("@E_Elev", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Pressure_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Invert_Silphon", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Material", MySqlDbType.VarChar,100),
                    new MySqlParameter("@ShapeType", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Grade", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Psize", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FlowDir", MySqlDbType.VarChar,10),
                    new MySqlParameter("@ConduitStyle", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Address", MySqlDbType.VarChar,255),
                    new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Sdate", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Mdate", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Pipe_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Status", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Note", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FileName", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Uploadtime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Lno", MySqlDbType.VarChar,255),
                    new MySqlParameter("@S_Point", MySqlDbType.VarChar,255),
                    new MySqlParameter("@E_Point", MySqlDbType.VarChar,255),
                    new MySqlParameter("@LnoTime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@PipeLength", MySqlDbType.Decimal,7)};
            parameters[0].Value = model.StormSystem_ID;
            parameters[1].Value = model.Exp_No0;
            parameters[2].Value = model.S_Deep;
            parameters[3].Value = model.S_Elev;
            parameters[4].Value = model.Exp_No1;
            parameters[5].Value = model.E_Deep;
            parameters[6].Value = model.E_Elev;
            parameters[7].Value = model.Type;
            parameters[8].Value = model.Pressure_Type;
            parameters[9].Value = model.Invert_Silphon;
            parameters[10].Value = model.Material;
            parameters[11].Value = model.ShapeType;
            parameters[12].Value = model.Grade;
            parameters[13].Value = model.Psize;
            parameters[14].Value = model.FlowDir;
            parameters[15].Value = model.ConduitStyle;
            parameters[16].Value = model.Address;
            parameters[17].Value = model.DataSource;
            parameters[18].Value = model.Sdate;
            parameters[19].Value = model.Mdate;
            parameters[20].Value = model.Pipe_Type;
            parameters[21].Value = model.Status;
            parameters[22].Value = model.Note;
            parameters[23].Value = model.FileName;
            parameters[24].Value = model.Uploadtime;
            parameters[25].Value = model.Lno;
            parameters[26].Value = model.S_Point;
            parameters[27].Value = model.E_Point;
            parameters[28].Value = model.LnoTime;
            parameters[29].Value = model.PipeLength;

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
        public bool Update(Maticsoft.Model.cjpllback model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update cjpllback set ");
            strSql.Append("StormSystem_ID=@StormSystem_ID,");
            strSql.Append("S_Deep=@S_Deep,");
            strSql.Append("S_Elev=@S_Elev,");
            strSql.Append("E_Deep=@E_Deep,");
            strSql.Append("E_Elev=@E_Elev,");
            strSql.Append("Type=@Type,");
            strSql.Append("Pressure_Type=@Pressure_Type,");
            strSql.Append("Invert_Silphon=@Invert_Silphon,");
            strSql.Append("Material=@Material,");
            strSql.Append("ShapeType=@ShapeType,");
            strSql.Append("Grade=@Grade,");
            strSql.Append("Psize=@Psize,");
            strSql.Append("FlowDir=@FlowDir,");
            strSql.Append("ConduitStyle=@ConduitStyle,");
            strSql.Append("Address=@Address,");
            strSql.Append("DataSource=@DataSource,");
            strSql.Append("Sdate=@Sdate,");
            strSql.Append("Mdate=@Mdate,");
            strSql.Append("Pipe_Type=@Pipe_Type,");
            strSql.Append("Status=@Status,");
            strSql.Append("Note=@Note,");
            strSql.Append("FileName=@FileName,");
            strSql.Append("Uploadtime=@Uploadtime,");
            strSql.Append("Lno=@Lno,");
            strSql.Append("S_Point=@S_Point,");
            strSql.Append("E_Point=@E_Point,");
            strSql.Append("LnoTime=@LnoTime,");
            strSql.Append("PipeLength=@PipeLength");
            strSql.Append(" where Exp_No0=@Exp_No0 and Exp_No1=@Exp_No1 ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,255),
                    new MySqlParameter("@S_Deep", MySqlDbType.Decimal,10),
                    new MySqlParameter("@S_Elev", MySqlDbType.Decimal,10),
                    new MySqlParameter("@E_Deep", MySqlDbType.Decimal,10),
                    new MySqlParameter("@E_Elev", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Pressure_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Invert_Silphon", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Material", MySqlDbType.VarChar,100),
                    new MySqlParameter("@ShapeType", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Grade", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Psize", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FlowDir", MySqlDbType.VarChar,10),
                    new MySqlParameter("@ConduitStyle", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Address", MySqlDbType.VarChar,255),
                    new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Sdate", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Mdate", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Pipe_Type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Status", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Note", MySqlDbType.VarChar,255),
                    new MySqlParameter("@FileName", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Uploadtime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Lno", MySqlDbType.VarChar,255),
                    new MySqlParameter("@S_Point", MySqlDbType.VarChar,255),
                    new MySqlParameter("@E_Point", MySqlDbType.VarChar,255),
                    new MySqlParameter("@LnoTime", MySqlDbType.VarChar,255),
                    new MySqlParameter("@PipeLength", MySqlDbType.Decimal,7),
                    new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,150),
                    new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,150)};
            parameters[0].Value = model.StormSystem_ID;
            parameters[1].Value = model.S_Deep;
            parameters[2].Value = model.S_Elev;
            parameters[3].Value = model.E_Deep;
            parameters[4].Value = model.E_Elev;
            parameters[5].Value = model.Type;
            parameters[6].Value = model.Pressure_Type;
            parameters[7].Value = model.Invert_Silphon;
            parameters[8].Value = model.Material;
            parameters[9].Value = model.ShapeType;
            parameters[10].Value = model.Grade;
            parameters[11].Value = model.Psize;
            parameters[12].Value = model.FlowDir;
            parameters[13].Value = model.ConduitStyle;
            parameters[14].Value = model.Address;
            parameters[15].Value = model.DataSource;
            parameters[16].Value = model.Sdate;
            parameters[17].Value = model.Mdate;
            parameters[18].Value = model.Pipe_Type;
            parameters[19].Value = model.Status;
            parameters[20].Value = model.Note;
            parameters[21].Value = model.FileName;
            parameters[22].Value = model.Uploadtime;
            parameters[23].Value = model.Lno;
            parameters[24].Value = model.S_Point;
            parameters[25].Value = model.E_Point;
            parameters[26].Value = model.LnoTime;
            parameters[27].Value = model.PipeLength;
            parameters[28].Value = model.Exp_No0;
            parameters[29].Value = model.Exp_No1;

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
        public bool Delete(string Exp_No0, string Exp_No1)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from cjpllback ");
            strSql.Append(" where Exp_No0=@Exp_No0 and Exp_No1=@Exp_No1 ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,150),
                    new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,150)         };
            parameters[0].Value = Exp_No0;
            parameters[1].Value = Exp_No1;

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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.cjpllback GetModel(string Exp_No0, string Exp_No1)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select StormSystem_ID,Exp_No0,S_Deep,S_Elev,Exp_No1,E_Deep,E_Elev,Type,Pressure_Type,Invert_Silphon,Material,ShapeType,Grade,Psize,FlowDir,ConduitStyle,Address,DataSource,Sdate,Mdate,Pipe_Type,Status,Note,FileName,Uploadtime,Lno,S_Point,E_Point,LnoTime,PipeLength from cjpllback ");
            strSql.Append(" where Exp_No0=@Exp_No0 and Exp_No1=@Exp_No1 ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,150),
                    new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,150)         };
            parameters[0].Value = Exp_No0;
            parameters[1].Value = Exp_No1;

            Maticsoft.Model.cjpllback model = new Maticsoft.Model.cjpllback();
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
        public Maticsoft.Model.cjpllback DataRowToModel(DataRow row)
        {
            Maticsoft.Model.cjpllback model = new Maticsoft.Model.cjpllback();
            if (row != null)
            {
                if (row["StormSystem_ID"] != null)
                {
                    model.StormSystem_ID = row["StormSystem_ID"].ToString();
                }
                if (row["Exp_No0"] != null)
                {
                    model.Exp_No0 = row["Exp_No0"].ToString();
                }
                if (row["S_Deep"] != null && row["S_Deep"].ToString() != "")
                {
                    model.S_Deep = decimal.Parse(row["S_Deep"].ToString());
                }
                if (row["S_Elev"] != null && row["S_Elev"].ToString() != "")
                {
                    model.S_Elev = decimal.Parse(row["S_Elev"].ToString());
                }
                if (row["Exp_No1"] != null)
                {
                    model.Exp_No1 = row["Exp_No1"].ToString();
                }
                if (row["E_Deep"] != null && row["E_Deep"].ToString() != "")
                {
                    model.E_Deep = decimal.Parse(row["E_Deep"].ToString());
                }
                if (row["E_Elev"] != null && row["E_Elev"].ToString() != "")
                {
                    model.E_Elev = decimal.Parse(row["E_Elev"].ToString());
                }
                if (row["Type"] != null)
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["Pressure_Type"] != null)
                {
                    model.Pressure_Type = row["Pressure_Type"].ToString();
                }
                if (row["Invert_Silphon"] != null)
                {
                    model.Invert_Silphon = row["Invert_Silphon"].ToString();
                }
                if (row["Material"] != null)
                {
                    model.Material = row["Material"].ToString();
                }
                if (row["ShapeType"] != null)
                {
                    model.ShapeType = row["ShapeType"].ToString();
                }
                if (row["Grade"] != null)
                {
                    model.Grade = row["Grade"].ToString();
                }
                if (row["Psize"] != null)
                {
                    model.Psize = row["Psize"].ToString();
                }
                if (row["FlowDir"] != null)
                {
                    model.FlowDir = row["FlowDir"].ToString();
                }
                if (row["ConduitStyle"] != null)
                {
                    model.ConduitStyle = row["ConduitStyle"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["DataSource"] != null)
                {
                    model.DataSource = row["DataSource"].ToString();
                }
                if (row["Sdate"] != null)
                {
                    model.Sdate = row["Sdate"].ToString();
                }
                if (row["Mdate"] != null)
                {
                    model.Mdate = row["Mdate"].ToString();
                }
                if (row["Pipe_Type"] != null)
                {
                    model.Pipe_Type = row["Pipe_Type"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
                }
                if (row["Note"] != null)
                {
                    model.Note = row["Note"].ToString();
                }
                if (row["FileName"] != null)
                {
                    model.FileName = row["FileName"].ToString();
                }
                if (row["Uploadtime"] != null)
                {
                    model.Uploadtime = row["Uploadtime"].ToString();
                }
                if (row["Lno"] != null)
                {
                    model.Lno = row["Lno"].ToString();
                }
                if (row["S_Point"] != null)
                {
                    model.S_Point = row["S_Point"].ToString();
                }
                if (row["E_Point"] != null)
                {
                    model.E_Point = row["E_Point"].ToString();
                }
                if (row["LnoTime"] != null)
                {
                    model.LnoTime = row["LnoTime"].ToString();
                }
                if (row["PipeLength"] != null && row["PipeLength"].ToString() != "")
                {
                    model.PipeLength = decimal.Parse(row["PipeLength"].ToString());
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
            strSql.Append("select StormSystem_ID,Exp_No0,S_Deep,S_Elev,Exp_No1,E_Deep,E_Elev,Type,Pressure_Type,Invert_Silphon,Material,ShapeType,Grade,Psize,FlowDir,ConduitStyle,Address,DataSource,Sdate,Mdate,Pipe_Type,Status,Note,FileName,Uploadtime,Lno,S_Point,E_Point,LnoTime,PipeLength ");
            strSql.Append(" FROM cjpllback ");
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
            strSql.Append("select count(1) FROM cjpllback ");
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
                strSql.Append("order by T.Exp_No1 desc");
            }
            strSql.Append(")AS Row, T.*  from cjpllback T ");
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
			parameters[0].Value = "cjpllback";
			parameters[1].Value = "Exp_No1";
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


using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:recordtable
    /// </summary>
    public partial class recordtable
    {
        public recordtable()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from recordtable");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@id", MySqlDbType.Int32)
            };
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.recordtable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into recordtable(");
            strSql.Append("type,year,strnolast5,inteno,serino,typeYear,typeYearStrnolast5,typeYearStrnolast5Inteno,inteserino,Exp_No,Lno)");
            strSql.Append(" values (");
            strSql.Append("@type,@year,@strnolast5,@inteno,@serino,@typeYear,@typeYearStrnolast5,@typeYearStrnolast5Inteno,@inteserino,@Exp_No,@Lno)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@year", MySqlDbType.VarChar,10),
                    new MySqlParameter("@strnolast5", MySqlDbType.VarChar,10),
                    new MySqlParameter("@inteno", MySqlDbType.Int32,11),
                    new MySqlParameter("@serino", MySqlDbType.Int32,11),
                    new MySqlParameter("@typeYear", MySqlDbType.VarChar,20),
                    new MySqlParameter("@typeYearStrnolast5", MySqlDbType.VarChar,30),
                    new MySqlParameter("@typeYearStrnolast5Inteno", MySqlDbType.VarChar,40),
                    new MySqlParameter("@inteserino", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Lno", MySqlDbType.VarChar,150)};
            parameters[0].Value = model.type;
            parameters[1].Value = model.year;
            parameters[2].Value = model.strnolast5;
            parameters[3].Value = model.inteno;
            parameters[4].Value = model.serino;
            parameters[5].Value = model.typeYear;
            parameters[6].Value = model.typeYearStrnolast5;
            parameters[7].Value = model.typeYearStrnolast5Inteno;
            parameters[8].Value = model.inteserino;
            parameters[9].Value = model.Exp_No;
            parameters[10].Value = model.Lno;

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
        public bool Update(Maticsoft.Model.recordtable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update recordtable set ");
            strSql.Append("type=@type,");
            strSql.Append("year=@year,");
            strSql.Append("strnolast5=@strnolast5,");
            strSql.Append("inteno=@inteno,");
            strSql.Append("serino=@serino,");
            strSql.Append("typeYear=@typeYear,");
            strSql.Append("typeYearStrnolast5=@typeYearStrnolast5,");
            strSql.Append("typeYearStrnolast5Inteno=@typeYearStrnolast5Inteno,");
            strSql.Append("inteserino=@inteserino,");
            strSql.Append("Exp_No=@Exp_No,");
            strSql.Append("Lno=@Lno");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@type", MySqlDbType.VarChar,10),
                    new MySqlParameter("@year", MySqlDbType.VarChar,10),
                    new MySqlParameter("@strnolast5", MySqlDbType.VarChar,10),
                    new MySqlParameter("@inteno", MySqlDbType.Int32,11),
                    new MySqlParameter("@serino", MySqlDbType.Int32,11),
                    new MySqlParameter("@typeYear", MySqlDbType.VarChar,20),
                    new MySqlParameter("@typeYearStrnolast5", MySqlDbType.VarChar,30),
                    new MySqlParameter("@typeYearStrnolast5Inteno", MySqlDbType.VarChar,40),
                    new MySqlParameter("@inteserino", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Lno", MySqlDbType.VarChar,150),
                    new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.type;
            parameters[1].Value = model.year;
            parameters[2].Value = model.strnolast5;
            parameters[3].Value = model.inteno;
            parameters[4].Value = model.serino;
            parameters[5].Value = model.typeYear;
            parameters[6].Value = model.typeYearStrnolast5;
            parameters[7].Value = model.typeYearStrnolast5Inteno;
            parameters[8].Value = model.inteserino;
            parameters[9].Value = model.Exp_No;
            parameters[10].Value = model.Lno;
            parameters[11].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from recordtable ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@id", MySqlDbType.Int32)
            };
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from recordtable ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public Maticsoft.Model.recordtable GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,type,year,strnolast5,inteno,serino,typeYear,typeYearStrnolast5,typeYearStrnolast5Inteno,inteserino,Exp_No,Lno from recordtable ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@id", MySqlDbType.Int32)
            };
            parameters[0].Value = id;

            Maticsoft.Model.recordtable model = new Maticsoft.Model.recordtable();
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
        public Maticsoft.Model.recordtable DataRowToModel(DataRow row)
        {
            Maticsoft.Model.recordtable model = new Maticsoft.Model.recordtable();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["type"] != null)
                {
                    model.type = row["type"].ToString();
                }
                if (row["year"] != null)
                {
                    model.year = row["year"].ToString();
                }
                if (row["strnolast5"] != null)
                {
                    model.strnolast5 = row["strnolast5"].ToString();
                }
                if (row["inteno"] != null && row["inteno"].ToString() != "")
                {
                    model.inteno = int.Parse(row["inteno"].ToString());
                }
                if (row["serino"] != null && row["serino"].ToString() != "")
                {
                    model.serino = int.Parse(row["serino"].ToString());
                }
                if (row["typeYear"] != null)
                {
                    model.typeYear = row["typeYear"].ToString();
                }
                if (row["typeYearStrnolast5"] != null)
                {
                    model.typeYearStrnolast5 = row["typeYearStrnolast5"].ToString();
                }
                if (row["typeYearStrnolast5Inteno"] != null)
                {
                    model.typeYearStrnolast5Inteno = row["typeYearStrnolast5Inteno"].ToString();
                }
                if (row["inteserino"] != null)
                {
                    model.inteserino = row["inteserino"].ToString();
                }
                if (row["Exp_No"] != null)
                {
                    model.Exp_No = row["Exp_No"].ToString();
                }
                if (row["Lno"] != null)
                {
                    model.Lno = row["Lno"].ToString();
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
            strSql.Append("select id,type,year,strnolast5,inteno,serino,typeYear,typeYearStrnolast5,typeYearStrnolast5Inteno,inteserino,Exp_No,Lno ");
            strSql.Append(" FROM recordtable ");
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
            strSql.Append("select count(1) FROM recordtable ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from recordtable T ");
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
			parameters[0].Value = "recordtable";
			parameters[1].Value = "id";
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


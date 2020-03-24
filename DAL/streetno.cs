using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:streetno
    /// </summary>
    public partial class streetno
    {
        public streetno()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("number", "streetno");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int number)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from streetno");
            strSql.Append(" where number=@number ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@number", MySqlDbType.Int32,11)         };
            parameters[0].Value = number;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.streetno model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into streetno(");
            strSql.Append("number,strname,strno,strnolast5,shortname)");
            strSql.Append(" values (");
            strSql.Append("@number,@strname,@strno,@strnolast5,@shortname)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@number", MySqlDbType.Int32,11),
                    new MySqlParameter("@strname", MySqlDbType.VarChar,255),
                    new MySqlParameter("@strno", MySqlDbType.VarChar,10),
                    new MySqlParameter("@strnolast5", MySqlDbType.VarChar,210),
                    new MySqlParameter("@shortname", MySqlDbType.VarChar,100)};
            parameters[0].Value = model.number;
            parameters[1].Value = model.strname;
            parameters[2].Value = model.strno;
            parameters[3].Value = model.strnolast5;
            parameters[4].Value = model.shortname;

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
        public bool Update(Maticsoft.Model.streetno model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update streetno set ");
            strSql.Append("strname=@strname,");
            strSql.Append("strno=@strno,");
            strSql.Append("strnolast5=@strnolast5,");
            strSql.Append("shortname=@shortname");
            strSql.Append(" where number=@number ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@strname", MySqlDbType.VarChar,255),
                    new MySqlParameter("@strno", MySqlDbType.VarChar,10),
                    new MySqlParameter("@strnolast5", MySqlDbType.VarChar,210),
                    new MySqlParameter("@shortname", MySqlDbType.VarChar,100),
                    new MySqlParameter("@number", MySqlDbType.Int32,11)};
            parameters[0].Value = model.strname;
            parameters[1].Value = model.strno;
            parameters[2].Value = model.strnolast5;
            parameters[3].Value = model.shortname;
            parameters[4].Value = model.number;

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
        public bool Delete(int number)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from streetno ");
            strSql.Append(" where number=@number ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@number", MySqlDbType.Int32,11)         };
            parameters[0].Value = number;

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
        public bool DeleteList(string numberlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from streetno ");
            strSql.Append(" where number in (" + numberlist + ")  ");
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
        public Maticsoft.Model.streetno GetModel(int number)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select number,strname,strno,strnolast5,shortname from streetno ");
            strSql.Append(" where number=@number ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@number", MySqlDbType.Int32,11)         };
            parameters[0].Value = number;

            Maticsoft.Model.streetno model = new Maticsoft.Model.streetno();
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
        public Maticsoft.Model.streetno DataRowToModel(DataRow row)
        {
            Maticsoft.Model.streetno model = new Maticsoft.Model.streetno();
            if (row != null)
            {
                if (row["number"] != null && row["number"].ToString() != "")
                {
                    model.number = int.Parse(row["number"].ToString());
                }
                if (row["strname"] != null)
                {
                    model.strname = row["strname"].ToString();
                }
                if (row["strno"] != null)
                {
                    model.strno = row["strno"].ToString();
                }
                if (row["strnolast5"] != null)
                {
                    model.strnolast5 = row["strnolast5"].ToString();
                }
                if (row["shortname"] != null)
                {
                    model.shortname = row["shortname"].ToString();
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
            strSql.Append("select number,strname,strno,strnolast5,shortname ");
            strSql.Append(" FROM streetno ");
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
            strSql.Append("select count(1) FROM streetno ");
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
                strSql.Append("order by T.number desc");
            }
            strSql.Append(")AS Row, T.*  from streetno T ");
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
			parameters[0].Value = "streetno";
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


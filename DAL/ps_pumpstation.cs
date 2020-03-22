using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:ps_pumpstation
    /// </summary>
    public partial class ps_pumpstation
    {
        public ps_pumpstation()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Exp_No)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ps_pumpstation");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)          };
            parameters[0].Value = Exp_No;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.ps_pumpstation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ps_pumpstation(");
            strSql.Append("Prj_No,Prj_Name,Exp_No,MapCode,Name,Area,Service_Dis,Service_Area,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,PS_Category2,Ps_Num,Design_Storm,Design_Sewer,Cur_Strom,Cur_Sew,Min_Level,Control_Level,Warnning_Level,S_Invert,PSize,OverOutfallID,Tel,ForebayLen,ForebayWid,ForebayDep,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime)");
            strSql.Append(" values (");
            strSql.Append("@Prj_No,@Prj_Name,@Exp_No,@MapCode,@Name,@Area,@Service_Dis,@Service_Area,@SewageSystem_ID,@StormSystem_ID,@Type,@X,@Y,@High,@PS_Category2,@Ps_Num,@Design_Storm,@Design_Sewer,@Cur_Strom,@Cur_Sew,@Min_Level,@Control_Level,@Warnning_Level,@S_Invert,@PSize,@OverOutfallID,@Tel,@ForebayLen,@ForebayWid,@ForebayDep,@Code,@Address,@DataSource,@Sunit,@Sdate,@UpdateTime,@Mdate,@DataListID,@Status,@Ename,@Design_Dept,@Conster_Dept,@Belong,@Operator,@Note,@Exp_NoOri,@FileName,@Uploadtime)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100),
                    new MySqlParameter("@MapCode", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Area", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Service_Dis", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Service_Area", MySqlDbType.Decimal,10),
                    new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,4),
                    new MySqlParameter("@X", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Y", MySqlDbType.Decimal,10),
                    new MySqlParameter("@High", MySqlDbType.Decimal,10),
                    new MySqlParameter("@PS_Category2", MySqlDbType.VarChar,4),
                    new MySqlParameter("@Ps_Num", MySqlDbType.VarChar,4),
                    new MySqlParameter("@Design_Storm", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Design_Sewer", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Cur_Strom", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Cur_Sew", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Min_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Control_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Warnning_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@S_Invert", MySqlDbType.Decimal,10),
                    new MySqlParameter("@PSize", MySqlDbType.VarChar,50),
                    new MySqlParameter("@OverOutfallID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Tel", MySqlDbType.VarChar,15),
                    new MySqlParameter("@ForebayLen", MySqlDbType.Decimal,10),
                    new MySqlParameter("@ForebayWid", MySqlDbType.Decimal,10),
                    new MySqlParameter("@ForebayDep", MySqlDbType.Decimal,10),
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
            parameters[5].Value = model.Area;
            parameters[6].Value = model.Service_Dis;
            parameters[7].Value = model.Service_Area;
            parameters[8].Value = model.SewageSystem_ID;
            parameters[9].Value = model.StormSystem_ID;
            parameters[10].Value = model.Type;
            parameters[11].Value = model.X;
            parameters[12].Value = model.Y;
            parameters[13].Value = model.High;
            parameters[14].Value = model.PS_Category2;
            parameters[15].Value = model.Ps_Num;
            parameters[16].Value = model.Design_Storm;
            parameters[17].Value = model.Design_Sewer;
            parameters[18].Value = model.Cur_Strom;
            parameters[19].Value = model.Cur_Sew;
            parameters[20].Value = model.Min_Level;
            parameters[21].Value = model.Control_Level;
            parameters[22].Value = model.Warnning_Level;
            parameters[23].Value = model.S_Invert;
            parameters[24].Value = model.PSize;
            parameters[25].Value = model.OverOutfallID;
            parameters[26].Value = model.Tel;
            parameters[27].Value = model.ForebayLen;
            parameters[28].Value = model.ForebayWid;
            parameters[29].Value = model.ForebayDep;
            parameters[30].Value = model.Code;
            parameters[31].Value = model.Address;
            parameters[32].Value = model.DataSource;
            parameters[33].Value = model.Sunit;
            parameters[34].Value = model.Sdate;
            parameters[35].Value = model.UpdateTime;
            parameters[36].Value = model.Mdate;
            parameters[37].Value = model.DataListID;
            parameters[38].Value = model.Status;
            parameters[39].Value = model.Ename;
            parameters[40].Value = model.Design_Dept;
            parameters[41].Value = model.Conster_Dept;
            parameters[42].Value = model.Belong;
            parameters[43].Value = model.Operator;
            parameters[44].Value = model.Note;
            parameters[45].Value = model.Exp_NoOri;
            parameters[46].Value = model.FileName;
            parameters[47].Value = model.Uploadtime;

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
        public bool Update(Maticsoft.Model.ps_pumpstation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ps_pumpstation set ");
            strSql.Append("Prj_No=@Prj_No,");
            strSql.Append("Prj_Name=@Prj_Name,");
            strSql.Append("MapCode=@MapCode,");
            strSql.Append("Name=@Name,");
            strSql.Append("Area=@Area,");
            strSql.Append("Service_Dis=@Service_Dis,");
            strSql.Append("Service_Area=@Service_Area,");
            strSql.Append("SewageSystem_ID=@SewageSystem_ID,");
            strSql.Append("StormSystem_ID=@StormSystem_ID,");
            strSql.Append("Type=@Type,");
            strSql.Append("X=@X,");
            strSql.Append("Y=@Y,");
            strSql.Append("High=@High,");
            strSql.Append("PS_Category2=@PS_Category2,");
            strSql.Append("Ps_Num=@Ps_Num,");
            strSql.Append("Design_Storm=@Design_Storm,");
            strSql.Append("Design_Sewer=@Design_Sewer,");
            strSql.Append("Cur_Strom=@Cur_Strom,");
            strSql.Append("Cur_Sew=@Cur_Sew,");
            strSql.Append("Min_Level=@Min_Level,");
            strSql.Append("Control_Level=@Control_Level,");
            strSql.Append("Warnning_Level=@Warnning_Level,");
            strSql.Append("S_Invert=@S_Invert,");
            strSql.Append("PSize=@PSize,");
            strSql.Append("OverOutfallID=@OverOutfallID,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("ForebayLen=@ForebayLen,");
            strSql.Append("ForebayWid=@ForebayWid,");
            strSql.Append("ForebayDep=@ForebayDep,");
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
                    new MySqlParameter("@Area", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Service_Dis", MySqlDbType.VarChar,255),
                    new MySqlParameter("@Service_Area", MySqlDbType.Decimal,10),
                    new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Type", MySqlDbType.VarChar,4),
                    new MySqlParameter("@X", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Y", MySqlDbType.Decimal,10),
                    new MySqlParameter("@High", MySqlDbType.Decimal,10),
                    new MySqlParameter("@PS_Category2", MySqlDbType.VarChar,4),
                    new MySqlParameter("@Ps_Num", MySqlDbType.VarChar,4),
                    new MySqlParameter("@Design_Storm", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Design_Sewer", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Cur_Strom", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Cur_Sew", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Min_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Control_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@Warnning_Level", MySqlDbType.Decimal,10),
                    new MySqlParameter("@S_Invert", MySqlDbType.Decimal,10),
                    new MySqlParameter("@PSize", MySqlDbType.VarChar,50),
                    new MySqlParameter("@OverOutfallID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Tel", MySqlDbType.VarChar,15),
                    new MySqlParameter("@ForebayLen", MySqlDbType.Decimal,10),
                    new MySqlParameter("@ForebayWid", MySqlDbType.Decimal,10),
                    new MySqlParameter("@ForebayDep", MySqlDbType.Decimal,10),
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
            parameters[4].Value = model.Area;
            parameters[5].Value = model.Service_Dis;
            parameters[6].Value = model.Service_Area;
            parameters[7].Value = model.SewageSystem_ID;
            parameters[8].Value = model.StormSystem_ID;
            parameters[9].Value = model.Type;
            parameters[10].Value = model.X;
            parameters[11].Value = model.Y;
            parameters[12].Value = model.High;
            parameters[13].Value = model.PS_Category2;
            parameters[14].Value = model.Ps_Num;
            parameters[15].Value = model.Design_Storm;
            parameters[16].Value = model.Design_Sewer;
            parameters[17].Value = model.Cur_Strom;
            parameters[18].Value = model.Cur_Sew;
            parameters[19].Value = model.Min_Level;
            parameters[20].Value = model.Control_Level;
            parameters[21].Value = model.Warnning_Level;
            parameters[22].Value = model.S_Invert;
            parameters[23].Value = model.PSize;
            parameters[24].Value = model.OverOutfallID;
            parameters[25].Value = model.Tel;
            parameters[26].Value = model.ForebayLen;
            parameters[27].Value = model.ForebayWid;
            parameters[28].Value = model.ForebayDep;
            parameters[29].Value = model.Code;
            parameters[30].Value = model.Address;
            parameters[31].Value = model.DataSource;
            parameters[32].Value = model.Sunit;
            parameters[33].Value = model.Sdate;
            parameters[34].Value = model.UpdateTime;
            parameters[35].Value = model.Mdate;
            parameters[36].Value = model.DataListID;
            parameters[37].Value = model.Status;
            parameters[38].Value = model.Ename;
            parameters[39].Value = model.Design_Dept;
            parameters[40].Value = model.Conster_Dept;
            parameters[41].Value = model.Belong;
            parameters[42].Value = model.Operator;
            parameters[43].Value = model.Note;
            parameters[44].Value = model.Exp_NoOri;
            parameters[45].Value = model.FileName;
            parameters[46].Value = model.Uploadtime;
            parameters[47].Value = model.Exp_No;

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
            strSql.Append("delete from ps_pumpstation ");
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
            strSql.Append("delete from ps_pumpstation ");
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
        public Maticsoft.Model.ps_pumpstation GetModel(string Exp_No)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,Name,Area,Service_Dis,Service_Area,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,PS_Category2,Ps_Num,Design_Storm,Design_Sewer,Cur_Strom,Cur_Sew,Min_Level,Control_Level,Warnning_Level,S_Invert,PSize,OverOutfallID,Tel,ForebayLen,ForebayWid,ForebayDep,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime from ps_pumpstation ");
            strSql.Append(" where Exp_No=@Exp_No ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Exp_No", MySqlDbType.VarChar,100)          };
            parameters[0].Value = Exp_No;

            Maticsoft.Model.ps_pumpstation model = new Maticsoft.Model.ps_pumpstation();
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
        public Maticsoft.Model.ps_pumpstation DataRowToModel(DataRow row)
        {
            Maticsoft.Model.ps_pumpstation model = new Maticsoft.Model.ps_pumpstation();
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
                if (row["Area"] != null && row["Area"].ToString() != "")
                {
                    model.Area = decimal.Parse(row["Area"].ToString());
                }
                if (row["Service_Dis"] != null)
                {
                    model.Service_Dis = row["Service_Dis"].ToString();
                }
                if (row["Service_Area"] != null && row["Service_Area"].ToString() != "")
                {
                    model.Service_Area = decimal.Parse(row["Service_Area"].ToString());
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
                if (row["PS_Category2"] != null)
                {
                    model.PS_Category2 = row["PS_Category2"].ToString();
                }
                if (row["Ps_Num"] != null)
                {
                    model.Ps_Num = row["Ps_Num"].ToString();
                }
                if (row["Design_Storm"] != null && row["Design_Storm"].ToString() != "")
                {
                    model.Design_Storm = decimal.Parse(row["Design_Storm"].ToString());
                }
                if (row["Design_Sewer"] != null && row["Design_Sewer"].ToString() != "")
                {
                    model.Design_Sewer = decimal.Parse(row["Design_Sewer"].ToString());
                }
                if (row["Cur_Strom"] != null && row["Cur_Strom"].ToString() != "")
                {
                    model.Cur_Strom = decimal.Parse(row["Cur_Strom"].ToString());
                }
                if (row["Cur_Sew"] != null && row["Cur_Sew"].ToString() != "")
                {
                    model.Cur_Sew = decimal.Parse(row["Cur_Sew"].ToString());
                }
                if (row["Min_Level"] != null && row["Min_Level"].ToString() != "")
                {
                    model.Min_Level = decimal.Parse(row["Min_Level"].ToString());
                }
                if (row["Control_Level"] != null && row["Control_Level"].ToString() != "")
                {
                    model.Control_Level = decimal.Parse(row["Control_Level"].ToString());
                }
                if (row["Warnning_Level"] != null && row["Warnning_Level"].ToString() != "")
                {
                    model.Warnning_Level = decimal.Parse(row["Warnning_Level"].ToString());
                }
                if (row["S_Invert"] != null && row["S_Invert"].ToString() != "")
                {
                    model.S_Invert = decimal.Parse(row["S_Invert"].ToString());
                }
                if (row["PSize"] != null)
                {
                    model.PSize = row["PSize"].ToString();
                }
                if (row["OverOutfallID"] != null)
                {
                    model.OverOutfallID = row["OverOutfallID"].ToString();
                }
                if (row["Tel"] != null)
                {
                    model.Tel = row["Tel"].ToString();
                }
                if (row["ForebayLen"] != null && row["ForebayLen"].ToString() != "")
                {
                    model.ForebayLen = decimal.Parse(row["ForebayLen"].ToString());
                }
                if (row["ForebayWid"] != null && row["ForebayWid"].ToString() != "")
                {
                    model.ForebayWid = decimal.Parse(row["ForebayWid"].ToString());
                }
                if (row["ForebayDep"] != null && row["ForebayDep"].ToString() != "")
                {
                    model.ForebayDep = decimal.Parse(row["ForebayDep"].ToString());
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
            strSql.Append("select Prj_No,Prj_Name,Exp_No,MapCode,Name,Area,Service_Dis,Service_Area,SewageSystem_ID,StormSystem_ID,Type,X,Y,High,PS_Category2,Ps_Num,Design_Storm,Design_Sewer,Cur_Strom,Cur_Sew,Min_Level,Control_Level,Warnning_Level,S_Invert,PSize,OverOutfallID,Tel,ForebayLen,ForebayWid,ForebayDep,Code,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,DataListID,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_NoOri,FileName,Uploadtime ");
            strSql.Append(" FROM ps_pumpstation ");
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
            strSql.Append("select count(1) FROM ps_pumpstation ");
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
            strSql.Append(")AS Row, T.*  from ps_pumpstation T ");
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
			parameters[0].Value = "ps_pumpstation";
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


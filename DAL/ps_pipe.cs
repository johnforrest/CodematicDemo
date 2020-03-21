using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ps_pipe
	/// </summary>
	public partial class ps_pipe
	{
		public ps_pipe()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Lno)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ps_pipe");
			strSql.Append(" where Lno=@Lno ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Lno", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Lno;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.ps_pipe model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ps_pipe(");
			strSql.Append("Prj_No,Prj_Name,Lno,Grade,S_Point,S_Deep,In_Elev,E_Point,E_Deep,Out_Elev,SewageSystem_ID,StormSystem_ID,Type,Code,Pressure_Type,Invert_Silphon,Material,ServiceLife,ShapeType,PSize,PipeLength,FlowDir,EmBed,Interface,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,Plan,Pipe_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_No0,Exp_No1,filename,update)");
			strSql.Append(" values (");
			strSql.Append("@Prj_No,@Prj_Name,@Lno,@Grade,@S_Point,@S_Deep,@In_Elev,@E_Point,@E_Deep,@Out_Elev,@SewageSystem_ID,@StormSystem_ID,@Type,@Code,@Pressure_Type,@Invert_Silphon,@Material,@ServiceLife,@ShapeType,@PSize,@PipeLength,@FlowDir,@EmBed,@Interface,@Address,@DataSource,@Sunit,@Sdate,@UpdateTime,@Mdate,@Plan,@Pipe_Type,@Status,@Ename,@Design_Dept,@Conster_Dept,@Belong,@Operator,@Note,@Exp_No0,@Exp_No1,@filename,@update)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Lno", MySqlDbType.VarChar,100),
					new MySqlParameter("@Grade", MySqlDbType.VarChar,10),
					new MySqlParameter("@S_Point", MySqlDbType.VarChar,100),
					new MySqlParameter("@S_Deep", MySqlDbType.Decimal,7),
					new MySqlParameter("@In_Elev", MySqlDbType.Decimal,7),
					new MySqlParameter("@E_Point", MySqlDbType.VarChar,100),
					new MySqlParameter("@E_Deep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Out_Elev", MySqlDbType.Decimal,7),
					new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,4),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Pressure_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Invert_Silphon", MySqlDbType.VarChar,1),
					new MySqlParameter("@Material", MySqlDbType.VarChar,20),
					new MySqlParameter("@ServiceLife", MySqlDbType.VarChar,10),
					new MySqlParameter("@ShapeType", MySqlDbType.VarChar,10),
					new MySqlParameter("@PSize", MySqlDbType.VarChar,20),
					new MySqlParameter("@PipeLength", MySqlDbType.Decimal,7),
					new MySqlParameter("@FlowDir", MySqlDbType.VarChar,10),
					new MySqlParameter("@EmBed", MySqlDbType.VarChar,50),
					new MySqlParameter("@Interface", MySqlDbType.VarChar,50),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Plan", MySqlDbType.VarChar,10),
					new MySqlParameter("@Pipe_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
					new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
					new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.Lno;
			parameters[3].Value = model.Grade;
			parameters[4].Value = model.S_Point;
			parameters[5].Value = model.S_Deep;
			parameters[6].Value = model.In_Elev;
			parameters[7].Value = model.E_Point;
			parameters[8].Value = model.E_Deep;
			parameters[9].Value = model.Out_Elev;
			parameters[10].Value = model.SewageSystem_ID;
			parameters[11].Value = model.StormSystem_ID;
			parameters[12].Value = model.Type;
			parameters[13].Value = model.Code;
			parameters[14].Value = model.Pressure_Type;
			parameters[15].Value = model.Invert_Silphon;
			parameters[16].Value = model.Material;
			parameters[17].Value = model.ServiceLife;
			parameters[18].Value = model.ShapeType;
			parameters[19].Value = model.PSize;
			parameters[20].Value = model.PipeLength;
			parameters[21].Value = model.FlowDir;
			parameters[22].Value = model.EmBed;
			parameters[23].Value = model.Interface;
			parameters[24].Value = model.Address;
			parameters[25].Value = model.DataSource;
			parameters[26].Value = model.Sunit;
			parameters[27].Value = model.Sdate;
			parameters[28].Value = model.UpdateTime;
			parameters[29].Value = model.Mdate;
			parameters[30].Value = model.Plan;
			parameters[31].Value = model.Pipe_Type;
			parameters[32].Value = model.Status;
			parameters[33].Value = model.Ename;
			parameters[34].Value = model.Design_Dept;
			parameters[35].Value = model.Conster_Dept;
			parameters[36].Value = model.Belong;
			parameters[37].Value = model.Operator;
			parameters[38].Value = model.Note;
			parameters[39].Value = model.Exp_No0;
			parameters[40].Value = model.Exp_No1;
			parameters[41].Value = model.filename;
			parameters[42].Value = model.update;

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
		public bool Update(Maticsoft.Model.ps_pipe model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ps_pipe set ");
			strSql.Append("Prj_No=@Prj_No,");
			strSql.Append("Prj_Name=@Prj_Name,");
			strSql.Append("Grade=@Grade,");
			strSql.Append("S_Point=@S_Point,");
			strSql.Append("S_Deep=@S_Deep,");
			strSql.Append("In_Elev=@In_Elev,");
			strSql.Append("E_Point=@E_Point,");
			strSql.Append("E_Deep=@E_Deep,");
			strSql.Append("Out_Elev=@Out_Elev,");
			strSql.Append("SewageSystem_ID=@SewageSystem_ID,");
			strSql.Append("StormSystem_ID=@StormSystem_ID,");
			strSql.Append("Type=@Type,");
			strSql.Append("Code=@Code,");
			strSql.Append("Pressure_Type=@Pressure_Type,");
			strSql.Append("Invert_Silphon=@Invert_Silphon,");
			strSql.Append("Material=@Material,");
			strSql.Append("ServiceLife=@ServiceLife,");
			strSql.Append("ShapeType=@ShapeType,");
			strSql.Append("PSize=@PSize,");
			strSql.Append("PipeLength=@PipeLength,");
			strSql.Append("FlowDir=@FlowDir,");
			strSql.Append("EmBed=@EmBed,");
			strSql.Append("Interface=@Interface,");
			strSql.Append("Address=@Address,");
			strSql.Append("DataSource=@DataSource,");
			strSql.Append("Sunit=@Sunit,");
			strSql.Append("Sdate=@Sdate,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("Mdate=@Mdate,");
			strSql.Append("Plan=@Plan,");
			strSql.Append("Pipe_Type=@Pipe_Type,");
			strSql.Append("Status=@Status,");
			strSql.Append("Ename=@Ename,");
			strSql.Append("Design_Dept=@Design_Dept,");
			strSql.Append("Conster_Dept=@Conster_Dept,");
			strSql.Append("Belong=@Belong,");
			strSql.Append("Operator=@Operator,");
			strSql.Append("Note=@Note,");
			strSql.Append("Exp_No0=@Exp_No0,");
			strSql.Append("Exp_No1=@Exp_No1,");
			strSql.Append("filename=@filename,");
			strSql.Append("update=@update");
			strSql.Append(" where Lno=@Lno ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Prj_No", MySqlDbType.VarChar,10),
					new MySqlParameter("@Prj_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Grade", MySqlDbType.VarChar,10),
					new MySqlParameter("@S_Point", MySqlDbType.VarChar,100),
					new MySqlParameter("@S_Deep", MySqlDbType.Decimal,7),
					new MySqlParameter("@In_Elev", MySqlDbType.Decimal,7),
					new MySqlParameter("@E_Point", MySqlDbType.VarChar,100),
					new MySqlParameter("@E_Deep", MySqlDbType.Decimal,7),
					new MySqlParameter("@Out_Elev", MySqlDbType.Decimal,7),
					new MySqlParameter("@SewageSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@StormSystem_ID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,4),
					new MySqlParameter("@Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Pressure_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Invert_Silphon", MySqlDbType.VarChar,1),
					new MySqlParameter("@Material", MySqlDbType.VarChar,20),
					new MySqlParameter("@ServiceLife", MySqlDbType.VarChar,10),
					new MySqlParameter("@ShapeType", MySqlDbType.VarChar,10),
					new MySqlParameter("@PSize", MySqlDbType.VarChar,20),
					new MySqlParameter("@PipeLength", MySqlDbType.Decimal,7),
					new MySqlParameter("@FlowDir", MySqlDbType.VarChar,10),
					new MySqlParameter("@EmBed", MySqlDbType.VarChar,50),
					new MySqlParameter("@Interface", MySqlDbType.VarChar,50),
					new MySqlParameter("@Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@DataSource", MySqlDbType.VarChar,10),
					new MySqlParameter("@Sunit", MySqlDbType.VarChar,255),
					new MySqlParameter("@Sdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@UpdateTime", MySqlDbType.VarChar,255),
					new MySqlParameter("@Mdate", MySqlDbType.VarChar,255),
					new MySqlParameter("@Plan", MySqlDbType.VarChar,10),
					new MySqlParameter("@Pipe_Type", MySqlDbType.VarChar,10),
					new MySqlParameter("@Status", MySqlDbType.VarChar,10),
					new MySqlParameter("@Ename", MySqlDbType.VarChar,100),
					new MySqlParameter("@Design_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Conster_Dept", MySqlDbType.VarChar,255),
					new MySqlParameter("@Belong", MySqlDbType.VarChar,255),
					new MySqlParameter("@Operator", MySqlDbType.VarChar,255),
					new MySqlParameter("@Note", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No0", MySqlDbType.VarChar,255),
					new MySqlParameter("@Exp_No1", MySqlDbType.VarChar,255),
					new MySqlParameter("@filename", MySqlDbType.VarChar,255),
					new MySqlParameter("@update", MySqlDbType.VarChar,255),
					new MySqlParameter("@Lno", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.Prj_No;
			parameters[1].Value = model.Prj_Name;
			parameters[2].Value = model.Grade;
			parameters[3].Value = model.S_Point;
			parameters[4].Value = model.S_Deep;
			parameters[5].Value = model.In_Elev;
			parameters[6].Value = model.E_Point;
			parameters[7].Value = model.E_Deep;
			parameters[8].Value = model.Out_Elev;
			parameters[9].Value = model.SewageSystem_ID;
			parameters[10].Value = model.StormSystem_ID;
			parameters[11].Value = model.Type;
			parameters[12].Value = model.Code;
			parameters[13].Value = model.Pressure_Type;
			parameters[14].Value = model.Invert_Silphon;
			parameters[15].Value = model.Material;
			parameters[16].Value = model.ServiceLife;
			parameters[17].Value = model.ShapeType;
			parameters[18].Value = model.PSize;
			parameters[19].Value = model.PipeLength;
			parameters[20].Value = model.FlowDir;
			parameters[21].Value = model.EmBed;
			parameters[22].Value = model.Interface;
			parameters[23].Value = model.Address;
			parameters[24].Value = model.DataSource;
			parameters[25].Value = model.Sunit;
			parameters[26].Value = model.Sdate;
			parameters[27].Value = model.UpdateTime;
			parameters[28].Value = model.Mdate;
			parameters[29].Value = model.Plan;
			parameters[30].Value = model.Pipe_Type;
			parameters[31].Value = model.Status;
			parameters[32].Value = model.Ename;
			parameters[33].Value = model.Design_Dept;
			parameters[34].Value = model.Conster_Dept;
			parameters[35].Value = model.Belong;
			parameters[36].Value = model.Operator;
			parameters[37].Value = model.Note;
			parameters[38].Value = model.Exp_No0;
			parameters[39].Value = model.Exp_No1;
			parameters[40].Value = model.filename;
			parameters[41].Value = model.update;
			parameters[42].Value = model.Lno;

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
		public bool Delete(string Lno)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ps_pipe ");
			strSql.Append(" where Lno=@Lno ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Lno", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Lno;

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
		public bool DeleteList(string Lnolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ps_pipe ");
			strSql.Append(" where Lno in ("+Lnolist + ")  ");
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
		public Maticsoft.Model.ps_pipe GetModel(string Lno)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Prj_No,Prj_Name,Lno,Grade,S_Point,S_Deep,In_Elev,E_Point,E_Deep,Out_Elev,SewageSystem_ID,StormSystem_ID,Type,Code,Pressure_Type,Invert_Silphon,Material,ServiceLife,ShapeType,PSize,PipeLength,FlowDir,EmBed,Interface,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,Plan,Pipe_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_No0,Exp_No1,filename,update from ps_pipe ");
			strSql.Append(" where Lno=@Lno ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Lno", MySqlDbType.VarChar,100)			};
			parameters[0].Value = Lno;

			Maticsoft.Model.ps_pipe model=new Maticsoft.Model.ps_pipe();
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
		public Maticsoft.Model.ps_pipe DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ps_pipe model=new Maticsoft.Model.ps_pipe();
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
				if(row["Lno"]!=null)
				{
					model.Lno=row["Lno"].ToString();
				}
				if(row["Grade"]!=null)
				{
					model.Grade=row["Grade"].ToString();
				}
				if(row["S_Point"]!=null)
				{
					model.S_Point=row["S_Point"].ToString();
				}
				if(row["S_Deep"]!=null && row["S_Deep"].ToString()!="")
				{
					model.S_Deep=decimal.Parse(row["S_Deep"].ToString());
				}
				if(row["In_Elev"]!=null && row["In_Elev"].ToString()!="")
				{
					model.In_Elev=decimal.Parse(row["In_Elev"].ToString());
				}
				if(row["E_Point"]!=null)
				{
					model.E_Point=row["E_Point"].ToString();
				}
				if(row["E_Deep"]!=null && row["E_Deep"].ToString()!="")
				{
					model.E_Deep=decimal.Parse(row["E_Deep"].ToString());
				}
				if(row["Out_Elev"]!=null && row["Out_Elev"].ToString()!="")
				{
					model.Out_Elev=decimal.Parse(row["Out_Elev"].ToString());
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
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Pressure_Type"]!=null)
				{
					model.Pressure_Type=row["Pressure_Type"].ToString();
				}
				if(row["Invert_Silphon"]!=null)
				{
					model.Invert_Silphon=row["Invert_Silphon"].ToString();
				}
				if(row["Material"]!=null)
				{
					model.Material=row["Material"].ToString();
				}
				if(row["ServiceLife"]!=null)
				{
					model.ServiceLife=row["ServiceLife"].ToString();
				}
				if(row["ShapeType"]!=null)
				{
					model.ShapeType=row["ShapeType"].ToString();
				}
				if(row["PSize"]!=null)
				{
					model.PSize=row["PSize"].ToString();
				}
				if(row["PipeLength"]!=null && row["PipeLength"].ToString()!="")
				{
					model.PipeLength=decimal.Parse(row["PipeLength"].ToString());
				}
				if(row["FlowDir"]!=null)
				{
					model.FlowDir=row["FlowDir"].ToString();
				}
				if(row["EmBed"]!=null)
				{
					model.EmBed=row["EmBed"].ToString();
				}
				if(row["Interface"]!=null)
				{
					model.Interface=row["Interface"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["DataSource"]!=null)
				{
					model.DataSource=row["DataSource"].ToString();
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
				if(row["Plan"]!=null)
				{
					model.Plan=row["Plan"].ToString();
				}
				if(row["Pipe_Type"]!=null)
				{
					model.Pipe_Type=row["Pipe_Type"].ToString();
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
				if(row["Exp_No0"]!=null)
				{
					model.Exp_No0=row["Exp_No0"].ToString();
				}
				if(row["Exp_No1"]!=null)
				{
					model.Exp_No1=row["Exp_No1"].ToString();
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
			strSql.Append("select Prj_No,Prj_Name,Lno,Grade,S_Point,S_Deep,In_Elev,E_Point,E_Deep,Out_Elev,SewageSystem_ID,StormSystem_ID,Type,Code,Pressure_Type,Invert_Silphon,Material,ServiceLife,ShapeType,PSize,PipeLength,FlowDir,EmBed,Interface,Address,DataSource,Sunit,Sdate,UpdateTime,Mdate,Plan,Pipe_Type,Status,Ename,Design_Dept,Conster_Dept,Belong,Operator,Note,Exp_No0,Exp_No1,filename,update ");
			strSql.Append(" FROM ps_pipe ");
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
			strSql.Append("select count(1) FROM ps_pipe ");
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
				strSql.Append("order by T.Lno desc");
			}
			strSql.Append(")AS Row, T.*  from ps_pipe T ");
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
			parameters[0].Value = "ps_pipe";
			parameters[1].Value = "Lno";
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


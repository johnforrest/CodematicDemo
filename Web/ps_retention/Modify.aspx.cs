using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.ps_retention
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string Exp_No= Request.Params["id"];
					ShowInfo(Exp_No);
				}
			}
		}
			
	private void ShowInfo(string Exp_No)
	{
		Maticsoft.BLL.ps_retention bll=new Maticsoft.BLL.ps_retention();
		Maticsoft.Model.ps_retention model=bll.GetModel(Exp_No);
		this.txtPrj_No.Text=model.Prj_No;
		this.txtPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.txtMapCode.Text=model.MapCode;
		this.txtName.Text=model.Name;
		this.txtSewageSystem_ID.Text=model.SewageSystem_ID;
		this.txtStormSystem_ID.Text=model.StormSystem_ID;
		this.txtType.Text=model.Type;
		this.txtX.Text=model.X.ToString();
		this.txtY.Text=model.Y.ToString();
		this.txtHigh.Text=model.High.ToString();
		this.txtInflow_Type.Text=model.Inflow_Type;
		this.txtOutflow_Type.Text=model.Outflow_Type;
		this.txtTotal_Vol.Text=model.Total_Vol.ToString();
		this.txtB_Level.Text=model.B_Level.ToString();
		this.txtMax_Level.Text=model.Max_Level.ToString();
		this.txtMin_Level.Text=model.Min_Level.ToString();
		this.txtDesign_Time.Text=model.Design_Time.ToString();
		this.txtPs_Num.Text=model.Ps_Num;
		this.txtFlowDir.Text=model.FlowDir;
		this.txtCode.Text=model.Code;
		this.txtAddress.Text=model.Address;
		this.txtDataSource.Text=model.DataSource;
		this.txtSunit.Text=model.Sunit;
		this.txtSdate.Text=model.Sdate;
		this.txtUpdateTime.Text=model.UpdateTime;
		this.txtMdate.Text=model.Mdate;
		this.txtDataListID.Text=model.DataListID;
		this.txtStatus.Text=model.Status;
		this.txtEname.Text=model.Ename;
		this.txtDesign_Dept.Text=model.Design_Dept;
		this.txtConster_Dept.Text=model.Conster_Dept;
		this.txtBelong.Text=model.Belong;
		this.txtOperator.Text=model.Operator;
		this.txtNote.Text=model.Note;
		this.txtExp_NoOri.Text=model.Exp_NoOri;
		this.txtfilename.Text=model.filename;
		this.txtupdate.Text=model.update;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPrj_No.Text.Trim().Length==0)
			{
				strErr+="Prj_No不能为空！\\n";	
			}
			if(this.txtPrj_Name.Text.Trim().Length==0)
			{
				strErr+="Prj_Name不能为空！\\n";	
			}
			if(this.txtMapCode.Text.Trim().Length==0)
			{
				strErr+="MapCode不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtSewageSystem_ID.Text.Trim().Length==0)
			{
				strErr+="SewageSystem_ID不能为空！\\n";	
			}
			if(this.txtStormSystem_ID.Text.Trim().Length==0)
			{
				strErr+="StormSystem_ID不能为空！\\n";	
			}
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtX.Text))
			{
				strErr+="X格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtY.Text))
			{
				strErr+="Y格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtHigh.Text))
			{
				strErr+="High格式错误！\\n";	
			}
			if(this.txtInflow_Type.Text.Trim().Length==0)
			{
				strErr+="Inflow_Type不能为空！\\n";	
			}
			if(this.txtOutflow_Type.Text.Trim().Length==0)
			{
				strErr+="Outflow_Type不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotal_Vol.Text))
			{
				strErr+="Total_Vol格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtB_Level.Text))
			{
				strErr+="B_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMax_Level.Text))
			{
				strErr+="Max_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMin_Level.Text))
			{
				strErr+="Min_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDesign_Time.Text))
			{
				strErr+="Design_Time格式错误！\\n";	
			}
			if(this.txtPs_Num.Text.Trim().Length==0)
			{
				strErr+="Ps_Num不能为空！\\n";	
			}
			if(this.txtFlowDir.Text.Trim().Length==0)
			{
				strErr+="FlowDir不能为空！\\n";	
			}
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtDataSource.Text.Trim().Length==0)
			{
				strErr+="DataSource不能为空！\\n";	
			}
			if(this.txtSunit.Text.Trim().Length==0)
			{
				strErr+="Sunit不能为空！\\n";	
			}
			if(this.txtSdate.Text.Trim().Length==0)
			{
				strErr+="Sdate不能为空！\\n";	
			}
			if(this.txtUpdateTime.Text.Trim().Length==0)
			{
				strErr+="UpdateTime不能为空！\\n";	
			}
			if(this.txtMdate.Text.Trim().Length==0)
			{
				strErr+="Mdate不能为空！\\n";	
			}
			if(this.txtDataListID.Text.Trim().Length==0)
			{
				strErr+="DataListID不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(this.txtEname.Text.Trim().Length==0)
			{
				strErr+="Ename不能为空！\\n";	
			}
			if(this.txtDesign_Dept.Text.Trim().Length==0)
			{
				strErr+="Design_Dept不能为空！\\n";	
			}
			if(this.txtConster_Dept.Text.Trim().Length==0)
			{
				strErr+="Conster_Dept不能为空！\\n";	
			}
			if(this.txtBelong.Text.Trim().Length==0)
			{
				strErr+="Belong不能为空！\\n";	
			}
			if(this.txtOperator.Text.Trim().Length==0)
			{
				strErr+="Operator不能为空！\\n";	
			}
			if(this.txtNote.Text.Trim().Length==0)
			{
				strErr+="Note不能为空！\\n";	
			}
			if(this.txtExp_NoOri.Text.Trim().Length==0)
			{
				strErr+="Exp_NoOri不能为空！\\n";	
			}
			if(this.txtfilename.Text.Trim().Length==0)
			{
				strErr+="filename不能为空！\\n";	
			}
			if(this.txtupdate.Text.Trim().Length==0)
			{
				strErr+="update不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Prj_No=this.txtPrj_No.Text;
			string Prj_Name=this.txtPrj_Name.Text;
			string Exp_No=this.lblExp_No.Text;
			string MapCode=this.txtMapCode.Text;
			string Name=this.txtName.Text;
			string SewageSystem_ID=this.txtSewageSystem_ID.Text;
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string Type=this.txtType.Text;
			decimal X=decimal.Parse(this.txtX.Text);
			decimal Y=decimal.Parse(this.txtY.Text);
			decimal High=decimal.Parse(this.txtHigh.Text);
			string Inflow_Type=this.txtInflow_Type.Text;
			string Outflow_Type=this.txtOutflow_Type.Text;
			decimal Total_Vol=decimal.Parse(this.txtTotal_Vol.Text);
			decimal B_Level=decimal.Parse(this.txtB_Level.Text);
			decimal Max_Level=decimal.Parse(this.txtMax_Level.Text);
			decimal Min_Level=decimal.Parse(this.txtMin_Level.Text);
			decimal Design_Time=decimal.Parse(this.txtDesign_Time.Text);
			string Ps_Num=this.txtPs_Num.Text;
			string FlowDir=this.txtFlowDir.Text;
			string Code=this.txtCode.Text;
			string Address=this.txtAddress.Text;
			string DataSource=this.txtDataSource.Text;
			string Sunit=this.txtSunit.Text;
			string Sdate=this.txtSdate.Text;
			string UpdateTime=this.txtUpdateTime.Text;
			string Mdate=this.txtMdate.Text;
			string DataListID=this.txtDataListID.Text;
			string Status=this.txtStatus.Text;
			string Ename=this.txtEname.Text;
			string Design_Dept=this.txtDesign_Dept.Text;
			string Conster_Dept=this.txtConster_Dept.Text;
			string Belong=this.txtBelong.Text;
			string Operator=this.txtOperator.Text;
			string Note=this.txtNote.Text;
			string Exp_NoOri=this.txtExp_NoOri.Text;
			string filename=this.txtfilename.Text;
			string update=this.txtupdate.Text;


			Maticsoft.Model.ps_retention model=new Maticsoft.Model.ps_retention();
			model.Prj_No=Prj_No;
			model.Prj_Name=Prj_Name;
			model.Exp_No=Exp_No;
			model.MapCode=MapCode;
			model.Name=Name;
			model.SewageSystem_ID=SewageSystem_ID;
			model.StormSystem_ID=StormSystem_ID;
			model.Type=Type;
			model.X=X;
			model.Y=Y;
			model.High=High;
			model.Inflow_Type=Inflow_Type;
			model.Outflow_Type=Outflow_Type;
			model.Total_Vol=Total_Vol;
			model.B_Level=B_Level;
			model.Max_Level=Max_Level;
			model.Min_Level=Min_Level;
			model.Design_Time=Design_Time;
			model.Ps_Num=Ps_Num;
			model.FlowDir=FlowDir;
			model.Code=Code;
			model.Address=Address;
			model.DataSource=DataSource;
			model.Sunit=Sunit;
			model.Sdate=Sdate;
			model.UpdateTime=UpdateTime;
			model.Mdate=Mdate;
			model.DataListID=DataListID;
			model.Status=Status;
			model.Ename=Ename;
			model.Design_Dept=Design_Dept;
			model.Conster_Dept=Conster_Dept;
			model.Belong=Belong;
			model.Operator=Operator;
			model.Note=Note;
			model.Exp_NoOri=Exp_NoOri;
			model.filename=filename;
			model.update=update;

			Maticsoft.BLL.ps_retention bll=new Maticsoft.BLL.ps_retention();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace Maticsoft.Web.ps_gate
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
		Maticsoft.BLL.ps_gate bll=new Maticsoft.BLL.ps_gate();
		Maticsoft.Model.ps_gate model=bll.GetModel(Exp_No);
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
		this.txtTop_Ele.Text=model.Top_Ele.ToString();
		this.txtBot_Ele.Text=model.Bot_Ele.ToString();
		this.txtWidth.Text=model.Width.ToString();
		this.txtManufacturer.Text=model.Manufacturer;
		this.txtGateModel.Text=model.GateModel;
		this.txtNum.Text=model.Num;
		this.txtControl_Type.Text=model.Control_Type;
		this.txtSwitch_Style.Text=model.Switch_Style;
		this.txtPressure_Type.Text=model.Pressure_Type;
		this.txtCode.Text=model.Code;
		this.txtModel.Text=model.Model;
		this.txtAddress.Text=model.Address;
		this.txtPointPosition.Text=model.PointPosition.ToString();
		this.txtDataSource.Text=model.DataSource;
		this.txtVisibility.Text=model.Visibility;
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
			if(!PageValidate.IsDecimal(txtTop_Ele.Text))
			{
				strErr+="Top_Ele格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBot_Ele.Text))
			{
				strErr+="Bot_Ele格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWidth.Text))
			{
				strErr+="Width格式错误！\\n";	
			}
			if(this.txtManufacturer.Text.Trim().Length==0)
			{
				strErr+="Manufacturer不能为空！\\n";	
			}
			if(this.txtGateModel.Text.Trim().Length==0)
			{
				strErr+="GateModel不能为空！\\n";	
			}
			if(this.txtNum.Text.Trim().Length==0)
			{
				strErr+="Num不能为空！\\n";	
			}
			if(this.txtControl_Type.Text.Trim().Length==0)
			{
				strErr+="Control_Type不能为空！\\n";	
			}
			if(this.txtSwitch_Style.Text.Trim().Length==0)
			{
				strErr+="Switch_Style不能为空！\\n";	
			}
			if(this.txtPressure_Type.Text.Trim().Length==0)
			{
				strErr+="Pressure_Type不能为空！\\n";	
			}
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtModel.Text.Trim().Length==0)
			{
				strErr+="Model不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPointPosition.Text))
			{
				strErr+="PointPosition格式错误！\\n";	
			}
			if(this.txtDataSource.Text.Trim().Length==0)
			{
				strErr+="DataSource不能为空！\\n";	
			}
			if(this.txtVisibility.Text.Trim().Length==0)
			{
				strErr+="Visibility不能为空！\\n";	
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
			decimal Top_Ele=decimal.Parse(this.txtTop_Ele.Text);
			decimal Bot_Ele=decimal.Parse(this.txtBot_Ele.Text);
			decimal Width=decimal.Parse(this.txtWidth.Text);
			string Manufacturer=this.txtManufacturer.Text;
			string GateModel=this.txtGateModel.Text;
			string Num=this.txtNum.Text;
			string Control_Type=this.txtControl_Type.Text;
			string Switch_Style=this.txtSwitch_Style.Text;
			string Pressure_Type=this.txtPressure_Type.Text;
			string Code=this.txtCode.Text;
			string Model=this.txtModel.Text;
			string Address=this.txtAddress.Text;
			int PointPosition=int.Parse(this.txtPointPosition.Text);
			string DataSource=this.txtDataSource.Text;
			string Visibility=this.txtVisibility.Text;
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


			Maticsoft.Model.ps_gate model=new Maticsoft.Model.ps_gate();
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
			model.Top_Ele=Top_Ele;
			model.Bot_Ele=Bot_Ele;
			model.Width=Width;
			model.Manufacturer=Manufacturer;
			model.GateModel=GateModel;
			model.Num=Num;
			model.Control_Type=Control_Type;
			model.Switch_Style=Switch_Style;
			model.Pressure_Type=Pressure_Type;
			model.Code=Code;
			model.Model=Model;
			model.Address=Address;
			model.PointPosition=PointPosition;
			model.DataSource=DataSource;
			model.Visibility=Visibility;
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

			Maticsoft.BLL.ps_gate bll=new Maticsoft.BLL.ps_gate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

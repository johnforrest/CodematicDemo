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
namespace Maticsoft.Web.ps_pumpstation
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
		Maticsoft.BLL.ps_pumpstation bll=new Maticsoft.BLL.ps_pumpstation();
		Maticsoft.Model.ps_pumpstation model=bll.GetModel(Exp_No);
		this.txtPrj_No.Text=model.Prj_No;
		this.txtPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.txtMapCode.Text=model.MapCode;
		this.txtName.Text=model.Name;
		this.txtArea.Text=model.Area.ToString();
		this.txtService_Dis.Text=model.Service_Dis;
		this.txtService_Area.Text=model.Service_Area.ToString();
		this.txtSewageSystem_ID.Text=model.SewageSystem_ID;
		this.txtStormSystem_ID.Text=model.StormSystem_ID;
		this.txtType.Text=model.Type;
		this.txtX.Text=model.X.ToString();
		this.txtY.Text=model.Y.ToString();
		this.txtHigh.Text=model.High.ToString();
		this.txtPS_Category2.Text=model.PS_Category2;
		this.txtPs_Num.Text=model.Ps_Num;
		this.txtDesign_Storm.Text=model.Design_Storm.ToString();
		this.txtDesign_Sewer.Text=model.Design_Sewer.ToString();
		this.txtCur_Strom.Text=model.Cur_Strom.ToString();
		this.txtCur_Sew.Text=model.Cur_Sew.ToString();
		this.txtMin_Level.Text=model.Min_Level.ToString();
		this.txtControl_Level.Text=model.Control_Level.ToString();
		this.txtWarnning_Level.Text=model.Warnning_Level.ToString();
		this.txtS_Invert.Text=model.S_Invert.ToString();
		this.txtPSize.Text=model.PSize;
		this.txtOverOutfallID.Text=model.OverOutfallID;
		this.txtTel.Text=model.Tel;
		this.txtForebayLen.Text=model.ForebayLen.ToString();
		this.txtForebayWid.Text=model.ForebayWid.ToString();
		this.txtForebayDep.Text=model.ForebayDep.ToString();
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
			if(!PageValidate.IsDecimal(txtArea.Text))
			{
				strErr+="Area格式错误！\\n";	
			}
			if(this.txtService_Dis.Text.Trim().Length==0)
			{
				strErr+="Service_Dis不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtService_Area.Text))
			{
				strErr+="Service_Area格式错误！\\n";	
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
			if(this.txtPS_Category2.Text.Trim().Length==0)
			{
				strErr+="PS_Category2不能为空！\\n";	
			}
			if(this.txtPs_Num.Text.Trim().Length==0)
			{
				strErr+="Ps_Num不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDesign_Storm.Text))
			{
				strErr+="Design_Storm格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDesign_Sewer.Text))
			{
				strErr+="Design_Sewer格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCur_Strom.Text))
			{
				strErr+="Cur_Strom格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCur_Sew.Text))
			{
				strErr+="Cur_Sew格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMin_Level.Text))
			{
				strErr+="Min_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtControl_Level.Text))
			{
				strErr+="Control_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWarnning_Level.Text))
			{
				strErr+="Warnning_Level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtS_Invert.Text))
			{
				strErr+="S_Invert格式错误！\\n";	
			}
			if(this.txtPSize.Text.Trim().Length==0)
			{
				strErr+="PSize不能为空！\\n";	
			}
			if(this.txtOverOutfallID.Text.Trim().Length==0)
			{
				strErr+="OverOutfallID不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="Tel不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtForebayLen.Text))
			{
				strErr+="ForebayLen格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtForebayWid.Text))
			{
				strErr+="ForebayWid格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtForebayDep.Text))
			{
				strErr+="ForebayDep格式错误！\\n";	
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
			decimal Area=decimal.Parse(this.txtArea.Text);
			string Service_Dis=this.txtService_Dis.Text;
			decimal Service_Area=decimal.Parse(this.txtService_Area.Text);
			string SewageSystem_ID=this.txtSewageSystem_ID.Text;
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string Type=this.txtType.Text;
			decimal X=decimal.Parse(this.txtX.Text);
			decimal Y=decimal.Parse(this.txtY.Text);
			decimal High=decimal.Parse(this.txtHigh.Text);
			string PS_Category2=this.txtPS_Category2.Text;
			string Ps_Num=this.txtPs_Num.Text;
			decimal Design_Storm=decimal.Parse(this.txtDesign_Storm.Text);
			decimal Design_Sewer=decimal.Parse(this.txtDesign_Sewer.Text);
			decimal Cur_Strom=decimal.Parse(this.txtCur_Strom.Text);
			decimal Cur_Sew=decimal.Parse(this.txtCur_Sew.Text);
			decimal Min_Level=decimal.Parse(this.txtMin_Level.Text);
			decimal Control_Level=decimal.Parse(this.txtControl_Level.Text);
			decimal Warnning_Level=decimal.Parse(this.txtWarnning_Level.Text);
			decimal S_Invert=decimal.Parse(this.txtS_Invert.Text);
			string PSize=this.txtPSize.Text;
			string OverOutfallID=this.txtOverOutfallID.Text;
			string Tel=this.txtTel.Text;
			decimal ForebayLen=decimal.Parse(this.txtForebayLen.Text);
			decimal ForebayWid=decimal.Parse(this.txtForebayWid.Text);
			decimal ForebayDep=decimal.Parse(this.txtForebayDep.Text);
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


			Maticsoft.Model.ps_pumpstation model=new Maticsoft.Model.ps_pumpstation();
			model.Prj_No=Prj_No;
			model.Prj_Name=Prj_Name;
			model.Exp_No=Exp_No;
			model.MapCode=MapCode;
			model.Name=Name;
			model.Area=Area;
			model.Service_Dis=Service_Dis;
			model.Service_Area=Service_Area;
			model.SewageSystem_ID=SewageSystem_ID;
			model.StormSystem_ID=StormSystem_ID;
			model.Type=Type;
			model.X=X;
			model.Y=Y;
			model.High=High;
			model.PS_Category2=PS_Category2;
			model.Ps_Num=Ps_Num;
			model.Design_Storm=Design_Storm;
			model.Design_Sewer=Design_Sewer;
			model.Cur_Strom=Cur_Strom;
			model.Cur_Sew=Cur_Sew;
			model.Min_Level=Min_Level;
			model.Control_Level=Control_Level;
			model.Warnning_Level=Warnning_Level;
			model.S_Invert=S_Invert;
			model.PSize=PSize;
			model.OverOutfallID=OverOutfallID;
			model.Tel=Tel;
			model.ForebayLen=ForebayLen;
			model.ForebayWid=ForebayWid;
			model.ForebayDep=ForebayDep;
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

			Maticsoft.BLL.ps_pumpstation bll=new Maticsoft.BLL.ps_pumpstation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

﻿using System;
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
namespace Maticsoft.Web.ps_outfall
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtExp_No.Text.Trim().Length==0)
			{
				strErr+="Exp_No不能为空！\\n";	
			}
			if(this.txtMapCode.Text.Trim().Length==0)
			{
				strErr+="MapCode不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtBottom_Elev.Text))
			{
				strErr+="Bottom_Elev格式错误！\\n";	
			}
			if(this.txtOutfallShape.Text.Trim().Length==0)
			{
				strErr+="OutfallShape不能为空！\\n";	
			}
			if(this.txtOutfallType.Text.Trim().Length==0)
			{
				strErr+="OutfallType不能为空！\\n";	
			}
			if(this.txtOffset.Text.Trim().Length==0)
			{
				strErr+="Offset不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRotation.Text))
			{
				strErr+="Rotation格式错误！\\n";	
			}
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtFlap.Text.Trim().Length==0)
			{
				strErr+="Flap不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFlap_Diameter.Text))
			{
				strErr+="Flap_Diameter格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFlap_TopEle.Text))
			{
				strErr+="Flap_TopEle格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFlap_BotEle.Text))
			{
				strErr+="Flap_BotEle格式错误！\\n";	
			}
			if(this.txtFlap_Materail.Text.Trim().Length==0)
			{
				strErr+="Flap_Materail不能为空！\\n";	
			}
			if(this.txtReceive.Text.Trim().Length==0)
			{
				strErr+="Receive不能为空！\\n";	
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
			if(this.txtOutfall_Type.Text.Trim().Length==0)
			{
				strErr+="Outfall_Type不能为空！\\n";	
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
			string Exp_No=this.txtExp_No.Text;
			string MapCode=this.txtMapCode.Text;
			string SewageSystem_ID=this.txtSewageSystem_ID.Text;
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string Type=this.txtType.Text;
			decimal X=decimal.Parse(this.txtX.Text);
			decimal Y=decimal.Parse(this.txtY.Text);
			decimal High=decimal.Parse(this.txtHigh.Text);
			decimal Bottom_Elev=decimal.Parse(this.txtBottom_Elev.Text);
			string OutfallShape=this.txtOutfallShape.Text;
			string OutfallType=this.txtOutfallType.Text;
			string Offset=this.txtOffset.Text;
			decimal Rotation=decimal.Parse(this.txtRotation.Text);
			string Code=this.txtCode.Text;
			string Flap=this.txtFlap.Text;
			decimal Flap_Diameter=decimal.Parse(this.txtFlap_Diameter.Text);
			decimal Flap_TopEle=decimal.Parse(this.txtFlap_TopEle.Text);
			decimal Flap_BotEle=decimal.Parse(this.txtFlap_BotEle.Text);
			string Flap_Materail=this.txtFlap_Materail.Text;
			string Receive=this.txtReceive.Text;
			string Address=this.txtAddress.Text;
			int PointPosition=int.Parse(this.txtPointPosition.Text);
			string DataSource=this.txtDataSource.Text;
			string Visibility=this.txtVisibility.Text;
			string Sunit=this.txtSunit.Text;
			string Sdate=this.txtSdate.Text;
			string UpdateTime=this.txtUpdateTime.Text;
			string Mdate=this.txtMdate.Text;
			string Outfall_Type=this.txtOutfall_Type.Text;
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

			Maticsoft.Model.ps_outfall model=new Maticsoft.Model.ps_outfall();
			model.Prj_No=Prj_No;
			model.Prj_Name=Prj_Name;
			model.Exp_No=Exp_No;
			model.MapCode=MapCode;
			model.SewageSystem_ID=SewageSystem_ID;
			model.StormSystem_ID=StormSystem_ID;
			model.Type=Type;
			model.X=X;
			model.Y=Y;
			model.High=High;
			model.Bottom_Elev=Bottom_Elev;
			model.OutfallShape=OutfallShape;
			model.OutfallType=OutfallType;
			model.Offset=Offset;
			model.Rotation=Rotation;
			model.Code=Code;
			model.Flap=Flap;
			model.Flap_Diameter=Flap_Diameter;
			model.Flap_TopEle=Flap_TopEle;
			model.Flap_BotEle=Flap_BotEle;
			model.Flap_Materail=Flap_Materail;
			model.Receive=Receive;
			model.Address=Address;
			model.PointPosition=PointPosition;
			model.DataSource=DataSource;
			model.Visibility=Visibility;
			model.Sunit=Sunit;
			model.Sdate=Sdate;
			model.UpdateTime=UpdateTime;
			model.Mdate=Mdate;
			model.Outfall_Type=Outfall_Type;
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

			Maticsoft.BLL.ps_outfall bll=new Maticsoft.BLL.ps_outfall();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace Maticsoft.Web.ps_pipe
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
			if(this.txtLno.Text.Trim().Length==0)
			{
				strErr+="Lno不能为空！\\n";	
			}
			if(this.txtGrade.Text.Trim().Length==0)
			{
				strErr+="Grade不能为空！\\n";	
			}
			if(this.txtS_Point.Text.Trim().Length==0)
			{
				strErr+="S_Point不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtS_Deep.Text))
			{
				strErr+="S_Deep格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtIn_Elev.Text))
			{
				strErr+="In_Elev格式错误！\\n";	
			}
			if(this.txtE_Point.Text.Trim().Length==0)
			{
				strErr+="E_Point不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtE_Deep.Text))
			{
				strErr+="E_Deep格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOut_Elev.Text))
			{
				strErr+="Out_Elev格式错误！\\n";	
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
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtPressure_Type.Text.Trim().Length==0)
			{
				strErr+="Pressure_Type不能为空！\\n";	
			}
			if(this.txtInvert_Silphon.Text.Trim().Length==0)
			{
				strErr+="Invert_Silphon不能为空！\\n";	
			}
			if(this.txtMaterial.Text.Trim().Length==0)
			{
				strErr+="Material不能为空！\\n";	
			}
			if(this.txtServiceLife.Text.Trim().Length==0)
			{
				strErr+="ServiceLife不能为空！\\n";	
			}
			if(this.txtShapeType.Text.Trim().Length==0)
			{
				strErr+="ShapeType不能为空！\\n";	
			}
			if(this.txtPSize.Text.Trim().Length==0)
			{
				strErr+="PSize不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPipeLength.Text))
			{
				strErr+="PipeLength格式错误！\\n";	
			}
			if(this.txtFlowDir.Text.Trim().Length==0)
			{
				strErr+="FlowDir不能为空！\\n";	
			}
			if(this.txtEmBed.Text.Trim().Length==0)
			{
				strErr+="EmBed不能为空！\\n";	
			}
			if(this.txtInterface.Text.Trim().Length==0)
			{
				strErr+="Interface不能为空！\\n";	
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
			if(this.txtPlan.Text.Trim().Length==0)
			{
				strErr+="Plan不能为空！\\n";	
			}
			if(this.txtPipe_Type.Text.Trim().Length==0)
			{
				strErr+="Pipe_Type不能为空！\\n";	
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
			if(this.txtExp_No0.Text.Trim().Length==0)
			{
				strErr+="Exp_No0不能为空！\\n";	
			}
			if(this.txtExp_No1.Text.Trim().Length==0)
			{
				strErr+="Exp_No1不能为空！\\n";	
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
			string Lno=this.txtLno.Text;
			string Grade=this.txtGrade.Text;
			string S_Point=this.txtS_Point.Text;
			decimal S_Deep=decimal.Parse(this.txtS_Deep.Text);
			decimal In_Elev=decimal.Parse(this.txtIn_Elev.Text);
			string E_Point=this.txtE_Point.Text;
			decimal E_Deep=decimal.Parse(this.txtE_Deep.Text);
			decimal Out_Elev=decimal.Parse(this.txtOut_Elev.Text);
			string SewageSystem_ID=this.txtSewageSystem_ID.Text;
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string Type=this.txtType.Text;
			string Code=this.txtCode.Text;
			string Pressure_Type=this.txtPressure_Type.Text;
			string Invert_Silphon=this.txtInvert_Silphon.Text;
			string Material=this.txtMaterial.Text;
			string ServiceLife=this.txtServiceLife.Text;
			string ShapeType=this.txtShapeType.Text;
			string PSize=this.txtPSize.Text;
			decimal PipeLength=decimal.Parse(this.txtPipeLength.Text);
			string FlowDir=this.txtFlowDir.Text;
			string EmBed=this.txtEmBed.Text;
			string Interface=this.txtInterface.Text;
			string Address=this.txtAddress.Text;
			string DataSource=this.txtDataSource.Text;
			string Sunit=this.txtSunit.Text;
			string Sdate=this.txtSdate.Text;
			string UpdateTime=this.txtUpdateTime.Text;
			string Mdate=this.txtMdate.Text;
			string Plan=this.txtPlan.Text;
			string Pipe_Type=this.txtPipe_Type.Text;
			string Status=this.txtStatus.Text;
			string Ename=this.txtEname.Text;
			string Design_Dept=this.txtDesign_Dept.Text;
			string Conster_Dept=this.txtConster_Dept.Text;
			string Belong=this.txtBelong.Text;
			string Operator=this.txtOperator.Text;
			string Note=this.txtNote.Text;
			string Exp_No0=this.txtExp_No0.Text;
			string Exp_No1=this.txtExp_No1.Text;
			string filename=this.txtfilename.Text;
			string update=this.txtupdate.Text;

			Maticsoft.Model.ps_pipe model=new Maticsoft.Model.ps_pipe();
			model.Prj_No=Prj_No;
			model.Prj_Name=Prj_Name;
			model.Lno=Lno;
			model.Grade=Grade;
			model.S_Point=S_Point;
			model.S_Deep=S_Deep;
			model.In_Elev=In_Elev;
			model.E_Point=E_Point;
			model.E_Deep=E_Deep;
			model.Out_Elev=Out_Elev;
			model.SewageSystem_ID=SewageSystem_ID;
			model.StormSystem_ID=StormSystem_ID;
			model.Type=Type;
			model.Code=Code;
			model.Pressure_Type=Pressure_Type;
			model.Invert_Silphon=Invert_Silphon;
			model.Material=Material;
			model.ServiceLife=ServiceLife;
			model.ShapeType=ShapeType;
			model.PSize=PSize;
			model.PipeLength=PipeLength;
			model.FlowDir=FlowDir;
			model.EmBed=EmBed;
			model.Interface=Interface;
			model.Address=Address;
			model.DataSource=DataSource;
			model.Sunit=Sunit;
			model.Sdate=Sdate;
			model.UpdateTime=UpdateTime;
			model.Mdate=Mdate;
			model.Plan=Plan;
			model.Pipe_Type=Pipe_Type;
			model.Status=Status;
			model.Ename=Ename;
			model.Design_Dept=Design_Dept;
			model.Conster_Dept=Conster_Dept;
			model.Belong=Belong;
			model.Operator=Operator;
			model.Note=Note;
			model.Exp_No0=Exp_No0;
			model.Exp_No1=Exp_No1;
			model.filename=filename;
			model.update=update;

			Maticsoft.BLL.ps_pipe bll=new Maticsoft.BLL.ps_pipe();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

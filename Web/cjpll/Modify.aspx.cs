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
namespace Maticsoft.Web.cjpll
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string S_Point = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					S_Point= Request.Params["id0"];
				}
				string E_Point = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					E_Point= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(S_Point,E_Point);
			}
		}
			
	private void ShowInfo(string S_Point,string E_Point)
	{
		Maticsoft.BLL.cjpll bll=new Maticsoft.BLL.cjpll();
		Maticsoft.Model.cjpll model=bll.GetModel(S_Point,E_Point);
		this.txtStormSystem_ID.Text=model.StormSystem_ID;
		this.lblS_Point.Text=model.S_Point;
		this.txtS_Deep.Text=model.S_Deep.ToString();
		this.txtS_Elev.Text=model.S_Elev.ToString();
		this.lblE_Point.Text=model.E_Point;
		this.txtE_Deep.Text=model.E_Deep.ToString();
		this.txtE_Elev.Text=model.E_Elev.ToString();
		this.txtType.Text=model.Type;
		this.txtPressure_Type.Text=model.Pressure_Type;
		this.txtInvert_Silphon.Text=model.Invert_Silphon;
		this.txtMaterial.Text=model.Material;
		this.txtShapeType.Text=model.ShapeType;
		this.txtGrade.Text=model.Grade;
		this.txtPsize.Text=model.Psize;
		this.txtFlowDir.Text=model.FlowDir;
		this.txtConduitStyle.Text=model.ConduitStyle;
		this.txtAddress.Text=model.Address;
		this.txtDataSource.Text=model.DataSource;
		this.txtSdate.Text=model.Sdate;
		this.txtMdate.Text=model.Mdate;
		this.txtPipe_Type.Text=model.Pipe_Type;
		this.txtStatus.Text=model.Status;
		this.txtNote.Text=model.Note;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStormSystem_ID.Text.Trim().Length==0)
			{
				strErr+="StormSystem_ID不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtS_Deep.Text))
			{
				strErr+="S_Deep格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtS_Elev.Text))
			{
				strErr+="S_Elev格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtE_Deep.Text))
			{
				strErr+="E_Deep格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtE_Elev.Text))
			{
				strErr+="E_Elev格式错误！\\n";	
			}
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
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
			if(this.txtShapeType.Text.Trim().Length==0)
			{
				strErr+="ShapeType不能为空！\\n";	
			}
			if(this.txtGrade.Text.Trim().Length==0)
			{
				strErr+="Grade不能为空！\\n";	
			}
			if(this.txtPsize.Text.Trim().Length==0)
			{
				strErr+="Psize不能为空！\\n";	
			}
			if(this.txtFlowDir.Text.Trim().Length==0)
			{
				strErr+="FlowDir不能为空！\\n";	
			}
			if(this.txtConduitStyle.Text.Trim().Length==0)
			{
				strErr+="ConduitStyle不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtDataSource.Text.Trim().Length==0)
			{
				strErr+="DataSource不能为空！\\n";	
			}
			if(this.txtSdate.Text.Trim().Length==0)
			{
				strErr+="Sdate不能为空！\\n";	
			}
			if(this.txtMdate.Text.Trim().Length==0)
			{
				strErr+="Mdate不能为空！\\n";	
			}
			if(this.txtPipe_Type.Text.Trim().Length==0)
			{
				strErr+="Pipe_Type不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(this.txtNote.Text.Trim().Length==0)
			{
				strErr+="Note不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string S_Point=this.lblS_Point.Text;
			decimal S_Deep=decimal.Parse(this.txtS_Deep.Text);
			decimal S_Elev=decimal.Parse(this.txtS_Elev.Text);
			string E_Point=this.lblE_Point.Text;
			decimal E_Deep=decimal.Parse(this.txtE_Deep.Text);
			decimal E_Elev=decimal.Parse(this.txtE_Elev.Text);
			string Type=this.txtType.Text;
			string Pressure_Type=this.txtPressure_Type.Text;
			string Invert_Silphon=this.txtInvert_Silphon.Text;
			string Material=this.txtMaterial.Text;
			string ShapeType=this.txtShapeType.Text;
			string Grade=this.txtGrade.Text;
			string Psize=this.txtPsize.Text;
			string FlowDir=this.txtFlowDir.Text;
			string ConduitStyle=this.txtConduitStyle.Text;
			string Address=this.txtAddress.Text;
			string DataSource=this.txtDataSource.Text;
			string Sdate=this.txtSdate.Text;
			string Mdate=this.txtMdate.Text;
			string Pipe_Type=this.txtPipe_Type.Text;
			string Status=this.txtStatus.Text;
			string Note=this.txtNote.Text;


			Maticsoft.Model.cjpll model=new Maticsoft.Model.cjpll();
			model.StormSystem_ID=StormSystem_ID;
			model.S_Point=S_Point;
			model.S_Deep=S_Deep;
			model.S_Elev=S_Elev;
			model.E_Point=E_Point;
			model.E_Deep=E_Deep;
			model.E_Elev=E_Elev;
			model.Type=Type;
			model.Pressure_Type=Pressure_Type;
			model.Invert_Silphon=Invert_Silphon;
			model.Material=Material;
			model.ShapeType=ShapeType;
			model.Grade=Grade;
			model.Psize=Psize;
			model.FlowDir=FlowDir;
			model.ConduitStyle=ConduitStyle;
			model.Address=Address;
			model.DataSource=DataSource;
			model.Sdate=Sdate;
			model.Mdate=Mdate;
			model.Pipe_Type=Pipe_Type;
			model.Status=Status;
			model.Note=Note;

			Maticsoft.BLL.cjpll bll=new Maticsoft.BLL.cjpll();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

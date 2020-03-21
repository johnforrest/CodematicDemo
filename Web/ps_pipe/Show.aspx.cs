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
namespace Maticsoft.Web.ps_pipe
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string Lno= strid;
					ShowInfo(Lno);
				}
			}
		}
		
	private void ShowInfo(string Lno)
	{
		Maticsoft.BLL.ps_pipe bll=new Maticsoft.BLL.ps_pipe();
		Maticsoft.Model.ps_pipe model=bll.GetModel(Lno);
		this.lblPrj_No.Text=model.Prj_No;
		this.lblPrj_Name.Text=model.Prj_Name;
		this.lblLno.Text=model.Lno;
		this.lblGrade.Text=model.Grade;
		this.lblS_Point.Text=model.S_Point;
		this.lblS_Deep.Text=model.S_Deep.ToString();
		this.lblIn_Elev.Text=model.In_Elev.ToString();
		this.lblE_Point.Text=model.E_Point;
		this.lblE_Deep.Text=model.E_Deep.ToString();
		this.lblOut_Elev.Text=model.Out_Elev.ToString();
		this.lblSewageSystem_ID.Text=model.SewageSystem_ID;
		this.lblStormSystem_ID.Text=model.StormSystem_ID;
		this.lblType.Text=model.Type;
		this.lblCode.Text=model.Code;
		this.lblPressure_Type.Text=model.Pressure_Type;
		this.lblInvert_Silphon.Text=model.Invert_Silphon;
		this.lblMaterial.Text=model.Material;
		this.lblServiceLife.Text=model.ServiceLife;
		this.lblShapeType.Text=model.ShapeType;
		this.lblPSize.Text=model.PSize;
		this.lblPipeLength.Text=model.PipeLength.ToString();
		this.lblFlowDir.Text=model.FlowDir;
		this.lblEmBed.Text=model.EmBed;
		this.lblInterface.Text=model.Interface;
		this.lblAddress.Text=model.Address;
		this.lblDataSource.Text=model.DataSource;
		this.lblSunit.Text=model.Sunit;
		this.lblSdate.Text=model.Sdate;
		this.lblUpdateTime.Text=model.UpdateTime;
		this.lblMdate.Text=model.Mdate;
		this.lblPlan.Text=model.Plan;
		this.lblPipe_Type.Text=model.Pipe_Type;
		this.lblStatus.Text=model.Status;
		this.lblEname.Text=model.Ename;
		this.lblDesign_Dept.Text=model.Design_Dept;
		this.lblConster_Dept.Text=model.Conster_Dept;
		this.lblBelong.Text=model.Belong;
		this.lblOperator.Text=model.Operator;
		this.lblNote.Text=model.Note;
		this.lblExp_No0.Text=model.Exp_No0;
		this.lblExp_No1.Text=model.Exp_No1;
		this.lblfilename.Text=model.filename;
		this.lblupdate.Text=model.update;

	}


    }
}

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
namespace Maticsoft.Web.ps_wwtp
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
					string Exp_No= strid;
					ShowInfo(Exp_No);
				}
			}
		}
		
	private void ShowInfo(string Exp_No)
	{
		Maticsoft.BLL.ps_wwtp bll=new Maticsoft.BLL.ps_wwtp();
		Maticsoft.Model.ps_wwtp model=bll.GetModel(Exp_No);
		this.lblPrj_No.Text=model.Prj_No;
		this.lblPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.lblMapCode.Text=model.MapCode;
		this.lblName.Text=model.Name;
		this.lblSewageSystem_ID.Text=model.SewageSystem_ID;
		this.lblStormSystem_ID.Text=model.StormSystem_ID;
		this.lblType.Text=model.Type;
		this.lblX.Text=model.X.ToString();
		this.lblY.Text=model.Y.ToString();
		this.lblHigh.Text=model.High.ToString();
		this.lblWWTPType.Text=model.WWTPType;
		this.lblPs_Num.Text=model.Ps_Num;
		this.lblTreatment_Level.Text=model.Treatment_Level;
		this.lblTreatment_Technology.Text=model.Treatment_Technology;
		this.lblReceiveWater.Text=model.ReceiveWater;
		this.lblDesign_Capa.Text=model.Design_Capa.ToString();
		this.lblSludgeDesign_Capa.Text=model.SludgeDesign_Capa.ToString();
		this.lblCode.Text=model.Code;
		this.lblAddress.Text=model.Address;
		this.lblPointPosition.Text=model.PointPosition.ToString();
		this.lblDataSource.Text=model.DataSource;
		this.lblSunit.Text=model.Sunit;
		this.lblSdate.Text=model.Sdate;
		this.lblUpdateTime.Text=model.UpdateTime;
		this.lblMdate.Text=model.Mdate;
		this.lblDataListID.Text=model.DataListID;
		this.lblStatus.Text=model.Status;
		this.lblEname.Text=model.Ename;
		this.lblDesign_Dept.Text=model.Design_Dept;
		this.lblConster_Dept.Text=model.Conster_Dept;
		this.lblBelong.Text=model.Belong;
		this.lblOperator.Text=model.Operator;
		this.lblNote.Text=model.Note;
		this.lblExp_NoOri.Text=model.Exp_NoOri;
		this.lblfilename.Text=model.filename;
		this.lblupdate.Text=model.update;

	}


    }
}

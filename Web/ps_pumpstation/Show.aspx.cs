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
namespace Maticsoft.Web.ps_pumpstation
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
		Maticsoft.BLL.ps_pumpstation bll=new Maticsoft.BLL.ps_pumpstation();
		Maticsoft.Model.ps_pumpstation model=bll.GetModel(Exp_No);
		this.lblPrj_No.Text=model.Prj_No;
		this.lblPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.lblMapCode.Text=model.MapCode;
		this.lblName.Text=model.Name;
		this.lblArea.Text=model.Area.ToString();
		this.lblService_Dis.Text=model.Service_Dis;
		this.lblService_Area.Text=model.Service_Area.ToString();
		this.lblSewageSystem_ID.Text=model.SewageSystem_ID;
		this.lblStormSystem_ID.Text=model.StormSystem_ID;
		this.lblType.Text=model.Type;
		this.lblX.Text=model.X.ToString();
		this.lblY.Text=model.Y.ToString();
		this.lblHigh.Text=model.High.ToString();
		this.lblPS_Category2.Text=model.PS_Category2;
		this.lblPs_Num.Text=model.Ps_Num;
		this.lblDesign_Storm.Text=model.Design_Storm.ToString();
		this.lblDesign_Sewer.Text=model.Design_Sewer.ToString();
		this.lblCur_Strom.Text=model.Cur_Strom.ToString();
		this.lblCur_Sew.Text=model.Cur_Sew.ToString();
		this.lblMin_Level.Text=model.Min_Level.ToString();
		this.lblControl_Level.Text=model.Control_Level.ToString();
		this.lblWarnning_Level.Text=model.Warnning_Level.ToString();
		this.lblS_Invert.Text=model.S_Invert.ToString();
		this.lblPSize.Text=model.PSize;
		this.lblOverOutfallID.Text=model.OverOutfallID;
		this.lblTel.Text=model.Tel;
		this.lblForebayLen.Text=model.ForebayLen.ToString();
		this.lblForebayWid.Text=model.ForebayWid.ToString();
		this.lblForebayDep.Text=model.ForebayDep.ToString();
		this.lblCode.Text=model.Code;
		this.lblAddress.Text=model.Address;
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

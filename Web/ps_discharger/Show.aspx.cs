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
namespace Maticsoft.Web.ps_discharger
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
		Maticsoft.BLL.ps_discharger bll=new Maticsoft.BLL.ps_discharger();
		Maticsoft.Model.ps_discharger model=bll.GetModel(Exp_No);
		this.lblPrj_No.Text=model.Prj_No;
		this.lblPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.lblCode.Text=model.Code;
		this.lblAddress.Text=model.Address;
		this.lblName.Text=model.Name;
		this.lblCodeID.Text=model.CodeID;
		this.lblRepresentative.Text=model.Representative;
		this.lblTel.Text=model.Tel;
		this.lblManager.Text=model.Manager;
		this.lblLicence_ID.Text=model.Licence_ID;
		this.lblLicence_Issue_Date.Text=model.Licence_Issue_Date;
		this.lblSort.Text=model.Sort;
		this.lblConn_ManholeID.Text=model.Conn_ManholeID;
		this.lblBusiness.Text=model.Business;
		this.lblProcess.Text=model.Process;
		this.lblPollutant_Name.Text=model.Pollutant_Name;
		this.lblTreatment_Method.Text=model.Treatment_Method;
		this.lblTreatment_Facilities.Text=model.Treatment_Facilities;
		this.lblTreatment_Capacity.Text=model.Treatment_Capacity.ToString();
		this.lblWater_Daily_Consumption.Text=model.Water_Daily_Consumption.ToString();
		this.lblWater_Self_Supply_Daily.Text=model.Water_Self_Supply_Daily.ToString();
		this.lblWater_Discharge_Quantity.Text=model.Water_Discharge_Quantity.ToString();
		this.lblProduction_Waste_Quantity.Text=model.Production_Waste_Quantity.ToString();
		this.lblSanitary_Waste_Quantity.Text=model.Sanitary_Waste_Quantity.ToString();
		this.lblTemp.Text=model.Temp.ToString();
		this.lblpH.Text=model.pH.ToString();
		this.lblSS.Text=model.SS.ToString();
		this.lblBOD5.Text=model.BOD5.ToString();
		this.lblCODcr.Text=model.CODcr.ToString();
		this.lblNH3_N.Text=model.NH3_N.ToString();
		this.lblTN.Text=model.TN.ToString();
		this.lblTP.Text=model.TP.ToString();
		this.lblSunit.Text=model.Sunit;
		this.lblSdate.Text=model.Sdate;
		this.lblUpdateTime.Text=model.UpdateTime;
		this.lblNote.Text=model.Note;
		this.lblExp_NoOri.Text=model.Exp_NoOri;
		this.lblfilename.Text=model.filename;
		this.lblupdate.Text=model.update;

	}


    }
}

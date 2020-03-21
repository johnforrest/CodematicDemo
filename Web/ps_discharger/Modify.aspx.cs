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
namespace Maticsoft.Web.ps_discharger
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
		Maticsoft.BLL.ps_discharger bll=new Maticsoft.BLL.ps_discharger();
		Maticsoft.Model.ps_discharger model=bll.GetModel(Exp_No);
		this.txtPrj_No.Text=model.Prj_No;
		this.txtPrj_Name.Text=model.Prj_Name;
		this.lblExp_No.Text=model.Exp_No;
		this.txtCode.Text=model.Code;
		this.txtAddress.Text=model.Address;
		this.txtName.Text=model.Name;
		this.txtCodeID.Text=model.CodeID;
		this.txtRepresentative.Text=model.Representative;
		this.txtTel.Text=model.Tel;
		this.txtManager.Text=model.Manager;
		this.txtLicence_ID.Text=model.Licence_ID;
		this.txtLicence_Issue_Date.Text=model.Licence_Issue_Date;
		this.txtSort.Text=model.Sort;
		this.txtConn_ManholeID.Text=model.Conn_ManholeID;
		this.txtBusiness.Text=model.Business;
		this.txtProcess.Text=model.Process;
		this.txtPollutant_Name.Text=model.Pollutant_Name;
		this.txtTreatment_Method.Text=model.Treatment_Method;
		this.txtTreatment_Facilities.Text=model.Treatment_Facilities;
		this.txtTreatment_Capacity.Text=model.Treatment_Capacity.ToString();
		this.txtWater_Daily_Consumption.Text=model.Water_Daily_Consumption.ToString();
		this.txtWater_Self_Supply_Daily.Text=model.Water_Self_Supply_Daily.ToString();
		this.txtWater_Discharge_Quantity.Text=model.Water_Discharge_Quantity.ToString();
		this.txtProduction_Waste_Quantity.Text=model.Production_Waste_Quantity.ToString();
		this.txtSanitary_Waste_Quantity.Text=model.Sanitary_Waste_Quantity.ToString();
		this.txtTemp.Text=model.Temp.ToString();
		this.txtpH.Text=model.pH.ToString();
		this.txtSS.Text=model.SS.ToString();
		this.txtBOD5.Text=model.BOD5.ToString();
		this.txtCODcr.Text=model.CODcr.ToString();
		this.txtNH3_N.Text=model.NH3_N.ToString();
		this.txtTN.Text=model.TN.ToString();
		this.txtTP.Text=model.TP.ToString();
		this.txtSunit.Text=model.Sunit;
		this.txtSdate.Text=model.Sdate;
		this.txtUpdateTime.Text=model.UpdateTime;
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
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtCodeID.Text.Trim().Length==0)
			{
				strErr+="CodeID不能为空！\\n";	
			}
			if(this.txtRepresentative.Text.Trim().Length==0)
			{
				strErr+="Representative不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="Tel不能为空！\\n";	
			}
			if(this.txtManager.Text.Trim().Length==0)
			{
				strErr+="Manager不能为空！\\n";	
			}
			if(this.txtLicence_ID.Text.Trim().Length==0)
			{
				strErr+="Licence_ID不能为空！\\n";	
			}
			if(this.txtLicence_Issue_Date.Text.Trim().Length==0)
			{
				strErr+="Licence_Issue_Date不能为空！\\n";	
			}
			if(this.txtSort.Text.Trim().Length==0)
			{
				strErr+="Sort不能为空！\\n";	
			}
			if(this.txtConn_ManholeID.Text.Trim().Length==0)
			{
				strErr+="Conn_ManholeID不能为空！\\n";	
			}
			if(this.txtBusiness.Text.Trim().Length==0)
			{
				strErr+="Business不能为空！\\n";	
			}
			if(this.txtProcess.Text.Trim().Length==0)
			{
				strErr+="Process不能为空！\\n";	
			}
			if(this.txtPollutant_Name.Text.Trim().Length==0)
			{
				strErr+="Pollutant_Name不能为空！\\n";	
			}
			if(this.txtTreatment_Method.Text.Trim().Length==0)
			{
				strErr+="Treatment_Method不能为空！\\n";	
			}
			if(this.txtTreatment_Facilities.Text.Trim().Length==0)
			{
				strErr+="Treatment_Facilities不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTreatment_Capacity.Text))
			{
				strErr+="Treatment_Capacity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWater_Daily_Consumption.Text))
			{
				strErr+="Water_Daily_Consumption格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWater_Self_Supply_Daily.Text))
			{
				strErr+="Water_Self_Supply_Daily格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWater_Discharge_Quantity.Text))
			{
				strErr+="Water_Discharge_Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtProduction_Waste_Quantity.Text))
			{
				strErr+="Production_Waste_Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSanitary_Waste_Quantity.Text))
			{
				strErr+="Sanitary_Waste_Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTemp.Text))
			{
				strErr+="Temp格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpH.Text))
			{
				strErr+="pH格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSS.Text))
			{
				strErr+="SS格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBOD5.Text))
			{
				strErr+="BOD5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCODcr.Text))
			{
				strErr+="CODcr格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNH3_N.Text))
			{
				strErr+="NH3_N格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTN.Text))
			{
				strErr+="TN格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTP.Text))
			{
				strErr+="TP格式错误！\\n";	
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
			string Code=this.txtCode.Text;
			string Address=this.txtAddress.Text;
			string Name=this.txtName.Text;
			string CodeID=this.txtCodeID.Text;
			string Representative=this.txtRepresentative.Text;
			string Tel=this.txtTel.Text;
			string Manager=this.txtManager.Text;
			string Licence_ID=this.txtLicence_ID.Text;
			string Licence_Issue_Date=this.txtLicence_Issue_Date.Text;
			string Sort=this.txtSort.Text;
			string Conn_ManholeID=this.txtConn_ManholeID.Text;
			string Business=this.txtBusiness.Text;
			string Process=this.txtProcess.Text;
			string Pollutant_Name=this.txtPollutant_Name.Text;
			string Treatment_Method=this.txtTreatment_Method.Text;
			string Treatment_Facilities=this.txtTreatment_Facilities.Text;
			decimal Treatment_Capacity=decimal.Parse(this.txtTreatment_Capacity.Text);
			decimal Water_Daily_Consumption=decimal.Parse(this.txtWater_Daily_Consumption.Text);
			decimal Water_Self_Supply_Daily=decimal.Parse(this.txtWater_Self_Supply_Daily.Text);
			decimal Water_Discharge_Quantity=decimal.Parse(this.txtWater_Discharge_Quantity.Text);
			decimal Production_Waste_Quantity=decimal.Parse(this.txtProduction_Waste_Quantity.Text);
			decimal Sanitary_Waste_Quantity=decimal.Parse(this.txtSanitary_Waste_Quantity.Text);
			decimal Temp=decimal.Parse(this.txtTemp.Text);
			decimal pH=decimal.Parse(this.txtpH.Text);
			decimal SS=decimal.Parse(this.txtSS.Text);
			decimal BOD5=decimal.Parse(this.txtBOD5.Text);
			decimal CODcr=decimal.Parse(this.txtCODcr.Text);
			decimal NH3_N=decimal.Parse(this.txtNH3_N.Text);
			decimal TN=decimal.Parse(this.txtTN.Text);
			decimal TP=decimal.Parse(this.txtTP.Text);
			string Sunit=this.txtSunit.Text;
			string Sdate=this.txtSdate.Text;
			string UpdateTime=this.txtUpdateTime.Text;
			string Note=this.txtNote.Text;
			string Exp_NoOri=this.txtExp_NoOri.Text;
			string filename=this.txtfilename.Text;
			string update=this.txtupdate.Text;


			Maticsoft.Model.ps_discharger model=new Maticsoft.Model.ps_discharger();
			model.Prj_No=Prj_No;
			model.Prj_Name=Prj_Name;
			model.Exp_No=Exp_No;
			model.Code=Code;
			model.Address=Address;
			model.Name=Name;
			model.CodeID=CodeID;
			model.Representative=Representative;
			model.Tel=Tel;
			model.Manager=Manager;
			model.Licence_ID=Licence_ID;
			model.Licence_Issue_Date=Licence_Issue_Date;
			model.Sort=Sort;
			model.Conn_ManholeID=Conn_ManholeID;
			model.Business=Business;
			model.Process=Process;
			model.Pollutant_Name=Pollutant_Name;
			model.Treatment_Method=Treatment_Method;
			model.Treatment_Facilities=Treatment_Facilities;
			model.Treatment_Capacity=Treatment_Capacity;
			model.Water_Daily_Consumption=Water_Daily_Consumption;
			model.Water_Self_Supply_Daily=Water_Self_Supply_Daily;
			model.Water_Discharge_Quantity=Water_Discharge_Quantity;
			model.Production_Waste_Quantity=Production_Waste_Quantity;
			model.Sanitary_Waste_Quantity=Sanitary_Waste_Quantity;
			model.Temp=Temp;
			model.pH=pH;
			model.SS=SS;
			model.BOD5=BOD5;
			model.CODcr=CODcr;
			model.NH3_N=NH3_N;
			model.TN=TN;
			model.TP=TP;
			model.Sunit=Sunit;
			model.Sdate=Sdate;
			model.UpdateTime=UpdateTime;
			model.Note=Note;
			model.Exp_NoOri=Exp_NoOri;
			model.filename=filename;
			model.update=update;

			Maticsoft.BLL.ps_discharger bll=new Maticsoft.BLL.ps_discharger();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

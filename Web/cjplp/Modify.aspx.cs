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
namespace Maticsoft.Web.cjplp
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
		Maticsoft.BLL.cjplp bll=new Maticsoft.BLL.cjplp();
		Maticsoft.Model.cjplp model=bll.GetModel(Exp_No);
		this.txtMapCode.Text=model.MapCode;
		this.txtStormSystem_ID.Text=model.StormSystem_ID;
		this.lblExp_No.Text=model.Exp_No;
		this.txtType.Text=model.Type;
		this.txtX.Text=model.X.ToString();
		this.txtY.Text=model.Y.ToString();
		this.txtHigh.Text=model.High.ToString();
		this.txtWellDeep.Text=model.WellDeep.ToString();
		this.txtOffset.Text=model.Offset;
		this.txtFeature.Text=model.Feature;
		this.txtSubsid.Text=model.Subsid;
		this.txtModel.Text=model.Model;
		this.txtWellPipes.Text=model.WellPipes;
		this.txtWellShape.Text=model.WellShape;
		this.txtWellSize.Text=model.WellSize;
		this.txtWellMaterial.Text=model.WellMaterial;
		this.txtWaterDeep.Text=model.WaterDeep.ToString();
		this.txtMudDeep.Text=model.MudDeep.ToString();
		this.txtInlet_Type.Text=model.Inlet_Type;
		this.txtOutfallType.Text=model.OutfallType;
		this.txtReceiveWater.Text=model.ReceiveWater;
		this.txtFlap.Text=model.Flap;
		this.txtFlap_Diameter.Text=model.Flap_Diameter.ToString();
		this.txtFlap_TopEle.Text=model.Flap_TopEle.ToString();
		this.txtFlap_BotEle.Text=model.Flap_BotEle.ToString();
		this.txtFlap_Material.Text=model.Flap_Material;
		this.txtAddress.Text=model.Address;
		this.txtPointPosition.Text=model.PointPosition;
		this.txtDataSource.Text=model.DataSource;
		this.txtVisibility.Text=model.Visibility;
		this.txtSdate.Text=model.Sdate;
		this.txtMdate.Text=model.Mdate;
		this.txtManhole_Type.Text=model.Manhole_Type;
		this.txtstatus.Text=model.status;
		this.txtNote.Text=model.Note;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMapCode.Text.Trim().Length==0)
			{
				strErr+="MapCode不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtWellDeep.Text))
			{
				strErr+="WellDeep格式错误！\\n";	
			}
			if(this.txtOffset.Text.Trim().Length==0)
			{
				strErr+="Offset不能为空！\\n";	
			}
			if(this.txtFeature.Text.Trim().Length==0)
			{
				strErr+="Feature不能为空！\\n";	
			}
			if(this.txtSubsid.Text.Trim().Length==0)
			{
				strErr+="Subsid不能为空！\\n";	
			}
			if(this.txtModel.Text.Trim().Length==0)
			{
				strErr+="Model不能为空！\\n";	
			}
			if(this.txtWellPipes.Text.Trim().Length==0)
			{
				strErr+="WellPipes不能为空！\\n";	
			}
			if(this.txtWellShape.Text.Trim().Length==0)
			{
				strErr+="WellShape不能为空！\\n";	
			}
			if(this.txtWellSize.Text.Trim().Length==0)
			{
				strErr+="WellSize不能为空！\\n";	
			}
			if(this.txtWellMaterial.Text.Trim().Length==0)
			{
				strErr+="WellMaterial不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWaterDeep.Text))
			{
				strErr+="WaterDeep格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMudDeep.Text))
			{
				strErr+="MudDeep格式错误！\\n";	
			}
			if(this.txtInlet_Type.Text.Trim().Length==0)
			{
				strErr+="Inlet_Type不能为空！\\n";	
			}
			if(this.txtOutfallType.Text.Trim().Length==0)
			{
				strErr+="OutfallType不能为空！\\n";	
			}
			if(this.txtReceiveWater.Text.Trim().Length==0)
			{
				strErr+="ReceiveWater不能为空！\\n";	
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
			if(this.txtFlap_Material.Text.Trim().Length==0)
			{
				strErr+="Flap_Material不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtPointPosition.Text.Trim().Length==0)
			{
				strErr+="PointPosition不能为空！\\n";	
			}
			if(this.txtDataSource.Text.Trim().Length==0)
			{
				strErr+="DataSource不能为空！\\n";	
			}
			if(this.txtVisibility.Text.Trim().Length==0)
			{
				strErr+="Visibility不能为空！\\n";	
			}
			if(this.txtSdate.Text.Trim().Length==0)
			{
				strErr+="Sdate不能为空！\\n";	
			}
			if(this.txtMdate.Text.Trim().Length==0)
			{
				strErr+="Mdate不能为空！\\n";	
			}
			if(this.txtManhole_Type.Text.Trim().Length==0)
			{
				strErr+="Manhole_Type不能为空！\\n";	
			}
			if(this.txtstatus.Text.Trim().Length==0)
			{
				strErr+="status不能为空！\\n";	
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
			string MapCode=this.txtMapCode.Text;
			string StormSystem_ID=this.txtStormSystem_ID.Text;
			string Exp_No=this.lblExp_No.Text;
			string Type=this.txtType.Text;
			decimal X=decimal.Parse(this.txtX.Text);
			decimal Y=decimal.Parse(this.txtY.Text);
			decimal High=decimal.Parse(this.txtHigh.Text);
			decimal WellDeep=decimal.Parse(this.txtWellDeep.Text);
			string Offset=this.txtOffset.Text;
			string Feature=this.txtFeature.Text;
			string Subsid=this.txtSubsid.Text;
			string Model=this.txtModel.Text;
			string WellPipes=this.txtWellPipes.Text;
			string WellShape=this.txtWellShape.Text;
			string WellSize=this.txtWellSize.Text;
			string WellMaterial=this.txtWellMaterial.Text;
			decimal WaterDeep=decimal.Parse(this.txtWaterDeep.Text);
			decimal MudDeep=decimal.Parse(this.txtMudDeep.Text);
			string Inlet_Type=this.txtInlet_Type.Text;
			string OutfallType=this.txtOutfallType.Text;
			string ReceiveWater=this.txtReceiveWater.Text;
			string Flap=this.txtFlap.Text;
			decimal Flap_Diameter=decimal.Parse(this.txtFlap_Diameter.Text);
			decimal Flap_TopEle=decimal.Parse(this.txtFlap_TopEle.Text);
			decimal Flap_BotEle=decimal.Parse(this.txtFlap_BotEle.Text);
			string Flap_Material=this.txtFlap_Material.Text;
			string Address=this.txtAddress.Text;
			string PointPosition=this.txtPointPosition.Text;
			string DataSource=this.txtDataSource.Text;
			string Visibility=this.txtVisibility.Text;
			string Sdate=this.txtSdate.Text;
			string Mdate=this.txtMdate.Text;
			string Manhole_Type=this.txtManhole_Type.Text;
			string status=this.txtstatus.Text;
			string Note=this.txtNote.Text;


			Maticsoft.Model.cjplp model=new Maticsoft.Model.cjplp();
			model.MapCode=MapCode;
			model.StormSystem_ID=StormSystem_ID;
			model.Exp_No=Exp_No;
			model.Type=Type;
			model.X=X;
			model.Y=Y;
			model.High=High;
			model.WellDeep=WellDeep;
			model.Offset=Offset;
			model.Feature=Feature;
			model.Subsid=Subsid;
			model.Model=Model;
			model.WellPipes=WellPipes;
			model.WellShape=WellShape;
			model.WellSize=WellSize;
			model.WellMaterial=WellMaterial;
			model.WaterDeep=WaterDeep;
			model.MudDeep=MudDeep;
			model.Inlet_Type=Inlet_Type;
			model.OutfallType=OutfallType;
			model.ReceiveWater=ReceiveWater;
			model.Flap=Flap;
			model.Flap_Diameter=Flap_Diameter;
			model.Flap_TopEle=Flap_TopEle;
			model.Flap_BotEle=Flap_BotEle;
			model.Flap_Material=Flap_Material;
			model.Address=Address;
			model.PointPosition=PointPosition;
			model.DataSource=DataSource;
			model.Visibility=Visibility;
			model.Sdate=Sdate;
			model.Mdate=Mdate;
			model.Manhole_Type=Manhole_Type;
			model.status=status;
			model.Note=Note;

			Maticsoft.BLL.cjplp bll=new Maticsoft.BLL.cjplp();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

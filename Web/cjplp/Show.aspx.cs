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
namespace Maticsoft.Web.cjplp
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
		Maticsoft.BLL.cjplp bll=new Maticsoft.BLL.cjplp();
		Maticsoft.Model.cjplp model=bll.GetModel(Exp_No);
		this.lblMapCode.Text=model.MapCode;
		this.lblStormSystem_ID.Text=model.StormSystem_ID;
		this.lblExp_No.Text=model.Exp_No;
		this.lblType.Text=model.Type;
		this.lblX.Text=model.X.ToString();
		this.lblY.Text=model.Y.ToString();
		this.lblHigh.Text=model.High.ToString();
		this.lblWellDeep.Text=model.WellDeep.ToString();
		this.lblOffset.Text=model.Offset;
		this.lblFeature.Text=model.Feature;
		this.lblSubsid.Text=model.Subsid;
		this.lblModel.Text=model.Model;
		this.lblWellPipes.Text=model.WellPipes;
		this.lblWellShape.Text=model.WellShape;
		this.lblWellSize.Text=model.WellSize;
		this.lblWellMaterial.Text=model.WellMaterial;
		this.lblWaterDeep.Text=model.WaterDeep.ToString();
		this.lblMudDeep.Text=model.MudDeep.ToString();
		this.lblInlet_Type.Text=model.Inlet_Type;
		this.lblOutfallType.Text=model.OutfallType;
		this.lblReceiveWater.Text=model.ReceiveWater;
		this.lblFlap.Text=model.Flap;
		this.lblFlap_Diameter.Text=model.Flap_Diameter.ToString();
		this.lblFlap_TopEle.Text=model.Flap_TopEle.ToString();
		this.lblFlap_BotEle.Text=model.Flap_BotEle.ToString();
		this.lblFlap_Material.Text=model.Flap_Material;
		this.lblAddress.Text=model.Address;
		this.lblPointPosition.Text=model.PointPosition;
		this.lblDataSource.Text=model.DataSource;
		this.lblVisibility.Text=model.Visibility;
		this.lblSdate.Text=model.Sdate;
		this.lblMdate.Text=model.Mdate;
		this.lblManhole_Type.Text=model.Manhole_Type;
		this.lblstatus.Text=model.status;
		this.lblNote.Text=model.Note;

	}


    }
}

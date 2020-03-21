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
namespace Maticsoft.Web.cjpll
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		this.lblStormSystem_ID.Text=model.StormSystem_ID;
		this.lblS_Point.Text=model.S_Point;
		this.lblS_Deep.Text=model.S_Deep.ToString();
		this.lblS_Elev.Text=model.S_Elev.ToString();
		this.lblE_Point.Text=model.E_Point;
		this.lblE_Deep.Text=model.E_Deep.ToString();
		this.lblE_Elev.Text=model.E_Elev.ToString();
		this.lblType.Text=model.Type;
		this.lblPressure_Type.Text=model.Pressure_Type;
		this.lblInvert_Silphon.Text=model.Invert_Silphon;
		this.lblMaterial.Text=model.Material;
		this.lblShapeType.Text=model.ShapeType;
		this.lblGrade.Text=model.Grade;
		this.lblPsize.Text=model.Psize;
		this.lblFlowDir.Text=model.FlowDir;
		this.lblConduitStyle.Text=model.ConduitStyle;
		this.lblAddress.Text=model.Address;
		this.lblDataSource.Text=model.DataSource;
		this.lblSdate.Text=model.Sdate;
		this.lblMdate.Text=model.Mdate;
		this.lblPipe_Type.Text=model.Pipe_Type;
		this.lblStatus.Text=model.Status;
		this.lblNote.Text=model.Note;

	}


    }
}

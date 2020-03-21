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
namespace Maticsoft.Web.streetno
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
					int number=(Convert.ToInt32(strid));
					ShowInfo(number);
				}
			}
		}
		
	private void ShowInfo(int number)
	{
		Maticsoft.BLL.streetno bll=new Maticsoft.BLL.streetno();
		Maticsoft.Model.streetno model=bll.GetModel(number);
		this.lblnumber.Text=model.number.ToString();
		this.lblstrname.Text=model.strname;
		this.lblstrno.Text=model.strno;
		this.lblstrnolast5.Text=model.strnolast5;

	}


    }
}

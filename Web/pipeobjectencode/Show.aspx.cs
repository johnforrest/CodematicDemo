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
namespace Maticsoft.Web.pipeobjectencode
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
		Maticsoft.BLL.pipeobjectencode bll=new Maticsoft.BLL.pipeobjectencode();
		Maticsoft.Model.pipeobjectencode model=bll.GetModel(number);
		this.lblnumber.Text=model.number.ToString();
		this.lblobjcate.Text=model.objcate;
		this.lblcode.Text=model.code;
		this.lblobjname.Text=model.objname;
		this.lblnote.Text=model.note;
		this.lbltablename.Text=model.tablename;
		this.lblobjtype.Text=model.objtype;

	}


    }
}

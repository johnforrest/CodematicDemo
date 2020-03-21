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
namespace Maticsoft.Web.streetno
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int number=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(number);
				}
			}
		}
			
	private void ShowInfo(int number)
	{
		Maticsoft.BLL.streetno bll=new Maticsoft.BLL.streetno();
		Maticsoft.Model.streetno model=bll.GetModel(number);
		this.lblnumber.Text=model.number.ToString();
		this.txtstrname.Text=model.strname;
		this.txtstrno.Text=model.strno;
		this.txtstrnolast5.Text=model.strnolast5;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtstrname.Text.Trim().Length==0)
			{
				strErr+="strname不能为空！\\n";	
			}
			if(this.txtstrno.Text.Trim().Length==0)
			{
				strErr+="strno不能为空！\\n";	
			}
			if(this.txtstrnolast5.Text.Trim().Length==0)
			{
				strErr+="strnolast5不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int number=int.Parse(this.lblnumber.Text);
			string strname=this.txtstrname.Text;
			string strno=this.txtstrno.Text;
			string strnolast5=this.txtstrnolast5.Text;


			Maticsoft.Model.streetno model=new Maticsoft.Model.streetno();
			model.number=number;
			model.strname=strname;
			model.strno=strno;
			model.strnolast5=strnolast5;

			Maticsoft.BLL.streetno bll=new Maticsoft.BLL.streetno();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

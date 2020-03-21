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
namespace Maticsoft.Web.pipeobjectencode
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
		Maticsoft.BLL.pipeobjectencode bll=new Maticsoft.BLL.pipeobjectencode();
		Maticsoft.Model.pipeobjectencode model=bll.GetModel(number);
		this.lblnumber.Text=model.number.ToString();
		this.txtobjcate.Text=model.objcate;
		this.txtcode.Text=model.code;
		this.txtobjname.Text=model.objname;
		this.txtnote.Text=model.note;
		this.txttablename.Text=model.tablename;
		this.txtobjtype.Text=model.objtype;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtobjcate.Text.Trim().Length==0)
			{
				strErr+="objcate不能为空！\\n";	
			}
			if(this.txtcode.Text.Trim().Length==0)
			{
				strErr+="code不能为空！\\n";	
			}
			if(this.txtobjname.Text.Trim().Length==0)
			{
				strErr+="objname不能为空！\\n";	
			}
			if(this.txtnote.Text.Trim().Length==0)
			{
				strErr+="note不能为空！\\n";	
			}
			if(this.txttablename.Text.Trim().Length==0)
			{
				strErr+="tablename不能为空！\\n";	
			}
			if(this.txtobjtype.Text.Trim().Length==0)
			{
				strErr+="objtype不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int number=int.Parse(this.lblnumber.Text);
			string objcate=this.txtobjcate.Text;
			string code=this.txtcode.Text;
			string objname=this.txtobjname.Text;
			string note=this.txtnote.Text;
			string tablename=this.txttablename.Text;
			string objtype=this.txtobjtype.Text;


			Maticsoft.Model.pipeobjectencode model=new Maticsoft.Model.pipeobjectencode();
			model.number=number;
			model.objcate=objcate;
			model.code=code;
			model.objname=objname;
			model.note=note;
			model.tablename=tablename;
			model.objtype=objtype;

			Maticsoft.BLL.pipeobjectencode bll=new Maticsoft.BLL.pipeobjectencode();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

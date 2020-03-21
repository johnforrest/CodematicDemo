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
namespace Maticsoft.Web.sewpartition
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSewpartname.Text.Trim().Length==0)
			{
				strErr+="Sewpartname不能为空！\\n";	
			}
			if(this.txtcode.Text.Trim().Length==0)
			{
				strErr+="code不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Sewpartname=this.txtSewpartname.Text;
			string code=this.txtcode.Text;

			Maticsoft.Model.sewpartition model=new Maticsoft.Model.sewpartition();
			model.Sewpartname=Sewpartname;
			model.code=code;

			Maticsoft.BLL.sewpartition bll=new Maticsoft.BLL.sewpartition();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace Maticsoft.Web.rainpartition
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtrainpartname.Text.Trim().Length==0)
			{
				strErr+="rainpartname不能为空！\\n";	
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
			string rainpartname=this.txtrainpartname.Text;
			string code=this.txtcode.Text;

			Maticsoft.Model.rainpartition model=new Maticsoft.Model.rainpartition();
			model.rainpartname=rainpartname;
			model.code=code;

			Maticsoft.BLL.rainpartition bll=new Maticsoft.BLL.rainpartition();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

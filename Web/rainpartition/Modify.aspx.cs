﻿using System;
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
		Maticsoft.BLL.rainpartition bll=new Maticsoft.BLL.rainpartition();
		Maticsoft.Model.rainpartition model=bll.GetModel(number);
		this.lblnumber.Text=model.number.ToString();
		this.txtrainpartname.Text=model.rainpartname;
		this.txtcode.Text=model.code;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int number=int.Parse(this.lblnumber.Text);
			string rainpartname=this.txtrainpartname.Text;
			string code=this.txtcode.Text;


			Maticsoft.Model.rainpartition model=new Maticsoft.Model.rainpartition();
			model.number=number;
			model.rainpartname=rainpartname;
			model.code=code;

			Maticsoft.BLL.rainpartition bll=new Maticsoft.BLL.rainpartition();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

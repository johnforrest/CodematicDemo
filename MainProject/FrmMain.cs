using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProject.Forms;

namespace MainProject
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 导入Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemOpenExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSetServer frmSetServer = new FrmSetServer();
            frmSetServer.Show();
        }
    }
}

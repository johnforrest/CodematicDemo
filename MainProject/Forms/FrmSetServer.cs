using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MainProject.Forms
{
    public partial class FrmSetServer : Form
    {
        #region 全局变量

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        string sqlconnstr;

        #endregion 

        public FrmSetServer()
        {
            InitializeComponent();
            Load += new EventHandler(SetServer_Load);
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SetServer_Load(object sender, EventArgs e)
        {
            Init();
            Evenhand();
        }


        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        void Init()
        {
            AcceptButton = bt_Conn_Test;
            MaximizeBox = false;
            MaximumSize = MinimumSize = Size;
        }

        #endregion

        #region 事件源绑定

        /// <summary>
        /// 事件源绑定
        /// </summary>
        void Evenhand()
        {
            //单选按钮
            // rd_SqlServer.Click += new EventHandler(rd_Click);
            // rd_Windows.Click += new EventHandler(rd_Click);
            //按钮
            bt_Conn_Test.Click += new EventHandler(bt_Click);
            bt_Login.Click += new EventHandler(bt_Click);
        }

        #endregion


        #region 控件事件

        #region 选中单选按钮

        /// <summary>
        /// 选中单选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rd_Click(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "rd_Windows":
                    lb_Uid.Enabled = false;
                    lb_Pwd.Enabled = false;
                    txt_Uid.Enabled = false;
                    txt_Pwd.Enabled = false;
                    break;
                case "rd_SqlServer":
                    lb_Uid.Enabled = true;
                    lb_Pwd.Enabled = true;
                    txt_Uid.Enabled = true;
                    txt_Pwd.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 单击按钮

        /// <summary>
        /// 单击按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bt_Click(object sender, EventArgs e)
        {
            if (txt_Server.Text.Trim().Length == 0)
            {
                MessageBox.Show("服务器地址为空！");
                return;
            }


            if (txt_Uid.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名为空！");
                return;
            }

            if (txt_Pwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("密码为空！");
                return;
            }


            switch ((sender as Button).Name)
            {
                case "bt_Conn_Test": //测试连接
                    bt_Login.Enabled = false;
                    string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
                    using (MySqlConnection conn = new MySqlConnection(_connectionString))
                    {
                        try
                        {
                            sqlconnstr = conn.ConnectionString;
                            conn.Open();
                            bt_Login.Enabled = true;
                            AcceptButton = bt_Login;
                        }
                        catch
                        {
                            MessageBox.Show("服务器连接失败!");
                        }
                    }


                    break;
                case "bt_Login":
                    //登陆
                    FrmOpenExcel show = new FrmOpenExcel(sqlconnstr);
                    // FrmReadExcel show = new FrmReadExcel(sqlconnstr);
                    show.Show();
                    Hide();
                    break;
                default:
                    break;
            }
        }




        #endregion

        #endregion

        private void bt_Login_Click(object sender, EventArgs e)
        {

        }
    }
}

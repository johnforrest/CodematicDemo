using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maticsoft.DBUtility;
using Maticsoft.DAL;

namespace MainProject.Forms
{
    public partial class FrmOpenExcel : Form
    {
        //字符串连接对象
        private string connstr;
        private string excelPath;

        public FrmOpenExcel()
        {
            InitializeComponent();
        }


        public FrmOpenExcel(string _connstr) : this()
        {
            connstr = _connstr;
        }


        private void simpleButtonOpenExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel2007(*.xlsx)|*.xlsx|Excel2003(*.xls)|*.xls|WPS表格(*.et)|*.et|所有文件(*.*)|*.*";
                open.ShowDialog(); //选择文件
                textBoxXExcelPath.Text = open.FileName;
                excelPath = open.FileName;
                string[] sheetArr = GetExcelSheetNames(open.FileName);
                for (int i = 0; i < sheetArr.Length; i++)
                {
                    this.listBoxControlSheetName.Items.Add(sheetArr[i]);
                }

                // ReadExcel(open.FileName, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 上传excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonUpLoad_Click(object sender, EventArgs e)
        {
            //todo：点表名称写死了
            DataSet dataSet = ExcelToDataSet(excelPath, "点表");
            DataTable dataTable = dataSet.Tables[0];
            int test = 0;
            foreach (DataRow dataTableRow in dataTable.Rows)
            {
                cjplp cjplpDAL = new cjplp();
                Maticsoft.Model.cjplp cjplpModel = cjplpDAL.DataRowToModel(dataTableRow);
                cjplpDAL.Add(cjplpModel);
            }

            Console.WriteLine("添加test行数据" + test);
        }

        /// <summary>
        /// 读取excel转换为Dataset
        /// </summary>
        /// <param name="filePath">excel路径</param>
        /// <param name="TABLENAME">sheet名称</param>
        /// <returns></returns>
        public DataSet ExcelToDataSet(string filePath, string TABLENAME)
        {
            try
            {
                //此连接只能操作Excel2007之前(.xls)文件
                // string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" +"Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                //此连接可以操作.xls与.xlsx文件
                // string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filePath +";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'";
                string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filePath +
                                 ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();

                string strExcel = "";
                DataSet ds = new DataSet();

                strExcel = "select * from [" + TABLENAME + "$]";
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, "table1");

                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        /// <summary>
        /// 根据Excel物理路径获取Excel文件中所有表表单名
        /// </summary>
        /// <param name="excelFile">excel路径</param>
        /// <returns></returns>
        public String[] GetExcelSheetNames(string excelFile)

        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;
            try
            {
                //此连接只能操作Excel2007之前(.xls)文件
                // string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + excelFile + ";Extended Properties='Excel 8.0; HDR=NO; IMEX=1'";
                //此连接可以操作.xls与.xlsx文件
                // string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + excelFile +";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'";
                string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + excelFile +
                                 ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'";
                objConn = new OleDbConnection(strConn);
                objConn.Open();
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                return excelSheets;
            }
            catch
            {
                return null;
            }

            finally
            {
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }

                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
    }
}
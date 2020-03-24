using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
            //todo：1点表名称写死了，前端界面处理
            DataSet dataSet = ExcelToDataSet(excelPath, "点表");
            DataTable dataTable = dataSet.Tables[0];
            //todo：字段名称配置写死，和数据库保持一致
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("Uploadtime", typeof(string));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["FileName"] = Path.GetFileNameWithoutExtension(excelPath);

                dataTable.Rows[i]["Uploadtime"] = DateTime.Now.ToString();
            }


            foreach (DataRow dataTableRow in dataTable.Rows)
            {
                //yjw:监测字段类型
                // foreach (DataColumn col in dataTableRow.Table.Columns)
                // {
                //     Console.WriteLine(col.ColumnName);
                // }

                Maticsoft.DAL.cjplp cjplpDAL = new Maticsoft.DAL.cjplp();
                Maticsoft.Model.cjplp cjplpModel = cjplpDAL.DataRowToModel(dataTableRow);
                if (dataTableRow["Exp_NoOri"] != null)
                {
                    bool exist = cjplpDAL.Exists(dataTableRow["Exp_NoOri"].ToString());
                    if (!exist)
                    {
                        cjplpDAL.Add(cjplpModel);
                    }
                    else
                    {
                        //todo:2重复的数据，返回给用户
                    }
                }
            }

            //todo：1线表名称写死了，前端界面处理
            DataSet dataSetLine = ExcelToDataSet(excelPath, "线表");
            DataTable dataTableLine = dataSetLine.Tables[0];

            dataTableLine.Columns.Add("FileName", typeof(string));
            dataTableLine.Columns.Add("Uploadtime", typeof(string));
            for (int i = 0; i < dataTableLine.Rows.Count; i++)
            {
                dataTableLine.Rows[i]["FileName"] = Path.GetFileNameWithoutExtension(excelPath);

                dataTableLine.Rows[i]["Uploadtime"] = DateTime.Now.ToString();
            }

            foreach (DataRow dataTableRow in dataTableLine.Rows)
            {
                Maticsoft.DAL.cjpll cjpllDAL = new Maticsoft.DAL.cjpll();
                Maticsoft.Model.cjpll cjplpModel = cjpllDAL.DataRowToModel(dataTableRow);
                if (dataTableRow["Exp_No0"] != null && dataTableRow["Exp_No1"] != null)
                {
                    bool exist = cjpllDAL.Exists(dataTableRow["Exp_No0"].ToString(),
                        dataTableRow["Exp_No1"].ToString());
                    if (!exist)
                    {
                        cjpllDAL.Add(cjplpModel);
                    }
                    else
                    {
                        //todo:2重复的数据，返回给用户
                    }
                }
            }

            //MessageBox.Show("管点添加成功！");
            DialogResult dr = MessageBox.Show("数据上传完成，请进行数据编码", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                //点确定的代码关闭此窗体
                this.Close();
            }

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
                //todo：此处的table1写死
                // myCommand.Fill(ds, "table1");
                myCommand.Fill(ds, TABLENAME);

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
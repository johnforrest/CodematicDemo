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
using Maticsoft.Model;

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

        #region 打开Excel

        /// <summary>
        /// 打开Excel路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonOpenExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //1.打开Excel
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel2007(*.xlsx)|*.xlsx|Excel2003(*.xls)|*.xls|WPS表格(*.et)|*.et|所有文件(*.*)|*.*";
                open.ShowDialog(); //选择文件
                textBoxXExcelPath.Text = open.FileName;
                excelPath = open.FileName;
                //设置ListBox
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
        /// 根据Excel物理路径获取Excel文件中所有表表单名
        /// </summary>
        /// <param name="excelFile">excel路径</param>
        /// <returns></returns>
        public String[] GetExcelSheetNames(string excelFile)

        {
            OleDbConnection objConn = null;
            DataTable dt = null;
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

        #endregion

        #region 上传Excel

        /// <summary>
        /// 上传excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonUpLoad_Click(object sender, EventArgs e)
        {
            if (UpLoadPointSheet()) return;

            if (UpLoadLineSheet())
            {
                return;
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
        /// 上传线表
        /// </summary>
        private bool UpLoadLineSheet()
        {
            if (String.IsNullOrEmpty(this.textEditLineSheet.Text))
            {
                MessageBox.Show("线表表单为空！请选择点表", "提示");
                return true;
            }

            DataSet dataSetLine = ExcelToDataSet(excelPath, this.textEditLineSheet.Text.Trim());
            DataTable dataTableLine = dataSetLine.Tables[0];

            dataTableLine.Columns.Add("FileName", typeof(string));
            dataTableLine.Columns.Add("Uploadtime", typeof(string));
            for (int i = 0; i < dataTableLine.Rows.Count; i++)
            {
                dataTableLine.Rows[i]["FileName"] = Path.GetFileNameWithoutExtension(excelPath);

                dataTableLine.Rows[i]["Uploadtime"] = DateTime.Now.ToString();
            }

            Maticsoft.BLL.cjpll cjpllBLL = new Maticsoft.BLL.cjpll();
            List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.DataTableToList(dataTableLine);

            Maticsoft.BLL.cjpllback cjpllBackBLL = new Maticsoft.BLL.cjpllback();
            List<Maticsoft.Model.cjpllback> cjplpBackModelList = cjpllBackBLL.DataTableToList(dataTableLine);

            Maticsoft.BLL.exportinfo exportinfoBLL = new Maticsoft.BLL.exportinfo();
            Maticsoft.Model.exportinfo exportinfoModel = new Maticsoft.Model.exportinfo();

            for (int i = 0; i < cjpllModelList.Count; i++)
            {
                List<Maticsoft.Model.exportinfo> exportinfosModelList = exportinfoBLL.GetModelList("");

                //不重复的数据
                if (!cjpllBLL.Exists(cjpllModelList[i].Exp_No0,cjpllModelList[i].Exp_No1))
                {
                    cjpllBLL.Add(cjpllModelList[i]);

                   
                }else
                {
                    //备份的数据库中，不重复的数据，则插入，否则，则更新
                    if (!cjpllBackBLL.Exists(cjpllModelList[i].Exp_No0,cjpllModelList[i].Exp_No1))
                    {
                        cjpllBackBLL.Add(cjplpBackModelList[i]);
                    }
                    else
                    {
                        cjpllBackBLL.Update(cjplpBackModelList[i]);
                    }
                }

                //导出配置表（exportinfo）中有配置数据，则对比
                if (exportinfosModelList.Count > 0)
                {
                    Int32 flag = 0;
                    //导出表的配置
                    for (int j = 0; j < exportinfosModelList.Count; j++)
                    {
                        if (exportinfosModelList[j].Address != cjpllModelList[i].Address
                            || !cjpllModelList[i].FileName.Contains(exportinfosModelList[j].Basin)
                            || !cjpllModelList[i].FileName.Contains(exportinfosModelList[j].Strname)
                            || !cjpllModelList[i].FileName.Contains(exportinfosModelList[j].Plot))
                        {
                            flag++;
                        }
                    }

                    if (flag==exportinfosModelList.Count)
                    {
                        string[] tempArr = cjpllModelList[i].FileName.Split('-');
                        //导出配置表（exportinfo）中没有配置数据，则直接插入
                        exportinfoModel.Address = cjpllModelList[i].Address;
                        exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                        exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                        exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                        exportinfoBLL.Add(exportinfoModel);
                    }
                }
                else
                {
                    string[] tempArr = cjpllModelList[i].FileName.Split('-');
                    //导出配置表（exportinfo）中没有配置数据，则直接插入
                    exportinfoModel.Address = cjpllModelList[i].Address;
                    exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                    exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                    exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                    exportinfoBLL.Add(exportinfoModel);
                }
            }

         

            return false;

        }

        /// <summary>
        /// 上传点表
        /// </summary>
        /// <returns></returns>
        private bool UpLoadPointSheet()
        {
            if (String.IsNullOrEmpty(this.textEditPointSheet.Text))
            {
                MessageBox.Show("点表表单为空！请选择点表", "提示");
                return true;
            }

            DataSet dataSet = ExcelToDataSet(excelPath, this.textEditPointSheet.Text.Trim());
            DataTable dataTable = dataSet.Tables[0];

            //1.填充数据名称和数据上传时间字段
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("Uploadtime", typeof(string));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["FileName"] = Path.GetFileNameWithoutExtension(excelPath);

                dataTable.Rows[i]["Uploadtime"] = DateTime.Now.ToString();
            }

            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<Maticsoft.Model.cjplp> cjplpModelList = cjplpBLL.DataTableToList(dataTable);

            Maticsoft.BLL.cjplpback cjplpBackBLL = new Maticsoft.BLL.cjplpback();
            List<Maticsoft.Model.cjplpback> cjplpBackModelList= cjplpBackBLL.DataTableToList(dataTable);

            Maticsoft.BLL.exportinfo exportinfoBLL = new Maticsoft.BLL.exportinfo();
            Maticsoft.Model.exportinfo exportinfoModel =new Maticsoft.Model.exportinfo(); 

            for (int i = 0; i < cjplpModelList.Count; i++)
            {
                List<Maticsoft.Model.exportinfo> exportinfosModelList = exportinfoBLL.GetModelList("");

                //不重复的数据
                if (!cjplpBLL.Exists(cjplpModelList[i].Exp_NoOri))
                {
                    //点表不重复的数据，直接插入
                    cjplpBLL.Add(cjplpModelList[i]);

                }
                else
                {
                    //备份的数据库中，不重复的数据，则插入，否则，则更新
                    if (!cjplpBackBLL.Exists(cjplpModelList[i].Exp_NoOri))
                    {
                        cjplpBackBLL.Add(cjplpBackModelList[i]);
                    }
                    else
                    {
                        cjplpBackBLL.Update(cjplpBackModelList[i]);
                    }
                }

                //导出配置表（exportinfo）中有配置数据，则对比
                if (exportinfosModelList.Count > 0)
                {
                    Int32 flag = 0;
                    //导出表的配置
                    for (int j = 0; j < exportinfosModelList.Count; j++)
                    {
                        if (exportinfosModelList[j].Address != cjplpModelList[i].Address
                            || !cjplpModelList[i].FileName.Contains(exportinfosModelList[j].Basin)
                            || !cjplpModelList[i].FileName.Contains(exportinfosModelList[j].Strname)
                            || !cjplpModelList[i].FileName.Contains(exportinfosModelList[j].Plot))
                        {
                            flag++;
                        }

                        if (flag==exportinfosModelList.Count)
                        {
                            string[] tempArr = cjplpModelList[i].FileName.Split('-');
                            //导出配置表（exportinfo）中没有配置数据，则直接插入
                            exportinfoModel.Address = cjplpModelList[i].Address;
                            exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                            exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                            exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                            exportinfoBLL.Add(exportinfoModel);
                        }
                    }
                }
                else
                {
                    string[] tempArr = cjplpModelList[i].FileName.Split('-');
                    //导出配置表（exportinfo）中没有配置数据，则直接插入
                    exportinfoModel.Address = cjplpModelList[i].Address;
                    exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                    exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                    exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                    exportinfoBLL.Add(exportinfoModel);
                }
            }

            return false;
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

                // strExcel = "select * from [" + TABLENAME + "$]";
                strExcel = "select * from [" + TABLENAME + "]";
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

        #endregion
        /// <summary>
        /// 选择点表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectPoint_Click(object sender, EventArgs e)
        {
            this.textEditPointSheet.Text = this.listBoxControlSheetName.SelectedItem.ToString();
        }
        /// <summary>
        /// 选择线表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectLine_Click(object sender, EventArgs e)
        {
            this.textEditLineSheet.Text = this.listBoxControlSheetName.SelectedItem.ToString();
        }
        /// <summary>
        /// 清除点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonClearPoint_Click(object sender, EventArgs e)
        {
            this.textEditPointSheet.Text = string.Empty;
        }
        /// <summary>
        /// 清除线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonClearLine_Click(object sender, EventArgs e)
        {
            this.textEditLineSheet.Text = string.Empty;
        }
    }
}
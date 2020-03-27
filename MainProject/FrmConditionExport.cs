using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using MainProject.ImplementClasses;
using Maticsoft.BLL;

namespace MainProject
{
    public partial class FrmConditionExport : Form
    {
        public FrmConditionExport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConditionExport_Load(object sender, EventArgs e)
        {
            asynExportInofTable();
        }

        /// <summary>
        /// 同步导出记录表的内容
        /// </summary>
        private void asynExportInofTable()
        {
            List<string> listAddress = new List<string>();
            List<string> listBasin = new List<string>();
            List<string> listStrName = new List<string>();
            List<string> listPlot = new List<string>();

            Maticsoft.BLL.exportinfo exportinfoBLL = new Maticsoft.BLL.exportinfo();
            List<Maticsoft.Model.exportinfo> exportinfosModelList = exportinfoBLL.GetModelList("");
            for (int i = 0; i < exportinfosModelList.Count; i++)
            {
                if (!listAddress.Contains(exportinfosModelList[i].Address))
                {
                    listAddress.Add(exportinfosModelList[i].Address);
                }

                if (!listBasin.Contains(exportinfosModelList[i].Basin))
                {
                    listBasin.Add(exportinfosModelList[i].Basin);
                }

                if (!listStrName.Contains(exportinfosModelList[i].Strname))
                {
                    listStrName.Add(exportinfosModelList[i].Strname);
                }

                if (!listPlot.Contains(exportinfosModelList[i].Plot))
                {
                    listPlot.Add(exportinfosModelList[i].Plot);
                }
            }

            this.listBoxControlAddres.DataSource = listAddress;
            this.listBoxControlBasin.DataSource = listBasin;
            this.listBoxControlStrName.DataSource = listStrName;
            this.listBoxControlPlot.DataSource = listPlot;
        }

        #region 条件导出

        /// <summary>
        /// 导出mdb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonExportMDB_Click(object sender, EventArgs e)
        {
            string mdbPath = "";
            //1.创建mdb文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ArcGIS Personal Geodatabase文件|*.mdb|所有文件|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mdbPath = saveFileDialog.FileName;
            }

            if (String.IsNullOrEmpty(mdbPath))
            {
                MessageBox.Show("导出的ArcGIS Personal GeoDatabase路径为空！", "提示");
                return;
            }

            IFeatureWorkspace featureWorkspace = CreateMdbfile(mdbPath);

            //todo:管点，在mdb中创建各个表的类型
            string prjPath = Application.StartupPath + @"\prj\Xian 1980 3 Degree GK CM 114E.prj";
            CreateMDB createMdb = new CreateMDB();

            string resultsql = getSql();

            //1.生成特征点
            createMdb.CreatePS_POINT(featureWorkspace, prjPath, resultsql);
            //2.生成排放口
            createMdb.CreatePS_OUTFALL(featureWorkspace, prjPath, resultsql);
            //3.生成检查井
            createMdb.CreatePS_MANHOLE(featureWorkspace, prjPath, resultsql);

            //4.生成雨水口
            createMdb.CreatePS_COMB(featureWorkspace, prjPath, resultsql);
            //5.生成堰
            createMdb.CreatePS_WEIR(featureWorkspace, prjPath, resultsql);
            //6.生成闸门
            createMdb.CreatePS_GATE(featureWorkspace, prjPath, resultsql);
            //7.生成阀门
            createMdb.CreatePS_VALVE(featureWorkspace, prjPath, resultsql);
            //8.生成排水泵站
            createMdb.CreatePS_PUMPSTATION(featureWorkspace, prjPath, resultsql);
            //9.生成调蓄设施
            createMdb.CreatePS_RETENTION(featureWorkspace, prjPath, resultsql);

            //10.生成污水处理设施
            createMdb.CreatePS_WWTP(featureWorkspace, prjPath, resultsql);

            //11.生成排水户
            createMdb.CreatePS_DISCHARGER(featureWorkspace, prjPath, resultsql);

            //todo:12.生成雨水管线
            createMdb.CreatePS_PIPE(featureWorkspace, prjPath, resultsql);

            DialogResult dialogResult = MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 获取拼接的sql语句
        /// </summary>
        /// <returns></returns>
        private string getSql()
        {
            //构建sql语句
            string resultSql1 = string.Empty;
            if (this.listBoxControlTargetAddress.Items.Count > 0)
            {
                for (int i = 0; i < listBoxControlTargetAddress.Items.Count; i++)
                {
                    resultSql1 = "Address ='";
                    if (i == listBoxControlTargetAddress.Items.Count - 1)
                    {
                        resultSql1 += listBoxControlTargetAddress.Items[i].ToString() + "' and ";
                    }
                    else
                    {
                        resultSql1 += listBoxControlTargetAddress.Items[i].ToString() + "' or ";
                    }
                }
            }

            // Console.WriteLine("resultSql1" + resultSql1);

            string resultSql2 = string.Empty;
            if (this.listBoxControlTargetBasin.Items.Count > 0)
            {
                for (int i = 0; i < listBoxControlTargetBasin.Items.Count; i++)
                {
                    resultSql2 = "FileName like '";

                    if (listBoxControlTargetBasin.Items.Count - 1 == i)
                    {
                        resultSql2 += listBoxControlTargetBasin.Items[i].ToString() + "%' and ";
                    }
                    else
                    {
                        resultSql2 += listBoxControlTargetBasin.Items[i].ToString() + "%' or ";
                    }
                }
            }

            // Console.WriteLine("resultSql2" + resultSql2);


            string resultSql3 = string.Empty;
            if (this.listBoxControlTargetStrName.Items.Count > 0)
            {
                for (int i = 0; i < listBoxControlTargetStrName.Items.Count; i++)
                {
                    resultSql3 = "FileName like '%";

                    if (listBoxControlTargetStrName.Items.Count - 1 == i)
                    {
                        resultSql3 += listBoxControlTargetStrName.Items[i].ToString() + "%' and ";
                    }
                    else
                    {
                        resultSql3 += listBoxControlTargetStrName.Items[i].ToString() + "%' or ";
                    }
                }
            }

            // Console.WriteLine("resultSql3" + resultSql3);

            string resultSql4 = string.Empty;
            if (this.listBoxControlTargetPlot.Items.Count > 0)
            {
                for (int i = 0; i < listBoxControlTargetPlot.Items.Count; i++)
                {
                    resultSql4 = "FileName like '%";

                    if (listBoxControlTargetPlot.Items.Count - 1 == i)
                    {
                        resultSql4 += listBoxControlTargetPlot.Items[i].ToString() + "%'";
                    }
                    else
                    {
                        resultSql4 += listBoxControlTargetPlot.Items[i].ToString() + "%' or ";
                    }
                }
            }

            // Console.WriteLine("resultSql4" + resultSql4);

            string resultsql = resultSql1 + resultSql2 + resultSql3 + resultSql4;
            if (String.IsNullOrEmpty(resultSql4))
            {
                resultsql = resultsql.Substring(0, resultsql.LastIndexOf(" and "));
            }

            Console.WriteLine("哈哈哈" + resultsql);
            return resultsql;
        }

        /// <summary>
        /// 创建mdb文件
        /// </summary>
        /// <param name="strMdbFileName">mdb文件绝对</param>
        public IFeatureWorkspace CreateMdbfile(string strMdbFileName)
        {
            //文件不存在
            if (!File.Exists(strMdbFileName))
            {
                //test
                string mdbfileName = Path.GetFileNameWithoutExtension(strMdbFileName);
                //返回文件名 test.mdb
                string fileName = Path.GetFileName(strMdbFileName);
                //返回文件目录 f://temp
                string fileDirectory = Path.GetDirectoryName(strMdbFileName);
                if (mdbfileName == "")
                    return null;

                IWorkspaceFactory workspaceFactory = new AccessWorkspaceFactoryClass();
                IWorkspaceName workspaceName = workspaceFactory.Create(fileDirectory, mdbfileName, null, 0);
                IName name = workspaceName as IName;
                IWorkspace iWorkspace = (IWorkspace) name.Open();
                // return iWorkspace;
                IFeatureWorkspace pFeWs = iWorkspace as IFeatureWorkspace;

                return pFeWs;
                this.Close();
                this.Dispose();
            }
            else
            {
                //文件存在，则打开mdb
                IWorkspaceFactory pFactory = new AccessWorkspaceFactoryClass();
                IWorkspace pWorkspace = pFactory.OpenFromFile(strMdbFileName, 0);
                IFeatureWorkspace pFeatWorkspace = pWorkspace as IFeatureWorkspace;
                // IFeatureClass pFeatureClass = pFeatWorkspace.OpenFeatureClass("Water")
                return pFeatWorkspace;
            }
        }

        #endregion

        #region 选择和清空选择

        /// <summary>
        /// 选择地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectAddress_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.listBoxControlAddres.SelectedItem.ToString()))
            {
                this.listBoxControlTargetAddress.Items.Add(this.listBoxControlAddres.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// 选择流域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectBasin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.listBoxControlBasin.SelectedItem.ToString()))
            {
                this.listBoxControlTargetBasin.Items.Add(this.listBoxControlBasin.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// 选择街区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectStrName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.listBoxControlStrName.SelectedItem.ToString()))
            {
                this.listBoxControlTargetStrName.Items.Add(this.listBoxControlStrName.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// 选择地块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSelectPlot_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.listBoxControlPlot.SelectedItem.ToString()))
            {
                this.listBoxControlTargetPlot.Items.Add(this.listBoxControlPlot.SelectedItem.ToString());
            }
        }


        /// <summary>
        /// 清空所有选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonClearAllSelect_Click(object sender, EventArgs e)
        {
            if (listBoxControlTargetAddress.Items.Count > 0)
                listBoxControlTargetAddress.Items.Clear();
            if (listBoxControlTargetBasin.Items.Count > 0)
                listBoxControlTargetBasin.Items.Clear();
            if (listBoxControlTargetStrName.Items.Count > 0)
                listBoxControlTargetStrName.Items.Clear();
            if (listBoxControlTargetPlot.Items.Count > 0)
                listBoxControlTargetPlot.Items.Clear();
        }

        #endregion
    }
}
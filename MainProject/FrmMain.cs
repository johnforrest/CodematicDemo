using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using MainProject.Classes;
using MainProject.Factory;
using MainProject.Forms;
using MainProject.ImplementClasses;
using MainProject.Interfaces;
using MainProject.Properties;
using Maticsoft.BLL;
using Maticsoft.DBUtility;
using cjplp = Maticsoft.Model.cjplp;
using Path = System.IO.Path;
using PropertyInfo = System.Reflection.PropertyInfo;
// using IWorkspace = DevExpress.Utils.IWorkspace;
using recordtable = Maticsoft.Model.recordtable;

namespace MainProject
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly CreateMDB _createMdb;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //同步编码表
            // asynRecordTabl();
        }


        #region 数据导入模块

        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemConnectDB_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSetServer frmSetServer = new FrmSetServer();
            frmSetServer.Show();
        }

        /// <summary>
        /// 导入Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemOpenExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            // FrmSetServer frmSetServer = new FrmSetServer();
            // frmSetServer.Show();
            string _connectionString =
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
            FrmOpenExcel show = new FrmOpenExcel(_connectionString);
            show.Show();
        }

        /// <summary>
        /// 重复数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemRepeData_ItemClick(object sender, ItemClickEventArgs e)
        {
            //1.获取到待拆分的数据
            Maticsoft.BLL.cjplpback cjplpBackBLL = new Maticsoft.BLL.cjplpback();
            List<Maticsoft.Model.cjplpback> cjplpModelList = cjplpBackBLL.GetModelList("");
            this.gridControlPointTable.DataSource = cjplpModelList;

            //获取待拆分的线表数据
            Maticsoft.BLL.cjpllback cjpllBackBLL = new Maticsoft.BLL.cjpllback();
            List<Maticsoft.Model.cjpllback> cjpllModelList = cjpllBackBLL.GetModelList("");
            this.gridControlLineTable.DataSource = cjpllModelList;
        }

        /// <summary>
        /// 导出重复数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemExportRepe_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel2007文件|*.xlsx|Excel2003文件|*.xls|所有文件|*.*";
                if (saveDialog.ShowDialog() == DialogResult.Cancel) return;
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;
                ExportExcel.ExportToExcel(exportFilePath, true, "", gridControlPointTable, gridControlLineTable);
                // DevExpress.XtraPrinting.XlsxExportOptions xlsxExportOptions=new XlsxExportOptions(TextExportMode.Value,true,false,false);
                // switch (fileExtenstion)
                // {
                //     case ".xls":
                //         gridControlLineTable.ExportToXls(exportFilePath);
                //         gridControlPointTable.ExportToXls(exportFilePath);
                //         break;
                //     case ".xlsx":
                //         gridControlLineTable.ExportToXlsx(exportFilePath, xlsxExportOptions);
                //         gridControlPointTable.ExportToXlsx(exportFilePath, xlsxExportOptions);
                //         break;
                //         // case ".rtf":
                //         //     gridControlAttri.ExportToRtf(exportFilePath);
                //         //     break;
                //         // case ".pdf":
                //         //     gridControlAttri.ExportToPdf(exportFilePath);
                //         //     break;
                //         // case ".html":
                //         //     gridControlAttri.ExportToHtml(exportFilePath);
                //         //     break;
                //         // case ".mht":
                //         //     gridControlAttri.ExportToMht(exportFilePath);
                //         //     break;
                // }

                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("是否导出文件！", "提示", MessageBoxButtons.YesNo))
                        {
                            Process.Start(exportFilePath);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("文件导出错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("文件路径不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region 数据拆分模块

        /// <summary>
        /// 拆分数据 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemMergeData_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //todo：拆分点表
                //1.获取到待拆分的数据
                Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
                // string pointSqlStr = "select * from cjplp";
                List<cjplp> cjplpModelList = cjplpBLL.GetModelList("");

                pipeobjectencode pipeobjectencodeBLL = new pipeobjectencode();
                // string pipeobjectencode = "select * from pipeobjectencode";
                List<Maticsoft.Model.pipeobjectencode> pipeobjectencodesModelList =
                    pipeobjectencodeBLL.GetModelList("");

                JudgePoint judgePoint = new JudgePoint();
                for (int i = 0; i < cjplpModelList.Count; i++)
                {
                    //2.类型判断
                    //3.计算信息填充-点号信息和编码信息

                    //todo：管点号不为空或者为null-也就是必须进行编码
                    if (!String.IsNullOrEmpty(cjplpModelList[i].Exp_No))
                    {
                        //附属物不为空
                        if (cjplpModelList[i] != null && !String.IsNullOrEmpty(cjplpModelList[i].Subsid))
                        {
                            for (int j = 0; j < pipeobjectencodesModelList.Count; j++)
                            {
                                if (!String.IsNullOrEmpty(pipeobjectencodesModelList[j].objname) &&
                                    pipeobjectencodesModelList[j].objname == cjplpModelList[i].Subsid)
                                {
                                    //C#在运行时通过类的名称实例化一个类
                                    string className = "MainProject.ImplementClasses." +
                                                       pipeobjectencodesModelList[j].tablename + "Implements";
                                    Type t = Type.GetType(className);
                                    SplitTableInterface b1 = Activator.CreateInstance(t, cjplpModelList[i],
                                        pipeobjectencodesModelList[j].code) as SplitTableInterface;
                                    // judgePoint.judge(new PS_MANHOLEImplements(pipeobjectencodesModelList[j].objname, cjplpModelList[i]));
                                    judgePoint.judge(b1);
                                }
                            }
                        }
                        else if (cjplpModelList[i] != null && !String.IsNullOrEmpty(cjplpModelList[i].Feature))
                        {
                            //附属物为空，但是特征不为空

                            for (int j = 0; j < pipeobjectencodesModelList.Count; j++)
                            {
                                if (!String.IsNullOrEmpty(pipeobjectencodesModelList[j].objname) &&
                                    pipeobjectencodesModelList[j].objname == cjplpModelList[i].Feature)
                                {
                                    // string tempTableName = pipeobjectencodesModelList[j].tablename;

                                    //C#在运行时通过类的名称实例化一个类
                                    string className = "MainProject.ImplementClasses." +
                                                       pipeobjectencodesModelList[j].tablename + "Implements";
                                    Type t = Type.GetType(className);
                                    SplitTableInterface b1 = Activator.CreateInstance(t, cjplpModelList[i],
                                        pipeobjectencodesModelList[j].code) as SplitTableInterface;

                                    // judgePoint.judge(new PS_MANHOLEImplements(pipeobjectencodesModelList[j].objname, cjplpModelList[i]));
                                    judgePoint.judge(b1);
                                }
                            }
                        }
                        else
                        {
                            //todo:附属物、特征都为空
                        }
                    }
                }


                //todo：拆分线表
                cjpll cjpllBLL = new cjpll();
                List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.GetModelList("");
                List<Maticsoft.Model.pipeobjectencode> pipeobjectencodesLineModelList =
                    pipeobjectencodeBLL.GetModelList("objcate=0");

                for (int i = 0; i < cjpllModelList.Count; i++)
                {
                    //todo：管点号不为空或者为null-也就是必须进行编码
                    if (!String.IsNullOrEmpty(cjpllModelList[i].Lno))
                    {
                        for (int j = 0; j < pipeobjectencodesLineModelList.Count; j++)
                        {
                            if (cjpllModelList[i].Type.Contains(pipeobjectencodesLineModelList[j].objtype))
                            {
                                Console.WriteLine(pipeobjectencodesLineModelList[j].tablename);
                                //C#在运行时通过类的名称实例化一个类
                                string className = "MainProject.ImplementClasses." +
                                                   pipeobjectencodesLineModelList[j].tablename + "Implements";
                                Type t = Type.GetType(className);
                                SplitTableInterface b1 = Activator.CreateInstance(t, cjpllModelList[i],
                                    pipeobjectencodesLineModelList[j].code) as SplitTableInterface;

                                // judgePoint.judge(new PS_MANHOLEImplements(pipeobjectencodesLineModelList[j].objname, cjplpModelList[i]));
                                judgePoint.judge(b1);
                            }
                        }
                    }
                }


                MessageBox.Show("拆分成功！");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        #endregion

        #region 数据编码模块

        /// <summary>
        /// 同步编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemAsynCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            //同步编码表
            AsynData.asynRecordTabl();
        }

        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            CjplpCode();

            CjpllCode();

            MessageBox.Show("编码完成！", "提示");
        }

        /// <summary>
        /// 点编码
        /// </summary>
        private static void CjplpCode()
        {
            //街道的编码
            streetno streetnoBLL = new streetno();
            List<Maticsoft.Model.streetno> streetnoModeList = streetnoBLL.GetModelList("shortname is not NULL");

            //顺序编码表
            recordtable recordtableModel = new recordtable();
            Maticsoft.BLL.recordtable recordtableBll = new Maticsoft.BLL.recordtable();

            #region 点表编码

            //1.获取到待拆分的数据
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<cjplp> cjplpModelList = cjplpBLL.GetModelList("");

            for (int i = 0; i < cjplpModelList.Count; i++)
            {
                //编码不存在的情况下才进行编码，否则不进行编码
                if (cjplpModelList[i] != null && String.IsNullOrEmpty(cjplpModelList[i].Exp_No))
                {
                    //查询街道编码不为空的列
                    List<recordtable> recordtablesModelList =
                        recordtableBll.GetModelList("type like '" + cjplpModelList[i].Type.Substring(0, 2) + "%'");
                    //如果数据库中没有此编码，则进行第一次编码
                    if (recordtablesModelList.Count == 0)
                    {
                        for (int j = 0; j < streetnoModeList.Count; j++)
                        {
                            if (!String.IsNullOrEmpty(cjplpModelList[i].FileName)
                                && !String.IsNullOrEmpty(cjplpModelList[i].Type)
                                && !String.IsNullOrEmpty(cjplpModelList[i].Sdate)
                                && cjplpModelList[i].FileName.Contains(streetnoModeList[j].shortname))
                            {
                                //更新：给原始管点编号
                                cjplpModelList[i].Exp_No = cjplpModelList[i].Type.Substring(0, 2) +
                                                           cjplpModelList[i].Sdate.Substring(0, 4) +
                                                           streetnoModeList[j].strnolast5 + "0100001";
                                cjplpModelList[i].ExpNoTime =
                                    DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString();
                                cjplpBLL.Update(cjplpModelList[i]);

                                //添加：数据库记录文件
                                recordtableModel.type = cjplpModelList[i].Type.Substring(0, 2);
                                recordtableModel.year = cjplpModelList[i].Sdate.Substring(0, 4);
                                recordtableModel.strnolast5 = streetnoModeList[j].strnolast5;
                                recordtableModel.inteno = 1;
                                recordtableModel.serino = 1;
                                recordtableModel.typeYear = cjplpModelList[i].Type.Substring(0, 2) +
                                                            cjplpModelList[i].Sdate.Substring(0, 4);
                                recordtableModel.typeYearStrnolast5 = cjplpModelList[i].Type.Substring(0, 2) +
                                                                      cjplpModelList[i].Sdate.Substring(0, 4) +
                                                                      streetnoModeList[j].strnolast5;
                                recordtableModel.typeYearStrnolast5Inteno = cjplpModelList[i].Type.Substring(0, 2) +
                                                                            cjplpModelList[i].Sdate.Substring(0, 4) +
                                                                            streetnoModeList[j].strnolast5 + "01";
                                recordtableModel.inteserino = "0100001";
                                recordtableModel.Exp_No = cjplpModelList[i].Type.Substring(0, 2) +
                                                          cjplpModelList[i].Sdate.Substring(0, 4) +
                                                          streetnoModeList[j].strnolast5 + "0100001";
                                recordtableBll.Add(recordtableModel);
                                // Console.WriteLine("点点点添加" + recordtableModel.Exp_No);
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < streetnoModeList.Count; j++)
                        {
                            if (!String.IsNullOrEmpty(cjplpModelList[i].FileName)
                                && !String.IsNullOrEmpty(cjplpModelList[i].Type)
                                && !String.IsNullOrEmpty(cjplpModelList[i].Sdate)
                                && cjplpModelList[i].FileName.Contains(streetnoModeList[j].shortname))
                            {
                                string temptypeYearStrnolast5 =
                                    cjplpModelList[i].Type.Substring(0, 2) +
                                    cjplpModelList[i].Sdate.Substring(0, 4) +
                                    streetnoModeList[j].strnolast5;

                                // string temptypeYear =
                                //     cjplpModelList[i].Type.Substring(0, 2) +
                                //     cjplpModelList[i].Sdate.Substring(0, 4);


                                for (int k = 0; k < recordtablesModelList.Count; k++)
                                {
                                    //如果前3段相同，则更新最后的交汇顺序号和排水管点顺序号
                                    if (recordtablesModelList[k].typeYearStrnolast5 == temptypeYearStrnolast5)
                                    {
                                        //获取数据库信息
                                        string dbInteserino = recordtablesModelList[k].inteserino;
                                        string newInteserino = string.Empty;
                                        if (Convert.ToInt32(dbInteserino.Substring(2)) != 99999)
                                        {
                                            //排水管点顺序号变化
                                            newInteserino =
                                                dbInteserino.Substring(0, 2) +
                                                ((Convert.ToInt32(dbInteserino.Substring(2)) + 1).ToString()
                                                    .PadLeft(5, '0'));

                                            //recordTableModelList表的变化
                                            // recordtablesModelList[k].inteno = 1;
                                            recordtablesModelList[k].serino =
                                                (Convert.ToInt32(dbInteserino.Substring(2)) + 1);

                                            // recordtablesModelList[k].typeYearStrnolast5Inteno = cjplpModelList[i].Type.Substring(0, 2) +
                                            //                                                     cjplpModelList[i].Sdate.Substring(0, 4) +
                                            //                                                     streetnoModeList[j].strnolast5 + "01";
                                            recordtablesModelList[k].inteserino = newInteserino;
                                        }
                                        else
                                        {
                                            //交汇点顺序号变化
                                            newInteserino =
                                                (Convert.ToInt32(dbInteserino.Substring(0, 2)) + 1).ToString()
                                                .PadLeft(2, '0') +
                                                "00001";

                                            //recordTableModelList表的变化
                                            recordtablesModelList[k].inteno =
                                                Convert.ToInt32(dbInteserino.Substring(0, 2)) + 1;
                                            recordtablesModelList[k].serino = 1;

                                            recordtablesModelList[k].typeYearStrnolast5Inteno =
                                                temptypeYearStrnolast5 +
                                                (Convert.ToInt32(dbInteserino.Substring(0, 2)) + 1).ToString()
                                                .PadLeft(2, '0');

                                            recordtablesModelList[k].inteserino = newInteserino;
                                        }

                                        //更新：给原始管点编号并添加进数据库
                                        cjplpModelList[i].Exp_No = temptypeYearStrnolast5 + newInteserino;
                                        cjplpModelList[i].ExpNoTime =
                                            DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString();
                                        cjplpBLL.Update(cjplpModelList[i]);

                                        //更新recordtable表
                                        recordtablesModelList[k].Exp_No = temptypeYearStrnolast5 + newInteserino;
                                        recordtableBll.Update(recordtablesModelList[k]);
                                        // Console.WriteLine("点点点更新" + recordtablesModelList[k].Exp_No);
                                    }
                                    else
                                    {
                                        //如果前2段相同，街道不同，则更新最后三段（后3端需要进行重新编码，然后写入数据库中
                                        for (int m = 0; m < streetnoModeList.Count; m++)
                                        {
                                            if (!String.IsNullOrEmpty(cjplpModelList[i].FileName)
                                                && !String.IsNullOrEmpty(cjplpModelList[i].Type)
                                                && !String.IsNullOrEmpty(cjplpModelList[i].Sdate)
                                                && cjplpModelList[i].FileName.Contains(streetnoModeList[m].shortname))
                                            {
                                                //更新给原始管点编号
                                                cjplpModelList[i].Exp_No = cjplpModelList[i].Type.Substring(0, 2) +
                                                                           cjplpModelList[i].Sdate.Substring(0, 4) +
                                                                           streetnoModeList[m].strnolast5 + "0100001";
                                                cjplpModelList[i].ExpNoTime =
                                                    DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString();
                                                cjplpBLL.Update(cjplpModelList[i]);

                                                //添加数据库记录文件
                                                recordtableModel.type = cjplpModelList[i].Type.Substring(0, 2);
                                                recordtableModel.year = cjplpModelList[i].Sdate.Substring(0, 4);
                                                recordtableModel.strnolast5 = streetnoModeList[m].strnolast5;
                                                recordtableModel.inteno = 1;
                                                recordtableModel.serino = 1;
                                                recordtableModel.typeYear = cjplpModelList[i].Type.Substring(0, 2) +
                                                                            cjplpModelList[i].Sdate.Substring(0, 4);
                                                recordtableModel.typeYearStrnolast5 =
                                                    cjplpModelList[i].Type.Substring(0, 2) +
                                                    cjplpModelList[i].Sdate.Substring(0, 4) +
                                                    streetnoModeList[m].strnolast5;
                                                recordtableModel.typeYearStrnolast5Inteno =
                                                    cjplpModelList[i].Type.Substring(0, 2) +
                                                    cjplpModelList[i].Sdate.Substring(0, 4) +
                                                    streetnoModeList[m].strnolast5 + "01";
                                                recordtableModel.inteserino = "0100001";
                                                recordtableModel.Exp_No = cjplpModelList[i].Type.Substring(0, 2) +
                                                                          cjplpModelList[i].Sdate.Substring(0, 4) +
                                                                          streetnoModeList[m].strnolast5 + "0100001";
                                                recordtableBll.Add(recordtableModel);
                                                // Console.WriteLine("点点点添加" + recordtableModel.Exp_No);

                                                break;
                                            }
                                        }
                                    }


                                    break;
                                }

                                break;
                            }
                        }
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// 线编码
        /// </summary>
        private void CjpllCode()
        {
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();

            #region 线表编码

            //街道的编码
            streetno streetnoBLL = new streetno();
            List<Maticsoft.Model.streetno> streetnoModeList = streetnoBLL.GetModelList("shortname is not NULL");

            //顺序编码表
            Maticsoft.Model.recordtable recordtableModel = new Maticsoft.Model.recordtable();
            Maticsoft.BLL.recordtable recordtableBll = new Maticsoft.BLL.recordtable();

            //获取待拆分的线表数据
            cjpll cjpllBLL = new cjpll();
            List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.GetModelList("");


            for (int i = 0; i < cjpllModelList.Count; i++)
            {
                for (int j = 0; j < streetnoModeList.Count; j++)
                {
                    if (!String.IsNullOrEmpty(cjpllModelList[i].Exp_No0)
                        && !String.IsNullOrEmpty(cjpllModelList[i].Exp_No1)
                        && !String.IsNullOrEmpty(cjpllModelList[i].Type)
                        && !String.IsNullOrEmpty(cjpllModelList[i].Sdate)
                        && cjpllModelList[i].FileName.Contains(streetnoModeList[j].shortname))
                    {
                        cjplp exp_No0Model = cjplpBLL.GetModel(cjpllModelList[i].Exp_No0);
                        cjplp exp_No1Model = cjplpBLL.GetModel(cjpllModelList[i].Exp_No1);


                        if (exp_No0Model != null && exp_No1Model != null)
                        {
                            // string tmp = "type like '" + cjpllModelList[i].Type.Substring(0, 2) +
                            //              "%' and Lno like '" +
                            //              cjpllModelList[i].Type.Substring(0, 2) +
                            //              cjpllModelList[i].Sdate.Substring(0, 4) +
                            //              streetnoModeList[j].strnolast5 + "__" +
                            //              exp_No0Model.Exp_No.Substring(13) +
                            //              exp_No1Model.Exp_No.Substring(13) + "'";
                            //查询街道编码不为空的列
                            List<recordtable> recordtablesModelList =
                                recordtableBll.GetModelList("type like '" + cjpllModelList[i].Type.Substring(0, 2) +
                                                            "%' and Lno like '" +
                                                            cjpllModelList[i].Type.Substring(0, 2) +
                                                            cjpllModelList[i].Sdate.Substring(0, 4) +
                                                            streetnoModeList[j].strnolast5 + "__" +
                                                            exp_No0Model.Exp_No.Substring(13) +
                                                            exp_No1Model.Exp_No.Substring(13) + "'");
                            //1.填充起点、终点编码
                            cjpllModelList[i].S_Point = exp_No0Model.Exp_No;
                            cjpllModelList[i].E_Point = exp_No1Model.Exp_No;
                            //2.计算管线编码
                            if (recordtablesModelList.Count == 0)
                            {
                                //计算管线编号
                                cjpllModelList[i].Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                        cjpllModelList[i].Sdate.Substring(0, 4) +
                                                        streetnoModeList[j].strnolast5 + "01" +
                                                        exp_No0Model.Exp_No.Substring(13) +
                                                        exp_No1Model.Exp_No.Substring(13);

                                //2.插入记录表
                                recordtableModel.type = cjpllModelList[i].Type.Substring(0, 2);
                                recordtableModel.year = cjpllModelList[i].Sdate.Substring(0, 4);
                                recordtableModel.strnolast5 = streetnoModeList[j].strnolast5;
                                recordtableModel.inteno = 1;
                                recordtableModel.serino = Convert.ToInt32(exp_No0Model.Exp_No.Substring(13)) +
                                                                          Convert.ToInt32(exp_No1Model.Exp_No.Substring(13));
                                recordtableModel.typeYear = cjpllModelList[i].Type.Substring(0, 2) +
                                                            cjpllModelList[i].Sdate.Substring(0, 4);
                                recordtableModel.typeYearStrnolast5 = cjpllModelList[i].Type.Substring(0, 2) +
                                                                      cjpllModelList[i].Sdate.Substring(0, 4) +
                                                                      streetnoModeList[j].strnolast5;
                                recordtableModel.typeYearStrnolast5Inteno = cjpllModelList[i].Type.Substring(0, 2) +
                                                                            cjpllModelList[i].Sdate.Substring(0, 4) +
                                                                            streetnoModeList[j].strnolast5 + "01";
                                recordtableModel.inteserino = exp_No0Model.Exp_No.Substring(13) +
                                                              exp_No1Model.Exp_No.Substring(13);
                                recordtableModel.Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                       cjpllModelList[i].Sdate.Substring(0, 4) +
                                                       streetnoModeList[j].strnolast5 + "01" +
                                                       exp_No0Model.Exp_No.Substring(13) +
                                                       exp_No1Model.Exp_No.Substring(13);
                                recordtableBll.Add(recordtableModel);
                                // Console.WriteLine("线线线添加" + recordtableModel.Lno);
                            }
                            else
                            {
                                List<int> seriaList = new List<int>();

                                for (int k = 0; k < recordtablesModelList.Count; k++)
                                {
                                    seriaList.Add(Convert.ToInt16(recordtablesModelList[k].Lno.Substring(11, 2)));
                                }

                                //计算管线编号
                                cjpllModelList[i].Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                        cjpllModelList[i].Sdate.Substring(0, 4) +
                                                        streetnoModeList[j].strnolast5 +
                                                        seriaList.Max().ToString().PadLeft(2, '0') +
                                                        exp_No0Model.Exp_No.Substring(13) +
                                                        exp_No1Model.Exp_No.Substring(13);

                                //2.插入记录表
                                recordtableModel.inteno = seriaList.Max();
                                recordtableModel.typeYearStrnolast5Inteno = cjpllModelList[i].Type.Substring(0, 2) +
                                                                            cjpllModelList[i].Sdate.Substring(0, 4) +
                                                                            streetnoModeList[j].strnolast5 +
                                                                            seriaList.Max().ToString().PadLeft(2, '0');
                                recordtableModel.Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                       cjpllModelList[i].Sdate.Substring(0, 4) +
                                                       streetnoModeList[j].strnolast5 +
                                                       seriaList.Max().ToString().PadLeft(2, '0') +
                                                       exp_No0Model.Exp_No.Substring(13) +
                                                       exp_No1Model.Exp_No.Substring(13);
                                recordtableBll.Update(recordtableModel);
                                // Console.WriteLine("线线线更新" + recordtableModel.Lno);
                            }

                            //3.计算管线长度
                            if (!String.IsNullOrEmpty(exp_No0Model.X.ToString())
                                && !String.IsNullOrEmpty(exp_No0Model.Y.ToString())
                                && !String.IsNullOrEmpty(exp_No1Model.X.ToString())
                                && !String.IsNullOrEmpty(exp_No1Model.Y.ToString()))
                            {
                                cjpllModelList[i].PipeLength =
                                    (decimal) calculatePipeLength(exp_No0Model, exp_No1Model);
                            }

                            cjpllModelList[i].LnoTime =
                                DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString();
                            //更新管线计算内容
                            cjpllBLL.Update(cjpllModelList[i]);
                            break;
                        }
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// 未编码的数据检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemUncoding_ItemClick(object sender, ItemClickEventArgs e)
        {
            //切换到属性页面
            // this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageLine;
            this.gridViewLine.BestFitColumns();
            this.gridViewLine.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridViewLine.OptionsView.ColumnAutoWidth = false;

            //1.获取到待拆分的数据
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<cjplp> cjplpModelList = cjplpBLL.GetModelList("Exp_No is null or trim(Exp_No)=''");
            this.gridControlPointTable.DataSource = cjplpModelList;

            //获取待拆分的线表数据
            cjpll cjpllBLL = new cjpll();
            List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.GetModelList("Lno is null or trim(Lno)=''");
            this.gridControlLineTable.DataSource = cjpllModelList;
        }

        /// <summary>
        ///导出未编码的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemExportUncoding_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel2007文件|*.xlsx|Excel2003文件|*.xls|所有文件|*.*";
                if (saveDialog.ShowDialog() == DialogResult.Cancel) return;
                string exportFilePath = saveDialog.FileName;
                ExportExcel.ExportToExcel(exportFilePath, true, "", gridControlPointTable, gridControlLineTable);

                // string fileExtenstion = new FileInfo(exportFilePath).Extension;
                // switch (fileExtenstion)
                // {
                //     case ".xls":
                //         gridControlLineTable.ExportToXls(exportFilePath);
                //         gridControlPointTable.ExportToXls(exportFilePath);
                //         break;
                //     case ".xlsx":
                //         gridControlLineTable.ExportToXlsx(exportFilePath);
                //         gridControlPointTable.ExportToXlsx(exportFilePath);
                //         break;
                //     // case ".rtf":
                //     //     gridControlAttri.ExportToRtf(exportFilePath);
                //     //     break;
                //     // case ".pdf":
                //     //     gridControlAttri.ExportToPdf(exportFilePath);
                //     //     break;
                //     // case ".html":
                //     //     gridControlAttri.ExportToHtml(exportFilePath);
                //     //     break;
                //     // case ".mht":
                //     //     gridControlAttri.ExportToMht(exportFilePath);
                //     //     break;
                // }

                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("是否导出文件！", "提示", MessageBoxButtons.YesNo))
                        {
                            Process.Start(exportFilePath);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("文件导出错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("文件路径不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 计算管线长度-物探指定计算方法
        /// 建议球面坐标不要这么计算，不准确
        /// </summary>
        /// <param name="expNo0Model"></param>
        /// <param name="expNo1Model"></param>
        /// <returns></returns>
        private double calculatePipeLength(Maticsoft.Model.cjplp expNo0Model, Maticsoft.Model.cjplp expNo1Model)
        {
            double result = Math.Sqrt(Convert.ToDouble(
                (expNo1Model.X - expNo0Model.X) * (expNo1Model.X - expNo0Model.X) +
                (expNo1Model.Y - expNo0Model.Y) * (expNo1Model.Y - expNo0Model.Y) +
                (expNo1Model.High - expNo0Model.High) * (expNo1Model.High - expNo0Model.High)));
            return result;
        }

        #endregion

        #region 数据导出模块

        /// <summary>
        /// 导出ArcGIS的mdb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemExport_ItemClick(object sender, ItemClickEventArgs e)
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

            //1.生成特征点
            createMdb.CreatePS_POINT(featureWorkspace, prjPath, "");
            //2.生成排放口
            createMdb.CreatePS_OUTFALL(featureWorkspace, prjPath, "");
            //3.生成检查井
            createMdb.CreatePS_MANHOLE(featureWorkspace, prjPath, "");

            //4.生成雨水口
            createMdb.CreatePS_COMB(featureWorkspace, prjPath, "");
            //5.生成堰
            createMdb.CreatePS_WEIR(featureWorkspace, prjPath, "");
            //6.生成闸门
            createMdb.CreatePS_GATE(featureWorkspace, prjPath, "");
            //7.生成阀门
            createMdb.CreatePS_VALVE(featureWorkspace, prjPath, "");
            //8.生成排水泵站
            createMdb.CreatePS_PUMPSTATION(featureWorkspace, prjPath, "");
            //9.生成调蓄设施
            createMdb.CreatePS_RETENTION(featureWorkspace, prjPath, "");

            //10.生成污水处理设施
            createMdb.CreatePS_WWTP(featureWorkspace, prjPath, "");

            //11.生成排水户
            createMdb.CreatePS_DISCHARGER(featureWorkspace, prjPath, "");

            //todo:12.生成雨水管线
            createMdb.CreatePS_PIPE(featureWorkspace, prjPath, "");

            MessageBox.Show("导出成功！", "提示");
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

        /// <summary>
        /// 条件导出mdb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemConditionExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmConditionExport frmConditionExport = new FrmConditionExport();
            frmConditionExport.Show();
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProject.Factory;
using MainProject.Forms;
using MainProject.ImplementClasses;
using MainProject.Interfaces;
using Maticsoft.BLL;
using cjplp = Maticsoft.Model.cjplp;
using recordtable = Maticsoft.Model.recordtable;

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

        /// <summary>
        /// 拆分数据 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemMergeData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //todo：拆分点表
            //1.获取到待拆分的数据
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            // string pointSqlStr = "select * from cjplp";
            List<Maticsoft.Model.cjplp> cjplpModelList = cjplpBLL.GetModelList("");

            Maticsoft.BLL.pipeobjectencode pipeobjectencodeBLL = new Maticsoft.BLL.pipeobjectencode();
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
                                SplitTableInterface b1 =Activator.CreateInstance(t, cjplpModelList[i],
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
            Maticsoft.BLL.cjpll cjpllBLL = new Maticsoft.BLL.cjpll();
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

        /// <summary>
        /// 导出ArcGIS的mdb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //todo：点表编码
            //1.获取到待拆分的数据
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<Maticsoft.Model.cjplp> cjplpModelList = cjplpBLL.GetModelList("");

            //街道的编码
            Maticsoft.BLL.streetno streetnoBLL = new Maticsoft.BLL.streetno();

            //查询街道编码不为空的列
            List<Maticsoft.Model.streetno> streetnoModeList = streetnoBLL.GetModelList("shortname is not NULL");

            //顺序编码表
            Maticsoft.Model.recordtable recordtableModel = new Maticsoft.Model.recordtable();
            Maticsoft.BLL.recordtable recordtableBll = new Maticsoft.BLL.recordtable();

            for (int i = 0; i < cjplpModelList.Count; i++)
            {
                //编码不存在的情况下才进行编码，否则不进行编码
                if (cjplpModelList[i] != null && String.IsNullOrEmpty(cjplpModelList[i].Exp_No))
                {
                    //查询街道编码不为空的列
                    List<Maticsoft.Model.recordtable> recordtablesModelList =
                        recordtableBll.GetModelList("type like '" + cjplpModelList[i].Type.Substring(0, 2)+"%'");
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
                                cjplpModelList[i].ExpNoTime = DateTime.Now.ToString();
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

                                string temptypeYear =
                                    cjplpModelList[i].Type.Substring(0, 2) +
                                    cjplpModelList[i].Sdate.Substring(0, 4);


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
                                                (Convert.ToInt32(dbInteserino.Substring(0,2)) + 1).ToString().PadLeft(2,'0');

                                            recordtablesModelList[k].inteserino = newInteserino;
                                        }

                                        //更新：给原始管点编号并添加进数据库
                                        cjplpModelList[i].Exp_No = temptypeYearStrnolast5 + newInteserino;
                                        cjplpModelList[i].ExpNoTime = DateTime.Now.ToString();
                                        cjplpBLL.Update(cjplpModelList[i]);

                                        //更新recordtable表
                                        recordtablesModelList[k].Exp_No = temptypeYearStrnolast5 + newInteserino;
                                        recordtableBll.Update(recordtablesModelList[k]);
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
                                                cjplpModelList[i].ExpNoTime = DateTime.Now.ToString();
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


            //todo：线表编码
            //获取待拆分的线表数据
            Maticsoft.BLL.cjpll cjpllBLL = new Maticsoft.BLL.cjpll();
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
       

                        Maticsoft.Model.cjplp exp_No0Model = cjplpBLL.GetModel(cjpllModelList[i].Exp_No0);
                        Maticsoft.Model.cjplp exp_No1Model = cjplpBLL.GetModel(cjpllModelList[i].Exp_No1);


                        if (exp_No0Model!=null&&exp_No1Model!=null)
                        {
                            //查询街道编码不为空的列
                            List<recordtable> recordtablesModelList =
                                recordtableBll.GetModelList("type like '" + cjpllModelList[i].Type.Substring(0, 2) + "%' and Lno like '" +
                                                            cjpllModelList[i].Type.Substring(0, 2) +
                                                            cjpllModelList[i].Sdate.Substring(0, 4) +
                                                            streetnoModeList[j].strnolast5 + "__" + exp_No0Model.Exp_No.Substring(13) +
                                                            exp_No1Model.Exp_No.Substring(13)+"'");
                            //1.填充起点、终点编码
                            cjpllModelList[i].S_Point = exp_No0Model.Exp_No;
                            cjpllModelList[i].E_Point = exp_No1Model.Exp_No;
                            //2.计算管线编码
                            if (recordtablesModelList.Count==0)
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
                                recordtableModel.serino = Convert.ToInt32(exp_No0Model.Exp_No.Substring(13) +
                                                                          exp_No1Model.Exp_No.Substring(13));
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
                                recordtableModel.Lno= cjpllModelList[i].Type.Substring(0, 2) +
                                                      cjpllModelList[i].Sdate.Substring(0, 4) +
                                                      streetnoModeList[j].strnolast5 + "01" +
                                                      exp_No0Model.Exp_No.Substring(13) +
                                                      exp_No1Model.Exp_No.Substring(13);
                                recordtableBll.Update(recordtableModel);
                            }
                            else
                            {
                                List<int> seriaList=new List<int>();

                                for (int k = 0; k < recordtablesModelList.Count; k++)
                                {
                                    seriaList.Add(Convert.ToInt16(recordtablesModelList[k].Lno.Substring(11, 13)));
                                }

                                //计算管线编号
                                cjpllModelList[i].Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                        cjpllModelList[i].Sdate.Substring(0, 4) +
                                                        streetnoModeList[j].strnolast5 + 
                                                        seriaList.Max().ToString().PadLeft(2, '0') +
                                                        exp_No0Model.Exp_No.Substring(13) +
                                                        exp_No1Model.Exp_No.Substring(13);

                                //2.插入记录表
                                // recordtableModel.type = cjpllModelList[i].Type.Substring(0, 2);
                                // recordtableModel.year = cjpllModelList[i].Sdate.Substring(0, 4);
                                // recordtableModel.strnolast5 = streetnoModeList[j].strnolast5;
                                recordtableModel.inteno = seriaList.Max();
                                // recordtableModel.serino = Convert.ToInt32(exp_No0Model.Exp_No.Substring(13) +
                                //                            exp_No1Model.Exp_No.Substring(13));
                                // recordtableModel.typeYear = cjpllModelList[i].Type.Substring(0, 2) +
                                //                             cjpllModelList[i].Sdate.Substring(0, 4);
                                // recordtableModel.typeYearStrnolast5 = cjpllModelList[i].Type.Substring(0, 2) +
                                //                                       cjpllModelList[i].Sdate.Substring(0, 4) +
                                //                                       streetnoModeList[j].strnolast5;
                                recordtableModel.typeYearStrnolast5Inteno = cjpllModelList[i].Type.Substring(0, 2) +
                                                                            cjpllModelList[i].Sdate.Substring(0, 4) +
                                                                            streetnoModeList[j].strnolast5 + 
                                                                            seriaList.Max().ToString().PadLeft(2, '0');
                                // recordtableModel.inteserino = exp_No0Model.Exp_No.Substring(13) +
                                //                               exp_No1Model.Exp_No.Substring(13);
                                recordtableModel.Lno = cjpllModelList[i].Type.Substring(0, 2) +
                                                       cjpllModelList[i].Sdate.Substring(0, 4) +
                                                       streetnoModeList[j].strnolast5 + 
                                                       seriaList.Max().ToString().PadLeft(2, '0') +
                                                       exp_No0Model.Exp_No.Substring(13) +
                                                       exp_No1Model.Exp_No.Substring(13);
                                recordtableBll.Update(recordtableModel);

                            }

                            //3.计算管线长度
                            if (!String.IsNullOrEmpty(exp_No0Model.X.ToString())
                                &&!String.IsNullOrEmpty(exp_No0Model.Y.ToString())
                                &&!String.IsNullOrEmpty(exp_No1Model.X.ToString())
                                &&!String.IsNullOrEmpty(exp_No1Model.Y.ToString()))
                            {
                                // cjpllModelList[i].PipeLength =decimal.Parse(calculatePipeLength(exp_No0Model, exp_No1Model));
                                cjpllModelList[i].PipeLength =(decimal)calculatePipeLength(exp_No0Model, exp_No1Model);
                            }
                            //更新管线计算内容
                            cjpllBLL.Update(cjpllModelList[i]);
                            break;
                        }
                    }
                }
            }

            MessageBox.Show("编码完成！","提示");

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
            double result = Math.Sqrt(Convert.ToDouble((expNo1Model.X - expNo0Model.X) * (expNo1Model.X - expNo0Model.X) + 
                                       (expNo1Model.Y - expNo0Model.Y) * (expNo1Model.Y - expNo0Model.Y) + 
                                       (expNo1Model.High - expNo0Model.High) * (expNo1Model.High - expNo0Model.High)));
            return result;
        }
    }
}
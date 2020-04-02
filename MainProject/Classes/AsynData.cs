using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maticsoft.Model;
using exportinfo = Maticsoft.BLL.exportinfo;

namespace MainProject.Classes
{
    public static class AsynData
    {
        /// <summary>
        /// 同步编码记录表记录(RecordTable)
        /// </summary>
        public static void asynRecordTabl()
        {
            //顺序编码表
            Maticsoft.BLL.recordtable recordtableBll = new Maticsoft.BLL.recordtable();

            //1.获取编码过的点表数据
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<cjplp> cjplpModelList = cjplpBLL.GetMaxCodeModelList();
            for (int i = 0; i < cjplpModelList.Count; i++)
            {
                //编码不为空
                if (!String.IsNullOrEmpty(cjplpModelList[i].Exp_No))
                {
                    // List<Maticsoft.Model.recordtable> recordtableModelList =recordtableBll.GetModelList("(Lno is null or trim(lno)=='') and type=" +
                    //                             cjplpModelList[i].Type.Substring(0, 2));
                    List<Maticsoft.Model.recordtable> recordtableModelList =
                        recordtableBll.GetModelList("type='" + cjplpModelList[i].Type.Substring(0, 2) + "'");
                    for (int j = 0; j < recordtableModelList.Count; j++)
                    {
                        //如果不相等，则更新recordtable，相同，则不做任何操作
                        if (recordtableModelList[j].Exp_No != cjplpModelList[i].Exp_No)
                        {
                            recordtableModelList[j].year = cjplpModelList[i].Exp_No.Substring(2, 4);
                            recordtableModelList[j].strnolast5 = cjplpModelList[i].Exp_No.Substring(6, 5);
                            recordtableModelList[j].inteno = Convert.ToInt32(cjplpModelList[i].Exp_No.Substring(11, 2));
                            recordtableModelList[j].serino = Convert.ToInt32(cjplpModelList[i].Exp_No.Substring(13, 5));

                            recordtableModelList[j].typeYear = cjplpModelList[i].Exp_No.Substring(0, 6);
                            recordtableModelList[j].typeYearStrnolast5 = cjplpModelList[i].Exp_No.Substring(0, 11);
                            recordtableModelList[j].typeYearStrnolast5Inteno =
                                cjplpModelList[i].Exp_No.Substring(0, 13);
                            recordtableModelList[j].inteserino = cjplpModelList[i].Exp_No.Substring(11, 7);


                            recordtableModelList[j].Exp_No = cjplpModelList[i].Exp_No;

                            recordtableBll.Update(recordtableModelList[j]);
                        }
                    }
                }
            }

            //2.获取编码过的线表数据
            Maticsoft.BLL.cjpll cjpllBLL = new Maticsoft.BLL.cjpll();
            List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.GetMaxCodeModelList();
            for (int i = 0; i < cjpllModelList.Count; i++)
            {
                if (!String.IsNullOrEmpty(cjpllModelList[i].Lno))
                {
                    // List<Maticsoft.Model.recordtable> recordtableModelList = recordtableBll.GetModelList("(Exp_No is null or trim(Exp_No)=='') and type=" +
                    //                                                                                      cjpllModelList[i].Type.Substring(0, 2));
                    List<Maticsoft.Model.recordtable> recordtableModelList =
                        recordtableBll.GetModelList("type='" + cjpllModelList[i].Type.Substring(0, 2) + "'");
                    for (int j = 0; j < recordtableModelList.Count; j++)
                    {
                        //如果不相等，则更新recordtable，相同，则不做任何操作
                        if (recordtableModelList[j].Lno != cjpllModelList[i].Lno)
                        {
                            recordtableModelList[j].year = cjpllModelList[i].Lno.Substring(2, 4);
                            recordtableModelList[j].strnolast5 = cjpllModelList[i].Lno.Substring(6, 5);
                            recordtableModelList[j].inteno = Convert.ToInt32(cjpllModelList[i].Lno.Substring(11, 2));
                            recordtableModelList[j].serino = Convert.ToInt32(cjpllModelList[i].Lno.Substring(13, 10));

                            recordtableModelList[j].typeYear = cjpllModelList[i].Lno.Substring(0, 6);
                            recordtableModelList[j].typeYearStrnolast5 = cjpllModelList[i].Lno.Substring(0, 11);
                            recordtableModelList[j].typeYearStrnolast5Inteno = cjpllModelList[i].Lno.Substring(0, 13);
                            recordtableModelList[j].inteserino = cjpllModelList[i].Lno.Substring(11, 12);


                            recordtableModelList[j].Lno = cjpllModelList[i].Lno;

                            recordtableBll.Update(recordtableModelList[j]);
                        }
                    }
                }
            }
        }


        public static void asynExportInfoTabl()
        {

            // List<string> list = new List<string>();
            //点表
            Maticsoft.BLL.cjplp cjplpBLL = new Maticsoft.BLL.cjplp();
            List<Maticsoft.Model.cjplp> cjplpModelList = cjplpBLL.GetFileNames();

            //线表
            Maticsoft.BLL.cjpll cjpllBLL = new Maticsoft.BLL.cjpll();
            List<Maticsoft.Model.cjpll> cjpllModelList = cjpllBLL.GetFileNames();

            Maticsoft.BLL.exportinfo  exportinfoBLL = new Maticsoft.BLL.exportinfo();
            Maticsoft.Model.exportinfo exportinfoModel = new Maticsoft.Model.exportinfo();
            List<Maticsoft.Model.exportinfo> exportinfosModelList = exportinfoBLL.GetModelList("");

            if (cjplpModelList.Count > 0)
            {

                //第一种情况：对于数据库中有的，但是同步表中没有的，需要增加
                var exp2 = cjplpModelList.Where(a => !exportinfosModelList.Exists(t => a.FileName.Contains(t.FileName))).ToList();
                // Console.WriteLine("--查找student1集合中存在，而student2不存在的数据--");
                foreach (var item in exp2)
                {
                    // Console.WriteLine("{0} \t {1} \t {2}", item.name, item.subject, item.score);
                    string[] tempArr = item.FileName.Split('-');
                    //导出配置表（exportinfo）中没有配置数据，则直接插入
                    exportinfoModel.Address = item.Address;
                    exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                    exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                    exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                    exportinfoModel.FileName = item.FileName;
                    exportinfoBLL.Add(exportinfoModel);

                }
            }

            if (cjpllModelList.Count > 0)
            {

                //第一种情况：对于数据库中有的，但是同步表中没有的，需要增加
                var exp2 = cjpllModelList.Where(a => !exportinfosModelList.Exists(t => a.FileName.Contains(t.FileName))).ToList();
                // Console.WriteLine("--查找student1集合中存在，而student2不存在的数据--");
                foreach (var item in exp2)
                {
                    // Console.WriteLine("{0} \t {1} \t {2}", item.name, item.subject, item.score);
                    string[] tempArr = item.FileName.Split('-');
                    //导出配置表（exportinfo）中没有配置数据，则直接插入
                    exportinfoModel.Address = item.Address;
                    exportinfoModel.Basin = tempArr.Length > 0 ? tempArr[0] : string.Empty;
                    exportinfoModel.Strname = tempArr.Length > 1 ? tempArr[1] : string.Empty;
                    exportinfoModel.Plot = tempArr.Length > 2 ? tempArr[2].Substring(0, tempArr[2].IndexOf("_")) : string.Empty;
                    exportinfoModel.FileName = item.FileName;
                    exportinfoBLL.Add(exportinfoModel);

                }
            }

            if (exportinfosModelList.Count>0)
            {
                //第二种情况：对于数据库中有的，但是同步表中没有的，需要增加
                List<Maticsoft.Model.exportinfo> expPoint = exportinfosModelList.Where(a => !cjplpModelList.Exists(t => a.FileName.Contains(t.FileName))).ToList();
                List<Maticsoft.Model.exportinfo> exLine = exportinfosModelList.Where(a => !cjpllModelList.Exists(t => a.FileName.Contains(t.FileName))).ToList();
                // Console.WriteLine("--查找student1集合中存在，而student2不存在的数据--");

                List<Maticsoft.Model.exportinfo> resultExportinfosList = expPoint.Union(exLine).ToList();
                foreach (Maticsoft.Model.exportinfo item in resultExportinfosList)
                {

                    exportinfoBLL.Delete(item.id);
                }
            }

        }

    }
}
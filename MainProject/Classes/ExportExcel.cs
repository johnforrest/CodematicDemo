using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace MainProject.Classes
{
    public static class ExportExcel
    {
        /// <summary>
        /// DevExpress控件通用导出Excel,支持多个控件同时导出在同一个Sheet表或者分不同工作薄
        /// eg:ExportToXlsx("test",true,"控件",gridControl1,gridControl2);
        /// 将gridControl1和gridControl2的数据一同导出到同一个文件不同的工作薄
        /// eg:ExportToXlsx("test",false,"",gridControl1,gridControl2);
        /// 将gridControl1和gridControl2的数据一同导出到同一个文件同一个的工作薄
        /// <param name="FileName">Excel路径</param>
        /// <param name="isPageForEachLink">多个打印控件是否分多个工作薄显示</param>
        /// <param name="sheetName">工作薄名称</param>
        /// <param name="printables">控件集 eg:GridControl,PivotGridControl,TreeList,ChartControl...</param>
        public static void ExportToExcel(string FileName, bool isPageForEachLink, string sheetName,
            params DevExpress.XtraPrinting.IPrintable[] printables)
        {
            // SaveFileDialog saveFileDialog = new SaveFileDialog()
            // {
            //     FileName = title,
            //     Title = "导出Excel",
            //     Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls"
            // };
            // DialogResult dialogResult = saveFileDialog.ShowDialog();
            // if (dialogResult == DialogResult.Cancel)
            //     return;
            // string FileName = saveFileDialog.FileName;

            DevExpress.XtraPrintingLinks.CompositeLink link =
                new DevExpress.XtraPrintingLinks.CompositeLink(new DevExpress.XtraPrinting.PrintingSystem());
            foreach (var item in printables)
            {
                var plink = new DevExpress.XtraPrinting.PrintableComponentLink() {Component = item};
                link.Links.Add(plink);
            }

            if (isPageForEachLink) //15.1 的Xls不支持这个功能，15.2未知
                link.CreatePageForEachLink();
            //默认工作薄名称
            if (string.IsNullOrEmpty(sheetName)) sheetName = "Sheet";
            try
            {
                int count = 1;
                //在重复名称后加（序号）
                while (System.IO.File.Exists(FileName))
                {
                    if (FileName.Contains(")."))
                    {
                        int start = FileName.LastIndexOf("(");
                        int end = FileName.LastIndexOf(").") - FileName.LastIndexOf("(") + 2;
                        FileName = FileName.Replace(FileName.Substring(start, end), string.Format("({0}).", count));
                    }
                    else
                    {
                        FileName = FileName.Replace(".", string.Format("({0}).", count));
                    }

                    count++;
                }

                if (FileName.LastIndexOf(".xlsx") >= FileName.Length - 5)
                {
                    DevExpress.XtraPrinting.XlsxExportOptions options =
                        new DevExpress.XtraPrinting.XlsxExportOptions(TextExportMode.Value, true, false, true)
                            {SheetName = sheetName};
                    if (isPageForEachLink)
                        options.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFilePageByPage;
                    link.ExportToXlsx(FileName, options);
                }
                else
                {
                    DevExpress.XtraPrinting.XlsExportOptions options =
                        new DevExpress.XtraPrinting.XlsExportOptions(TextExportMode.Value, true, false, true)
                            {SheetName = sheetName};
                    if (isPageForEachLink) //15.Xls没有这个属性，15.2未知
                        options.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFilePageByPage;
                    link.ExportToXls(FileName, options);
                }

                if (DevExpress.XtraEditors.XtraMessageBox.Show("保存成功，是否打开文件？", "提示", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(FileName); //打开指定路径下的文件
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
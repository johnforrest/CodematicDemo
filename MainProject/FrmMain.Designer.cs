namespace MainProject
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemOpenExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMergeData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCode = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageBasic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBasic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemOpenExcel,
            this.barButtonItemMergeData,
            this.barButtonItemExport,
            this.btnCode});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageBasic});
            this.ribbonControl1.Size = new System.Drawing.Size(1069, 183);
            // 
            // barButtonItemOpenExcel
            // 
            this.barButtonItemOpenExcel.Caption = "导入Excel";
            this.barButtonItemOpenExcel.Id = 1;
            this.barButtonItemOpenExcel.ImageOptions.Image = global::MainProject.Properties.Resources.btnAddExcel;
            this.barButtonItemOpenExcel.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnAddExcel;
            this.barButtonItemOpenExcel.Name = "barButtonItemOpenExcel";
            this.barButtonItemOpenExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenExcel_ItemClick);
            // 
            // barButtonItemMergeData
            // 
            this.barButtonItemMergeData.Caption = "拆分数据";
            this.barButtonItemMergeData.Id = 2;
            this.barButtonItemMergeData.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnMergeData;
            this.barButtonItemMergeData.Name = "barButtonItemMergeData";
            this.barButtonItemMergeData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMergeData_ItemClick);
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "导出MDB";
            this.barButtonItemExport.Id = 3;
            this.barButtonItemExport.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnExportMDB;
            this.barButtonItemExport.Name = "barButtonItemExport";
            this.barButtonItemExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExport_ItemClick);
            // 
            // btnCode
            // 
            this.btnCode.Caption = "编码";
            this.btnCode.Id = 4;
            this.btnCode.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnCode;
            this.btnCode.Name = "btnCode";
            this.btnCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCode_ItemClick);
            // 
            // ribbonPageBasic
            // 
            this.ribbonPageBasic.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBasic});
            this.ribbonPageBasic.Name = "ribbonPageBasic";
            this.ribbonPageBasic.Text = "基础操作";
            // 
            // ribbonPageGroupBasic
            // 
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemOpenExcel);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.btnCode);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemMergeData);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemExport);
            this.ribbonPageGroupBasic.Name = "ribbonPageGroupBasic";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 701);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBasic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBasic;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenExcel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMergeData;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExport;
        private DevExpress.XtraBars.BarButtonItem btnCode;
    }
}
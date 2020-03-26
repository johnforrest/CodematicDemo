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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemOpenExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMergeData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCode = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageBasic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBasic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.axMapControlMain = new ESRI.ArcGIS.Controls.AxMapControl();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMapControl = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageAtrri = new DevExpress.XtraTab.XtraTabPage();
            this.axTOCControlMain = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControlMain = new ESRI.ArcGIS.Controls.AxLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageMapControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.barButtonItemOpenExcel,
            this.barButtonItemMergeData,
            this.barButtonItemExport,
            this.btnCode});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControlMain.MaxItemId = 5;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageBasic});
            this.ribbonControlMain.Size = new System.Drawing.Size(1069, 183);
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
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 183);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.axTOCControlMain);
            this.splitContainerControlMain.Panel1.Text = "Panel1";
            this.splitContainerControlMain.Panel2.Controls.Add(this.xtraTabControlMain);
            this.splitContainerControlMain.Panel2.Text = "Panel2";
            this.splitContainerControlMain.Size = new System.Drawing.Size(1069, 518);
            this.splitContainerControlMain.SplitterPosition = 161;
            this.splitContainerControlMain.TabIndex = 1;
            this.splitContainerControlMain.Text = "splitContainerControl1";
            // 
            // axMapControlMain
            // 
            this.axMapControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControlMain.Location = new System.Drawing.Point(0, 0);
            this.axMapControlMain.Name = "axMapControlMain";
            this.axMapControlMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControlMain.OcxState")));
            this.axMapControlMain.Size = new System.Drawing.Size(895, 482);
            this.axMapControlMain.TabIndex = 0;
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageMapControl;
            this.xtraTabControlMain.Size = new System.Drawing.Size(902, 518);
            this.xtraTabControlMain.TabIndex = 1;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMapControl,
            this.xtraTabPageAtrri});
            // 
            // xtraTabPageMapControl
            // 
            this.xtraTabPageMapControl.Controls.Add(this.axLicenseControlMain);
            this.xtraTabPageMapControl.Controls.Add(this.axMapControlMain);
            this.xtraTabPageMapControl.Name = "xtraTabPageMapControl";
            this.xtraTabPageMapControl.Size = new System.Drawing.Size(895, 482);
            this.xtraTabPageMapControl.Text = "地图视图";
            // 
            // xtraTabPageAtrri
            // 
            this.xtraTabPageAtrri.Name = "xtraTabPageAtrri";
            this.xtraTabPageAtrri.Size = new System.Drawing.Size(895, 482);
            this.xtraTabPageAtrri.Text = "属性视图";
            // 
            // axTOCControlMain
            // 
            this.axTOCControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControlMain.Location = new System.Drawing.Point(0, 0);
            this.axTOCControlMain.Name = "axTOCControlMain";
            this.axTOCControlMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControlMain.OcxState")));
            this.axTOCControlMain.Size = new System.Drawing.Size(161, 518);
            this.axTOCControlMain.TabIndex = 0;
            // 
            // axLicenseControlMain
            // 
            this.axLicenseControlMain.Enabled = true;
            this.axLicenseControlMain.Location = new System.Drawing.Point(206, 326);
            this.axLicenseControlMain.Name = "axLicenseControlMain";
            this.axLicenseControlMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControlMain.OcxState")));
            this.axLicenseControlMain.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 701);
            this.Controls.Add(this.splitContainerControlMain);
            this.Controls.Add(this.ribbonControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControlMain;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageMapControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBasic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBasic;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenExcel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMergeData;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExport;
        private DevExpress.XtraBars.BarButtonItem btnCode;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControlMain;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMapControl;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControlMain;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAtrri;
    }
}
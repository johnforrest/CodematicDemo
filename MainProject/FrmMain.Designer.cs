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
            this.barButtonItemUncoding = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportUncoding = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAsynCode = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageBasic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBasic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCoding = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSplitTable = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSplitTable = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCreateMDB = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCreateMDB = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.axTOCControlMain = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMapControl = new DevExpress.XtraTab.XtraTabPage();
            this.axLicenseControlMain = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControlMain = new ESRI.ArcGIS.Controls.AxMapControl();
            this.xtraTabPageAtrri = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAttri = new DevExpress.XtraGrid.GridControl();
            this.gridViewCJPLL = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageMapControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlMain)).BeginInit();
            this.xtraTabPageAtrri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAttri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCJPLL)).BeginInit();
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
            this.btnCode,
            this.barButtonItemUncoding,
            this.barButtonItemExportUncoding,
            this.barButtonItemAsynCode});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControlMain.MaxItemId = 8;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageBasic,
            this.ribbonPageCoding,
            this.ribbonPageSplitTable,
            this.ribbonPageCreateMDB});
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
            this.barButtonItemMergeData.Caption = "拆分点线表";
            this.barButtonItemMergeData.Id = 2;
            this.barButtonItemMergeData.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnMergeData;
            this.barButtonItemMergeData.Name = "barButtonItemMergeData";
            this.barButtonItemMergeData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMergeData_ItemClick);
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "导出ArcGIS MDB";
            this.barButtonItemExport.Id = 3;
            this.barButtonItemExport.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnExportMDB;
            this.barButtonItemExport.Name = "barButtonItemExport";
            this.barButtonItemExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExport_ItemClick);
            // 
            // btnCode
            // 
            this.btnCode.Caption = "点线表编码";
            this.btnCode.Id = 4;
            this.btnCode.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnCode;
            this.btnCode.Name = "btnCode";
            this.btnCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCode_ItemClick);
            // 
            // barButtonItemUncoding
            // 
            this.barButtonItemUncoding.Caption = "未编码数据";
            this.barButtonItemUncoding.Id = 5;
            this.barButtonItemUncoding.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnUncode;
            this.barButtonItemUncoding.Name = "barButtonItemUncoding";
            this.barButtonItemUncoding.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUncoding_ItemClick);
            // 
            // barButtonItemExportUncoding
            // 
            this.barButtonItemExportUncoding.Caption = "导出未编码数据";
            this.barButtonItemExportUncoding.Id = 6;
            this.barButtonItemExportUncoding.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnExportUncoding;
            this.barButtonItemExportUncoding.Name = "barButtonItemExportUncoding";
            this.barButtonItemExportUncoding.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExportUncoding_ItemClick);
            // 
            // barButtonItemAsynCode
            // 
            this.barButtonItemAsynCode.Caption = "同步编码";
            this.barButtonItemAsynCode.Id = 7;
            this.barButtonItemAsynCode.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnAsynCode;
            this.barButtonItemAsynCode.Name = "barButtonItemAsynCode";
            this.barButtonItemAsynCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAsynCode_ItemClick);
            // 
            // ribbonPageBasic
            // 
            this.ribbonPageBasic.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBasic});
            this.ribbonPageBasic.Name = "ribbonPageBasic";
            this.ribbonPageBasic.Text = "数据导入";
            // 
            // ribbonPageGroupBasic
            // 
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemOpenExcel);
            this.ribbonPageGroupBasic.Name = "ribbonPageGroupBasic";
            // 
            // ribbonPageCoding
            // 
            this.ribbonPageCoding.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPageCoding.Name = "ribbonPageCoding";
            this.ribbonPageCoding.Text = "数据编码";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.barButtonItemAsynCode);
            this.ribbonPageGroup.ItemLinks.Add(this.btnCode);
            this.ribbonPageGroup.ItemLinks.Add(this.barButtonItemUncoding);
            this.ribbonPageGroup.ItemLinks.Add(this.barButtonItemExportUncoding);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            // 
            // ribbonPageSplitTable
            // 
            this.ribbonPageSplitTable.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSplitTable});
            this.ribbonPageSplitTable.Name = "ribbonPageSplitTable";
            this.ribbonPageSplitTable.Text = "数据拆分";
            // 
            // ribbonPageGroupSplitTable
            // 
            this.ribbonPageGroupSplitTable.ItemLinks.Add(this.barButtonItemMergeData);
            this.ribbonPageGroupSplitTable.Name = "ribbonPageGroupSplitTable";
            // 
            // ribbonPageCreateMDB
            // 
            this.ribbonPageCreateMDB.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCreateMDB});
            this.ribbonPageCreateMDB.Name = "ribbonPageCreateMDB";
            this.ribbonPageCreateMDB.Text = "导出MDB";
            // 
            // ribbonPageGroupCreateMDB
            // 
            this.ribbonPageGroupCreateMDB.ItemLinks.Add(this.barButtonItemExport);
            this.ribbonPageGroupCreateMDB.Name = "ribbonPageGroupCreateMDB";
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
            // axTOCControlMain
            // 
            this.axTOCControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControlMain.Location = new System.Drawing.Point(0, 0);
            this.axTOCControlMain.Name = "axTOCControlMain";
            this.axTOCControlMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControlMain.OcxState")));
            this.axTOCControlMain.Size = new System.Drawing.Size(161, 518);
            this.axTOCControlMain.TabIndex = 0;
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
            // axLicenseControlMain
            // 
            this.axLicenseControlMain.Enabled = true;
            this.axLicenseControlMain.Location = new System.Drawing.Point(206, 326);
            this.axLicenseControlMain.Name = "axLicenseControlMain";
            this.axLicenseControlMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControlMain.OcxState")));
            this.axLicenseControlMain.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControlMain.TabIndex = 1;
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
            // xtraTabPageAtrri
            // 
            this.xtraTabPageAtrri.Controls.Add(this.gridControlAttri);
            this.xtraTabPageAtrri.Name = "xtraTabPageAtrri";
            this.xtraTabPageAtrri.Size = new System.Drawing.Size(895, 482);
            this.xtraTabPageAtrri.Text = "属性视图";
            // 
            // gridControlAttri
            // 
            this.gridControlAttri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAttri.Location = new System.Drawing.Point(0, 0);
            this.gridControlAttri.MainView = this.gridViewCJPLL;
            this.gridControlAttri.MenuManager = this.ribbonControlMain;
            this.gridControlAttri.Name = "gridControlAttri";
            this.gridControlAttri.Size = new System.Drawing.Size(895, 482);
            this.gridControlAttri.TabIndex = 0;
            this.gridControlAttri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCJPLL});
            // 
            // gridViewCJPLL
            // 
            this.gridViewCJPLL.GridControl = this.gridControlAttri;
            this.gridViewCJPLL.Name = "gridViewCJPLL";
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
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageMapControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControlMain)).EndInit();
            this.xtraTabPageAtrri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAttri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCJPLL)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCoding;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSplitTable;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSplitTable;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCreateMDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCreateMDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUncoding;
        private DevExpress.XtraGrid.GridControl gridControlAttri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCJPLL;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportUncoding;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAsynCode;
    }
}
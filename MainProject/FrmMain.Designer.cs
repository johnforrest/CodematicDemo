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
            this.barButtonItemRepeData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportRepe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemConnectDB = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageBasic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBasic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCoding = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSplitTable = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSplitTable = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCreateMDB = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCreateMDB = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageLine = new DevExpress.XtraTab.XtraTabPage();
            this.axLicenseControlMain = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.gridControlLineTable = new DevExpress.XtraGrid.GridControl();
            this.gridViewLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPagePoint = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlPointTable = new DevExpress.XtraGrid.GridControl();
            this.gridViewPoint = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLine)).BeginInit();
            this.xtraTabPagePoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPointTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoint)).BeginInit();
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
            this.barButtonItemAsynCode,
            this.barButtonItemRepeData,
            this.barButtonItemExportRepe,
            this.barButtonItemConnectDB});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControlMain.MaxItemId = 11;
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
            // barButtonItemRepeData
            // 
            this.barButtonItemRepeData.Caption = "重复数据";
            this.barButtonItemRepeData.Id = 8;
            this.barButtonItemRepeData.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnReData;
            this.barButtonItemRepeData.Name = "barButtonItemRepeData";
            this.barButtonItemRepeData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRepeData_ItemClick);
            // 
            // barButtonItemExportRepe
            // 
            this.barButtonItemExportRepe.Caption = "导出重复数据";
            this.barButtonItemExportRepe.Id = 9;
            this.barButtonItemExportRepe.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnExportRepe;
            this.barButtonItemExportRepe.Name = "barButtonItemExportRepe";
            this.barButtonItemExportRepe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExportRepe_ItemClick);
            // 
            // barButtonItemConnectDB
            // 
            this.barButtonItemConnectDB.Caption = "数据库连接测试";
            this.barButtonItemConnectDB.Id = 10;
            this.barButtonItemConnectDB.ImageOptions.LargeImage = global::MainProject.Properties.Resources.btnConnectDB;
            this.barButtonItemConnectDB.Name = "barButtonItemConnectDB";
            this.barButtonItemConnectDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemConnectDB_ItemClick);
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
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemConnectDB);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemOpenExcel);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemRepeData);
            this.ribbonPageGroupBasic.ItemLinks.Add(this.barButtonItemExportRepe);
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
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 183);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageLine;
            this.xtraTabControlMain.Size = new System.Drawing.Size(1069, 518);
            this.xtraTabControlMain.TabIndex = 1;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageLine,
            this.xtraTabPagePoint});
            // 
            // xtraTabPageLine
            // 
            this.xtraTabPageLine.Controls.Add(this.axLicenseControlMain);
            this.xtraTabPageLine.Controls.Add(this.gridControlLineTable);
            this.xtraTabPageLine.Name = "xtraTabPageLine";
            this.xtraTabPageLine.Size = new System.Drawing.Size(1062, 482);
            this.xtraTabPageLine.Text = "线属性";
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
            // gridControlLineTable
            // 
            this.gridControlLineTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLineTable.Location = new System.Drawing.Point(0, 0);
            this.gridControlLineTable.MainView = this.gridViewLine;
            this.gridControlLineTable.MenuManager = this.ribbonControlMain;
            this.gridControlLineTable.Name = "gridControlLineTable";
            this.gridControlLineTable.Size = new System.Drawing.Size(1062, 482);
            this.gridControlLineTable.TabIndex = 0;
            this.gridControlLineTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLine});
            // 
            // gridViewLine
            // 
            this.gridViewLine.GridControl = this.gridControlLineTable;
            this.gridViewLine.Name = "gridViewLine";
            this.gridViewLine.OptionsFind.AlwaysVisible = true;
            this.gridViewLine.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPagePoint
            // 
            this.xtraTabPagePoint.Controls.Add(this.gridControlPointTable);
            this.xtraTabPagePoint.Name = "xtraTabPagePoint";
            this.xtraTabPagePoint.Size = new System.Drawing.Size(1062, 482);
            this.xtraTabPagePoint.Text = "点属性";
            // 
            // gridControlPointTable
            // 
            this.gridControlPointTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPointTable.Location = new System.Drawing.Point(0, 0);
            this.gridControlPointTable.MainView = this.gridViewPoint;
            this.gridControlPointTable.MenuManager = this.ribbonControlMain;
            this.gridControlPointTable.Name = "gridControlPointTable";
            this.gridControlPointTable.Size = new System.Drawing.Size(1062, 482);
            this.gridControlPointTable.TabIndex = 0;
            this.gridControlPointTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPoint});
            // 
            // gridViewPoint
            // 
            this.gridViewPoint.GridControl = this.gridControlPointTable;
            this.gridViewPoint.Name = "gridViewPoint";
            this.gridViewPoint.OptionsFind.AlwaysVisible = true;
            this.gridViewPoint.OptionsView.ShowGroupPanel = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 701);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.ribbonControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControlMain;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLine)).EndInit();
            this.xtraTabPagePoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPointTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoint)).EndInit();
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
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLine;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCoding;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSplitTable;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSplitTable;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCreateMDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCreateMDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUncoding;
        private DevExpress.XtraGrid.GridControl gridControlLineTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLine;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportUncoding;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAsynCode;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePoint;
        private DevExpress.XtraGrid.GridControl gridControlPointTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPoint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRepeData;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportRepe;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConnectDB;
    }
}
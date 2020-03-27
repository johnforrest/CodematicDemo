namespace MainProject.Forms
{
    partial class FrmOpenExcel
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
            this.simpleButtonOpenExcel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpLoad = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlExcelPath = new DevExpress.XtraEditors.LabelControl();
            this.textBoxXExcelPath = new DevExpress.XtraEditors.TextEdit();
            this.listBoxControlSheetName = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonSelectLine = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSelectPoint = new DevExpress.XtraEditors.SimpleButton();
            this.textEditPointSheet = new DevExpress.XtraEditors.TextEdit();
            this.textEditLineSheet = new DevExpress.XtraEditors.TextEdit();
            this.panelControlOpenExcel = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonClearPoint = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClearLine = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPointSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLineSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenExcel)).BeginInit();
            this.panelControlOpenExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonOpenExcel
            // 
            this.simpleButtonOpenExcel.Location = new System.Drawing.Point(335, 50);
            this.simpleButtonOpenExcel.Name = "simpleButtonOpenExcel";
            this.simpleButtonOpenExcel.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonOpenExcel.TabIndex = 5;
            this.simpleButtonOpenExcel.Text = "打开Excel";
            this.simpleButtonOpenExcel.Click += new System.EventHandler(this.simpleButtonOpenExcel_Click);
            // 
            // simpleButtonUpLoad
            // 
            this.simpleButtonUpLoad.Location = new System.Drawing.Point(347, 330);
            this.simpleButtonUpLoad.Name = "simpleButtonUpLoad";
            this.simpleButtonUpLoad.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonUpLoad.TabIndex = 4;
            this.simpleButtonUpLoad.Text = "上传Excel";
            this.simpleButtonUpLoad.Click += new System.EventHandler(this.simpleButtonUpLoad_Click);
            // 
            // labelControlExcelPath
            // 
            this.labelControlExcelPath.Location = new System.Drawing.Point(20, 28);
            this.labelControlExcelPath.Name = "labelControlExcelPath";
            this.labelControlExcelPath.Size = new System.Drawing.Size(78, 18);
            this.labelControlExcelPath.TabIndex = 3;
            this.labelControlExcelPath.Text = "Excel路径：";
            // 
            // textBoxXExcelPath
            // 
            this.textBoxXExcelPath.Location = new System.Drawing.Point(129, 20);
            this.textBoxXExcelPath.Name = "textBoxXExcelPath";
            this.textBoxXExcelPath.Size = new System.Drawing.Size(581, 24);
            this.textBoxXExcelPath.TabIndex = 6;
            // 
            // listBoxControlSheetName
            // 
            this.listBoxControlSheetName.Location = new System.Drawing.Point(44, 15);
            this.listBoxControlSheetName.Name = "listBoxControlSheetName";
            this.listBoxControlSheetName.Size = new System.Drawing.Size(259, 95);
            this.listBoxControlSheetName.TabIndex = 7;
            // 
            // simpleButtonSelectLine
            // 
            this.simpleButtonSelectLine.Location = new System.Drawing.Point(316, 81);
            this.simpleButtonSelectLine.Name = "simpleButtonSelectLine";
            this.simpleButtonSelectLine.Size = new System.Drawing.Size(72, 29);
            this.simpleButtonSelectLine.TabIndex = 8;
            this.simpleButtonSelectLine.Text = "选择线表";
            this.simpleButtonSelectLine.Click += new System.EventHandler(this.simpleButtonSelectLine_Click);
            // 
            // simpleButtonSelectPoint
            // 
            this.simpleButtonSelectPoint.Location = new System.Drawing.Point(316, 11);
            this.simpleButtonSelectPoint.Name = "simpleButtonSelectPoint";
            this.simpleButtonSelectPoint.Size = new System.Drawing.Size(72, 29);
            this.simpleButtonSelectPoint.TabIndex = 9;
            this.simpleButtonSelectPoint.Text = "选择点表";
            this.simpleButtonSelectPoint.Click += new System.EventHandler(this.simpleButtonSelectPoint_Click);
            // 
            // textEditPointSheet
            // 
            this.textEditPointSheet.Enabled = false;
            this.textEditPointSheet.Location = new System.Drawing.Point(405, 16);
            this.textEditPointSheet.Name = "textEditPointSheet";
            this.textEditPointSheet.Properties.ReadOnly = true;
            this.textEditPointSheet.Size = new System.Drawing.Size(244, 24);
            this.textEditPointSheet.TabIndex = 10;
            // 
            // textEditLineSheet
            // 
            this.textEditLineSheet.Location = new System.Drawing.Point(405, 86);
            this.textEditLineSheet.Name = "textEditLineSheet";
            this.textEditLineSheet.Properties.ReadOnly = true;
            this.textEditLineSheet.Size = new System.Drawing.Size(244, 24);
            this.textEditLineSheet.TabIndex = 11;
            // 
            // panelControlOpenExcel
            // 
            this.panelControlOpenExcel.Controls.Add(this.textBoxXExcelPath);
            this.panelControlOpenExcel.Controls.Add(this.labelControlExcelPath);
            this.panelControlOpenExcel.Controls.Add(this.simpleButtonOpenExcel);
            this.panelControlOpenExcel.Location = new System.Drawing.Point(12, 12);
            this.panelControlOpenExcel.Name = "panelControlOpenExcel";
            this.panelControlOpenExcel.Size = new System.Drawing.Size(744, 108);
            this.panelControlOpenExcel.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButtonClearLine);
            this.panelControl2.Controls.Add(this.simpleButtonClearPoint);
            this.panelControl2.Controls.Add(this.simpleButtonSelectLine);
            this.panelControl2.Controls.Add(this.listBoxControlSheetName);
            this.panelControl2.Controls.Add(this.textEditLineSheet);
            this.panelControl2.Controls.Add(this.simpleButtonSelectPoint);
            this.panelControl2.Controls.Add(this.textEditPointSheet);
            this.panelControl2.Location = new System.Drawing.Point(12, 145);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(744, 129);
            this.panelControl2.TabIndex = 13;
            // 
            // simpleButtonClearPoint
            // 
            this.simpleButtonClearPoint.Location = new System.Drawing.Point(667, 11);
            this.simpleButtonClearPoint.Name = "simpleButtonClearPoint";
            this.simpleButtonClearPoint.Size = new System.Drawing.Size(72, 29);
            this.simpleButtonClearPoint.TabIndex = 12;
            this.simpleButtonClearPoint.Text = "清除点";
            this.simpleButtonClearPoint.Click += new System.EventHandler(this.simpleButtonClearPoint_Click);
            // 
            // simpleButtonClearLine
            // 
            this.simpleButtonClearLine.Location = new System.Drawing.Point(667, 83);
            this.simpleButtonClearLine.Name = "simpleButtonClearLine";
            this.simpleButtonClearLine.Size = new System.Drawing.Size(72, 29);
            this.simpleButtonClearLine.TabIndex = 13;
            this.simpleButtonClearLine.Text = "清除线";
            this.simpleButtonClearLine.Click += new System.EventHandler(this.simpleButtonClearLine_Click);
            // 
            // FrmOpenExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControlOpenExcel);
            this.Controls.Add(this.simpleButtonUpLoad);
            this.Name = "FrmOpenExcel";
            this.Text = "打开Excel";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPointSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLineSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenExcel)).EndInit();
            this.panelControlOpenExcel.ResumeLayout(false);
            this.panelControlOpenExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonOpenExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpLoad;
        private DevExpress.XtraEditors.LabelControl labelControlExcelPath;
        private DevExpress.XtraEditors.TextEdit textBoxXExcelPath;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlSheetName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelectLine;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelectPoint;
        private DevExpress.XtraEditors.TextEdit textEditPointSheet;
        private DevExpress.XtraEditors.TextEdit textEditLineSheet;
        private DevExpress.XtraEditors.PanelControl panelControlOpenExcel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClearLine;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClearPoint;
    }
}
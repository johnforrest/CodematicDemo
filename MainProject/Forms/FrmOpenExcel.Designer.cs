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
            this.panelControlSelectSheet = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonClearLine = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClearPoint = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlDelete = new DevExpress.XtraEditors.PanelControl();
            this.listBoxControlDeleteBlock = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonClearSelectBlocks = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControlDBBlock = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonSelectBlock = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPointSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLineSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenExcel)).BeginInit();
            this.panelControlOpenExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSelectSheet)).BeginInit();
            this.panelControlSelectSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelete)).BeginInit();
            this.panelControlDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlDeleteBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlDBBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonOpenExcel
            // 
            this.simpleButtonOpenExcel.Location = new System.Drawing.Point(251, 40);
            this.simpleButtonOpenExcel.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonOpenExcel.Name = "simpleButtonOpenExcel";
            this.simpleButtonOpenExcel.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonOpenExcel.TabIndex = 5;
            this.simpleButtonOpenExcel.Text = "打开Excel";
            this.simpleButtonOpenExcel.Click += new System.EventHandler(this.simpleButtonOpenExcel_Click);
            // 
            // simpleButtonUpLoad
            // 
            this.simpleButtonUpLoad.Location = new System.Drawing.Point(493, 664);
            this.simpleButtonUpLoad.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonUpLoad.Name = "simpleButtonUpLoad";
            this.simpleButtonUpLoad.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonUpLoad.TabIndex = 4;
            this.simpleButtonUpLoad.Text = "上传Excel";
            this.simpleButtonUpLoad.Click += new System.EventHandler(this.simpleButtonUpLoad_Click);
            // 
            // labelControlExcelPath
            // 
            this.labelControlExcelPath.Location = new System.Drawing.Point(15, 22);
            this.labelControlExcelPath.Margin = new System.Windows.Forms.Padding(2);
            this.labelControlExcelPath.Name = "labelControlExcelPath";
            this.labelControlExcelPath.Size = new System.Drawing.Size(64, 14);
            this.labelControlExcelPath.TabIndex = 3;
            this.labelControlExcelPath.Text = "Excel路径：";
            // 
            // textBoxXExcelPath
            // 
            this.textBoxXExcelPath.Location = new System.Drawing.Point(97, 16);
            this.textBoxXExcelPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXExcelPath.Name = "textBoxXExcelPath";
            this.textBoxXExcelPath.Size = new System.Drawing.Size(436, 20);
            this.textBoxXExcelPath.TabIndex = 6;
            // 
            // listBoxControlSheetName
            // 
            this.listBoxControlSheetName.Location = new System.Drawing.Point(33, 12);
            this.listBoxControlSheetName.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxControlSheetName.Name = "listBoxControlSheetName";
            this.listBoxControlSheetName.Size = new System.Drawing.Size(194, 76);
            this.listBoxControlSheetName.TabIndex = 7;
            // 
            // simpleButtonSelectLine
            // 
            this.simpleButtonSelectLine.Location = new System.Drawing.Point(237, 65);
            this.simpleButtonSelectLine.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonSelectLine.Name = "simpleButtonSelectLine";
            this.simpleButtonSelectLine.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonSelectLine.TabIndex = 8;
            this.simpleButtonSelectLine.Text = "选择线表";
            this.simpleButtonSelectLine.Click += new System.EventHandler(this.simpleButtonSelectLine_Click);
            // 
            // simpleButtonSelectPoint
            // 
            this.simpleButtonSelectPoint.Location = new System.Drawing.Point(237, 9);
            this.simpleButtonSelectPoint.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonSelectPoint.Name = "simpleButtonSelectPoint";
            this.simpleButtonSelectPoint.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonSelectPoint.TabIndex = 9;
            this.simpleButtonSelectPoint.Text = "选择点表";
            this.simpleButtonSelectPoint.Click += new System.EventHandler(this.simpleButtonSelectPoint_Click);
            // 
            // textEditPointSheet
            // 
            this.textEditPointSheet.Enabled = false;
            this.textEditPointSheet.Location = new System.Drawing.Point(304, 13);
            this.textEditPointSheet.Margin = new System.Windows.Forms.Padding(2);
            this.textEditPointSheet.Name = "textEditPointSheet";
            this.textEditPointSheet.Properties.ReadOnly = true;
            this.textEditPointSheet.Size = new System.Drawing.Size(183, 20);
            this.textEditPointSheet.TabIndex = 10;
            // 
            // textEditLineSheet
            // 
            this.textEditLineSheet.Location = new System.Drawing.Point(304, 69);
            this.textEditLineSheet.Margin = new System.Windows.Forms.Padding(2);
            this.textEditLineSheet.Name = "textEditLineSheet";
            this.textEditLineSheet.Properties.ReadOnly = true;
            this.textEditLineSheet.Size = new System.Drawing.Size(183, 20);
            this.textEditLineSheet.TabIndex = 11;
            // 
            // panelControlOpenExcel
            // 
            this.panelControlOpenExcel.Controls.Add(this.textBoxXExcelPath);
            this.panelControlOpenExcel.Controls.Add(this.labelControlExcelPath);
            this.panelControlOpenExcel.Controls.Add(this.simpleButtonOpenExcel);
            this.panelControlOpenExcel.Location = new System.Drawing.Point(9, 10);
            this.panelControlOpenExcel.Margin = new System.Windows.Forms.Padding(2);
            this.panelControlOpenExcel.Name = "panelControlOpenExcel";
            this.panelControlOpenExcel.Size = new System.Drawing.Size(558, 86);
            this.panelControlOpenExcel.TabIndex = 12;
            // 
            // panelControlSelectSheet
            // 
            this.panelControlSelectSheet.Controls.Add(this.simpleButtonClearLine);
            this.panelControlSelectSheet.Controls.Add(this.simpleButtonClearPoint);
            this.panelControlSelectSheet.Controls.Add(this.simpleButtonSelectLine);
            this.panelControlSelectSheet.Controls.Add(this.listBoxControlSheetName);
            this.panelControlSelectSheet.Controls.Add(this.textEditLineSheet);
            this.panelControlSelectSheet.Controls.Add(this.simpleButtonSelectPoint);
            this.panelControlSelectSheet.Controls.Add(this.textEditPointSheet);
            this.panelControlSelectSheet.Location = new System.Drawing.Point(9, 116);
            this.panelControlSelectSheet.Margin = new System.Windows.Forms.Padding(2);
            this.panelControlSelectSheet.Name = "panelControlSelectSheet";
            this.panelControlSelectSheet.Size = new System.Drawing.Size(558, 103);
            this.panelControlSelectSheet.TabIndex = 13;
            // 
            // simpleButtonClearLine
            // 
            this.simpleButtonClearLine.Location = new System.Drawing.Point(500, 66);
            this.simpleButtonClearLine.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonClearLine.Name = "simpleButtonClearLine";
            this.simpleButtonClearLine.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonClearLine.TabIndex = 13;
            this.simpleButtonClearLine.Text = "清除线";
            this.simpleButtonClearLine.Click += new System.EventHandler(this.simpleButtonClearLine_Click);
            // 
            // simpleButtonClearPoint
            // 
            this.simpleButtonClearPoint.Location = new System.Drawing.Point(500, 9);
            this.simpleButtonClearPoint.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonClearPoint.Name = "simpleButtonClearPoint";
            this.simpleButtonClearPoint.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonClearPoint.TabIndex = 12;
            this.simpleButtonClearPoint.Text = "清除点";
            this.simpleButtonClearPoint.Click += new System.EventHandler(this.simpleButtonClearPoint_Click);
            // 
            // panelControlDelete
            // 
            this.panelControlDelete.Controls.Add(this.listBoxControlDeleteBlock);
            this.panelControlDelete.Controls.Add(this.simpleButtonClearSelectBlocks);
            this.panelControlDelete.Controls.Add(this.listBoxControlDBBlock);
            this.panelControlDelete.Controls.Add(this.simpleButtonSelectBlock);
            this.panelControlDelete.Location = new System.Drawing.Point(9, 239);
            this.panelControlDelete.Margin = new System.Windows.Forms.Padding(2);
            this.panelControlDelete.Name = "panelControlDelete";
            this.panelControlDelete.Size = new System.Drawing.Size(558, 417);
            this.panelControlDelete.TabIndex = 14;
            // 
            // listBoxControlDeleteBlock
            // 
            this.listBoxControlDeleteBlock.Location = new System.Drawing.Point(304, 16);
            this.listBoxControlDeleteBlock.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxControlDeleteBlock.Name = "listBoxControlDeleteBlock";
            this.listBoxControlDeleteBlock.Size = new System.Drawing.Size(194, 382);
            this.listBoxControlDeleteBlock.TabIndex = 10;
            // 
            // simpleButtonClearSelectBlocks
            // 
            this.simpleButtonClearSelectBlocks.Location = new System.Drawing.Point(237, 65);
            this.simpleButtonClearSelectBlocks.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonClearSelectBlocks.Name = "simpleButtonClearSelectBlocks";
            this.simpleButtonClearSelectBlocks.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonClearSelectBlocks.TabIndex = 8;
            this.simpleButtonClearSelectBlocks.Text = "清空选择";
            this.simpleButtonClearSelectBlocks.Click += new System.EventHandler(this.simpleButtonClearSelectBlocks_Click);
            // 
            // listBoxControlDBBlock
            // 
            this.listBoxControlDBBlock.Location = new System.Drawing.Point(33, 12);
            this.listBoxControlDBBlock.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxControlDBBlock.Name = "listBoxControlDBBlock";
            this.listBoxControlDBBlock.Size = new System.Drawing.Size(194, 382);
            this.listBoxControlDBBlock.TabIndex = 7;
            // 
            // simpleButtonSelectBlock
            // 
            this.simpleButtonSelectBlock.Location = new System.Drawing.Point(237, 9);
            this.simpleButtonSelectBlock.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButtonSelectBlock.Name = "simpleButtonSelectBlock";
            this.simpleButtonSelectBlock.Size = new System.Drawing.Size(54, 23);
            this.simpleButtonSelectBlock.TabIndex = 9;
            this.simpleButtonSelectBlock.Text = "选择区块";
            this.simpleButtonSelectBlock.Click += new System.EventHandler(this.simpleButtonSelectBlock_Click);
            // 
            // FrmOpenExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 698);
            this.Controls.Add(this.panelControlDelete);
            this.Controls.Add(this.panelControlSelectSheet);
            this.Controls.Add(this.panelControlOpenExcel);
            this.Controls.Add(this.simpleButtonUpLoad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOpenExcel";
            this.Text = "打开Excel";
            this.Load += new System.EventHandler(this.FrmOpenExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPointSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLineSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenExcel)).EndInit();
            this.panelControlOpenExcel.ResumeLayout(false);
            this.panelControlOpenExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSelectSheet)).EndInit();
            this.panelControlSelectSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelete)).EndInit();
            this.panelControlDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlDeleteBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlDBBlock)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControlSelectSheet;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClearLine;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClearPoint;
        private DevExpress.XtraEditors.PanelControl panelControlDelete;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlDeleteBlock;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClearSelectBlocks;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlDBBlock;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelectBlock;
    }
}
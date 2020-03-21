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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonOpenExcel
            // 
            this.simpleButtonOpenExcel.Location = new System.Drawing.Point(466, 58);
            this.simpleButtonOpenExcel.Name = "simpleButtonOpenExcel";
            this.simpleButtonOpenExcel.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonOpenExcel.TabIndex = 5;
            this.simpleButtonOpenExcel.Text = "打开Excel";
            this.simpleButtonOpenExcel.Click += new System.EventHandler(this.simpleButtonOpenExcel_Click);
            // 
            // simpleButtonUpLoad
            // 
            this.simpleButtonUpLoad.Location = new System.Drawing.Point(628, 58);
            this.simpleButtonUpLoad.Name = "simpleButtonUpLoad";
            this.simpleButtonUpLoad.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonUpLoad.TabIndex = 4;
            this.simpleButtonUpLoad.Text = "上传Excel";
            this.simpleButtonUpLoad.Click += new System.EventHandler(this.simpleButtonUpLoad_Click);
            // 
            // labelControlExcelPath
            // 
            this.labelControlExcelPath.Location = new System.Drawing.Point(32, 12);
            this.labelControlExcelPath.Name = "labelControlExcelPath";
            this.labelControlExcelPath.Size = new System.Drawing.Size(78, 18);
            this.labelControlExcelPath.TabIndex = 3;
            this.labelControlExcelPath.Text = "Excel路径：";
            // 
            // textBoxXExcelPath
            // 
            this.textBoxXExcelPath.Location = new System.Drawing.Point(141, 4);
            this.textBoxXExcelPath.Name = "textBoxXExcelPath";
            this.textBoxXExcelPath.Size = new System.Drawing.Size(581, 24);
            this.textBoxXExcelPath.TabIndex = 6;
            // 
            // listBoxControlSheetName
            // 
            this.listBoxControlSheetName.Location = new System.Drawing.Point(141, 44);
            this.listBoxControlSheetName.Name = "listBoxControlSheetName";
            this.listBoxControlSheetName.Size = new System.Drawing.Size(120, 95);
            this.listBoxControlSheetName.TabIndex = 7;
            // 
            // FrmOpenExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 159);
            this.Controls.Add(this.listBoxControlSheetName);
            this.Controls.Add(this.textBoxXExcelPath);
            this.Controls.Add(this.simpleButtonOpenExcel);
            this.Controls.Add(this.simpleButtonUpLoad);
            this.Controls.Add(this.labelControlExcelPath);
            this.Name = "FrmOpenExcel";
            this.Text = "FrmOpenExcel";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxXExcelPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlSheetName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonOpenExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpLoad;
        private DevExpress.XtraEditors.LabelControl labelControlExcelPath;
        private DevExpress.XtraEditors.TextEdit textBoxXExcelPath;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlSheetName;
    }
}
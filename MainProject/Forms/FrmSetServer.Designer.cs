namespace MainProject.Forms
{
    partial class FrmSetServer
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
            this.gb_Conn = new System.Windows.Forms.GroupBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_Uid = new System.Windows.Forms.TextBox();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.lb_Pwd = new System.Windows.Forms.Label();
            this.lb_Uid = new System.Windows.Forms.Label();
            this.lb_Server = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Conn_Test = new System.Windows.Forms.Button();
            this.gb_Conn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Conn
            // 
            this.gb_Conn.Controls.Add(this.txt_Pwd);
            this.gb_Conn.Controls.Add(this.txt_Uid);
            this.gb_Conn.Controls.Add(this.txt_Server);
            this.gb_Conn.Controls.Add(this.lb_Pwd);
            this.gb_Conn.Controls.Add(this.lb_Uid);
            this.gb_Conn.Controls.Add(this.lb_Server);
            this.gb_Conn.Location = new System.Drawing.Point(13, 13);
            this.gb_Conn.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Conn.Name = "gb_Conn";
            this.gb_Conn.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Conn.Size = new System.Drawing.Size(337, 145);
            this.gb_Conn.TabIndex = 6;
            this.gb_Conn.TabStop = false;
            this.gb_Conn.Text = "连接信息";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(128, 100);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(176, 25);
            this.txt_Pwd.TabIndex = 7;
            this.txt_Pwd.Text = "1234";
            // 
            // txt_Uid
            // 
            this.txt_Uid.Location = new System.Drawing.Point(128, 62);
            this.txt_Uid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Uid.Name = "txt_Uid";
            this.txt_Uid.Size = new System.Drawing.Size(176, 25);
            this.txt_Uid.TabIndex = 6;
            this.txt_Uid.Text = "root";
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(128, 28);
            this.txt_Server.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(176, 25);
            this.txt_Server.TabIndex = 4;
            this.txt_Server.Text = "127.0.0.1";
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.AutoSize = true;
            this.lb_Pwd.Location = new System.Drawing.Point(57, 104);
            this.lb_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(45, 15);
            this.lb_Pwd.TabIndex = 3;
            this.lb_Pwd.Text = "密码:";
            // 
            // lb_Uid
            // 
            this.lb_Uid.AutoSize = true;
            this.lb_Uid.Location = new System.Drawing.Point(57, 66);
            this.lb_Uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Uid.Name = "lb_Uid";
            this.lb_Uid.Size = new System.Drawing.Size(60, 15);
            this.lb_Uid.TabIndex = 2;
            this.lb_Uid.Text = "用户名:";
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Location = new System.Drawing.Point(25, 31);
            this.lb_Server.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(90, 15);
            this.lb_Server.TabIndex = 0;
            this.lb_Server.Text = "服务器地址:";
            // 
            // bt_Login
            // 
            this.bt_Login.Enabled = false;
            this.bt_Login.Location = new System.Drawing.Point(250, 185);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 29);
            this.bt_Login.TabIndex = 11;
            this.bt_Login.Text = "登陆";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Conn_Test
            // 
            this.bt_Conn_Test.Location = new System.Drawing.Point(13, 185);
            this.bt_Conn_Test.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Conn_Test.Name = "bt_Conn_Test";
            this.bt_Conn_Test.Size = new System.Drawing.Size(100, 29);
            this.bt_Conn_Test.TabIndex = 10;
            this.bt_Conn_Test.Text = "测试连接";
            this.bt_Conn_Test.UseVisualStyleBackColor = true;
            // 
            // FrmSetServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 237);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.bt_Conn_Test);
            this.Controls.Add(this.gb_Conn);
            this.Name = "FrmSetServer";
            this.Text = "测试数据库连接";
            this.gb_Conn.ResumeLayout(false);
            this.gb_Conn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Conn;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_Uid;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.Label lb_Pwd;
        private System.Windows.Forms.Label lb_Uid;
        private System.Windows.Forms.Label lb_Server;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Conn_Test;
    }
}
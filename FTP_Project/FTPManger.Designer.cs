namespace FTP_Project
{
    partial class FTPManger
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.FTPUserPwTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FTPUserIdTxt = new System.Windows.Forms.TextBox();
            this.FTPIpAddrTxt = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.myDirectory = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RemoteTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ftpDirectory = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.syncBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnectionBtn);
            this.panel1.Controls.Add(this.FTPUserPwTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FTPUserIdTxt);
            this.panel1.Controls.Add(this.FTPIpAddrTxt);
            this.panel1.Controls.Add(this.IP);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 82);
            this.panel1.TabIndex = 0;
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.Location = new System.Drawing.Point(631, 34);
            this.ConnectionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(85, 28);
            this.ConnectionBtn.TabIndex = 6;
            this.ConnectionBtn.Text = "Connect";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click_1);
            // 
            // FTPUserPwTxt
            // 
            this.FTPUserPwTxt.Location = new System.Drawing.Point(461, 35);
            this.FTPUserPwTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPUserPwTxt.Name = "FTPUserPwTxt";
            this.FTPUserPwTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPUserPwTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // FTPUserIdTxt
            // 
            this.FTPUserIdTxt.Location = new System.Drawing.Point(254, 35);
            this.FTPUserIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPUserIdTxt.Name = "FTPUserIdTxt";
            this.FTPUserIdTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPUserIdTxt.TabIndex = 3;
            // 
            // FTPIpAddrTxt
            // 
            this.FTPIpAddrTxt.Location = new System.Drawing.Point(51, 35);
            this.FTPIpAddrTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPIpAddrTxt.Name = "FTPIpAddrTxt";
            this.FTPIpAddrTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPIpAddrTxt.TabIndex = 2;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(21, 41);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(20, 15);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(176, 41);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(72, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35663F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.67836F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.32164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 428);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.localTextBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 228);
            this.panel2.TabIndex = 0;
            // 
            // localTextBox
            // 
            this.localTextBox.Location = new System.Drawing.Point(93, 16);
            this.localTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(277, 25);
            this.localTextBox.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.myDirectory);
            this.panel4.Location = new System.Drawing.Point(2, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 178);
            this.panel4.TabIndex = 9;
            // 
            // myDirectory
            // 
            this.myDirectory.Location = new System.Drawing.Point(3, 2);
            this.myDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myDirectory.Name = "myDirectory";
            this.myDirectory.Size = new System.Drawing.Size(387, 158);
            this.myDirectory.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local site";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RemoteTextBox);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(400, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 228);
            this.panel3.TabIndex = 1;
            // 
            // RemoteTextBox
            // 
            this.RemoteTextBox.Location = new System.Drawing.Point(101, 16);
            this.RemoteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoteTextBox.Name = "RemoteTextBox";
            this.RemoteTextBox.Size = new System.Drawing.Size(277, 25);
            this.RemoteTextBox.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.ftpDirectory);
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 176);
            this.panel5.TabIndex = 10;
            // 
            // ftpDirectory
            // 
            this.ftpDirectory.Location = new System.Drawing.Point(-1, 0);
            this.ftpDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ftpDirectory.Name = "ftpDirectory";
            this.ftpDirectory.Size = new System.Drawing.Size(396, 174);
            this.ftpDirectory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remote site";
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(400, 236);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(395, 188);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 236);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 188);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // syncBtn
            // 
            this.syncBtn.Location = new System.Drawing.Point(691, 534);
            this.syncBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(105, 48);
            this.syncBtn.TabIndex = 2;
            this.syncBtn.Text = "동기화";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FTPManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 662);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FTPManger";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FTPManger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.TextBox FTPUserPwTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FTPUserIdTxt;
        private System.Windows.Forms.TextBox FTPIpAddrTxt;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView myDirectory;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox RemoteTextBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TreeView ftpDirectory;
        private System.Windows.Forms.Button syncBtn;
    }
}


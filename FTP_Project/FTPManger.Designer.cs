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
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.FTPUserPwTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FTPUserIdTxt = new System.Windows.Forms.TextBox();
            this.FTPIpAddrTxt = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.myDirectory = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoteTextBox = new System.Windows.Forms.TextBox();
            this.ftpDirectory = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.syncBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.Location = new System.Drawing.Point(703, 27);
            this.ConnectionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(95, 28);
            this.ConnectionBtn.TabIndex = 6;
            this.ConnectionBtn.Text = "Connect";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click_1);
            // 
            // FTPUserPwTxt
            // 
            this.FTPUserPwTxt.Location = new System.Drawing.Point(480, 40);
            this.FTPUserPwTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPUserPwTxt.Name = "FTPUserPwTxt";
            this.FTPUserPwTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPUserPwTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // FTPUserIdTxt
            // 
            this.FTPUserIdTxt.Location = new System.Drawing.Point(273, 40);
            this.FTPUserIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPUserIdTxt.Name = "FTPUserIdTxt";
            this.FTPUserIdTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPUserIdTxt.TabIndex = 3;
            // 
            // FTPIpAddrTxt
            // 
            this.FTPIpAddrTxt.Location = new System.Drawing.Point(70, 40);
            this.FTPIpAddrTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTPIpAddrTxt.Name = "FTPIpAddrTxt";
            this.FTPIpAddrTxt.Size = new System.Drawing.Size(100, 25);
            this.FTPIpAddrTxt.TabIndex = 2;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(40, 46);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(20, 15);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(195, 46);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(72, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            // 
            // localTextBox
            // 
            this.localTextBox.Location = new System.Drawing.Point(113, 14);
            this.localTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(277, 25);
            this.localTextBox.TabIndex = 10;
            // 
            // myDirectory
            // 
            this.myDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDirectory.Location = new System.Drawing.Point(0, 0);
            this.myDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myDirectory.Name = "myDirectory";
            this.myDirectory.Size = new System.Drawing.Size(438, 186);
            this.myDirectory.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local site";
            // 
            // RemoteTextBox
            // 
            this.RemoteTextBox.Location = new System.Drawing.Point(119, 15);
            this.RemoteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoteTextBox.Name = "RemoteTextBox";
            this.RemoteTextBox.Size = new System.Drawing.Size(277, 25);
            this.RemoteTextBox.TabIndex = 11;
            // 
            // ftpDirectory
            // 
            this.ftpDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftpDirectory.Location = new System.Drawing.Point(0, 0);
            this.ftpDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ftpDirectory.Name = "ftpDirectory";
            this.ftpDirectory.Size = new System.Drawing.Size(436, 186);
            this.ftpDirectory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remote site";
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(436, 224);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(438, 224);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // syncBtn
            // 
            this.syncBtn.Enabled = false;
            this.syncBtn.Location = new System.Drawing.Point(661, 0);
            this.syncBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(105, 48);
            this.syncBtn.TabIndex = 2;
            this.syncBtn.Text = "동기화";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(620, 46);
            this.progressBar.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "실행상황";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(772, 0);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 48);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(703, 59);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(95, 28);
            this.DisconnectBtn.TabIndex = 7;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 477F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 763);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DisconnectBtn);
            this.panel6.Controls.Add(this.FTPUserPwTxt);
            this.panel6.Controls.Add(this.ConnectionBtn);
            this.panel6.Controls.Add(this.UserName);
            this.panel6.Controls.Add(this.IP);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.FTPIpAddrTxt);
            this.panel6.Controls.Add(this.FTPUserIdTxt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 94);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.logBox);
            this.panel8.Controls.Add(this.lblStatus);
            this.panel8.Controls.Add(this.progressBar);
            this.panel8.Controls.Add(this.deleteBtn);
            this.panel8.Controls.Add(this.syncBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 580);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(886, 180);
            this.panel8.TabIndex = 2;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(20, 70);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(857, 107);
            this.logBox.TabIndex = 6;
            this.logBox.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22573F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.77427F));
            this.tableLayoutPanel3.Controls.Add(this.panel12, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5036F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.49641F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(886, 471);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.listView1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 244);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(438, 224);
            this.panel12.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.listView2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(447, 244);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(436, 224);
            this.panel11.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.localTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.RemoteTextBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(447, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 43);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.myDirectory);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 52);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(438, 186);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ftpDirectory);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(447, 52);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(436, 186);
            this.panel10.TabIndex = 3;
            // 
            // FTPManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 783);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FTPManger";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FTPManger_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.TextBox FTPUserPwTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FTPUserIdTxt;
        private System.Windows.Forms.TextBox FTPIpAddrTxt;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView myDirectory;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox RemoteTextBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TreeView ftpDirectory;

        private System.Windows.Forms.Button syncBtn;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RichTextBox logBox;
    }
}


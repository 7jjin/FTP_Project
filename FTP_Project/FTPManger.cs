using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FTP_Project
{
    public partial class FTPManger : Form
    {
        // FTP 연결 확인 값
        //private bool result = false;
        //private FTPClass ftp = null;

        private bool result = false;
        private static TcpClient client = new TcpClient();

        public FTPManger()
            
        {

            InitializeComponent();
            //ftp = new FTPClass();
            
            FTPIpAddrTxt.Focus();

            // 각각의 TextBox를 Default값으로 넣는다.
            if (Properties.Settings.Default.FtpSaveInfo)
            {
                FTPIpAddrTxt.Text = Properties.Settings.Default.FtpIpAddress;
                FTPUserIdTxt.Text = Properties.Settings.Default.FtpUserId;
                FTPUserPwTxt.Text = Properties.Settings.Default.FtpUserPw;
            }
            // 트리뷰 이벤트 핸들러 연결
            myDirectory.BeforeExpand += treeView1_BeforeExpand;
            myDirectory.NodeMouseClick += treeView1_NodeMouseClick;
            ftpDirectory.BeforeExpand += treeView2_BeforeExpand;
            ftpDirectory.NodeMouseClick += treeView2_NodeMouseClick;
            listView1.ItemDrag += new ItemDragEventHandler(listView_ItemDrag);
            listView2.ItemDrag += new ItemDragEventHandler(listView_ItemDrag);
            listView1.DragEnter += new DragEventHandler(listView_DragEnter);
            listView2.DragEnter += new DragEventHandler(listView_DragEnter);
            listView1.DragDrop += new DragEventHandler(listView_DragDrop);
            listView2.DragDrop += new DragEventHandler(listView_DragDrop);
            listView1.DragOver += new DragEventHandler(listView_DragOver);
            listView2.DragOver += new DragEventHandler(listView_DragOver);
        }

        StreamReader streamReader;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter;  // 데이타 쓰기 위한 스트림라이터 

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ItemDrag 이벤트 핸들러
        private void listView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;
            if (listView != null)
            {
                listView.DoDragDrop(listView.SelectedItems, DragDropEffects.Move);
            }
        }

        // DragEnter 이벤트 핸들러
        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // DragOver 이벤트 핸들러
        private void listView_DragOver(object sender, DragEventArgs e)
        {
            System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;
            Point point = listView.PointToClient(new Point(e.X, e.Y));
            ListViewItem item = listView.GetItemAt(point.X, point.Y);

            if (item != null)
            {
                listView.InsertionMark.Index = item.Index;
                listView.InsertionMark.AppearsAfterItem = point.Y > item.Bounds.Top + (item.Bounds.Height / 2);
            }
            else
            {
                listView.InsertionMark.Index = listView.Items.Count - 1;
            }
        }

        // DragDrop 이벤트 핸들러
        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;

            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection)))
            {
                System.Windows.Forms.ListView.SelectedListViewItemCollection items = (System.Windows.Forms.ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection));
                Point point = listView.PointToClient(new Point(e.X, e.Y));
                ListViewItem targetItem = listView.GetItemAt(point.X, point.Y);
                int targetIndex = targetItem != null ? targetItem.Index : listView.Items.Count;

                foreach (ListViewItem item in items)
                {
                    ListViewItem clonedItem = (ListViewItem)item.Clone();
                    listView.Items.Insert(targetIndex, clonedItem);
                    item.Remove();
                    targetIndex++;
                }
            }
        }

        // TreeView 폴더 기준으로 노드 경로를 가져옴
        private void FTPManger_Load(object sender, EventArgs e)
        {
            //Thread receiveThread = new Thread(new ThreadStart(Receive));
            //receiveThread.IsBackground = true;
            //receiveThread.Start();
            // 내 드라이브의 모든 폴더 경로 가져오기
            DriveInfo[] allDrives = DriveInfo.GetDrives();
          
            foreach (DriveInfo dname in allDrives)
            {
                if (dname.DriveType == DriveType.Fixed)
                {
                    TreeNode rootNode = new TreeNode(dname.Name);
                    myDirectory.Nodes.Add(rootNode);
                    Fill(rootNode);
                }
            }
            //첫번째 노드 확장
            myDirectory.Nodes[0].Expand();

            //ListView 보기 속성 설정
            listView1.View = View.Details;
            listView2.View = View.Details;

            //ListView Details 속성을 위한 헤더 추가
            listView1.Columns.Add("이름", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("수정한 날짜", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("유형", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("크기", listView1.Width / 4, HorizontalAlignment.Left);

            listView2.Columns.Add("이름", listView2.Width / 4, HorizontalAlignment.Left);
            listView2.Columns.Add("수정한 날짜", listView2.Width / 4, HorizontalAlignment.Left);
            listView2.Columns.Add("유형", listView2.Width / 4, HorizontalAlignment.Left);
            listView2.Columns.Add("크기", listView2.Width / 4, HorizontalAlignment.Left);

            //행 단위 선택 가능
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }

        //private void Receive()
        //{
        //    while (true)
        //    {
        //        if (client.Connected)
        //        {
        //            try
        //            {
        //                NetworkStream stream = client.GetStream();
        //                byte[] buffer = new byte[1024];
        //                int bytes = stream.Read(buffer, 0, buffer.Length);
        //                if (bytes <= 0)
        //                {
        //                    continue;
        //                }

        //                string message = Encoding.UTF8.GetString(buffer, 0, bytes);
        //                Console.WriteLine("[Other] " + message);
        //            }
        //            catch (Exception ex)
        //            {
        //                Debug.WriteLine(ex.ToString());
        //            }
        //        }
        //    }
        //}
        // 디렉토리 정보를 Treeview에 뿌려주기
        private void Fill(TreeNode dirNode)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
                //드라이브의 하위 폴더 추가
                foreach (DirectoryInfo dirItem in dir.GetDirectories())
                {
                    TreeNode newNode = new TreeNode(dirItem.Name);
                    dirNode.Nodes.Add(newNode);
                    newNode.Nodes.Add("*");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message);
            }
        }
        /// <summary>
        /// 트리가 확장되기 전에 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                Fill(e.Node);
            }
        }
        /// <summary>
        /// 트리가 닫히기 전에 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                Fill(e.Node);
            }
        }
        private void treeView2_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                Fill(e.Node);
            }
        }
        /// <summary>
        /// 트리가 닫히기 전에 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView2_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                Fill(e.Node);
            }
        }
        /// <summary>
        /// 트리를 마우스로 클릭할 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SettingMyListVeiw(e.Node.FullPath);
        }
        /// <summary>
        /// Client 아래 ListView를 그린다.
        /// </summary>
        /// <param name="sFullPath"></param>
        private void SettingMyListVeiw(string sFullPath)
        {
            try
            {
                //기존의 파일 목록 제거
                listView1.Items.Clear();
                //현재 경로를 표시

                localTextBox.Text = sFullPath;
                DirectoryInfo dir = new DirectoryInfo(sFullPath);
                int DirectCount = 0;
                //하부 데렉토르 보여주기
                foreach (DirectoryInfo dirItem in dir.GetDirectories())
                {
                    //하부 디렉토리가 존재할 경우 ListView에 추가
                    //ListViewItem 객체를 생성
                    ListViewItem lsvitem = new ListViewItem();
                    //생성된 ListViewItem 객체에 똑같은 이미지를 할당
                    lsvitem.Text = dirItem.Name;
                    //아이템을 ListView(listView1)에 추가
                    listView1.Items.Add(lsvitem);
                    listView1.Items[DirectCount].SubItems.Add(dirItem.CreationTime.ToString());
                    listView1.Items[DirectCount].SubItems.Add("폴더");
                    listView1.Items[DirectCount].SubItems.Add(dirItem.GetFiles().Length.ToString() + " files");
                    DirectCount++;
                }
                //디렉토리에 존재하는 파일목록 보여주기
                FileInfo[] files = dir.GetFiles();
                int Count = 0;
                foreach (FileInfo fileinfo in files)
                {
                    listView1.Items.Add(fileinfo.Name);
                    if (fileinfo.LastWriteTime != null)
                    {
                        listView1.Items[Count].SubItems.Add(fileinfo.LastWriteTime.ToString());
                    }
                    else
                    {
                        listView1.Items[Count].SubItems.Add(fileinfo.CreationTime.ToString());
                    }
                    listView1.Items[Count].SubItems.Add(fileinfo.Attributes.ToString());
                    listView1.Items[Count].SubItems.Add(fileinfo.Length.ToString());
                    Count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message);
            }
            myDirectory.Nodes[0].Expand();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void FTPIpAddrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        // FTP 연결 버튼 이벤트
        private void ConnectionBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FTPIpAddrTxt.Text))
            {
                MessageBox.Show("IP를 입력해주세요.");
                FTPIpAddrTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FTPUserIdTxt.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                FTPUserIdTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FTPUserPwTxt.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                FTPUserPwTxt.Focus();
                return;
            }

            //result = ftp.ConnectToServer(FTPIpAddrTxt.Text, FTPUserIdTxt.Text, FTPUserPwTxt.Text);
            Thread thread1 = new Thread(connect);  // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true;  // Form이 종료되면 thread1도 종료.
            thread1.Start();  // thread1 시작.



            
        }

        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpClient tcpClient1 = new TcpClient();  // TcpClient 객체 생성
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse("21"));  // IP주소와 Port번호를 할당
            tcpClient1.Connect(ipEnd);  // 서버에 연결 요청
            
           
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate { textBox1.Text = "서버 연결됨..."; }));
            }
            else
            {
                textBox1.Text = "서버 연결됨...";
            }

            streamReader = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (true)  // 클라이언트가 연결되어 있는 동안
            {
                //string receiveData1 = streamReader.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                //writeRichTextbox(receiveData1);  // 데이타를 수신창에 쓰기
                string sendData = FTPUserIdTxt.Text;
                streamWriter.Write(sendData);
            }
        }


        // remote Treeview 구성 메소드
        private void LoadDirectoryTree(string path)
        {
            ftpDirectory.Nodes.Clear();
            TreeNode rootNode = new TreeNode(path);
            ftpDirectory.Nodes.Add(rootNode);

            //AddDirectoryNodes(rootNode, path);
            rootNode.Expand();
        }

        // remote 폴더, 파일 가져오는 메소드
        //private void AddDirectoryNodes(TreeNode treeNode, string path)
        //{
        //     List<string> directories = ftp.GetDirectoryListing(path);

        //    foreach (string dir in directories)
        //    {
        //        string[] parts = dir.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
        //        string name = parts[8];

        //        if (dir.StartsWith("d"))
        //        {
        //            // 디렉토리인 경우
        //            TreeNode dirNode = new TreeNode(name);
        //            treeNode.Nodes.Add(dirNode);
        //            AddDirectoryNodes(dirNode, path + "/" + name);
        //        }
        //        else
        //        {
        //            // 파일인 경우
        //            TreeNode fileNode = new TreeNode(name);
        //            treeNode.Nodes.Add(fileNode);
        //        }
        //    }
        //}

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //SettingRemoteListView(e.Node.FullPath);
        }

        //private void SettingRemoteListView(string sFullPath)
        //{
        //    try
        //    {
        //        listView2.Items.Clear();

        //        RemoteTextBox.Text = sFullPath;

        //        List<string> directories = ftp.GetDirectoryListing(sFullPath);
        //        List<string> files = ftp.GetDirectoryListing(sFullPath);

        //        int DirectCount = 0;
        //        foreach (string dir in directories)
        //        {
        //            string[] parts = dir.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
        //            string name = parts[8];
        //            string date = parts[5] + " " + parts[6] + " " + parts[7];

        //            ListViewItem lsvitem = new ListViewItem();
        //            lsvitem.Text = name;
        //            listView2.Items.Add(lsvitem);
        //            listView2.Items[DirectCount].SubItems.Add(date);
        //            listView2.Items[DirectCount].SubItems.Add("폴더");
        //            listView2.Items[DirectCount].SubItems.Add("");
        //            DirectCount++;
        //        }

        //        int Count = 0;
        //        foreach (string file in files)
        //        {
        //            string[] parts = file.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
        //            string name = parts[8];
        //            string date = parts[5] + " " + parts[6] + " " + parts[7];
        //            string size = parts[4];

        //            ListViewItem lsvitem = new ListViewItem();
        //            lsvitem.Text = name;
        //            listView2.Items.Add(lsvitem);
        //            listView2.Items[Count].SubItems.Add(date);
        //            listView2.Items[Count].SubItems.Add("파일");
        //            listView2.Items[Count].SubItems.Add(size);
        //            Count++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("에러 발생 : " + ex.Message);
        //    }
        //    ftpDirectory.Nodes[0].Expand();
        //}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void localTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ftpDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {

        }

        

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void listView2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SyncListViews(listView1, listView2);
        }
        private void SyncListViews(System.Windows.Forms.ListView source, System.Windows.Forms.ListView target)
        {
            target.Items.Clear();
            HashSet<string> targetItems = new HashSet<string>();
            foreach (ListViewItem item in target.Items)
            {
                targetItems.Add(item.Text);
            }

            foreach (ListViewItem item in source.Items)
            {
                if (!targetItems.Contains(item.Text))
                {
                    ListViewItem clonedItem = (ListViewItem)item.Clone();
                    target.Items.Add(clonedItem);
                }
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate { textBox1.Text = "서버 해제됨...."; }));
            }
            else
            {
                textBox1.Text = "서버 해제됨....";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

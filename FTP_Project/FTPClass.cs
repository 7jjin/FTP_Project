//using FTP_Project;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace FTP_Project
//{
//    class FTPClass
//    {
//        public delegate void ExceptionEventHandler(string locationID, Exception ex);

//        public event ExceptionEventHandler ExceptionEvent;

//        public Exception LastException = null;

//        public bool isConnected { get; set; }

//        private string ipAddr = string.Empty;
//        private string userId = string.Empty;
//        private string pwd = string.Empty;

//        List<DirectoryPath> directoryPaths = null;

//        public FTPClass()
//        {
//        }

//        // 서버 연결

//        public bool ConnectToServer(string ip, string userId, string pwd)
//        {
//            this.isConnected = false;
//            this.ipAddr = ip;
//            this.userId = userId;
//            this.pwd = pwd;

//            string url = $@"FTP://{this.ipAddr}:21/";

//            try
//            {

//                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
//                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
//                ftpWebRequest.KeepAlive = false;
//                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;
//                ftpWebRequest.UsePassive = true;    // FTP passive 모드


//                // FTP 서버 응답을 반환
//                using (ftpWebRequest.GetResponse())
//                {
//                }

//                this.isConnected = true;
//            }
//            catch (Exception ex)
//            {
//                this.LastException = ex;


//                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
//                string id = $"{info.ReflectedType.Name}.{info.Name}";

//                if (this.ExceptionEvent != null)
//                {
//                    this.ExceptionEvent(id, ex);
//                }

//                return false;
//            }

//            return true;
//        }

//        // 디렉토리 목록을 가져오는 메서드
//        public List<string> GetDirectoryListing(string path)
//        {
//            List<string> directories = new List<string>();

//            try
//            {
//                string url = $@"FTP://{this.ipAddr}/{path}";
//                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
//                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
//                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

//                using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
//                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
//                {
//                    while (!reader.EndOfStream)
//                    {
//                        directories.Add(reader.ReadLine());
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                this.LastException = ex;

//                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
//                string id = $"{info.ReflectedType.Name}.{info.Name}";

//                if (this.ExceptionEvent != null)
//                {
//                    this.ExceptionEvent(id, ex);
//                }
//            }

//            return directories;
//        }
//    }
//}
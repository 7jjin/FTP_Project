using FTP_Project;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FTP_Project
{
    class FTPClass
    {
        public delegate void ExceptionEventHandler(string locationID, Exception ex);

        public event ExceptionEventHandler ExceptionEvent;

        public Exception LastException = null;

        public bool isConnected { get; set; }

        private string ipAddr = string.Empty;
        private string userId = string.Empty;
        private string pwd = string.Empty;

        List<DirectoryPath> directoryPaths = null;

        public FTPClass()
        {
        }

        // 서버 연결

        private bool connectToServer(string ip, string userId, string pwd)
        {
            this.isConnected = false;
            this.ipAddr = ip;
            this.userId = userId;
            this.pwd = pwd;

            string url = $@"FTP://{this.ipAddr}:21/";

            try
            {
  
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);

                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);

                ftpWebRequest.KeepAlive = false;

                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpWebRequest.UsePassive = false;

                // FTP 서버 응답을 반환
                using (ftpWebRequest.GetResponse())
                {
                }

                this.isConnected = true;
            }
            catch (Exception ex)
            {
                this.LastException = ex;


                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";

                if (this.ExceptionEvent != null)
                {
                    this.ExceptionEvent(id, ex);
                }

                return false;
            }

            return true;
        }

        

        public async Task<List<DirectoryPath>> GetFTPList(string path)
        {
            directoryPaths = new List<DirectoryPath>(); ;
            return await Task.FromResult(getFTPList(path));
        }

        // 전체파일 불러오기
        private List<DirectoryPath> getFTPList(string path)
        {
            string url = $@"FTP://{this.ipAddr}:21/{path}";
            DirectoryPath directoryPath = null;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(userId, pwd);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8))
                {
                    string strData = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(strData))
                    {
                        directoryPath = new DirectoryPath();
                        directoryPath.Folder = path;
                        directoryPath.File = "EMPTY";
                        directoryPaths.Add(directoryPath);
                    }

                    string[] filename = strData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string file in filename)
                    {
                        string[] fileDetailes = file.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                        directoryPath = new DirectoryPath();

                        if (fileDetailes[0].Contains("d"))
                        {
                            getFTPList($"{path}{fileDetailes[8]}/");
                        }
                        else
                        {
                            directoryPath.Folder = path;
                            directoryPath.File = fileDetailes[8];
                            directoryPaths.Add(directoryPath);
                        }
                        //Console.WriteLine($"권한 : {fileDetailes[0]}");
                        //Console.WriteLine($"파일or폴더 : {fileDetailes[8]}");
                    }

                    return directoryPaths;
                }
            }
        }
    }
}
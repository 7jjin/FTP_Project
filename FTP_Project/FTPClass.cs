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
using System.Windows.Forms;

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

        public bool ConnectToServer(string ip, string userId, string pwd)
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
                //using (ftpWebRequest.GetResponse())
                //{
                //}

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

        // 디렉토리 목록을 가져오는 메서드
        public List<string> GetDirectoryListing(string path)
        {
            List<string> directories = new List<string>();

            try
            {
                string url = $@"FTP://{this.ipAddr}/{path}";
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    while (!reader.EndOfStream)
                    {
                        directories.Add(reader.ReadLine());
                    }
                }
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
            }

            return directories;
        }

        // 디렉토리 업로드 메서드
        public bool UploadFile(string localFilePath, string remoteFilePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(localFilePath);
                string url = $"FTP://{this.ipAddr}/{remoteFilePath}";

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(this.userId, this.pwd);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false;

                using (FileStream fileStream = fileInfo.OpenRead())
                using (Stream requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // Optional: Handle response here if needed
                }

                return true;
            }
            catch (Exception ex)
            {
                this.LastException = ex;
                // Handle exception
                return false;
            }
        }

        //디렉토리 다운로드 메서드
        public bool DownloadFile(string remoteFilePath, string localFilePath)
        {
            try
            {
                string url = $"FTP://{this.ipAddr}/{remoteFilePath}".Replace("\\", "/");

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(this.userId, this.pwd);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false;

                using (FtpWebResponse response = (FtpWebResponse) request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                {
                    responseStream.CopyToAsync(fileStream);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download file {remoteFilePath}: {ex.Message}");
                return false;
            }
        }

        // 디렉토리 생성 메서드
        public async Task CreateDirectory(string remoteDirectoryPath)
        {
            try
            {
                // URL을 생성하고 역슬래시를 슬래시로 바꿉니다.
                string url = $"FTP://{this.ipAddr}/{remoteDirectoryPath}".Replace("\\", "/");

                // FtpWebRequest를 생성하고 메소드와 자격 증명을 설정합니다.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(this.userId, this.pwd);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false;

                // 디렉토리 생성 요청을 수행합니다.
                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    // 요청이 성공적으로 완료된 경우, 상태 코드에 따라 성공적으로 디렉토리를 생성한 것으로 간주합니다.
                    if (response.StatusCode == FtpStatusCode.CommandOK || response.StatusCode == FtpStatusCode.PathnameCreated)
                    {
                        Console.WriteLine($"Directory created successfully: {remoteDirectoryPath}");
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류가 발생하면 메시지 박스를 표시합니다.
                MessageBox.Show($"Failed to create directory {remoteDirectoryPath}: {ex.Message}");
            }
        }


    }
}
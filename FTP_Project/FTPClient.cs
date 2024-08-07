using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FTP_Project
{
    internal class FTPClient
    {
        private TcpClient _client;
        private NetworkStream _networkStream;
        private StreamReader _reader;
        private StreamWriter _writer;

        public FTPClient(string ipAddress, int port)
        {
            _client = new TcpClient(ipAddress, port);
            _networkStream = _client.GetStream();
            _reader = new StreamReader(_networkStream, Encoding.ASCII);
            _writer = new StreamWriter(_networkStream, Encoding.ASCII) { AutoFlush = true };
        }

        public void Connect()
        {
            Console.WriteLine(ReadResponse());
        }

        public void SendCommand(string command)
        {
            _writer.WriteLine(command);
            Console.WriteLine($"Sent: {command}");
            Console.WriteLine(ReadResponse());
        }

        public void Disconnect()
        {
            _client.Close();
            Console.WriteLine("Disconnected from server.");
        }

        private string ReadResponse()
        {
            return _reader.ReadLine();
        }

    }
}

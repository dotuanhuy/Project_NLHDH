using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLHDH_WinProcess.Thread
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        // Đóng kết nối
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        // Gửi tin cho tất cả client
        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            AddMessage("Server", txbMessage.Text);
            txbMessage.Clear();
        }

        IPEndPoint IP;  // Địa chỉ server
        Socket server;
        List<Socket> clientList = new List<Socket>();    // Danh sách client

        public object BinaryFormater { get; private set; }

        // Kết nối tới server
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 9999);   // Lắng nghe tất cả các địa chỉ IP trên máy
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);    // Lắng nghe vào xử lý kết nối từ địa chỉ ip và cổng trong IP
            System.Threading.Thread listen = new System.Threading.Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);     // Chờ tối đa 100 kết nối để xử lý
                        Socket client = server.Accept();
                        clientList.Add(client);

                        System.Threading.Thread receive = new System.Threading.Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);   // Lắng nghe tất cả các địa chỉ IP trên máy
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        // Đóng kết nối
        void Close()
        {
            server.Close();
        }

        // Gửi tin
        void Send(Socket client)
        {
            // Nếu giá trị textBox không rỗng
            if (client != null && txbMessage.Text != String.Empty)
                client.Send(Serialize(txbMessage.Text));
        }

        // Nhận tin
        void Receive(object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                // Nhận tin liên tục
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];    // 5MB
                    client.Receive(data);

                    string message = (string)Deserialize(data);    // Chuyển byte[] thành object rồi chuyển thành chuỗi

                    foreach (Socket item in clientList)
                    {
                        Console.WriteLine(item.LocalEndPoint);
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }

                    AddMessage("Client", message);
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi
                clientList.Remove(client);
                client.Close();
            }
        }

        // Add message vào khung chat
        void AddMessage(string obj, string message)
        {
            if(obj == "Client")
            {
                lsvMessage.Items.Add(new ListViewItem() { Text = "Client:  " + message });
            }
            else
            {
                lsvMessage.Items.Add(new ListViewItem() { Text = "Server:  " + message });
            }
        }

        // Phân mảnh data
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(stream, obj);    // phân mảnh thành chuỗi nhị phân
            return stream.ToArray();    // Trả về mảng byte
        }

        // Gom mảnh lại
        Object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formater = new BinaryFormatter();
            return formater.Deserialize(stream);    // Chuyển đổi dữ liệu nhị phân về đối tượng
        }

        // đóng kết nối khi đóng form
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string selectedFile = openFileDialog1.FileName;
            //    txbMessage.Text = selectedFile;
            //}
        }
    }
}

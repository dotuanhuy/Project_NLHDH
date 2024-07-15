using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLHDH_WinProcess.Thread
{
        public partial class ClientChat : Form
        {
            public ClientChat()
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;
                Connect();
            }

            private void btnSend_Click(object sender, EventArgs e)
            {
                if(txbMessage.Text == "")
                {
                    return;
                }
                Send();
                AddMessage("Client", txbMessage.Text);
            }

            IPEndPoint IP;  // Địa chỉ server
            Socket client;

            public object BinaryFormater { get; private set; }

            // Kết nối tới server
            void Connect()
            {
                IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                try
                {
                    client.Connect(IP);

                }
                catch
                {
                    MessageBox.Show("Không thể kết nối server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            // Tạo ra luồng lắng nghe
                System.Threading.Thread listen = new System.Threading.Thread(Receive);
                listen.IsBackground = true;
                listen.Start();

            }

            // Đóng kết nối
            void Close()
            {
                client.Close();
            }

            // Gửi tin
            void Send()
            {
                // Nếu giá trị textBox không rỗng
                if (txbMessage.Text != String.Empty)
                    client.Send(Serialize(txbMessage.Text));
            }

            // Nhận tin
            void Receive()
            {
                try
                {
                    // Nhận tin liên tục
                    while (true)
                    {
                        byte[] data = new byte[1024 * 5000];    // 5MB
                        client.Receive(data);

                        string message = (string)Deserialize(data);    // Chuyển byte[] thành object rồi chuyển thành chuỗi

                        AddMessage("Server", message);
                    }
                }
                catch 
                {
                    Close();
                }
            }

            // Add message vào khung chat
            void AddMessage(string obj, string message)
            {
                if(obj == "Server")
                {
                    lsvMessage.Items.Add(new ListViewItem() { Text = "Server:  " + message });
                }
                else
                {
                lsvMessage.Items.Add(new ListViewItem() { Text = "Client:  " + message });
            }
                txbMessage.Clear();
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
    }
    }


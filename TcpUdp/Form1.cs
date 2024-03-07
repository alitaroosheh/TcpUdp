using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.IPNetwork2;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;
namespace TcpUdp
{
    public partial class Form1 : Form
    {


        public class Address
        {
            public string Ip { get; set; }
            public string Port { get; set; }
        }
        public class Settings
        {

            public List<Address> addresses { get; set; } = new List<Address>();
        }

        UdpClient udpClient;
        TcpClient TcpClient;
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();
        }

        void settingsAddAddress(string ip, string port)
        {
            settings.addresses.Add(new Address { Ip = ip, Port = port });
            settings.addresses.Distinct();
            saveSettings();
            loadSettings();

        }
        private void btnUdpClientConnect_Click(object sender, EventArgs e)
        {
            MakeUdpClient(txtUdpClientIP.Text, txtUdpClientPort.Text);
            settingsAddAddress(txtUdpClientIP.Text, txtUdpClientPort.Text);

        }

        private void MakeUdpClient(string address, string port)
        {
            int portno;
            int.TryParse(port, out portno);
            udpClient = new UdpClient(AddressFamily.InterNetworkV6);
            udpClient.Client.DualMode = true;

            IPAddress ipAddress;
            if (!IPAddress.TryParse(address, out ipAddress))
            {
                MessageBox.Show("Invalid IP address.");
                return;
            }

            //udp.Client.Bind(new IPEndPoint(ipAddress, portno));
            try
            {
                udpClient.Connect(ipAddress, portno);


                //IPEndPoint object will allow us to read datagrams sent from any source.
                //IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        void loadSettings()
        {
            settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText("settings.ini"));
            var portcollecton = new AutoCompleteStringCollection();
            var ipcollecton = new AutoCompleteStringCollection();
            foreach (var item in settings.addresses)
            {
                portcollecton.Add(item.Port);
                ipcollecton.Add(item.Ip);
            }
            txtTcpServerPort.AutoCompleteCustomSource = portcollecton;
            txtUdpClientIP.AutoCompleteCustomSource = ipcollecton;
            txtUdpClientPort.AutoCompleteCustomSource = portcollecton;
        }
        void saveSettings()
        {
            string settingsstring = JsonSerializer.Serialize(settings);
            File.WriteAllText("settings.ini", settingsstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.ini"))
            {
                loadSettings();
            }
        }

        private void btnUdpClientSend_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(txtUdpClientSend.Text);
                udpClient.Send(sendBytes, sendBytes.Length);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string colortext = string.Format("{0},{1},{2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            txtUdpClientSend.Text = colortext;
        }

        private void btnColorPickerTcpClient_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string colortext = string.Format("{0},{1},{2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            txtTcpClientSend.Text = colortext;
        }

        private void sendTcpClient(string message)
        {
            try
            {

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = TcpClient.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        private void btTcpClientConect_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port;
                Int32.TryParse(txtTcpClientPort.Text, out port);

                // Prefer a using declaration to ensure the instance is Disposed later.


                TcpClient = new TcpClient();
                TcpClient.Connect(txtTcpClientIp.Text, port);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btnTcpClientSend_Click(object sender, EventArgs e)
        {
            sendTcpClient(txtTcpClientSend.Text);
        }
    }
}

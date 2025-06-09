using System.Net.Sockets;
using System.Text;

namespace Lab17
{
    public partial class Form1 : Form
    {
        private string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private volatile bool isRunning;

        public Form1()
        {
            InitializeComponent();
            btnSend.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }

            try
            {
                client = new TcpClient();
                client.Connect(host, port);
                stream = client.GetStream();

                byte[] data = Encoding.Unicode.GetBytes(userName);
                stream.Write(data, 0, data.Length);

                isRunning = true;
                receiveThread = new Thread(new ThreadStart(ReceiveMessage))
                {
                    IsBackground = true
                };
                receiveThread.Start();

                AppendChatMessage($"Вітаємо, {userName}");
                btnSend.Enabled = true;
                btnLogin.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                txtMessage.Clear();
            }
            AppendChatMessage($"(Ваше повідомлення): {message}");
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }

        private void ReceiveMessage()
        {
            try
            {
                while (isRunning)
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    AppendChatMessage(message);
                }
            }
            catch
            {
                AppendChatMessage("Підключення прервано");
            }
        }

        private void AppendChatMessage(string message)
        {
            if (rtbChat.InvokeRequired)
            {
                rtbChat.Invoke(new Action<string>(AppendChatMessage), message);
            }
            else
            {
                rtbChat.AppendText(message + Environment.NewLine);
            }
        }

        private void Disconnect()
        {
            isRunning = false;

            stream?.Close();
            client?.Close();

            btnSend.Enabled = false;
            btnLogin.Enabled = true;
            AppendChatMessage("Ви відключилися від чату");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    }
}

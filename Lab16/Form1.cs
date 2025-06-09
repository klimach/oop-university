using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Lab16
{
    public partial class Form1 : Form
    {
        string logFilePath = "chat_log.txt";
        bool alive = false; // чи буде працювати потік для приймання
        UdpClient client;
        int LOCALPORT = 8001; // порт для приймання повідомлень
        int REMOTEPORT = 8001; // порт для передавання повідомлень
        const int TTL = 20;
        string HOST = "235.5.5.1"; // хост для групового розсилання
        IPAddress groupAddress; // адреса для групового розсилання
        string userName; // ім’я користувача в чаті
        Font chatFont = new("Microsoft Sans Serif", 10);
        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true; 
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            chatTextBox.ReadOnly = true;    
            chatTextBox.Font = chatFont;
            groupAddress = IPAddress.Parse(HOST);
        }
        // обробник натискання кнопок loginButton
        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                //підєднання до групового розсилання
                client.JoinMulticastGroup(groupAddress, TTL);

                // задача на приймання повідомлень
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                // перше повідомлення про вхід нового користувача
                string message = userName + " доєднується до чату";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // метод приймання повідомлення
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    string time = DateTime.Now.ToShortTimeString();
                    string logEntry = $"{time} {message}";
                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        chatTextBox.Text = logEntry + "\r\n" + chatTextBox.Text;
                    }));

                    try
                    {
                        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {}
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // обробник натискання кнопки sendButton
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // обробник натискання кнопки logoutButton
        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        // вихід з чату
        private void ExitChat()
        {
            string message = userName + " виходить з чату";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
        }
        // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using SettingsForm settingsForm = new SettingsForm(HOST, LOCALPORT, REMOTEPORT, chatFont);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                HOST = settingsForm.Host;
                LOCALPORT = settingsForm.LocalPort;
                REMOTEPORT = settingsForm.RemotePort;
                chatFont = settingsForm.ChatFont;

                chatTextBox.Font = chatFont;
            }
        }
    }
}

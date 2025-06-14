﻿using System.Net.Sockets;
using System.Text;

namespace Lab17ChatServer
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerObject server; // об’єкт серверу
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }
        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                // отримуємо ім’я користувача
                string message = GetMessage();
                userName = message;
                message = userName + " вошел в чат";
                // відсилаемо повідомлення про вхід в чат користувача
                server.BroadcastMessage(message, this.Id);
                Console.WriteLine(message);
                // в нескінченому цикліотримуємо повідомлення клієнта
                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        message = String.Format("{0}: {1}", userName, message);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = String.Format("{0}: покинул чат", userName);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // звільняємо ресурси
                server.RemoveConnection(this.Id);
                Close();
            }
        }
        // читання вхідного повідомлення та перетворення в строку
        private string GetMessage()
        {
            byte[] data = new byte[64]; // буфер
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);
            return builder.ToString();
        }
        // закриття підключення
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}

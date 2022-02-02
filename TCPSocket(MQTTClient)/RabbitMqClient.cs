using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSocket_MQTTClient_
{
    public partial class RabbitMqClient : Form
    {
        private ConnectionFactory connectionFactory;
        private IConnection connection;
        private IModel subscribeChannel;
        private IModel publishChannel;
        public RabbitMqClient() => InitializeComponent();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectionFactory = new ConnectionFactory()
            {
                HostName = txtHost.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                VirtualHost = txtUsername.Text,
                ClientProvidedName = txtClientId.Text

            };
            connection = connectionFactory.CreateConnection();
            subscribeChannel = connection.CreateModel();
            publishChannel = connection.CreateModel();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            //subscribeChannel.QueueDeclare(queue: "aerotive",
            //                     durable: false,
            //                     exclusive: false,
            //                     autoDelete: false,
            //                     arguments: null);

            var consumer = new EventingBasicConsumer(subscribeChannel);
            consumer.Received += onMessageReceived;
            subscribeChannel.BasicConsume(queue: "level",
                                 autoAck: true,
                                 consumer: consumer);

            //var consumer2 = new EventingBasicConsumer(subscribeChannel);
            //consumer2.Received += onMessageReceived;
            //subscribeChannel.BasicConsume(queue: "state",
            //                     autoAck: true,
            //                     consumer: consumer);

        }

        private void onMessageReceived(object? model, BasicDeliverEventArgs ea)
        {
            var body = ea.Body.ToArray();
            int i;
            string response = String.Empty;
            try
            {
                for (i = 0; i < 5; i++)
                    response += Convert.ToString(Convert.ToChar(body[i + 2]));
                this.Invoke(() => txtSubscription.Text += response + ";\n");
                this.Invoke(() => txtSubscription.SelectionStart = txtSubscription.Text.Length);
                this.Invoke(() => txtSubscription.ScrollToCaret());
            }
            catch (Exception)
            { }
        }

        private void MQTTPublish_Button_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes(txtMessage.Text);
            //publishChannel.QueueDeclare(queue: "state",
            //                    durable: false,
            //                    exclusive: false,
            //                    autoDelete: false,
            //                    arguments: null);
            publishChannel.BasicPublish(exchange: "",
                                 routingKey: "state",
                                 basicProperties: null,
                                 body: message);
            txtPublish.Text += DateTime.Now.ToString("dd-MM-yyyy hh:mm:ssss") + " : " + txtMessage.Text + " (sent)" + Environment.NewLine;

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            subscribeChannel.Close();
            publishChannel.Close();
            if (connection.IsOpen)
                connection.Close();
        }

        private void RabbitMqClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnDisconnect_Click(sender, e);
        }

        private void RabbitMqClient_Load(object sender, EventArgs e)
        {

        }
    }
}

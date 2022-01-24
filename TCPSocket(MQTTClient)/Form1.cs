
using System.Diagnostics;
using System.Net.Sockets;


namespace TCPSocket_MQTTClient_
{
    public partial class MainWindow : Form
    {
        public Byte[] MQTT_buffer = new Byte[1000];
        public int MQTT_size;
        public bool tcp_started, tcp_first;
        public string host_name;
        public int port_number;

        public TcpClient tcp_client;

        public Stream mqtt_stream;

        public Byte[] stream_data = new Byte[1000];


        public MainWindow()
        {
            InitializeComponent();

        }

        private void TCP_Button_Click(object sender, EventArgs e)
        {
            int error_code = 0;
            try
            {
                if (Port_TextBox.Text != "") port_number = Convert.ToInt16(Port_TextBox.Text);
                else error_code |= 0x0001;
                if (port_number > 65535 || port_number < 0) error_code |= 0x0002;
                if (Host_TextBox.Text != "") host_name = Host_TextBox.Text;
                else error_code |= 0x0004;
            }
            catch (System.Exception) { }
            if (error_code != 0)
            {
                if ((error_code &= 0x01) == 0x01) TextLog.Text += "empty port number!\n";
                if ((error_code &= 0x02) == 0x02) TextLog.Text += "wrong port number format!\n";
                if ((error_code &= 0x04) == 0x04) TextLog.Text += "wrong host name format!\n";
            }
            else
            {
                tcp_started = true;
                tcp_first = true;
                CheckTimer.Interval = 100;
                CheckTimer.Start();
            }

        }

        private void StopTCP_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcp_client.Connected == true)
                {
                    mqtt_stream.Close();
                    tcp_client.Close();
                    tcp_started = false;
                    CheckTimer.Stop();
                    TextLog.Text += "TCP socket closed!" + "\n";
                }
            }
            catch
            { }
        }

        private void MQTTSub_Button_Click(object sender, EventArgs e)
        {
            int i, k;
            MQTT_buffer[0] = 0x82; // control field
            MQTT_buffer[1] = (byte)(5 + TopicTextBox.Text.Length);
            try
            {
                MQTT_buffer[2] = (byte)((Convert.ToInt16(SubIDTextBox.Text) >> 8) & 0xFF);
                MQTT_buffer[3] = (byte)(Convert.ToInt16(SubIDTextBox.Text) & 0xFF);
            }
            catch (Exception ex) 
            { 
                MQTT_buffer[2] = 0x00;
                MQTT_buffer[3] = 0x01;
            }
            MQTT_buffer[4] = (byte)((Convert.ToInt16(TopicTextBox.Text.Length) >> 8) & 0xFF);
            MQTT_buffer[5] = (byte)(Convert.ToInt16(TopicTextBox.Text.Length) & 0xFF);
            k = 6;
            for (i = 0; i < TopicTextBox.Text.Length; i++) // Topic name
                MQTT_buffer[k + i] = Convert.ToByte(TopicTextBox.Text[i]);
            k = k + i;
            MQTT_buffer[k++] = 0x01; // Request QOS
            MQTT_size = k;

            try
            {
                mqtt_stream.Write(MQTT_buffer, 0, MQTT_size);
            }
            catch
            {
                MessageBox.Show("TCP socket closed!");
            }
        }

        private void MQTTPublish_Button_Click(object sender, EventArgs e)
        {
            int i, k;
            MQTT_buffer[0] = 0x30; // control field
            MQTT_buffer[1] = (byte)(4 + Key_TextBox.Text.Length + Value_TextBox.Text.Length);
            k = 2;
            // MQTT data key
            MQTT_buffer[k++] = 0x00;
            MQTT_buffer[k++] = (byte)Key_TextBox.Text.Length;
            for (i = 0; i < Key_TextBox.Text.Length; i++)
                MQTT_buffer[k + i] = Convert.ToByte(Key_TextBox.Text[i]);
            k = k + i;
            // MQTT data value
            MQTT_buffer[k++] = 0x00;
            MQTT_buffer[k++] = (byte)Value_TextBox.Text.Length;
            for (i = 0; i < Value_TextBox.Text.Length; i++)
                MQTT_buffer[k + i] = Convert.ToByte(Value_TextBox.Text[i]);
            k = k + i;
            MQTT_size = k;

            try
            {
                mqtt_stream.Write(MQTT_buffer, 0, MQTT_size);
            }
            catch
            {
                MessageBox.Show("TCP socket closed!");
            }
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            if (tcp_started)
            {
                if (tcp_first)
                {
                    tcp_first = false;
                    tcp_client = new TcpClient(host_name, port_number);
                    TextLog.Text += "TCP client created, host: " + host_name + " ,port: " + Convert.ToString(port_number) + "\n";
                    mqtt_stream = tcp_client.GetStream();

                    int i, k;
                    MQTT_buffer[0] = 0x10; // control field
                    MQTT_buffer[1] = (byte)(16 + ID_TextBox.Text.Length + User_TextBox.Text.Length + Pswd_TextBox.Text.Length); // remain length
                    MQTT_buffer[2] = 0x00; // protocol name length MSB
                    MQTT_buffer[3] = 0x04; // protocol name length LSB
                    MQTT_buffer[4] = (byte)'M'; // protocol name
                    MQTT_buffer[5] = (byte)'Q';
                    MQTT_buffer[6] = (byte)'T';
                    MQTT_buffer[7] = (byte)'T';
                    MQTT_buffer[8] = 0x04; // protocol level
                    MQTT_buffer[9] = 0xC2; // connect flags
                    MQTT_buffer[10] = 0x00; // keep alive time MSB
                    MQTT_buffer[11] = 0x0A; // keep alive time LSB

                    k = 12;
                    // MQTT client ID
                    MQTT_buffer[k++] = 0x00;
                    MQTT_buffer[k++] = (byte)ID_TextBox.Text.Length;
                    for (i = 0; i < ID_TextBox.Text.Length; i++)
                        MQTT_buffer[k + i] = Convert.ToByte(ID_TextBox.Text[i]);
                    k = k + i;
                    
                    
                    // MQTT user name
                    MQTT_buffer[k++] = 0x00;
                    MQTT_buffer[k++] = (byte)User_TextBox.Text.Length;
                    for (i = 0; i < User_TextBox.Text.Length; i++)
                        MQTT_buffer[k + i] = Convert.ToByte(User_TextBox.Text[i]);
                    k = k + i;

                    // MQTT password
                    MQTT_buffer[k++] = 0x00;
                    MQTT_buffer[k++] = (byte)Pswd_TextBox.Text.Length;
                    for (i = 0; i < Pswd_TextBox.Text.Length; i++)
                        MQTT_buffer[k + i] = Convert.ToByte(Pswd_TextBox.Text[i]);
                    k = k + i;
                    
                    MQTT_size = k;


                    try
                    {
                        mqtt_stream.Write(MQTT_buffer, 0, MQTT_size); // send mqtt subscriber packet
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        MessageBox.Show("TCP socket closed!");
                    }
                }
                else
                {
                    
                    try
                    {
                        if (tcp_client.Available > 0 && tcp_client.Connected )
                        {
                            String responseData = String.Empty;
                            Int32 bytes;
                            bytes = 0;
                            bytes = mqtt_stream.Read(stream_data, 0, tcp_client.Available);
                            responseData = System.Text.Encoding.ASCII.GetString(stream_data, 0, bytes);
                            TextLog.Text += "Received: {0}" + responseData + "\n";
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                        
                }
            }
        }




    }
}
namespace TCPSocket_MQTTClient_
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.host_label = new System.Windows.Forms.Label();
            this.TCP_Button = new System.Windows.Forms.Button();
            this.Host_TextBox = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.TextLog = new System.Windows.Forms.RichTextBox();
            this.key_label = new System.Windows.Forms.Label();
            this.value_label = new System.Windows.Forms.Label();
            this.Value_TextBox = new System.Windows.Forms.TextBox();
            this.Key_TextBox = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.pswd_label = new System.Windows.Forms.Label();
            this.Pswd_TextBox = new System.Windows.Forms.TextBox();
            this.MQTTSub_Button = new System.Windows.Forms.Button();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.MQTTPublish_Button = new System.Windows.Forms.Button();
            this.StopTCP_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopicTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(12, 9);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(35, 15);
            this.host_label.TabIndex = 0;
            this.host_label.Text = "Host:";
            // 
            // TCP_Button
            // 
            this.TCP_Button.Location = new System.Drawing.Point(370, 6);
            this.TCP_Button.Name = "TCP_Button";
            this.TCP_Button.Size = new System.Drawing.Size(66, 23);
            this.TCP_Button.TabIndex = 1;
            this.TCP_Button.Text = "Start TCP";
            this.TCP_Button.UseVisualStyleBackColor = true;
            this.TCP_Button.Click += new System.EventHandler(this.TCP_Button_Click);
            // 
            // Host_TextBox
            // 
            this.Host_TextBox.Location = new System.Drawing.Point(53, 5);
            this.Host_TextBox.Name = "Host_TextBox";
            this.Host_TextBox.Size = new System.Drawing.Size(203, 23);
            this.Host_TextBox.TabIndex = 3;
            this.Host_TextBox.Text = "whale.rmq.cloudamqp.com";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(262, 8);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(32, 15);
            this.port_label.TabIndex = 4;
            this.port_label.Text = "Port:";
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(300, 6);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(64, 23);
            this.Port_TextBox.TabIndex = 5;
            this.Port_TextBox.Text = "1883";
            // 
            // CheckTimer
            // 
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // TextLog
            // 
            this.TextLog.Location = new System.Drawing.Point(9, 132);
            this.TextLog.Name = "TextLog";
            this.TextLog.Size = new System.Drawing.Size(417, 160);
            this.TextLog.TabIndex = 6;
            this.TextLog.Text = "";
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(12, 69);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(29, 15);
            this.key_label.TabIndex = 8;
            this.key_label.Text = "Key:";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(128, 69);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(38, 15);
            this.value_label.TabIndex = 9;
            this.value_label.Text = "Value:";
            // 
            // Value_TextBox
            // 
            this.Value_TextBox.Location = new System.Drawing.Point(167, 66);
            this.Value_TextBox.Name = "Value_TextBox";
            this.Value_TextBox.Size = new System.Drawing.Size(57, 23);
            this.Value_TextBox.TabIndex = 10;
            this.Value_TextBox.Text = "1234";
            // 
            // Key_TextBox
            // 
            this.Key_TextBox.Location = new System.Drawing.Point(47, 66);
            this.Key_TextBox.Name = "Key_TextBox";
            this.Key_TextBox.Size = new System.Drawing.Size(75, 23);
            this.Key_TextBox.TabIndex = 11;
            this.Key_TextBox.Text = "deneme";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(117, 40);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(33, 15);
            this.user_label.TabIndex = 12;
            this.user_label.Text = "User:";
            // 
            // User_TextBox
            // 
            this.User_TextBox.Location = new System.Drawing.Point(156, 36);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(57, 23);
            this.User_TextBox.TabIndex = 13;
            this.User_TextBox.Text = "sawkznkz:sawkznkz";
            // 
            // pswd_label
            // 
            this.pswd_label.AutoSize = true;
            this.pswd_label.Location = new System.Drawing.Point(219, 40);
            this.pswd_label.Name = "pswd_label";
            this.pswd_label.Size = new System.Drawing.Size(38, 15);
            this.pswd_label.TabIndex = 14;
            this.pswd_label.Text = "Pswd:";
            // 
            // Pswd_TextBox
            // 
            this.Pswd_TextBox.Location = new System.Drawing.Point(263, 37);
            this.Pswd_TextBox.Name = "Pswd_TextBox";
            this.Pswd_TextBox.Size = new System.Drawing.Size(247, 23);
            this.Pswd_TextBox.TabIndex = 15;
            this.Pswd_TextBox.Text = "ts0c9yMLFHEEOcL1vvkfLAhLjcljyhsR";
            // 
            // MQTTSub_Button
            // 
            this.MQTTSub_Button.Location = new System.Drawing.Point(300, 99);
            this.MQTTSub_Button.Name = "MQTTSub_Button";
            this.MQTTSub_Button.Size = new System.Drawing.Size(75, 23);
            this.MQTTSub_Button.TabIndex = 16;
            this.MQTTSub_Button.Text = "Sub.MQTT";
            this.MQTTSub_Button.UseVisualStyleBackColor = true;
            this.MQTTSub_Button.Click += new System.EventHandler(this.MQTTSub_Button_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(12, 40);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(55, 15);
            this.ID_label.TabIndex = 17;
            this.ID_label.Text = "Client ID:";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(65, 36);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(46, 23);
            this.ID_TextBox.TabIndex = 18;
            this.ID_TextBox.Text = "MPPT";
            // 
            // MQTTPublish_Button
            // 
            this.MQTTPublish_Button.Location = new System.Drawing.Point(230, 66);
            this.MQTTPublish_Button.Name = "MQTTPublish_Button";
            this.MQTTPublish_Button.Size = new System.Drawing.Size(75, 23);
            this.MQTTPublish_Button.TabIndex = 19;
            this.MQTTPublish_Button.Text = "Publish";
            this.MQTTPublish_Button.UseVisualStyleBackColor = true;
            this.MQTTPublish_Button.Click += new System.EventHandler(this.MQTTPublish_Button_Click);
            // 
            // StopTCP_Button
            // 
            this.StopTCP_Button.Location = new System.Drawing.Point(444, 6);
            this.StopTCP_Button.Name = "StopTCP_Button";
            this.StopTCP_Button.Size = new System.Drawing.Size(66, 23);
            this.StopTCP_Button.TabIndex = 20;
            this.StopTCP_Button.Text = "Stop TCP";
            this.StopTCP_Button.UseVisualStyleBackColor = true;
            this.StopTCP_Button.Click += new System.EventHandler(this.StopTCP_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sub.ID:";
            // 
            // SubIDTextBox
            // 
            this.SubIDTextBox.Location = new System.Drawing.Point(62, 100);
            this.SubIDTextBox.Name = "SubIDTextBox";
            this.SubIDTextBox.Size = new System.Drawing.Size(57, 23);
            this.SubIDTextBox.TabIndex = 22;
            this.SubIDTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Topic:";
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Location = new System.Drawing.Point(178, 99);
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.Size = new System.Drawing.Size(116, 23);
            this.TopicTextBox.TabIndex = 24;
            this.TopicTextBox.Text = "deneme";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 304);
            this.Controls.Add(this.TopicTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopTCP_Button);
            this.Controls.Add(this.MQTTPublish_Button);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.MQTTSub_Button);
            this.Controls.Add(this.Pswd_TextBox);
            this.Controls.Add(this.pswd_label);
            this.Controls.Add(this.User_TextBox);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.Key_TextBox);
            this.Controls.Add(this.Value_TextBox);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.TextLog);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.Host_TextBox);
            this.Controls.Add(this.TCP_Button);
            this.Controls.Add(this.host_label);
            this.Name = "MainWindow";
            this.Text = "MQTT Client Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label host_label;
        private Button TCP_Button;
        private TextBox Host_TextBox;
        private Label port_label;
        private TextBox Port_TextBox;
        private System.Windows.Forms.Timer CheckTimer;
        private RichTextBox TextLog;
        private Label key_label;
        private Label value_label;
        private TextBox Value_TextBox;
        private TextBox Key_TextBox;
        private Label user_label;
        private TextBox User_TextBox;
        private Label pswd_label;
        private TextBox Pswd_TextBox;
        private Button MQTTSub_Button;
        private Label ID_label;
        private TextBox ID_TextBox;
        private Button MQTTPublish_Button;
        private Button StopTCP_Button;
        private Label label1;
        private TextBox SubIDTextBox;
        private Label label2;
        private TextBox TopicTextBox;
    }
}
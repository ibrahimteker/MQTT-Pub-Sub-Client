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
            this.TextClearButton = new System.Windows.Forms.Button();
            this.Topic2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sub2IDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MQTTSub2_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub1ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.Sub2ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(6, 28);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(35, 15);
            this.host_label.TabIndex = 0;
            this.host_label.Text = "Host:";
            // 
            // TCP_Button
            // 
            this.TCP_Button.Location = new System.Drawing.Point(341, 24);
            this.TCP_Button.Name = "TCP_Button";
            this.TCP_Button.Size = new System.Drawing.Size(68, 23);
            this.TCP_Button.TabIndex = 1;
            this.TCP_Button.Text = "Start TCP";
            this.TCP_Button.UseVisualStyleBackColor = true;
            this.TCP_Button.Click += new System.EventHandler(this.TCP_Button_Click);
            // 
            // Host_TextBox
            // 
            this.Host_TextBox.Location = new System.Drawing.Point(42, 25);
            this.Host_TextBox.Name = "Host_TextBox";
            this.Host_TextBox.Size = new System.Drawing.Size(197, 23);
            this.Host_TextBox.TabIndex = 3;
            this.Host_TextBox.Text = "whale.rmq.cloudamqp.com";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(250, 28);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(32, 15);
            this.port_label.TabIndex = 4;
            this.port_label.Text = "Port:";
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(288, 25);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(47, 23);
            this.Port_TextBox.TabIndex = 5;
            this.Port_TextBox.Text = "1883";
            // 
            // CheckTimer
            // 
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // TextLog
            // 
            this.TextLog.Location = new System.Drawing.Point(6, 22);
            this.TextLog.Name = "TextLog";
            this.TextLog.Size = new System.Drawing.Size(290, 185);
            this.TextLog.TabIndex = 6;
            this.TextLog.Text = "";
            this.TextLog.TextChanged += new System.EventHandler(this.TextLog_TextChanged);
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(32, 23);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(29, 15);
            this.key_label.TabIndex = 8;
            this.key_label.Text = "Key:";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(139, 23);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(38, 15);
            this.value_label.TabIndex = 9;
            this.value_label.Text = "Value:";
            // 
            // Value_TextBox
            // 
            this.Value_TextBox.Location = new System.Drawing.Point(183, 20);
            this.Value_TextBox.Name = "Value_TextBox";
            this.Value_TextBox.Size = new System.Drawing.Size(62, 23);
            this.Value_TextBox.TabIndex = 10;
            this.Value_TextBox.Text = "00001";
            // 
            // Key_TextBox
            // 
            this.Key_TextBox.Location = new System.Drawing.Point(67, 20);
            this.Key_TextBox.MaxLength = 24;
            this.Key_TextBox.Name = "Key_TextBox";
            this.Key_TextBox.Size = new System.Drawing.Size(57, 23);
            this.Key_TextBox.TabIndex = 11;
            this.Key_TextBox.Text = "r/state";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(85, 59);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(33, 15);
            this.user_label.TabIndex = 12;
            this.user_label.Text = "User:";
            // 
            // User_TextBox
            // 
            this.User_TextBox.Location = new System.Drawing.Point(124, 56);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(115, 23);
            this.User_TextBox.TabIndex = 13;
            this.User_TextBox.Text = "sawkznkz:sawkznkz";
            // 
            // pswd_label
            // 
            this.pswd_label.AutoSize = true;
            this.pswd_label.Location = new System.Drawing.Point(245, 59);
            this.pswd_label.Name = "pswd_label";
            this.pswd_label.Size = new System.Drawing.Size(38, 15);
            this.pswd_label.TabIndex = 14;
            this.pswd_label.Text = "Pswd:";
            // 
            // Pswd_TextBox
            // 
            this.Pswd_TextBox.Location = new System.Drawing.Point(288, 56);
            this.Pswd_TextBox.Name = "Pswd_TextBox";
            this.Pswd_TextBox.Size = new System.Drawing.Size(204, 23);
            this.Pswd_TextBox.TabIndex = 15;
            this.Pswd_TextBox.Text = "ts0c9yMLFHEEOcL1vvkfLAhLjcljyhsR";
            // 
            // MQTTSub_Button
            // 
            this.MQTTSub_Button.Location = new System.Drawing.Point(404, 23);
            this.MQTTSub_Button.Name = "MQTTSub_Button";
            this.MQTTSub_Button.Size = new System.Drawing.Size(75, 23);
            this.MQTTSub_Button.TabIndex = 16;
            this.MQTTSub_Button.Text = "Subscribe1";
            this.MQTTSub_Button.UseVisualStyleBackColor = true;
            this.MQTTSub_Button.Click += new System.EventHandler(this.MQTTSub_Button_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(6, 59);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(21, 15);
            this.ID_label.TabIndex = 17;
            this.ID_label.Text = "ID:";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(33, 56);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(46, 23);
            this.ID_TextBox.TabIndex = 18;
            this.ID_TextBox.Text = "MPPT2";
            // 
            // MQTTPublish_Button
            // 
            this.MQTTPublish_Button.Location = new System.Drawing.Point(260, 19);
            this.MQTTPublish_Button.Name = "MQTTPublish_Button";
            this.MQTTPublish_Button.Size = new System.Drawing.Size(75, 23);
            this.MQTTPublish_Button.TabIndex = 19;
            this.MQTTPublish_Button.Text = "Publish";
            this.MQTTPublish_Button.UseVisualStyleBackColor = true;
            this.MQTTPublish_Button.Click += new System.EventHandler(this.MQTTPublish_Button_Click);
            // 
            // StopTCP_Button
            // 
            this.StopTCP_Button.Location = new System.Drawing.Point(415, 24);
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
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sub1.ID:";
            // 
            // SubIDTextBox
            // 
            this.SubIDTextBox.Location = new System.Drawing.Point(67, 22);
            this.SubIDTextBox.MaxLength = 3;
            this.SubIDTextBox.Name = "SubIDTextBox";
            this.SubIDTextBox.Size = new System.Drawing.Size(57, 23);
            this.SubIDTextBox.TabIndex = 22;
            this.SubIDTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Topic1:";
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Location = new System.Drawing.Point(183, 21);
            this.TopicTextBox.MaxLength = 24;
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.Size = new System.Drawing.Size(62, 23);
            this.TopicTextBox.TabIndex = 24;
            this.TopicTextBox.Text = "w/level";
            // 
            // TextClearButton
            // 
            this.TextClearButton.Location = new System.Drawing.Point(240, 216);
            this.TextClearButton.Name = "TextClearButton";
            this.TextClearButton.Size = new System.Drawing.Size(56, 23);
            this.TextClearButton.TabIndex = 25;
            this.TextClearButton.Text = "Clear";
            this.TextClearButton.UseVisualStyleBackColor = true;
            this.TextClearButton.Click += new System.EventHandler(this.TextClearButton_Click);
            // 
            // Topic2TextBox
            // 
            this.Topic2TextBox.Location = new System.Drawing.Point(183, 50);
            this.Topic2TextBox.MaxLength = 24;
            this.Topic2TextBox.Name = "Topic2TextBox";
            this.Topic2TextBox.Size = new System.Drawing.Size(62, 23);
            this.Topic2TextBox.TabIndex = 30;
            this.Topic2TextBox.Text = "r/state";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Topic2:";
            // 
            // Sub2IDTextBox
            // 
            this.Sub2IDTextBox.Location = new System.Drawing.Point(67, 51);
            this.Sub2IDTextBox.MaxLength = 3;
            this.Sub2IDTextBox.Name = "Sub2IDTextBox";
            this.Sub2IDTextBox.Size = new System.Drawing.Size(57, 23);
            this.Sub2IDTextBox.TabIndex = 28;
            this.Sub2IDTextBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sub2.ID:";
            // 
            // MQTTSub2_Button
            // 
            this.MQTTSub2_Button.Location = new System.Drawing.Point(404, 50);
            this.MQTTSub2_Button.Name = "MQTTSub2_Button";
            this.MQTTSub2_Button.Size = new System.Drawing.Size(75, 23);
            this.MQTTSub2_Button.TabIndex = 26;
            this.MQTTSub2_Button.Text = "Subscribe2";
            this.MQTTSub2_Button.UseVisualStyleBackColor = true;
            this.MQTTSub2_Button.Click += new System.EventHandler(this.MQTTSub2_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Received1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Received2:";
            // 
            // Sub1ReceivedTextBox
            // 
            this.Sub1ReceivedTextBox.Location = new System.Drawing.Point(324, 23);
            this.Sub1ReceivedTextBox.MaxLength = 8;
            this.Sub1ReceivedTextBox.Name = "Sub1ReceivedTextBox";
            this.Sub1ReceivedTextBox.Size = new System.Drawing.Size(74, 23);
            this.Sub1ReceivedTextBox.TabIndex = 33;
            // 
            // Sub2ReceivedTextBox
            // 
            this.Sub2ReceivedTextBox.Location = new System.Drawing.Point(324, 50);
            this.Sub2ReceivedTextBox.MaxLength = 8;
            this.Sub2ReceivedTextBox.Name = "Sub2ReceivedTextBox";
            this.Sub2ReceivedTextBox.Size = new System.Drawing.Size(74, 23);
            this.Sub2ReceivedTextBox.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubIDTextBox);
            this.groupBox1.Controls.Add(this.Sub2ReceivedTextBox);
            this.groupBox1.Controls.Add(this.MQTTSub_Button);
            this.groupBox1.Controls.Add(this.Sub1ReceivedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TopicTextBox);
            this.groupBox1.Controls.Add(this.Topic2TextBox);
            this.groupBox1.Controls.Add(this.MQTTSub2_Button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sub2IDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 93);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscribe Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextLog);
            this.groupBox2.Controls.Add(this.TextClearButton);
            this.groupBox2.Location = new System.Drawing.Point(520, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 254);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Host_TextBox);
            this.groupBox3.Controls.Add(this.host_label);
            this.groupBox3.Controls.Add(this.TCP_Button);
            this.groupBox3.Controls.Add(this.StopTCP_Button);
            this.groupBox3.Controls.Add(this.port_label);
            this.groupBox3.Controls.Add(this.Port_TextBox);
            this.groupBox3.Controls.Add(this.ID_TextBox);
            this.groupBox3.Controls.Add(this.user_label);
            this.groupBox3.Controls.Add(this.ID_label);
            this.groupBox3.Controls.Add(this.User_TextBox);
            this.groupBox3.Controls.Add(this.Pswd_TextBox);
            this.groupBox3.Controls.Add(this.pswd_label);
            this.groupBox3.Location = new System.Drawing.Point(12, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 91);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.key_label);
            this.groupBox4.Controls.Add(this.value_label);
            this.groupBox4.Controls.Add(this.Value_TextBox);
            this.groupBox4.Controls.Add(this.Key_TextBox);
            this.groupBox4.Controls.Add(this.MQTTPublish_Button);
            this.groupBox4.Location = new System.Drawing.Point(12, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 56);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Publish";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 271);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "MQTT pub sub client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private Button TextClearButton;
        private TextBox Topic2TextBox;
        private Label label3;
        private TextBox Sub2IDTextBox;
        private Label label4;
        private Button MQTTSub2_Button;
        private Label label5;
        private Label label6;
        private TextBox Sub1ReceivedTextBox;
        private TextBox Sub2ReceivedTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
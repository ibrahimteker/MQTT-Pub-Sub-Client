namespace TCPSocket_MQTTClient_
{
    partial class RabbitMqClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.MQTTPublish_Button = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pswd_label = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPublish = new System.Windows.Forms.RichTextBox();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.value_label = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.host_label = new System.Windows.Forms.Label();
            this.txtSubscription = new System.Windows.Forms.RichTextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(437, 7);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(76, 23);
            this.btnDisconnect.TabIndex = 39;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // MQTTPublish_Button
            // 
            this.MQTTPublish_Button.Location = new System.Drawing.Point(233, 67);
            this.MQTTPublish_Button.Name = "MQTTPublish_Button";
            this.MQTTPublish_Button.Size = new System.Drawing.Size(134, 23);
            this.MQTTPublish_Button.TabIndex = 38;
            this.MQTTPublish_Button.Text = "Publish";
            this.MQTTPublish_Button.UseVisualStyleBackColor = true;
            this.MQTTPublish_Button.Click += new System.EventHandler(this.MQTTPublish_Button_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(68, 37);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(46, 23);
            this.txtClientId.TabIndex = 37;
            this.txtClientId.Text = "MPPT";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(15, 41);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(55, 15);
            this.ID_label.TabIndex = 36;
            this.ID_label.Text = "Client ID:";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(373, 66);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(140, 23);
            this.btnSubscribe.TabIndex = 35;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(266, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 23);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.Text = "ts0c9yMLFHEEOcL1vvkfLAhLjcljyhsR";
            // 
            // pswd_label
            // 
            this.pswd_label.AutoSize = true;
            this.pswd_label.Location = new System.Drawing.Point(222, 41);
            this.pswd_label.Name = "pswd_label";
            this.pswd_label.Size = new System.Drawing.Size(38, 15);
            this.pswd_label.TabIndex = 33;
            this.pswd_label.Text = "Pswd:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(159, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(57, 23);
            this.txtUsername.TabIndex = 32;
            this.txtUsername.Text = "sawkznkz";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(120, 41);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(33, 15);
            this.user_label.TabIndex = 31;
            this.user_label.Text = "User:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(68, 66);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 23);
            this.txtMessage.TabIndex = 29;
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(12, 107);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(224, 159);
            this.txtPublish.TabIndex = 26;
            this.txtPublish.Text = "";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(15, 70);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(56, 15);
            this.value_label.TabIndex = 28;
            this.value_label.Text = "Message:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(303, 7);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(64, 23);
            this.txtPort.TabIndex = 25;
            this.txtPort.Text = "1883";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(265, 9);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(32, 15);
            this.port_label.TabIndex = 24;
            this.port_label.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(56, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(203, 23);
            this.txtHost.TabIndex = 23;
            this.txtHost.Text = "whale.rmq.cloudamqp.com";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(373, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(66, 23);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(15, 10);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(35, 15);
            this.host_label.TabIndex = 21;
            this.host_label.Text = "Host:";
            // 
            // txtSubscription
            // 
            this.txtSubscription.Location = new System.Drawing.Point(266, 107);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(247, 159);
            this.txtSubscription.TabIndex = 41;
            this.txtSubscription.Text = "";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(314, 70);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(0, 15);
            this.lblTopic.TabIndex = 42;
            // 
            // RabbitMqClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 271);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.txtSubscription);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.MQTTPublish_Button);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pswd_label);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.host_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RabbitMqClient";
            this.Text = "RabbitMqClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RabbitMqClient_FormClosing);
            this.Load += new System.EventHandler(this.RabbitMqClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisconnect;
        private Button MQTTPublish_Button;
        private TextBox txtClientId;
        private Label ID_label;
        private Button btnSubscribe;
        private TextBox txtPassword;
        private Label pswd_label;
        private TextBox txtUsername;
        private Label user_label;
        private TextBox txtMessage;
        private RichTextBox txtPublish;
        private System.Windows.Forms.Timer CheckTimer;
        private Label value_label;
        private TextBox txtPort;
        private Label port_label;
        private TextBox txtHost;
        private Button btnConnect;
        private Label host_label;
        private RichTextBox txtSubscription;
        private Label lblTopic;
    }
}
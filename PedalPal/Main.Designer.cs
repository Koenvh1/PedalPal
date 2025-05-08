namespace PedalPal
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.progressBrake = new System.Windows.Forms.ProgressBar();
            this.progressThrottle = new System.Windows.Forms.ProgressBar();
            this.groupInputs = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputTimer = new System.Windows.Forms.Timer(this.components);
            this.comboBrake = new System.Windows.Forms.ComboBox();
            this.comboThrottle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputOwnIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboVJoyID = new System.Windows.Forms.ComboBox();
            this.linkGameControllers = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBrakeRemote = new System.Windows.Forms.ProgressBar();
            this.progressThrottleRemote = new System.Windows.Forms.ProgressBar();
            this.groupInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBrake
            // 
            this.progressBrake.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBrake.Location = new System.Drawing.Point(64, 19);
            this.progressBrake.MarqueeAnimationSpeed = 0;
            this.progressBrake.Name = "progressBrake";
            this.progressBrake.Size = new System.Drawing.Size(66, 23);
            this.progressBrake.TabIndex = 0;
            // 
            // progressThrottle
            // 
            this.progressThrottle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressThrottle.Location = new System.Drawing.Point(64, 48);
            this.progressThrottle.MarqueeAnimationSpeed = 0;
            this.progressThrottle.Name = "progressThrottle";
            this.progressThrottle.Size = new System.Drawing.Size(66, 23);
            this.progressThrottle.TabIndex = 1;
            // 
            // groupInputs
            // 
            this.groupInputs.Controls.Add(this.label2);
            this.groupInputs.Controls.Add(this.label1);
            this.groupInputs.Controls.Add(this.progressBrake);
            this.groupInputs.Controls.Add(this.progressThrottle);
            this.groupInputs.Location = new System.Drawing.Point(15, 187);
            this.groupInputs.Name = "groupInputs";
            this.groupInputs.Size = new System.Drawing.Size(136, 80);
            this.groupInputs.TabIndex = 2;
            this.groupInputs.TabStop = false;
            this.groupInputs.Text = "Own inputs";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Throttle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brake";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboDevice
            // 
            this.comboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDevice.FormattingEnabled = true;
            this.comboDevice.Location = new System.Drawing.Point(15, 113);
            this.comboDevice.Name = "comboDevice";
            this.comboDevice.Size = new System.Drawing.Size(278, 21);
            this.comboDevice.TabIndex = 3;
            this.comboDevice.SelectedIndexChanged += new System.EventHandler(this.comboDevice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // inputTimer
            // 
            this.inputTimer.Enabled = true;
            this.inputTimer.Interval = 10;
            this.inputTimer.Tick += new System.EventHandler(this.inputTimer_Tick);
            // 
            // comboBrake
            // 
            this.comboBrake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBrake.FormattingEnabled = true;
            this.comboBrake.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z",
            "RX",
            "RY",
            "RZ",
            "Slider0",
            "Slider1",
            "POV0",
            "POV1"});
            this.comboBrake.Location = new System.Drawing.Point(15, 160);
            this.comboBrake.Name = "comboBrake";
            this.comboBrake.Size = new System.Drawing.Size(136, 21);
            this.comboBrake.TabIndex = 7;
            this.comboBrake.SelectedIndexChanged += new System.EventHandler(this.comboBrake_SelectedIndexChanged);
            // 
            // comboThrottle
            // 
            this.comboThrottle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboThrottle.FormattingEnabled = true;
            this.comboThrottle.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z",
            "RX",
            "RY",
            "RZ",
            "Slider0",
            "Slider1",
            "POV0",
            "POV1"});
            this.comboThrottle.Location = new System.Drawing.Point(157, 160);
            this.comboThrottle.Name = "comboThrottle";
            this.comboThrottle.Size = new System.Drawing.Size(136, 21);
            this.comboThrottle.TabIndex = 8;
            this.comboThrottle.SelectedIndexChanged += new System.EventHandler(this.comboThrottle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 56);
            this.label3.TabIndex = 9;
            this.label3.Text = "PedalPal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Device:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Brake:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Throttle:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(15, 394);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(278, 41);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Start";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(15, 286);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(278, 20);
            this.inputIP.TabIndex = 13;
            this.inputIP.TextChanged += new System.EventHandler(this.inputIP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "A silly project by Koenvh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Remote machine\'s IP address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "This machine\'s IP address:";
            // 
            // inputOwnIP
            // 
            this.inputOwnIP.Location = new System.Drawing.Point(15, 334);
            this.inputOwnIP.Name = "inputOwnIP";
            this.inputOwnIP.ReadOnly = true;
            this.inputOwnIP.Size = new System.Drawing.Size(278, 20);
            this.inputOwnIP.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "vJoy controller ID:";
            // 
            // comboVJoyID
            // 
            this.comboVJoyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVJoyID.FormattingEnabled = true;
            this.comboVJoyID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboVJoyID.Location = new System.Drawing.Point(110, 367);
            this.comboVJoyID.Name = "comboVJoyID";
            this.comboVJoyID.Size = new System.Drawing.Size(61, 21);
            this.comboVJoyID.TabIndex = 20;
            this.comboVJoyID.SelectedIndexChanged += new System.EventHandler(this.comboVJoyID_SelectedIndexChanged);
            // 
            // linkGameControllers
            // 
            this.linkGameControllers.AutoSize = true;
            this.linkGameControllers.Location = new System.Drawing.Point(180, 448);
            this.linkGameControllers.Name = "linkGameControllers";
            this.linkGameControllers.Size = new System.Drawing.Size(113, 13);
            this.linkGameControllers.TabIndex = 21;
            this.linkGameControllers.TabStop = true;
            this.linkGameControllers.Text = "Open game controllers";
            this.linkGameControllers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGameControllers_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.progressBrakeRemote);
            this.groupBox1.Controls.Add(this.progressThrottleRemote);
            this.groupBox1.Location = new System.Drawing.Point(157, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote inputs";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Throttle";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Brake";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBrakeRemote
            // 
            this.progressBrakeRemote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBrakeRemote.Location = new System.Drawing.Point(64, 19);
            this.progressBrakeRemote.MarqueeAnimationSpeed = 0;
            this.progressBrakeRemote.Name = "progressBrakeRemote";
            this.progressBrakeRemote.Size = new System.Drawing.Size(66, 23);
            this.progressBrakeRemote.TabIndex = 0;
            // 
            // progressThrottleRemote
            // 
            this.progressThrottleRemote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressThrottleRemote.Location = new System.Drawing.Point(64, 48);
            this.progressThrottleRemote.MarqueeAnimationSpeed = 0;
            this.progressThrottleRemote.Name = "progressThrottleRemote";
            this.progressThrottleRemote.Size = new System.Drawing.Size(66, 23);
            this.progressThrottleRemote.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkGameControllers);
            this.Controls.Add(this.comboVJoyID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputOwnIP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.comboThrottle);
            this.Controls.Add(this.comboDevice);
            this.Controls.Add(this.groupInputs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBrake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PedalPal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBrake;
        private System.Windows.Forms.ProgressBar progressThrottle;
        private System.Windows.Forms.GroupBox groupInputs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer inputTimer;
        private System.Windows.Forms.ComboBox comboBrake;
        private System.Windows.Forms.ComboBox comboThrottle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputOwnIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboVJoyID;
        private System.Windows.Forms.LinkLabel linkGameControllers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBrakeRemote;
        private System.Windows.Forms.ProgressBar progressThrottleRemote;
    }
}


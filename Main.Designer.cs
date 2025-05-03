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
            this.radioSender = new System.Windows.Forms.RadioButton();
            this.radioReceiver = new System.Windows.Forms.RadioButton();
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
            this.groupInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBrake
            // 
            this.progressBrake.Location = new System.Drawing.Point(94, 19);
            this.progressBrake.MarqueeAnimationSpeed = 0;
            this.progressBrake.Name = "progressBrake";
            this.progressBrake.Size = new System.Drawing.Size(100, 23);
            this.progressBrake.TabIndex = 0;
            // 
            // progressThrottle
            // 
            this.progressThrottle.Location = new System.Drawing.Point(94, 48);
            this.progressThrottle.MarqueeAnimationSpeed = 0;
            this.progressThrottle.Name = "progressThrottle";
            this.progressThrottle.Size = new System.Drawing.Size(100, 23);
            this.progressThrottle.TabIndex = 1;
            // 
            // groupInputs
            // 
            this.groupInputs.Controls.Add(this.label2);
            this.groupInputs.Controls.Add(this.label1);
            this.groupInputs.Controls.Add(this.progressBrake);
            this.groupInputs.Controls.Add(this.progressThrottle);
            this.groupInputs.Location = new System.Drawing.Point(42, 187);
            this.groupInputs.Name = "groupInputs";
            this.groupInputs.Size = new System.Drawing.Size(200, 80);
            this.groupInputs.TabIndex = 2;
            this.groupInputs.TabStop = false;
            this.groupInputs.Text = "Inputs";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Throttle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
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
            this.comboDevice.Size = new System.Drawing.Size(252, 21);
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
            // radioSender
            // 
            this.radioSender.AutoSize = true;
            this.radioSender.Location = new System.Drawing.Point(89, 329);
            this.radioSender.Name = "radioSender";
            this.radioSender.Size = new System.Drawing.Size(59, 17);
            this.radioSender.TabIndex = 5;
            this.radioSender.TabStop = true;
            this.radioSender.Text = "Sender";
            this.radioSender.UseVisualStyleBackColor = true;
            // 
            // radioReceiver
            // 
            this.radioReceiver.AutoSize = true;
            this.radioReceiver.Location = new System.Drawing.Point(15, 329);
            this.radioReceiver.Name = "radioReceiver";
            this.radioReceiver.Size = new System.Drawing.Size(68, 17);
            this.radioReceiver.TabIndex = 6;
            this.radioReceiver.TabStop = true;
            this.radioReceiver.Text = "Receiver";
            this.radioReceiver.UseVisualStyleBackColor = true;
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
            this.comboBrake.Size = new System.Drawing.Size(121, 21);
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
            this.comboThrottle.Location = new System.Drawing.Point(146, 160);
            this.comboThrottle.Name = "comboThrottle";
            this.comboThrottle.Size = new System.Drawing.Size(121, 21);
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
            this.label6.Location = new System.Drawing.Point(143, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Throttle:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(15, 352);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Start";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(15, 293);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(171, 20);
            this.inputIP.TabIndex = 13;
            this.inputIP.TextChanged += new System.EventHandler(this.inputIP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "A silly project by Koenvh";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 451);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.radioReceiver);
            this.Controls.Add(this.comboThrottle);
            this.Controls.Add(this.radioSender);
            this.Controls.Add(this.comboDevice);
            this.Controls.Add(this.groupInputs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBrake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PedalPal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RadioButton radioSender;
        private System.Windows.Forms.RadioButton radioReceiver;
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
    }
}


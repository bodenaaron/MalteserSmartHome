namespace MalteserSmartHome
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_emergency = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_care = new System.Windows.Forms.Button();
            this.btn_family = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_temperatur = new System.Windows.Forms.Label();
            this.lbl_doors = new System.Windows.Forms.Label();
            this.lbl_window = new System.Windows.Forms.Label();
            this.btn_dev_FireAlarm = new System.Windows.Forms.Button();
            this.btn_dev_WaterAlarm = new System.Windows.Forms.Button();
            this.btn_dev_CO2Alarm = new System.Windows.Forms.Button();
            this.btn_dev__doorClosed = new System.Windows.Forms.Button();
            this.btn_dev_doorOpen = new System.Windows.Forms.Button();
            this.btn_dev_WindowClosed = new System.Windows.Forms.Button();
            this.btn_dev_WindowOpen = new System.Windows.Forms.Button();
            this.pnl_dateTime = new System.Windows.Forms.Panel();
            this.pnl_air = new System.Windows.Forms.Panel();
            this.pnl_security = new System.Windows.Forms.Panel();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_dev = new System.Windows.Forms.Panel();
            this.btn_arrow_left = new System.Windows.Forms.Button();
            this.btn_arrow_right = new System.Windows.Forms.Button();
            this.pnl_dateTime.SuspendLayout();
            this.pnl_air.SuspendLayout();
            this.pnl_security.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_dev.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_emergency
            // 
            this.btn_emergency.Location = new System.Drawing.Point(1, 1);
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.Size = new System.Drawing.Size(75, 23);
            this.btn_emergency.TabIndex = 0;
            this.btn_emergency.Text = "Notruf";
            this.btn_emergency.UseVisualStyleBackColor = true;
            this.btn_emergency.Click += new System.EventHandler(this.btn_emergency_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(713, 1);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(75, 23);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Einstellungen";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_care
            // 
            this.btn_care.Location = new System.Drawing.Point(12, 415);
            this.btn_care.Name = "btn_care";
            this.btn_care.Size = new System.Drawing.Size(75, 23);
            this.btn_care.TabIndex = 2;
            this.btn_care.Text = "Pflegedienst";
            this.btn_care.UseVisualStyleBackColor = true;
            this.btn_care.Click += new System.EventHandler(this.btn_care_Click);
            // 
            // btn_family
            // 
            this.btn_family.Location = new System.Drawing.Point(713, 415);
            this.btn_family.Name = "btn_family";
            this.btn_family.Size = new System.Drawing.Size(75, 23);
            this.btn_family.TabIndex = 3;
            this.btn_family.Text = "Familie";
            this.btn_family.UseVisualStyleBackColor = true;
            this.btn_family.Click += new System.EventHandler(this.btn_family_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(15, 59);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 13);
            this.lbl_time.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(11, 18);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 13);
            this.lbl_date.TabIndex = 0;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Location = new System.Drawing.Point(3, 57);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(61, 13);
            this.lbl_humidity.TabIndex = 1;
            this.lbl_humidity.Text = "Luftfeuchte";
            // 
            // lbl_temperatur
            // 
            this.lbl_temperatur.AutoSize = true;
            this.lbl_temperatur.Location = new System.Drawing.Point(3, 26);
            this.lbl_temperatur.Name = "lbl_temperatur";
            this.lbl_temperatur.Size = new System.Drawing.Size(61, 13);
            this.lbl_temperatur.TabIndex = 0;
            this.lbl_temperatur.Text = "Temperatur";
            // 
            // lbl_doors
            // 
            this.lbl_doors.AutoSize = true;
            this.lbl_doors.Location = new System.Drawing.Point(15, 47);
            this.lbl_doors.Name = "lbl_doors";
            this.lbl_doors.Size = new System.Drawing.Size(35, 13);
            this.lbl_doors.TabIndex = 1;
            this.lbl_doors.Text = "Türen";
            // 
            // lbl_window
            // 
            this.lbl_window.AutoSize = true;
            this.lbl_window.Location = new System.Drawing.Point(15, 16);
            this.lbl_window.Name = "lbl_window";
            this.lbl_window.Size = new System.Drawing.Size(42, 13);
            this.lbl_window.TabIndex = 0;
            this.lbl_window.Text = "Fenster";
            // 
            // btn_dev_FireAlarm
            // 
            this.btn_dev_FireAlarm.Location = new System.Drawing.Point(41, 0);
            this.btn_dev_FireAlarm.Name = "btn_dev_FireAlarm";
            this.btn_dev_FireAlarm.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_FireAlarm.TabIndex = 10;
            this.btn_dev_FireAlarm.Text = "Feuer";
            this.btn_dev_FireAlarm.UseVisualStyleBackColor = true;
            this.btn_dev_FireAlarm.Click += new System.EventHandler(this.btn_dev_FireAlarm_Click);
            // 
            // btn_dev_WaterAlarm
            // 
            this.btn_dev_WaterAlarm.Location = new System.Drawing.Point(41, 37);
            this.btn_dev_WaterAlarm.Name = "btn_dev_WaterAlarm";
            this.btn_dev_WaterAlarm.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_WaterAlarm.TabIndex = 11;
            this.btn_dev_WaterAlarm.Text = "Wasser";
            this.btn_dev_WaterAlarm.UseVisualStyleBackColor = true;
            this.btn_dev_WaterAlarm.Click += new System.EventHandler(this.btn_dev_WaterAlarm_Click);
            // 
            // btn_dev_CO2Alarm
            // 
            this.btn_dev_CO2Alarm.Location = new System.Drawing.Point(41, 75);
            this.btn_dev_CO2Alarm.Name = "btn_dev_CO2Alarm";
            this.btn_dev_CO2Alarm.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_CO2Alarm.TabIndex = 16;
            this.btn_dev_CO2Alarm.Text = "Co2";
            this.btn_dev_CO2Alarm.UseVisualStyleBackColor = true;
            this.btn_dev_CO2Alarm.Click += new System.EventHandler(this.btn_dev_CO2Alarm_Click);
            // 
            // btn_dev__doorClosed
            // 
            this.btn_dev__doorClosed.Location = new System.Drawing.Point(188, 32);
            this.btn_dev__doorClosed.Name = "btn_dev__doorClosed";
            this.btn_dev__doorClosed.Size = new System.Drawing.Size(75, 23);
            this.btn_dev__doorClosed.TabIndex = 15;
            this.btn_dev__doorClosed.Text = "Tür zu";
            this.btn_dev__doorClosed.UseVisualStyleBackColor = true;
            this.btn_dev__doorClosed.Click += new System.EventHandler(this.btn_dev__doorClosed_Click);
            // 
            // btn_dev_doorOpen
            // 
            this.btn_dev_doorOpen.Location = new System.Drawing.Point(188, 3);
            this.btn_dev_doorOpen.Name = "btn_dev_doorOpen";
            this.btn_dev_doorOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_doorOpen.TabIndex = 14;
            this.btn_dev_doorOpen.Text = "Tür auf";
            this.btn_dev_doorOpen.UseVisualStyleBackColor = true;
            this.btn_dev_doorOpen.Click += new System.EventHandler(this.btn_dev_doorOpen_Click);
            // 
            // btn_dev_WindowClosed
            // 
            this.btn_dev_WindowClosed.Location = new System.Drawing.Point(188, 90);
            this.btn_dev_WindowClosed.Name = "btn_dev_WindowClosed";
            this.btn_dev_WindowClosed.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_WindowClosed.TabIndex = 13;
            this.btn_dev_WindowClosed.Text = "Fenster zu";
            this.btn_dev_WindowClosed.UseVisualStyleBackColor = true;
            this.btn_dev_WindowClosed.Click += new System.EventHandler(this.btn_dev_WindowClosed_Click);
            // 
            // btn_dev_WindowOpen
            // 
            this.btn_dev_WindowOpen.Location = new System.Drawing.Point(188, 61);
            this.btn_dev_WindowOpen.Name = "btn_dev_WindowOpen";
            this.btn_dev_WindowOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_dev_WindowOpen.TabIndex = 12;
            this.btn_dev_WindowOpen.Text = "Fenster  auf";
            this.btn_dev_WindowOpen.UseVisualStyleBackColor = true;
            this.btn_dev_WindowOpen.Click += new System.EventHandler(this.btn_dev_WindowOpen_Click);
            // 
            // pnl_dateTime
            // 
            this.pnl_dateTime.Controls.Add(this.lbl_time);
            this.pnl_dateTime.Controls.Add(this.lbl_date);
            this.pnl_dateTime.Location = new System.Drawing.Point(132, 77);
            this.pnl_dateTime.Name = "pnl_dateTime";
            this.pnl_dateTime.Size = new System.Drawing.Size(144, 89);
            this.pnl_dateTime.TabIndex = 11;
            // 
            // pnl_air
            // 
            this.pnl_air.Controls.Add(this.lbl_humidity);
            this.pnl_air.Controls.Add(this.lbl_temperatur);
            this.pnl_air.Location = new System.Drawing.Point(282, 77);
            this.pnl_air.Name = "pnl_air";
            this.pnl_air.Size = new System.Drawing.Size(106, 73);
            this.pnl_air.TabIndex = 12;
            // 
            // pnl_security
            // 
            this.pnl_security.Controls.Add(this.lbl_doors);
            this.pnl_security.Controls.Add(this.lbl_window);
            this.pnl_security.Location = new System.Drawing.Point(394, 77);
            this.pnl_security.Name = "pnl_security";
            this.pnl_security.Size = new System.Drawing.Size(76, 73);
            this.pnl_security.TabIndex = 13;
            // 
            // pnl_settings
            // 
            this.pnl_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_settings.Controls.Add(this.pictureBox2);
            this.pnl_settings.Controls.Add(this.pictureBox1);
            this.pnl_settings.Location = new System.Drawing.Point(139, 205);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(549, 142);
            this.pnl_settings.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::MalteserSmartHome.Properties.Resources.MalteserModellhausLeiser;
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 132);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.sendCommandQuieter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausLauter;
            this.pictureBox1.Location = new System.Drawing.Point(421, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 129);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.sendCommandLouder);
            // 
            // pnl_dev
            // 
            this.pnl_dev.Controls.Add(this.btn_dev_CO2Alarm);
            this.pnl_dev.Controls.Add(this.btn_dev_doorOpen);
            this.pnl_dev.Controls.Add(this.btn_dev__doorClosed);
            this.pnl_dev.Controls.Add(this.btn_dev_WaterAlarm);
            this.pnl_dev.Controls.Add(this.btn_dev_FireAlarm);
            this.pnl_dev.Controls.Add(this.btn_dev_WindowClosed);
            this.pnl_dev.Controls.Add(this.btn_dev_WindowOpen);
            this.pnl_dev.Location = new System.Drawing.Point(269, 331);
            this.pnl_dev.Name = "pnl_dev";
            this.pnl_dev.Size = new System.Drawing.Size(388, 95);
            this.pnl_dev.TabIndex = 15;
            // 
            // btn_arrow_left
            // 
            this.btn_arrow_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_arrow_left.Image")));
            this.btn_arrow_left.Location = new System.Drawing.Point(12, 183);
            this.btn_arrow_left.Name = "btn_arrow_left";
            this.btn_arrow_left.Size = new System.Drawing.Size(75, 23);
            this.btn_arrow_left.TabIndex = 5;
            this.btn_arrow_left.UseVisualStyleBackColor = true;
            this.btn_arrow_left.Click += new System.EventHandler(this.btn_arrow_left_Click);
            // 
            // btn_arrow_right
            // 
            this.btn_arrow_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_arrow_right.Image")));
            this.btn_arrow_right.Location = new System.Drawing.Point(713, 183);
            this.btn_arrow_right.Name = "btn_arrow_right";
            this.btn_arrow_right.Size = new System.Drawing.Size(75, 23);
            this.btn_arrow_right.TabIndex = 4;
            this.btn_arrow_right.UseVisualStyleBackColor = true;
            this.btn_arrow_right.Click += new System.EventHandler(this.btn_arrow_right_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_dev);
            this.Controls.Add(this.pnl_settings);
            this.Controls.Add(this.pnl_security);
            this.Controls.Add(this.pnl_air);
            this.Controls.Add(this.pnl_dateTime);
            this.Controls.Add(this.btn_arrow_left);
            this.Controls.Add(this.btn_arrow_right);
            this.Controls.Add(this.btn_family);
            this.Controls.Add(this.btn_care);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_emergency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainWindow";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            this.pnl_dateTime.ResumeLayout(false);
            this.pnl_dateTime.PerformLayout();
            this.pnl_air.ResumeLayout(false);
            this.pnl_air.PerformLayout();
            this.pnl_security.ResumeLayout(false);
            this.pnl_security.PerformLayout();
            this.pnl_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_dev.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_emergency;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_care;
        private System.Windows.Forms.Button btn_family;
        private System.Windows.Forms.Button btn_arrow_right;
        private System.Windows.Forms.Button btn_arrow_left;
        private System.Windows.Forms.Label lbl_doors;
        private System.Windows.Forms.Label lbl_window;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_dev_FireAlarm;
        private System.Windows.Forms.Button btn_dev_WaterAlarm;
        private System.Windows.Forms.Button btn_dev__doorClosed;
        private System.Windows.Forms.Button btn_dev_doorOpen;
        private System.Windows.Forms.Button btn_dev_WindowClosed;
        private System.Windows.Forms.Button btn_dev_WindowOpen;
        private System.Windows.Forms.Button btn_dev_CO2Alarm;
        private System.Windows.Forms.Label lbl_temperatur;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Panel pnl_dateTime;
        private System.Windows.Forms.Panel pnl_air;
        private System.Windows.Forms.Panel pnl_security;
        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.Panel pnl_dev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
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
            this.pb_quieter = new System.Windows.Forms.PictureBox();
            this.pb_louder = new System.Windows.Forms.PictureBox();
            this.pnl_dev = new System.Windows.Forms.Panel();
            this.btn_arrow_left = new System.Windows.Forms.Button();
            this.btn_arrow_right = new System.Windows.Forms.Button();
            this.pb_Sound1 = new System.Windows.Forms.PictureBox();
            this.pb_Sound2 = new System.Windows.Forms.PictureBox();
            this.pb_Sound3 = new System.Windows.Forms.PictureBox();
            this.pb_Sound4 = new System.Windows.Forms.PictureBox();
            this.pnl_dateTime.SuspendLayout();
            this.pnl_air.SuspendLayout();
            this.pnl_security.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quieter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_louder)).BeginInit();
            this.pnl_dev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_emergency
            // 
            this.btn_emergency.Location = new System.Drawing.Point(3, 2);
            this.btn_emergency.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.Size = new System.Drawing.Size(200, 55);
            this.btn_emergency.TabIndex = 0;
            this.btn_emergency.Text = "Notruf";
            this.btn_emergency.UseVisualStyleBackColor = true;
            this.btn_emergency.Click += new System.EventHandler(this.btn_emergency_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(1901, 2);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(200, 55);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Einstellungen";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_care
            // 
            this.btn_care.Location = new System.Drawing.Point(32, 990);
            this.btn_care.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_care.Name = "btn_care";
            this.btn_care.Size = new System.Drawing.Size(200, 55);
            this.btn_care.TabIndex = 2;
            this.btn_care.Text = "Pflegedienst";
            this.btn_care.UseVisualStyleBackColor = true;
            this.btn_care.Click += new System.EventHandler(this.btn_care_Click);
            // 
            // btn_family
            // 
            this.btn_family.Location = new System.Drawing.Point(1901, 990);
            this.btn_family.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_family.Name = "btn_family";
            this.btn_family.Size = new System.Drawing.Size(200, 55);
            this.btn_family.TabIndex = 3;
            this.btn_family.Text = "Familie";
            this.btn_family.UseVisualStyleBackColor = true;
            this.btn_family.Click += new System.EventHandler(this.btn_family_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(40, 141);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 32);
            this.lbl_time.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(29, 43);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 32);
            this.lbl_date.TabIndex = 0;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Location = new System.Drawing.Point(8, 136);
            this.lbl_humidity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(157, 32);
            this.lbl_humidity.TabIndex = 1;
            this.lbl_humidity.Text = "Luftfeuchte";
            // 
            // lbl_temperatur
            // 
            this.lbl_temperatur.AutoSize = true;
            this.lbl_temperatur.Location = new System.Drawing.Point(8, 62);
            this.lbl_temperatur.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_temperatur.Name = "lbl_temperatur";
            this.lbl_temperatur.Size = new System.Drawing.Size(161, 32);
            this.lbl_temperatur.TabIndex = 0;
            this.lbl_temperatur.Text = "Temperatur";
            // 
            // lbl_doors
            // 
            this.lbl_doors.AutoSize = true;
            this.lbl_doors.Location = new System.Drawing.Point(40, 112);
            this.lbl_doors.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_doors.Name = "lbl_doors";
            this.lbl_doors.Size = new System.Drawing.Size(89, 32);
            this.lbl_doors.TabIndex = 1;
            this.lbl_doors.Text = "Türen";
            // 
            // lbl_window
            // 
            this.lbl_window.AutoSize = true;
            this.lbl_window.Location = new System.Drawing.Point(40, 38);
            this.lbl_window.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_window.Name = "lbl_window";
            this.lbl_window.Size = new System.Drawing.Size(111, 32);
            this.lbl_window.TabIndex = 0;
            this.lbl_window.Text = "Fenster";
            // 
            // btn_dev_FireAlarm
            // 
            this.btn_dev_FireAlarm.Location = new System.Drawing.Point(109, 0);
            this.btn_dev_FireAlarm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_FireAlarm.Name = "btn_dev_FireAlarm";
            this.btn_dev_FireAlarm.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_FireAlarm.TabIndex = 10;
            this.btn_dev_FireAlarm.Text = "Feuer";
            this.btn_dev_FireAlarm.UseVisualStyleBackColor = true;
            this.btn_dev_FireAlarm.Click += new System.EventHandler(this.btn_dev_FireAlarm_Click);
            // 
            // btn_dev_WaterAlarm
            // 
            this.btn_dev_WaterAlarm.Location = new System.Drawing.Point(109, 88);
            this.btn_dev_WaterAlarm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_WaterAlarm.Name = "btn_dev_WaterAlarm";
            this.btn_dev_WaterAlarm.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_WaterAlarm.TabIndex = 11;
            this.btn_dev_WaterAlarm.Text = "Wasser";
            this.btn_dev_WaterAlarm.UseVisualStyleBackColor = true;
            this.btn_dev_WaterAlarm.Click += new System.EventHandler(this.btn_dev_WaterAlarm_Click);
            // 
            // btn_dev_CO2Alarm
            // 
            this.btn_dev_CO2Alarm.Location = new System.Drawing.Point(109, 179);
            this.btn_dev_CO2Alarm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_CO2Alarm.Name = "btn_dev_CO2Alarm";
            this.btn_dev_CO2Alarm.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_CO2Alarm.TabIndex = 16;
            this.btn_dev_CO2Alarm.Text = "Co2";
            this.btn_dev_CO2Alarm.UseVisualStyleBackColor = true;
            this.btn_dev_CO2Alarm.Click += new System.EventHandler(this.btn_dev_CO2Alarm_Click);
            // 
            // btn_dev__doorClosed
            // 
            this.btn_dev__doorClosed.Location = new System.Drawing.Point(501, 76);
            this.btn_dev__doorClosed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev__doorClosed.Name = "btn_dev__doorClosed";
            this.btn_dev__doorClosed.Size = new System.Drawing.Size(200, 55);
            this.btn_dev__doorClosed.TabIndex = 15;
            this.btn_dev__doorClosed.Text = "Tür zu";
            this.btn_dev__doorClosed.UseVisualStyleBackColor = true;
            this.btn_dev__doorClosed.Click += new System.EventHandler(this.btn_dev__doorClosed_Click);
            // 
            // btn_dev_doorOpen
            // 
            this.btn_dev_doorOpen.Location = new System.Drawing.Point(501, 7);
            this.btn_dev_doorOpen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_doorOpen.Name = "btn_dev_doorOpen";
            this.btn_dev_doorOpen.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_doorOpen.TabIndex = 14;
            this.btn_dev_doorOpen.Text = "Tür auf";
            this.btn_dev_doorOpen.UseVisualStyleBackColor = true;
            this.btn_dev_doorOpen.Click += new System.EventHandler(this.btn_dev_doorOpen_Click);
            // 
            // btn_dev_WindowClosed
            // 
            this.btn_dev_WindowClosed.Location = new System.Drawing.Point(501, 215);
            this.btn_dev_WindowClosed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_WindowClosed.Name = "btn_dev_WindowClosed";
            this.btn_dev_WindowClosed.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_WindowClosed.TabIndex = 13;
            this.btn_dev_WindowClosed.Text = "Fenster zu";
            this.btn_dev_WindowClosed.UseVisualStyleBackColor = true;
            this.btn_dev_WindowClosed.Click += new System.EventHandler(this.btn_dev_WindowClosed_Click);
            // 
            // btn_dev_WindowOpen
            // 
            this.btn_dev_WindowOpen.Location = new System.Drawing.Point(501, 145);
            this.btn_dev_WindowOpen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_dev_WindowOpen.Name = "btn_dev_WindowOpen";
            this.btn_dev_WindowOpen.Size = new System.Drawing.Size(200, 55);
            this.btn_dev_WindowOpen.TabIndex = 12;
            this.btn_dev_WindowOpen.Text = "Fenster  auf";
            this.btn_dev_WindowOpen.UseVisualStyleBackColor = true;
            this.btn_dev_WindowOpen.Click += new System.EventHandler(this.btn_dev_WindowOpen_Click);
            // 
            // pnl_dateTime
            // 
            this.pnl_dateTime.Controls.Add(this.lbl_time);
            this.pnl_dateTime.Controls.Add(this.lbl_date);
            this.pnl_dateTime.Location = new System.Drawing.Point(352, 184);
            this.pnl_dateTime.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_dateTime.Name = "pnl_dateTime";
            this.pnl_dateTime.Size = new System.Drawing.Size(384, 212);
            this.pnl_dateTime.TabIndex = 11;
            // 
            // pnl_air
            // 
            this.pnl_air.Controls.Add(this.lbl_humidity);
            this.pnl_air.Controls.Add(this.lbl_temperatur);
            this.pnl_air.Location = new System.Drawing.Point(752, 184);
            this.pnl_air.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_air.Name = "pnl_air";
            this.pnl_air.Size = new System.Drawing.Size(283, 174);
            this.pnl_air.TabIndex = 12;
            // 
            // pnl_security
            // 
            this.pnl_security.Controls.Add(this.lbl_doors);
            this.pnl_security.Controls.Add(this.lbl_window);
            this.pnl_security.Location = new System.Drawing.Point(1051, 184);
            this.pnl_security.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_security.Name = "pnl_security";
            this.pnl_security.Size = new System.Drawing.Size(203, 174);
            this.pnl_security.TabIndex = 13;
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.pb_Sound4);
            this.pnl_settings.Controls.Add(this.pb_Sound3);
            this.pnl_settings.Controls.Add(this.pb_Sound2);
            this.pnl_settings.Controls.Add(this.pb_Sound1);
            this.pnl_settings.Controls.Add(this.pb_quieter);
            this.pnl_settings.Controls.Add(this.pb_louder);
            this.pnl_settings.Location = new System.Drawing.Point(371, 489);
            this.pnl_settings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(1464, 339);
            this.pnl_settings.TabIndex = 14;
            // 
            // pb_quieter
            // 
            this.pb_quieter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_quieter.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausLeiser;
            this.pb_quieter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_quieter.Location = new System.Drawing.Point(0, 10);
            this.pb_quieter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pb_quieter.Name = "pb_quieter";
            this.pb_quieter.Size = new System.Drawing.Size(408, 315);
            this.pb_quieter.TabIndex = 17;
            this.pb_quieter.TabStop = false;
            this.pb_quieter.Click += new System.EventHandler(this.sendCommandQuieter);
            // 
            // pb_louder
            // 
            this.pb_louder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_louder.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausLauter;
            this.pb_louder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_louder.Location = new System.Drawing.Point(1123, 0);
            this.pb_louder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pb_louder.Name = "pb_louder";
            this.pb_louder.Size = new System.Drawing.Size(341, 308);
            this.pb_louder.TabIndex = 16;
            this.pb_louder.TabStop = false;
            this.pb_louder.Click += new System.EventHandler(this.sendCommandLouder);
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
            this.pnl_dev.Location = new System.Drawing.Point(717, 789);
            this.pnl_dev.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_dev.Name = "pnl_dev";
            this.pnl_dev.Size = new System.Drawing.Size(1035, 227);
            this.pnl_dev.TabIndex = 15;
            // 
            // btn_arrow_left
            // 
            this.btn_arrow_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_arrow_left.Image")));
            this.btn_arrow_left.Location = new System.Drawing.Point(32, 436);
            this.btn_arrow_left.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_arrow_left.Name = "btn_arrow_left";
            this.btn_arrow_left.Size = new System.Drawing.Size(200, 55);
            this.btn_arrow_left.TabIndex = 5;
            this.btn_arrow_left.UseVisualStyleBackColor = true;
            this.btn_arrow_left.Click += new System.EventHandler(this.btn_arrow_left_Click);
            // 
            // btn_arrow_right
            // 
            this.btn_arrow_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_arrow_right.Image")));
            this.btn_arrow_right.Location = new System.Drawing.Point(1901, 436);
            this.btn_arrow_right.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_arrow_right.Name = "btn_arrow_right";
            this.btn_arrow_right.Size = new System.Drawing.Size(200, 55);
            this.btn_arrow_right.TabIndex = 4;
            this.btn_arrow_right.UseVisualStyleBackColor = true;
            this.btn_arrow_right.Click += new System.EventHandler(this.btn_arrow_right_Click);
            // 
            // pb_Sound1
            // 
            this.pb_Sound1.Location = new System.Drawing.Point(520, 66);
            this.pb_Sound1.Name = "pb_Sound1";
            this.pb_Sound1.Size = new System.Drawing.Size(100, 50);
            this.pb_Sound1.TabIndex = 18;
            this.pb_Sound1.TabStop = false;
            // 
            // pb_Sound2
            // 
            this.pb_Sound2.Location = new System.Drawing.Point(682, 144);
            this.pb_Sound2.Name = "pb_Sound2";
            this.pb_Sound2.Size = new System.Drawing.Size(100, 50);
            this.pb_Sound2.TabIndex = 19;
            this.pb_Sound2.TabStop = false;
            // 
            // pb_Sound3
            // 
            this.pb_Sound3.Location = new System.Drawing.Point(847, 106);
            this.pb_Sound3.Name = "pb_Sound3";
            this.pb_Sound3.Size = new System.Drawing.Size(100, 50);
            this.pb_Sound3.TabIndex = 20;
            this.pb_Sound3.TabStop = false;
            // 
            // pb_Sound4
            // 
            this.pb_Sound4.Location = new System.Drawing.Point(935, 217);
            this.pb_Sound4.Name = "pb_Sound4";
            this.pb_Sound4.Size = new System.Drawing.Size(100, 50);
            this.pb_Sound4.TabIndex = 21;
            this.pb_Sound4.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2173, 1173);
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
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "pb_quiter";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pnl_dateTime.ResumeLayout(false);
            this.pnl_dateTime.PerformLayout();
            this.pnl_air.ResumeLayout(false);
            this.pnl_air.PerformLayout();
            this.pnl_security.ResumeLayout(false);
            this.pnl_security.PerformLayout();
            this.pnl_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_quieter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_louder)).EndInit();
            this.pnl_dev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sound4)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_louder;
        private System.Windows.Forms.PictureBox pb_quieter;
        private System.Windows.Forms.PictureBox pb_Sound4;
        private System.Windows.Forms.PictureBox pb_Sound3;
        private System.Windows.Forms.PictureBox pb_Sound2;
        private System.Windows.Forms.PictureBox pb_Sound1;
    }
}
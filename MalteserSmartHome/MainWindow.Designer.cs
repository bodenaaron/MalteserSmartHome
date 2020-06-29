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
            this.btn_emergency = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_care = new System.Windows.Forms.Button();
            this.btn_family = new System.Windows.Forms.Button();
            this.btn_arrow_right = new System.Windows.Forms.Button();
            this.btn_arrow_left = new System.Windows.Forms.Button();
            this.gb_datetime = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.gb_air = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_security = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_window = new System.Windows.Forms.Label();
            this.gb_settings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lauter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_datetime.SuspendLayout();
            this.gb_air.SuspendLayout();
            this.gb_security.SuspendLayout();
            this.gb_settings.SuspendLayout();
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
            this.btn_care.Location = new System.Drawing.Point(12, 424);
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
            this.btn_family.Text = "Familie kontaktieren";
            this.btn_family.UseVisualStyleBackColor = true;
            this.btn_family.Click += new System.EventHandler(this.btn_family_Click);
            // 
            // btn_arrow_right
            // 
            this.btn_arrow_right.Location = new System.Drawing.Point(713, 183);
            this.btn_arrow_right.Name = "btn_arrow_right";
            this.btn_arrow_right.Size = new System.Drawing.Size(75, 23);
            this.btn_arrow_right.TabIndex = 4;
            this.btn_arrow_right.Text = "r";
            this.btn_arrow_right.UseVisualStyleBackColor = true;
            this.btn_arrow_right.Click += new System.EventHandler(this.btn_arrow_right_Click);
            // 
            // btn_arrow_left
            // 
            this.btn_arrow_left.Location = new System.Drawing.Point(12, 183);
            this.btn_arrow_left.Name = "btn_arrow_left";
            this.btn_arrow_left.Size = new System.Drawing.Size(75, 23);
            this.btn_arrow_left.TabIndex = 5;
            this.btn_arrow_left.Text = "l";
            this.btn_arrow_left.UseVisualStyleBackColor = true;
            this.btn_arrow_left.Click += new System.EventHandler(this.btn_arrow_left_Click);
            // 
            // gb_datetime
            // 
            this.gb_datetime.Controls.Add(this.lbl_time);
            this.gb_datetime.Controls.Add(this.lbl_date);
            this.gb_datetime.Location = new System.Drawing.Point(163, 90);
            this.gb_datetime.Name = "gb_datetime";
            this.gb_datetime.Size = new System.Drawing.Size(113, 76);
            this.gb_datetime.TabIndex = 6;
            this.gb_datetime.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(6, 47);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(35, 13);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "label6";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(6, 16);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(35, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "label5";
            // 
            // gb_air
            // 
            this.gb_air.Controls.Add(this.label1);
            this.gb_air.Controls.Add(this.label2);
            this.gb_air.Location = new System.Drawing.Point(298, 90);
            this.gb_air.Name = "gb_air";
            this.gb_air.Size = new System.Drawing.Size(113, 76);
            this.gb_air.TabIndex = 7;
            this.gb_air.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luftfeuchte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperatur";
            // 
            // gb_security
            // 
            this.gb_security.Controls.Add(this.label3);
            this.gb_security.Controls.Add(this.lbl_window);
            this.gb_security.Location = new System.Drawing.Point(428, 90);
            this.gb_security.Name = "gb_security";
            this.gb_security.Size = new System.Drawing.Size(113, 76);
            this.gb_security.TabIndex = 8;
            this.gb_security.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Türen";
            // 
            // lbl_window
            // 
            this.lbl_window.AutoSize = true;
            this.lbl_window.Location = new System.Drawing.Point(6, 16);
            this.lbl_window.Name = "lbl_window";
            this.lbl_window.Size = new System.Drawing.Size(42, 13);
            this.lbl_window.TabIndex = 0;
            this.lbl_window.Text = "Fenster";
            // 
            // gb_settings
            // 
            this.gb_settings.Controls.Add(this.label4);
            this.gb_settings.Controls.Add(this.lauter);
            this.gb_settings.Location = new System.Drawing.Point(163, 183);
            this.gb_settings.Name = "gb_settings";
            this.gb_settings.Size = new System.Drawing.Size(113, 76);
            this.gb_settings.TabIndex = 9;
            this.gb_settings.TabStop = false;
            this.gb_settings.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "leiser";
            // 
            // lauter
            // 
            this.lauter.AutoSize = true;
            this.lauter.Location = new System.Drawing.Point(6, 16);
            this.lauter.Name = "lauter";
            this.lauter.Size = new System.Drawing.Size(33, 13);
            this.lauter.TabIndex = 0;
            this.lauter.Text = "lauter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Feuer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Wasser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_settings);
            this.Controls.Add(this.gb_security);
            this.Controls.Add(this.gb_air);
            this.Controls.Add(this.gb_datetime);
            this.Controls.Add(this.btn_arrow_left);
            this.Controls.Add(this.btn_arrow_right);
            this.Controls.Add(this.btn_family);
            this.Controls.Add(this.btn_care);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_emergency);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gb_datetime.ResumeLayout(false);
            this.gb_datetime.PerformLayout();
            this.gb_air.ResumeLayout(false);
            this.gb_air.PerformLayout();
            this.gb_security.ResumeLayout(false);
            this.gb_security.PerformLayout();
            this.gb_settings.ResumeLayout(false);
            this.gb_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_emergency;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_care;
        private System.Windows.Forms.Button btn_family;
        private System.Windows.Forms.Button btn_arrow_right;
        private System.Windows.Forms.Button btn_arrow_left;
        public System.Windows.Forms.GroupBox gb_datetime;        
        private System.Windows.Forms.GroupBox gb_air;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_security;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_window;
        private System.Windows.Forms.GroupBox gb_settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lauter;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace MalteserSmartHome
{
    partial class EmergencyFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyFire));
            this.btn_EmergencyFire_falseAlarm = new System.Windows.Forms.Button();
            this.btn_EmergencyFire_callFamily = new System.Windows.Forms.Button();
            this.btn_EmergencyFire_callEmergencyService = new System.Windows.Forms.Button();
            this.lbl_FireAlarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EmergencyFire_falseAlarm
            // 
            this.btn_EmergencyFire_falseAlarm.Location = new System.Drawing.Point(146, 354);
            this.btn_EmergencyFire_falseAlarm.Name = "btn_EmergencyFire_falseAlarm";
            this.btn_EmergencyFire_falseAlarm.Size = new System.Drawing.Size(75, 23);
            this.btn_EmergencyFire_falseAlarm.TabIndex = 0;
            this.btn_EmergencyFire_falseAlarm.Text = "button1";
            this.btn_EmergencyFire_falseAlarm.UseVisualStyleBackColor = true;
            this.btn_EmergencyFire_falseAlarm.Click += new System.EventHandler(this.btn_EmergencyFire_falseAlarm_Click);
            // 
            // btn_EmergencyFire_callFamily
            // 
            this.btn_EmergencyFire_callFamily.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmergencyFire_callFamily.Location = new System.Drawing.Point(363, 214);
            this.btn_EmergencyFire_callFamily.Name = "btn_EmergencyFire_callFamily";
            this.btn_EmergencyFire_callFamily.Size = new System.Drawing.Size(75, 23);
            this.btn_EmergencyFire_callFamily.TabIndex = 1;
            this.btn_EmergencyFire_callFamily.Text = "button1";
            this.btn_EmergencyFire_callFamily.UseVisualStyleBackColor = true;
            this.btn_EmergencyFire_callFamily.Click += new System.EventHandler(this.btn_EmergencyFire_callFamily_Click);
            // 
            // btn_EmergencyFire_callEmergencyService
            // 
            this.btn_EmergencyFire_callEmergencyService.Location = new System.Drawing.Point(471, 339);
            this.btn_EmergencyFire_callEmergencyService.Name = "btn_EmergencyFire_callEmergencyService";
            this.btn_EmergencyFire_callEmergencyService.Size = new System.Drawing.Size(75, 23);
            this.btn_EmergencyFire_callEmergencyService.TabIndex = 2;
            this.btn_EmergencyFire_callEmergencyService.Text = "button1";
            this.btn_EmergencyFire_callEmergencyService.UseVisualStyleBackColor = true;
            this.btn_EmergencyFire_callEmergencyService.Click += new System.EventHandler(this.btn_EmergencyFire_callEmergencyService_Click);
            // 
            // lbl_FireAlarm
            // 
            this.lbl_FireAlarm.AutoSize = true;
            this.lbl_FireAlarm.Location = new System.Drawing.Point(263, 255);
            this.lbl_FireAlarm.Name = "lbl_FireAlarm";
            this.lbl_FireAlarm.Size = new System.Drawing.Size(35, 13);
            this.lbl_FireAlarm.TabIndex = 4;
            this.lbl_FireAlarm.Text = "label2";
            // 
            // EmergencyFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FireAlarm);
            this.Controls.Add(this.btn_EmergencyFire_callEmergencyService);
            this.Controls.Add(this.btn_EmergencyFire_callFamily);
            this.Controls.Add(this.btn_EmergencyFire_falseAlarm);
            this.Name = "EmergencyFire";
            this.Text = "EmergencyFire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EmergencyFire_falseAlarm;
        private System.Windows.Forms.Button btn_EmergencyFire_callFamily;
        private System.Windows.Forms.Button btn_EmergencyFire_callEmergencyService;
        private System.Windows.Forms.Label lbl_FireAlarm;
    }
}
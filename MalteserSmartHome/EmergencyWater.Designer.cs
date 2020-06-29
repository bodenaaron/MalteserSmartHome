namespace MalteserSmartHome
{
    partial class EmergencyWater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyWater));
            this.btn_EmergencyWater_falseAlarm = new System.Windows.Forms.Button();
            this.btn_EmergencyWater_callFamily = new System.Windows.Forms.Button();
            this.lbl_EmegencyWater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EmergencyWater_falseAlarm
            // 
            this.btn_EmergencyWater_falseAlarm.Location = new System.Drawing.Point(108, 272);
            this.btn_EmergencyWater_falseAlarm.Name = "btn_EmergencyWater_falseAlarm";
            this.btn_EmergencyWater_falseAlarm.Size = new System.Drawing.Size(75, 23);
            this.btn_EmergencyWater_falseAlarm.TabIndex = 0;
            this.btn_EmergencyWater_falseAlarm.Text = "button1";
            this.btn_EmergencyWater_falseAlarm.UseVisualStyleBackColor = true;
            this.btn_EmergencyWater_falseAlarm.Click += new System.EventHandler(this.btn_EmergencyWater_falseAlarm_Click);
            // 
            // btn_EmergencyWater_callFamily
            // 
            this.btn_EmergencyWater_callFamily.Location = new System.Drawing.Point(574, 307);
            this.btn_EmergencyWater_callFamily.Name = "btn_EmergencyWater_callFamily";
            this.btn_EmergencyWater_callFamily.Size = new System.Drawing.Size(75, 23);
            this.btn_EmergencyWater_callFamily.TabIndex = 1;
            this.btn_EmergencyWater_callFamily.Text = "button2";
            this.btn_EmergencyWater_callFamily.UseVisualStyleBackColor = true;
            this.btn_EmergencyWater_callFamily.Click += new System.EventHandler(this.btn_EmergencyWater_callFamily_Click);
            // 
            // lbl_EmegencyWater
            // 
            this.lbl_EmegencyWater.AutoSize = true;
            this.lbl_EmegencyWater.Location = new System.Drawing.Point(337, 241);
            this.lbl_EmegencyWater.Name = "lbl_EmegencyWater";
            this.lbl_EmegencyWater.Size = new System.Drawing.Size(35, 13);
            this.lbl_EmegencyWater.TabIndex = 2;
            this.lbl_EmegencyWater.Text = "label1";
            // 
            // EmergencyWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_EmegencyWater);
            this.Controls.Add(this.btn_EmergencyWater_callFamily);
            this.Controls.Add(this.btn_EmergencyWater_falseAlarm);
            this.Name = "EmergencyWater";
            this.Text = "EmergencyWater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EmergencyWater_falseAlarm;
        private System.Windows.Forms.Button btn_EmergencyWater_callFamily;
        private System.Windows.Forms.Label lbl_EmegencyWater;
    }
}
namespace MalteserSmartHome
{
    partial class EmergencyCO2
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
            this.pb_COAlarfm = new System.Windows.Forms.PictureBox();
            this.lbl_coAlarm = new System.Windows.Forms.Label();
            this.btn_CO_emergency = new System.Windows.Forms.Button();
            this.btn_CO_Family = new System.Windows.Forms.Button();
            this.btn_CO_nothing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_COAlarfm)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_COAlarfm
            // 
            this.pb_COAlarfm.BackgroundImage = global::MalteserSmartHome.Properties.Resources.COALAR_;
            this.pb_COAlarfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_COAlarfm.Location = new System.Drawing.Point(268, 106);
            this.pb_COAlarfm.Name = "pb_COAlarfm";
            this.pb_COAlarfm.Size = new System.Drawing.Size(337, 198);
            this.pb_COAlarfm.TabIndex = 0;
            this.pb_COAlarfm.TabStop = false;
            // 
            // lbl_coAlarm
            // 
            this.lbl_coAlarm.AutoSize = true;
            this.lbl_coAlarm.Location = new System.Drawing.Point(719, 475);
            this.lbl_coAlarm.Name = "lbl_coAlarm";
            this.lbl_coAlarm.Size = new System.Drawing.Size(161, 32);
            this.lbl_coAlarm.TabIndex = 1;
            this.lbl_coAlarm.Text = "CO ALARM";
            // 
            // btn_CO_emergency
            // 
            this.btn_CO_emergency.Location = new System.Drawing.Point(903, 430);
            this.btn_CO_emergency.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_CO_emergency.Name = "btn_CO_emergency";
            this.btn_CO_emergency.Size = new System.Drawing.Size(200, 55);
            this.btn_CO_emergency.TabIndex = 5;
            this.btn_CO_emergency.Text = "button1";
            this.btn_CO_emergency.UseVisualStyleBackColor = true;
            // 
            // btn_CO_Family
            // 
            this.btn_CO_Family.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CO_Family.Location = new System.Drawing.Point(615, 132);
            this.btn_CO_Family.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_CO_Family.Name = "btn_CO_Family";
            this.btn_CO_Family.Size = new System.Drawing.Size(200, 55);
            this.btn_CO_Family.TabIndex = 4;
            this.btn_CO_Family.Text = "button1";
            this.btn_CO_Family.UseVisualStyleBackColor = true;
            // 
            // btn_CO_nothing
            // 
            this.btn_CO_nothing.Location = new System.Drawing.Point(36, 466);
            this.btn_CO_nothing.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_CO_nothing.Name = "btn_CO_nothing";
            this.btn_CO_nothing.Size = new System.Drawing.Size(200, 55);
            this.btn_CO_nothing.TabIndex = 3;
            this.btn_CO_nothing.Text = "button1";
            this.btn_CO_nothing.UseVisualStyleBackColor = true;
            // 
            // EmergencyCO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.btn_CO_emergency);
            this.Controls.Add(this.btn_CO_Family);
            this.Controls.Add(this.btn_CO_nothing);
            this.Controls.Add(this.lbl_coAlarm);
            this.Controls.Add(this.pb_COAlarfm);
            this.Name = "EmergencyCO2";
            this.Text = "EmergencyCO2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_COAlarfm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_COAlarfm;
        private System.Windows.Forms.Label lbl_coAlarm;
        private System.Windows.Forms.Button btn_CO_emergency;
        private System.Windows.Forms.Button btn_CO_Family;
        private System.Windows.Forms.Button btn_CO_nothing;
    }
}
namespace MalteserSmartHome
{
    partial class AirQualityAlarm
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
            this.pb_AirQualityOpenWindow = new System.Windows.Forms.PictureBox();
            this.lbl_AirQuality = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AirQualityOpenWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_AirQualityOpenWindow
            // 
            this.pb_AirQualityOpenWindow.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausFensterAuf;
            this.pb_AirQualityOpenWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_AirQualityOpenWindow.Location = new System.Drawing.Point(191, 109);
            this.pb_AirQualityOpenWindow.Name = "pb_AirQualityOpenWindow";
            this.pb_AirQualityOpenWindow.Size = new System.Drawing.Size(100, 50);
            this.pb_AirQualityOpenWindow.TabIndex = 4;
            this.pb_AirQualityOpenWindow.TabStop = false;
            // 
            // lbl_AirQuality
            // 
            this.lbl_AirQuality.AutoSize = true;
            this.lbl_AirQuality.Location = new System.Drawing.Point(574, 328);
            this.lbl_AirQuality.Name = "lbl_AirQuality";
            this.lbl_AirQuality.Size = new System.Drawing.Size(67, 13);
            this.lbl_AirQuality.TabIndex = 3;
            this.lbl_AirQuality.Text = "lbl_AirQuality";
            // 
            // AirQualityAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_AirQualityOpenWindow);
            this.Controls.Add(this.lbl_AirQuality);
            this.Name = "AirQualityAlarm";
            this.Text = "AirQualityAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_AirQualityOpenWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_AirQualityOpenWindow;
        private System.Windows.Forms.Label lbl_AirQuality;
    }
}
namespace MalteserSmartHome
{
    partial class EmergencyCalling
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
            this.lbl_Emergency = new System.Windows.Forms.Label();
            this.pb_cancelCall = new System.Windows.Forms.PictureBox();
            this.pb_Ambulance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ambulance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Emergency
            // 
            this.lbl_Emergency.AutoSize = true;
            this.lbl_Emergency.Location = new System.Drawing.Point(342, 62);
            this.lbl_Emergency.Name = "lbl_Emergency";
            this.lbl_Emergency.Size = new System.Drawing.Size(35, 13);
            this.lbl_Emergency.TabIndex = 1;
            this.lbl_Emergency.Text = "label1";
            // 
            // pb_cancelCall
            // 
            this.pb_cancelCall.BackColor = System.Drawing.Color.Transparent;
            this.pb_cancelCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_cancelCall.Image = global::MalteserSmartHome.Properties.Resources.AuflegenIMG;
            this.pb_cancelCall.Location = new System.Drawing.Point(495, 229);
            this.pb_cancelCall.Name = "pb_cancelCall";
            this.pb_cancelCall.Size = new System.Drawing.Size(100, 50);
            this.pb_cancelCall.TabIndex = 2;
            this.pb_cancelCall.TabStop = false;
            this.pb_cancelCall.Click += new System.EventHandler(this.cancelCall);
            // 
            // pb_Ambulance
            // 
            this.pb_Ambulance.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ambulance.BackgroundImage = global::MalteserSmartHome.Properties.Resources.Krankenwaagen;
            this.pb_Ambulance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Ambulance.Location = new System.Drawing.Point(272, 106);
            this.pb_Ambulance.Name = "pb_Ambulance";
            this.pb_Ambulance.Size = new System.Drawing.Size(267, 200);
            this.pb_Ambulance.TabIndex = 0;
            this.pb_Ambulance.TabStop = false;
            // 
            // EmergencyCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.pb_cancelCall);
            this.Controls.Add(this.lbl_Emergency);
            this.Controls.Add(this.pb_Ambulance);
            this.Name = "EmergencyCalling";
            this.Text = "EmergencyCalling";
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ambulance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ambulance;
        private System.Windows.Forms.Label lbl_Emergency;
        private System.Windows.Forms.PictureBox pb_cancelCall;
    }
}
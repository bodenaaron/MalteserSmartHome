namespace MalteserSmartHome
{
    partial class CareServiceCalling
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
            this.pb_careService = new System.Windows.Forms.PictureBox();
            this.lbl_careService = new System.Windows.Forms.Label();
            this.pb_cancelCall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_careService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelCall)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_careService
            // 
            this.pb_careService.BackColor = System.Drawing.Color.Transparent;
            this.pb_careService.BackgroundImage = global::MalteserSmartHome.Properties.Resources.Krankenschwester;
            this.pb_careService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_careService.Location = new System.Drawing.Point(212, 68);
            this.pb_careService.Name = "pb_careService";
            this.pb_careService.Size = new System.Drawing.Size(366, 284);
            this.pb_careService.TabIndex = 1;
            this.pb_careService.TabStop = false;
            // 
            // lbl_careService
            // 
            this.lbl_careService.AutoSize = true;
            this.lbl_careService.Location = new System.Drawing.Point(346, 29);
            this.lbl_careService.Name = "lbl_careService";
            this.lbl_careService.Size = new System.Drawing.Size(35, 13);
            this.lbl_careService.TabIndex = 2;
            this.lbl_careService.Text = "label1";
            // 
            // pb_cancelCall
            // 
            this.pb_cancelCall.BackColor = System.Drawing.Color.Transparent;
            this.pb_cancelCall.BackgroundImage = global::MalteserSmartHome.Properties.Resources.AuflegenKnopf;
            this.pb_cancelCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_cancelCall.Location = new System.Drawing.Point(281, 388);
            this.pb_cancelCall.Name = "pb_cancelCall";
            this.pb_cancelCall.Size = new System.Drawing.Size(100, 50);
            this.pb_cancelCall.TabIndex = 3;
            this.pb_cancelCall.TabStop = false;
            this.pb_cancelCall.Click += new System.EventHandler(this.cancelCall);
            // 
            // CareServiceCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_cancelCall);
            this.Controls.Add(this.lbl_careService);
            this.Controls.Add(this.pb_careService);
            this.Name = "CareServiceCalling";
            this.Text = "CareServiceCalling";
            ((System.ComponentModel.ISupportInitialize)(this.pb_careService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelCall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_careService;
        private System.Windows.Forms.Label lbl_careService;
        private System.Windows.Forms.PictureBox pb_cancelCall;
    }
}
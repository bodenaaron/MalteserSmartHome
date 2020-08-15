namespace MalteserSmartHome
{
    partial class ActionDoorClosed
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
            this.lbl_doorClosed = new System.Windows.Forms.Label();
            this.pb_doorClosed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_doorClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_doorClosed
            // 
            this.lbl_doorClosed.AutoSize = true;
            this.lbl_doorClosed.Location = new System.Drawing.Point(261, 373);
            this.lbl_doorClosed.Name = "lbl_doorClosed";
            this.lbl_doorClosed.Size = new System.Drawing.Size(35, 13);
            this.lbl_doorClosed.TabIndex = 0;
            this.lbl_doorClosed.Text = "label1";
            // 
            // pb_doorClosed
            // 
            this.pb_doorClosed.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausTuerZu1;
            this.pb_doorClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_doorClosed.Location = new System.Drawing.Point(228, -31);
            this.pb_doorClosed.Name = "pb_doorClosed";
            this.pb_doorClosed.Size = new System.Drawing.Size(352, 443);
            this.pb_doorClosed.TabIndex = 1;
            this.pb_doorClosed.TabStop = false;
            // 
            // ActionDoorClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_doorClosed);
            this.Controls.Add(this.lbl_doorClosed);
            this.Name = "ActionDoorClosed";
            this.Text = "ActionDoorClosed";
            ((System.ComponentModel.ISupportInitialize)(this.pb_doorClosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_doorClosed;
        private System.Windows.Forms.PictureBox pb_doorClosed;
    }
}
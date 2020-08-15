namespace MalteserSmartHome
{
    partial class ActionWindowClosed
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
            this.lbl_WindowClosed = new System.Windows.Forms.Label();
            this.pb_WindowClosed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_WindowClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_WindowClosed
            // 
            this.lbl_WindowClosed.AutoSize = true;
            this.lbl_WindowClosed.Location = new System.Drawing.Point(316, 255);
            this.lbl_WindowClosed.Name = "lbl_WindowClosed";
            this.lbl_WindowClosed.Size = new System.Drawing.Size(35, 13);
            this.lbl_WindowClosed.TabIndex = 0;
            this.lbl_WindowClosed.Text = "label1";
            // 
            // pb_WindowClosed
            // 
            this.pb_WindowClosed.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausFensterZu;
            this.pb_WindowClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_WindowClosed.Location = new System.Drawing.Point(350, 200);
            this.pb_WindowClosed.Name = "pb_WindowClosed";
            this.pb_WindowClosed.Size = new System.Drawing.Size(100, 50);
            this.pb_WindowClosed.TabIndex = 3;
            this.pb_WindowClosed.TabStop = false;
            // 
            // ActionWindowClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_WindowClosed);
            this.Controls.Add(this.lbl_WindowClosed);
            this.Name = "ActionWindowClosed";
            this.Text = "ActionWindowClosed";
            ((System.ComponentModel.ISupportInitialize)(this.pb_WindowClosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WindowClosed;
        private System.Windows.Forms.PictureBox pb_WindowClosed;
    }
}
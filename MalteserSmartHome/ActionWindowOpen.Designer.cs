namespace MalteserSmartHome
{
    partial class ActionWindowOpen
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
            this.lbl_WindowOpen = new System.Windows.Forms.Label();
            this.pb_WindowOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_WindowOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_WindowOpen
            // 
            this.lbl_WindowOpen.AutoSize = true;
            this.lbl_WindowOpen.Location = new System.Drawing.Point(383, 219);
            this.lbl_WindowOpen.Name = "lbl_WindowOpen";
            this.lbl_WindowOpen.Size = new System.Drawing.Size(35, 13);
            this.lbl_WindowOpen.TabIndex = 1;
            this.lbl_WindowOpen.Text = "label1";
            // 
            // pb_WindowOpen
            // 
            this.pb_WindowOpen.BackgroundImage = global::MalteserSmartHome.Properties.Resources.MalteserModellhausFensterAuf;
            this.pb_WindowOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_WindowOpen.Location = new System.Drawing.Point(0, 0);
            this.pb_WindowOpen.Name = "pb_WindowOpen";
            this.pb_WindowOpen.Size = new System.Drawing.Size(100, 50);
            this.pb_WindowOpen.TabIndex = 2;
            this.pb_WindowOpen.TabStop = false;
            // 
            // ActionWindowOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_WindowOpen);
            this.Controls.Add(this.lbl_WindowOpen);
            this.Name = "ActionWindowOpen";
            this.Text = "ActionWindowOpen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_WindowOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WindowOpen;
        private System.Windows.Forms.PictureBox pb_WindowOpen;
    }
}
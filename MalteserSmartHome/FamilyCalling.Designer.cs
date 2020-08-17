namespace MalteserSmartHome
{
    partial class FamilyCalling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyCalling));
            this.pb_hangUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hangUp
            // 
            this.pb_hangUp.BackColor = System.Drawing.Color.Transparent;
            this.pb_hangUp.BackgroundImage = global::MalteserSmartHome.Properties.Resources.AuflegenKnopf;
            this.pb_hangUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_hangUp.Location = new System.Drawing.Point(316, 344);
            this.pb_hangUp.Name = "pb_hangUp";
            this.pb_hangUp.Size = new System.Drawing.Size(151, 94);
            this.pb_hangUp.TabIndex = 0;
            this.pb_hangUp.TabStop = false;
            this.pb_hangUp.Click += new System.EventHandler(this.hangUp);
            // 
            // FamilyCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_hangUp);
            this.Name = "FamilyCalling";
            this.Text = "FamilyCalling";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hangUp;
    }
}
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
            this.pb_family = new System.Windows.Forms.PictureBox();
            this.pb_hangUp = new System.Windows.Forms.PictureBox();
            this.lbl_Family = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_family)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_family
            // 
            this.pb_family.BackColor = System.Drawing.Color.Transparent;
            this.pb_family.BackgroundImage = global::MalteserSmartHome.Properties.Resources.Familie;
            this.pb_family.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_family.Location = new System.Drawing.Point(262, 159);
            this.pb_family.Name = "pb_family";
            this.pb_family.Size = new System.Drawing.Size(100, 50);
            this.pb_family.TabIndex = 1;
            this.pb_family.TabStop = false;
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
            // lbl_Family
            // 
            this.lbl_Family.AutoSize = true;
            this.lbl_Family.Location = new System.Drawing.Point(283, 58);
            this.lbl_Family.Name = "lbl_Family";
            this.lbl_Family.Size = new System.Drawing.Size(35, 13);
            this.lbl_Family.TabIndex = 2;
            this.lbl_Family.Text = "label1";
            // 
            // FamilyCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Family);
            this.Controls.Add(this.pb_family);
            this.Controls.Add(this.pb_hangUp);
            this.Name = "FamilyCalling";
            this.Text = "FamilyCalling";
            ((System.ComponentModel.ISupportInitialize)(this.pb_family)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hangUp;
        private System.Windows.Forms.PictureBox pb_family;
        private System.Windows.Forms.Label lbl_Family;
    }
}
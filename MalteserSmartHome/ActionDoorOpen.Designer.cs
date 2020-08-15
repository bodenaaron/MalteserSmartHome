namespace MalteserSmartHome
{
    partial class ActionDoorOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionDoorOpen));
            this.lbl_doorOpened = new System.Windows.Forms.Label();
            this.pb_DoorOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DoorOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_doorOpened
            // 
            this.lbl_doorOpened.AutoSize = true;
            this.lbl_doorOpened.Location = new System.Drawing.Point(108, 419);
            this.lbl_doorOpened.Name = "lbl_doorOpened";
            this.lbl_doorOpened.Size = new System.Drawing.Size(65, 13);
            this.lbl_doorOpened.TabIndex = 1;
            this.lbl_doorOpened.Text = "Tür geöffnet";
            // 
            // pb_DoorOpen
            // 
            this.pb_DoorOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_DoorOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_DoorOpen.BackgroundImage")));
            this.pb_DoorOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_DoorOpen.Location = new System.Drawing.Point(185, 34);
            this.pb_DoorOpen.Name = "pb_DoorOpen";
            this.pb_DoorOpen.Size = new System.Drawing.Size(394, 294);
            this.pb_DoorOpen.TabIndex = 2;
            this.pb_DoorOpen.TabStop = false;
            // 
            // ActionDoorOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_DoorOpen);
            this.Controls.Add(this.lbl_doorOpened);
            this.Name = "ActionDoorOpen";
            this.Text = "ActionDoorOpen";
            this.Load += new System.EventHandler(this.ActionDoorOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_DoorOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_doorOpened;
        private System.Windows.Forms.PictureBox pb_DoorOpen;
    }
}
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
            this.btn_cancelFamilyCalling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancelFamilyCalling
            // 
            this.btn_cancelFamilyCalling.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelFamilyCalling.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelFamilyCalling.Image")));
            this.btn_cancelFamilyCalling.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelFamilyCalling.Location = new System.Drawing.Point(361, 318);
            this.btn_cancelFamilyCalling.Name = "btn_cancelFamilyCalling";
            this.btn_cancelFamilyCalling.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelFamilyCalling.TabIndex = 0;
            this.btn_cancelFamilyCalling.UseVisualStyleBackColor = true;
            this.btn_cancelFamilyCalling.Click += new System.EventHandler(this.btn_cancelFamilyCalling_Click);
            // 
            // FamilyCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelFamilyCalling);
            this.Name = "FamilyCalling";
            this.Text = "FamilyCalling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelFamilyCalling;
    }
}
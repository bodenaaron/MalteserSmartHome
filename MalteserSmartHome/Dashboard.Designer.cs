namespace MalteserSmartHome
{
    partial class Dashboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Dashboard = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_notruf = new System.Windows.Forms.Button();
            this.btn_familie = new System.Windows.Forms.Button();
            this.btn_pflegedienst = new System.Windows.Forms.Button();
            this.btn_LichterAn = new System.Windows.Forms.Button();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.btn_tabWechsel_seite_2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Tab_Dashboard);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 464);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Dashboard
            // 
            this.Tab_Dashboard.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_Dashboard.Controls.Add(this.btn_tabWechsel_seite_2);
            this.Tab_Dashboard.Controls.Add(this.pb_status);
            this.Tab_Dashboard.Controls.Add(this.btn_LichterAn);
            this.Tab_Dashboard.Controls.Add(this.btn_pflegedienst);
            this.Tab_Dashboard.Controls.Add(this.btn_familie);
            this.Tab_Dashboard.Controls.Add(this.btn_notruf);
            this.Tab_Dashboard.Location = new System.Drawing.Point(4, 5);
            this.Tab_Dashboard.Name = "Tab_Dashboard";
            this.Tab_Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Dashboard.Size = new System.Drawing.Size(776, 455);
            this.Tab_Dashboard.TabIndex = 0;            
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_notruf
            // 
            this.btn_notruf.Location = new System.Drawing.Point(0, 0);
            this.btn_notruf.Name = "btn_notruf";
            this.btn_notruf.Size = new System.Drawing.Size(298, 115);
            this.btn_notruf.TabIndex = 0;
            this.btn_notruf.Text = "Notruf";
            this.btn_notruf.UseVisualStyleBackColor = true;
            // 
            // btn_familie
            // 
            this.btn_familie.Location = new System.Drawing.Point(0, 115);
            this.btn_familie.Name = "btn_familie";
            this.btn_familie.Size = new System.Drawing.Size(298, 115);
            this.btn_familie.TabIndex = 1;
            this.btn_familie.Text = "Familie Kontaktieren";
            this.btn_familie.UseVisualStyleBackColor = true;
            // 
            // btn_pflegedienst
            // 
            this.btn_pflegedienst.Location = new System.Drawing.Point(0, 230);
            this.btn_pflegedienst.Name = "btn_pflegedienst";
            this.btn_pflegedienst.Size = new System.Drawing.Size(298, 115);
            this.btn_pflegedienst.TabIndex = 2;
            this.btn_pflegedienst.Text = "Pflegedienst Rufen";
            this.btn_pflegedienst.UseVisualStyleBackColor = true;
            // 
            // btn_LichterAn
            // 
            this.btn_LichterAn.Location = new System.Drawing.Point(0, 345);
            this.btn_LichterAn.Name = "btn_LichterAn";
            this.btn_LichterAn.Size = new System.Drawing.Size(298, 115);
            this.btn_LichterAn.TabIndex = 3;
            this.btn_LichterAn.Text = "Alle Lichter an";
            this.btn_LichterAn.UseVisualStyleBackColor = true;
            // 
            // pb_status
            // 
            this.pb_status.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_status.ErrorImage")));
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_status.InitialImage")));
            this.pb_status.Location = new System.Drawing.Point(304, 2);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(319, 449);
            this.pb_status.TabIndex = 4;
            this.pb_status.TabStop = false;
            this.pb_status.WaitOnLoad = true;
            // 
            // btn_tabWechsel_seite_2
            // 
            this.btn_tabWechsel_seite_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_tabWechsel_seite_2.Location = new System.Drawing.Point(623, 3);
            this.btn_tabWechsel_seite_2.Name = "btn_tabWechsel_seite_2";
            this.btn_tabWechsel_seite_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_tabWechsel_seite_2.Size = new System.Drawing.Size(150, 449);
            this.btn_tabWechsel_seite_2.TabIndex = 5;
            this.btn_tabWechsel_seite_2.Text = "⟹";
            this.btn_tabWechsel_seite_2.UseVisualStyleBackColor = true;            
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 464);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Tab_Dashboard;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_LichterAn;
        private System.Windows.Forms.Button btn_pflegedienst;
        private System.Windows.Forms.Button btn_familie;
        private System.Windows.Forms.Button btn_notruf;
        private System.Windows.Forms.Button btn_tabWechsel_seite_2;
        private System.Windows.Forms.PictureBox pb_status;
    }
}


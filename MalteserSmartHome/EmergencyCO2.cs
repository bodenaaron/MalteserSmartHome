using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalteserSmartHome
{
    public partial class EmergencyCO2 : Form
    {
        System.Windows.Forms.Timer t = null;        
        public void Wait()
        {
            t = new System.Windows.Forms.Timer
            {
                Interval = 20000
            };
            t.Tick += new EventHandler(kill);
            t.Enabled = true;
        }
        private void kill(object sender, EventArgs e)
        {
            t.Enabled = false;            
            Close();
        }
        public EmergencyCO2()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            //this.MaximumSize = new Size(800, 480);
            //this.MinimumSize = new Size(800, 480);
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();
            Wait();
        }

        private void InitializeCustomComponents()
        {
            pb_COAlarfm.Location = new Point(280,20);
            pb_COAlarfm.Size = new Size(250,250);

            lbl_coAlarm.Location = new Point(250,280);
            lbl_coAlarm.Text = "CO ALARM";
            lbl_coAlarm.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            btn_CO_nothing.Location = new Point(50, 360);
            btn_CO_nothing.Width = 200;
            btn_CO_nothing.Height = 100;
            btn_CO_nothing.Text = "Falscher Alarm";
            btn_CO_nothing.BackColor = Color.Red;
            btn_CO_nothing.FlatStyle = FlatStyle.Flat;
            btn_CO_nothing.FlatAppearance.BorderSize = 2;
            btn_CO_nothing.FlatAppearance.BorderColor = Color.Black;
            btn_CO_nothing.ForeColor = Color.White;
            btn_CO_nothing.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_CO_Family.Location = new Point(300, 360);
            btn_CO_Family.Width = 200;
            btn_CO_Family.Height = 100;
            btn_CO_Family.Text = "Familie Anrufen";
            btn_CO_Family.BackColor = Color.Red;
            btn_CO_Family.FlatStyle = FlatStyle.Flat;
            btn_CO_Family.FlatAppearance.BorderSize = 2;
            btn_CO_Family.FlatAppearance.BorderColor = Color.Black;
            btn_CO_Family.ForeColor = Color.White;
            btn_CO_Family.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_CO_emergency.Location = new Point(550, 360);
            btn_CO_emergency.Width = 200;
            btn_CO_emergency.Height = 100;
            btn_CO_emergency.Text = "Rettungsdienst";
            btn_CO_emergency.BackColor = Color.Red;
            btn_CO_emergency.FlatStyle = FlatStyle.Flat;
            btn_CO_emergency.FlatAppearance.BorderSize = 2;
            btn_CO_emergency.FlatAppearance.BorderColor = Color.Black;
            btn_CO_emergency.ForeColor = Color.White;
            btn_CO_emergency.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
    }
}

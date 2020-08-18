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
    public partial class EmergencyWater : Form
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
        public EmergencyWater()
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
            btn_EmergencyWater_falseAlarm.Location = new Point(50, 360);
            btn_EmergencyWater_falseAlarm.Width = 200;
            btn_EmergencyWater_falseAlarm.Height = 100;
            btn_EmergencyWater_falseAlarm.Text = "Falscher Alarm";
            btn_EmergencyWater_falseAlarm.BackColor = Color.Blue;
            btn_EmergencyWater_falseAlarm.FlatStyle = FlatStyle.Flat;
            btn_EmergencyWater_falseAlarm.FlatAppearance.BorderSize = 2;
            btn_EmergencyWater_falseAlarm.FlatAppearance.BorderColor = Color.Black;
            btn_EmergencyWater_falseAlarm.ForeColor = Color.White;
            btn_EmergencyWater_falseAlarm.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_EmergencyWater_callFamily.Location = new Point(550, 360);
            btn_EmergencyWater_callFamily.Width = 200;
            btn_EmergencyWater_callFamily.Height = 100;
            btn_EmergencyWater_callFamily.Text = "Familie anrufen";
            btn_EmergencyWater_callFamily.BackColor = Color.Blue;
            btn_EmergencyWater_callFamily.FlatStyle = FlatStyle.Flat;
            btn_EmergencyWater_callFamily.FlatAppearance.BorderSize = 2;
            btn_EmergencyWater_callFamily.FlatAppearance.BorderColor = Color.Black;
            btn_EmergencyWater_callFamily.ForeColor = Color.White;
            btn_EmergencyWater_callFamily.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lbl_EmegencyWater.Text = "Wasser festgestellt";
            lbl_EmegencyWater.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_EmegencyWater.Location = new Point(150, 250);
            lbl_EmegencyWater.BackColor = Color.Transparent;

        }

        private void btn_EmergencyWater_falseAlarm_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btn_EmergencyWater_callFamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            FamilyCalling fc = new FamilyCalling();
            fc.Show();
        }
    }
}

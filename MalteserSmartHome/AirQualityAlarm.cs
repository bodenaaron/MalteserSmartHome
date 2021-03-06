﻿using System;
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
    public partial class AirQualityAlarm : Form
    {              
        System.Windows.Forms.Timer t = null;
        public void Wait()
        {
            t = new System.Windows.Forms.Timer
            {
                Interval = 5000
            };
            t.Tick += new EventHandler(kill);
            t.Enabled = true;
        }

        private void kill(object sender, EventArgs e)
        {
            t.Enabled = false;            
            Close();
        }
        public AirQualityAlarm()
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

            lbl_AirQuality.Location = new Point(250, 400);
            lbl_AirQuality.Text = "Bitte lüften";
            lbl_AirQuality.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_AirQualityOpenWindow.Size = new Size(300, 400);
            pb_AirQualityOpenWindow.Location = new Point(250, 0);
        }


    }
}

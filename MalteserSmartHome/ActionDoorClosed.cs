﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalteserSmartHome
{
    public partial class ActionDoorClosed : Form
    {
        private MainWindow mainWindow { get; set; }
        System.Windows.Forms.Timer t = null;
        public void Wait()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 5000;
            t.Tick += new EventHandler(kill);
            t.Enabled = true;
        }

        private void kill(object sender, EventArgs e)
        {
            t.Enabled = false;
            mainWindow.Show();
            Hide();
        }
        public ActionDoorClosed(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();            
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            

        }

        private void InitializeCustomComponents()
        {
            lbl_doorClosed.Location = new Point(250, 400);
            lbl_doorClosed.Text = "Tür geschlossen";
            lbl_doorClosed.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_doorClosed.Size = new Size(300, 400);
            pb_doorClosed.Location = new Point(250, 0);

        }

        public void Wait(int wait)
        {
            Thread.Sleep(wait);
        }
    }
}

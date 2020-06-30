﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalteserSmartHome
{
    public partial class EmergencyFire : Form
    {
        MainWindow mainWindow;
        public EmergencyFire(MainWindow mainWindow)
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 460);
            this.MinimumSize = new Size(800, 460);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.mainWindow = mainWindow;
        }

        private void InitializeCustomComponents()
        {
            btn_EmergencyFire_falseAlarm.Location = new Point(50, 360);
            btn_EmergencyFire_falseAlarm.Width = 200;
            btn_EmergencyFire_falseAlarm.Height = 100;
            btn_EmergencyFire_falseAlarm.Text = "Falscher Alarm";
            btn_EmergencyFire_falseAlarm.BackColor = Color.Red;
            btn_EmergencyFire_falseAlarm.FlatStyle = FlatStyle.Flat;
            btn_EmergencyFire_falseAlarm.FlatAppearance.BorderSize = 2;
            btn_EmergencyFire_falseAlarm.FlatAppearance.BorderColor = Color.Black;
            btn_EmergencyFire_falseAlarm.ForeColor = Color.White;
            btn_EmergencyFire_falseAlarm.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_EmergencyFire_callFamily.Location = new Point(300, 360);
            btn_EmergencyFire_callFamily.Width = 200;
            btn_EmergencyFire_callFamily.Height = 100;
            btn_EmergencyFire_callFamily.Text = "Familie Anrufen";
            btn_EmergencyFire_callFamily.BackColor = Color.Red;
            btn_EmergencyFire_callFamily.FlatStyle = FlatStyle.Flat;
            btn_EmergencyFire_callFamily.FlatAppearance.BorderSize = 2;
            btn_EmergencyFire_callFamily.FlatAppearance.BorderColor = Color.Black;
            btn_EmergencyFire_callFamily.ForeColor = Color.White;
            btn_EmergencyFire_callFamily.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_EmergencyFire_callEmergencyService.Location = new Point(550, 360);
            btn_EmergencyFire_callEmergencyService.Width = 200;
            btn_EmergencyFire_callEmergencyService.Height = 100;
            btn_EmergencyFire_callEmergencyService.Text = "Rettungsdienst";
            btn_EmergencyFire_callEmergencyService.BackColor = Color.Red;
            btn_EmergencyFire_callEmergencyService.FlatStyle = FlatStyle.Flat;
            btn_EmergencyFire_callEmergencyService.FlatAppearance.BorderSize = 2;
            btn_EmergencyFire_callEmergencyService.FlatAppearance.BorderColor = Color.Black;
            btn_EmergencyFire_callEmergencyService.ForeColor = Color.White;
            btn_EmergencyFire_callEmergencyService.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lbl_FireAlarm.Text = "Feueralarm Ausgelöst";
            lbl_FireAlarm.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_FireAlarm.Location = new Point(100, 250);
            lbl_FireAlarm.BackColor = Color.Transparent;

        }

        private void btn_EmergencyFire_falseAlarm_Click(object sender, EventArgs e)
        {
            Hide();
            mainWindow.Show();
            Close();
        }

        private void btn_EmergencyFire_callFamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            FamilyCalling fc = new FamilyCalling(mainWindow);
            fc.Show();
        }

        private void btn_EmergencyFire_callEmergencyService_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyCalling ec = new EmergencyCalling(mainWindow);
            ec.Show();
        }
    }
}
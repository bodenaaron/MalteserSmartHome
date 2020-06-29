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
    public partial class FamilyCalling : Form
    {
        MainWindow mainWindow;
        public FamilyCalling(MainWindow mainWindow)
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
            btn_cancelFamilyCalling.Location = new Point(200, 360);
            btn_cancelFamilyCalling.Width = 400;
            btn_cancelFamilyCalling.Height = 120;            
            btn_cancelFamilyCalling.Font = new System.Drawing.Font("Microsoft Tai Le", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_cancelFamilyCalling.ForeColor = Color.Red;
            btn_cancelFamilyCalling.BackColor = Color.White;
            
        }

        private void btn_cancelFamilyCalling_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}

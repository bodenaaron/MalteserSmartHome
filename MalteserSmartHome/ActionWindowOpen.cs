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
    public partial class ActionWindowOpen : Form
    {
        public ActionWindowOpen()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 460);
            this.MinimumSize = new Size(800, 460);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void InitializeCustomComponents()
        {
            lbl_WindowOpen.Location = new Point(250, 400);
            lbl_WindowOpen.Text = "Bitte lüften";
            lbl_WindowOpen.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_WindowOpen.Size = new Size(300, 400);
            pb_WindowOpen.Location = new Point(250, 0);
        }
    }
}

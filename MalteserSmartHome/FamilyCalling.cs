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
    public partial class FamilyCalling : Form
    {
        MainWindow mainWindow;
        public FamilyCalling(MainWindow mainWindow)
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            //this.MaximumSize = new Size(800, 480);
            //this.MinimumSize = new Size(800, 480);
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.mainWindow = mainWindow;
        }

        private void InitializeCustomComponents()
        {
            lbl_Family.Text = "Familie";
            lbl_Family.Location = new Point(300,50);
            lbl_Family.Font= new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_hangUp.Location = new Point(330, 320);
            pb_hangUp.Width = 170;
            pb_hangUp.Height = 170;

            pb_family.Location = new Point(200, 100);
            pb_family.Width = 400;
            pb_family.Height = 200;
            
        }

        private void hangUp(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}

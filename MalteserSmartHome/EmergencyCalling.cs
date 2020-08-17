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
    public partial class EmergencyCalling : Form
    {
        MainWindow mainWindow;
        public EmergencyCalling(MainWindow mainWindow)
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
            Cursor.Hide();
        }

        private void InitializeCustomComponents()
        {
            lbl_Emergency.Text="Rettungsdienst";
            lbl_Emergency.Location = new Point(250,50);
            lbl_Emergency.Font= new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_Ambulance.Location = new Point(200,100);
            pb_Ambulance.Width = 400;
            pb_Ambulance.Height = 300;

            pb_cancelCall.Location = new Point(330, 320);
            pb_cancelCall.Width = 170;
            pb_cancelCall.Height = 170;
        }
        
        private void cancelCall(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}

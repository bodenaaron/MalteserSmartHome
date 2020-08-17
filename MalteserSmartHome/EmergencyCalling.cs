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
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.mainWindow = mainWindow;
        }

        private void InitializeCustomComponents()
        {
            btn_cancelEmergencyCall.Location = new Point(200,360);
            btn_cancelEmergencyCall.Width = 400;
            btn_cancelEmergencyCall.Height = 100;
        }

        private void btn_cancelEmergencyCall_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}

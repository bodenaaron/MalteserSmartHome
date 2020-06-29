using System;
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

            btn_EmergencyFire_callFamily.Location = new Point(300, 360);
            btn_EmergencyFire_callFamily.Width = 200;
            btn_EmergencyFire_callFamily.Height = 100;
            btn_EmergencyFire_callFamily.Text = "Familie Anrufen";

            btn_EmergencyFire_callEmergencyService.Location = new Point(550, 360);
            btn_EmergencyFire_callEmergencyService.Width = 200;
            btn_EmergencyFire_callEmergencyService.Height = 100;
            btn_EmergencyFire_callEmergencyService.Text = "Rettungsdienst";
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

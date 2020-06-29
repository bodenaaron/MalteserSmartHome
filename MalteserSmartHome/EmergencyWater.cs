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
        MainWindow mainWindow;
        public EmergencyWater(MainWindow mainWindow)
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
            btn_EmergencyWater_falseAlarm.Location = new Point(50, 360);
            btn_EmergencyWater_falseAlarm.Width = 200;
            btn_EmergencyWater_falseAlarm.Height = 100;
            btn_EmergencyWater_falseAlarm.Text = "Falscher Alarm";

            btn_EmergencyWater_callFamily.Location = new Point(550, 360);
            btn_EmergencyWater_callFamily.Width = 200;
            btn_EmergencyWater_callFamily.Height = 100;
            btn_EmergencyWater_callFamily.Text = "Familie anrufen";
        }

        private void btn_EmergencyWater_falseAlarm_Click(object sender, EventArgs e)
        {
            Hide();
            mainWindow.Show();
            Close();
        }

        private void btn_EmergencyWater_callFamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            FamilyCalling fc = new FamilyCalling(mainWindow);
            fc.Show();
        }
    }
}

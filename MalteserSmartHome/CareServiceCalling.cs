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
    public partial class CareServiceCalling : Form
    {
        MainWindow mainWindow;
        public CareServiceCalling(MainWindow mainWindow)
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
            btn_cancelCareCalling.Location = new Point(200, 360);
            btn_cancelCareCalling.Width = 400;
            btn_cancelCareCalling.Height = 100;
        }

        private void btn_cancelCareCalling_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}

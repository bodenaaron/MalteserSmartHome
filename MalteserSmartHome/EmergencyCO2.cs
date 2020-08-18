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
    public partial class EmergencyCO2 : Form
    {
        System.Windows.Forms.Timer t = null;        
        public void Wait()
        {
            t = new System.Windows.Forms.Timer
            {
                Interval = 5000
            };
            t.Tick += new EventHandler(kill);
            t.Enabled = true;
        }
        private void kill(object sender, EventArgs e)
        {
            t.Enabled = false;            
            Close();
        }
        public EmergencyCO2()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            //this.MaximumSize = new Size(800, 480);
            //this.MinimumSize = new Size(800, 480);
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();

        }

        private void InitializeCustomComponents()
        {

        }
    }
}

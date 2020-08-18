using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalteserSmartHome
{
    public partial class ActionDoorOpen : Form
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
        public ActionDoorOpen()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();
            Wait();
        }

        private void InitializeCustomComponents()
        {            
            lbl_doorOpened.Location = new Point(270, 400);
            lbl_doorOpened.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_DoorOpen.Location = new Point(200, 50);
        }

        private void ActionDoorOpen_Load(object sender, EventArgs e)
        {

        }
        

    }
}

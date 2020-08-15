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
        public ActionDoorOpen()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            MaximumSize = new Size(800, 460);
            MinimumSize = new Size(800, 460);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
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

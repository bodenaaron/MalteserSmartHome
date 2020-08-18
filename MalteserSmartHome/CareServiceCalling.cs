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
        public CareServiceCalling()
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

            lbl_careService.Text = "Pflegedienst";
            lbl_careService.Font= new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_careService.Location = new Point(250, 50);

            pb_careService.Size = new Size(400, 300);
            pb_careService.Location = new Point(220, 100);

            pb_cancelCall.Location = new Point(330, 320);
            pb_cancelCall.Width = 170;
            pb_cancelCall.Height = 170;
        }

        private void btn_cancelCareCalling_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelCall(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}

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
    public partial class ActionWindowClosed : Form
    {
        public ActionWindowClosed()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 460);
            this.MinimumSize = new Size(800, 460);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void InitializeCustomComponents()
        {
            lbl_WindowClosed.Text = "Fenster geschlossen";
            lbl_WindowClosed.Location = new Point(250, 400);
            lbl_WindowClosed.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            pb_WindowClosed.Size = new Size(300, 400);
            pb_WindowClosed.Location = new Point(250, 0);
        }
    }
}

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
        public EmergencyCO2()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void InitializeCustomComponents()
        {

        }
    }
}

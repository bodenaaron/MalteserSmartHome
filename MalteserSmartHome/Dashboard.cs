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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);
            btn_tabWechsel_seite_2.Font = new Font("Microsoft Sans Serif", 70, FontStyle.Bold);
            btn_tabWechsel_seite_2.TextAlign = ContentAlignment.MiddleRight;
            btn_notruf.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Bold);
            btn_familie.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btn_pflegedienst.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btn_LichterAn.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btn_notruf.BackColor = Color.Red;
            btn_familie.BackColor = Color.Green;
            btn_pflegedienst.BackColor = Color.Blue;
            btn_LichterAn.BackColor = Color.Orange;
            //button5.BackColor = Color.Brown;
            btn_notruf.ForeColor = Color.White;
            btn_familie.ForeColor = Color.White;
            btn_pflegedienst.ForeColor = Color.White;
            btn_LichterAn.ForeColor = Color.White;
            //button5.ForeColor = Color.White;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalteserSmartHome
{
    public partial class PrintSerialPorts : Form
    {
        public PrintSerialPorts()
        {
            InitializeComponent();
            
            
        }

        public void printerror(string s)
        {
            richTextBox1.Text= richTextBox1.Text + Environment.NewLine + s;
        }

        public void ports()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine + s;
            }
        }
    }
}

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
    public partial class MainWindow : Form
    {        
        private int visibleStatus = 0;
        System.Windows.Forms.Timer t = null;
        SerialPort serialPort1;

        public MainWindow()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            this.MaximumSize = new Size(800, 460);
            this.MinimumSize = new Size(800, 460);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            startTimer();

        }

        private void readSerialData(object sender, EventArgs e)
        {

        }

        private void startTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(updateTimeAndDate);
            t.Tick += new EventHandler(readSerialData);
            t.Enabled = true;
        }

        private void updateTimeAndDate(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("dddd dd.MM.yyyy");
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void InitializeCustomComponents()
        {            
            Thread readThread = new Thread(read);
            serialPort1 = new SerialPort();
            serialPort1.PortName = "asd";
            serialPort1.BaudRate = 1;
            //todo:auskommentieren serialPort1.Open();
            readThread.Start();

            //Knopf initialisierung
            btn_emergency.Location = new Point(0,0);
            btn_emergency.Width = 400;
            btn_emergency.Height = 100;

            btn_settings.Location = new Point(400, 0);
            btn_settings.Width = 400;
            btn_settings.Height = 100;

            btn_care.Location = new Point(0, 360);
            btn_care.Width = 400;
            btn_care.Height = 100;

            btn_family.Location = new Point(400, 360);
            btn_family.Width = 400;
            btn_family.Height = 100;

            btn_arrow_left.Location = new Point(0, 100);
            btn_arrow_left.Width = 100;
            btn_arrow_left.Height = 260;

            btn_arrow_right.Location = new Point(700, 100);
            btn_arrow_right.Width = 100;
            btn_arrow_right.Height = 260;

            gb_datetime.Location = new Point(100, 100);
            gb_datetime.Width = 600;
            gb_datetime.Height = 260;
            

            gb_air.Location = new Point(100, 100);
            gb_air.Width = 600;
            gb_air.Height = 260;
            gb_air.Visible = false;

            gb_security.Location = new Point(100, 100);
            gb_security.Width = 600;
            gb_security.Height = 260;
            gb_security.Visible = false;

        }

        private void btn_emergency_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyCalling ec = new EmergencyCalling(this);
            ec.Show();            

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            visibleStatus = 3;
            selectStatus();
        }

        private void btn_arrow_left_Click(object sender, EventArgs e)
        {
            if (visibleStatus == 0)
            {
                visibleStatus = 3;
            }
            else
            {
                visibleStatus = visibleStatus - 1;
            }
            selectStatus();
        }

        private void btn_arrow_right_Click(object sender, EventArgs e)
        {
            if (visibleStatus == 3)
            {
                visibleStatus = 0;
            }
            else
            {
                visibleStatus = visibleStatus + 1;
            }
            selectStatus();
        }

        private void btn_care_Click(object sender, EventArgs e)
        {
            this.Hide();
            CareServiceCalling careServiceCalling = new CareServiceCalling(this);
            careServiceCalling.Show();
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            this.Hide();
            FamilyCalling familyCalling = new FamilyCalling(this);
            familyCalling.Show();
        }

        private void selectStatus()
        {
            gb_datetime.Visible = false;
            gb_air.Visible = false;
            gb_security.Visible = false;
            gb_settings.Visible = false;

            switch (visibleStatus) 
            {
                case 0:
                    gb_datetime.Visible = true;                    
                    break;
                case 1:
                    gb_air.Visible = true;
                    break;
                case 2:
                    gb_security.Visible = true;
                    break;
                case 3:
                    gb_settings.Visible = true;
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void read()
        {
            //todo:auskommentieren string serialBuffer = serialPort1.ReadExisting();

            //todo:Daten aus Seriellem Buffer auswerten
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyFire ef = new EmergencyFire(this);
            ef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyWater ew = new EmergencyWater(this);
            ew.Show();
        }
    }
}

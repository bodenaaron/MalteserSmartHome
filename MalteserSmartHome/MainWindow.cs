
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
        public SerialPort port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
        public bool WindowOpen
        {
            get { return windowOpen; }
            set
            {
                windowOpen = value;

                if (value == true)
                {
                    //this.Hide();
                    ActionWindowOpen wo = new ActionWindowOpen();
                    wo.ShowDialog();
                    wo.Wait();
                    lbl_window.Text = "Fenster offen";
                }
                else
                {
                    //Hide();
                    ActionWindowClosed wc = new ActionWindowClosed();
                    wc.ShowDialog();
                    wc.Wait();
                    lbl_window.Text = "Fenster geschlossen";
                }
            }
        }
        private bool windowOpen;

        public bool DoorOpen
        {
            get { return doorOpen; }
            set
            {
                doorOpen = value;

                if (value==true)
                {
                    //this.Hide();
                    ActionDoorOpen doo = new ActionDoorOpen();
                    doo.ShowDialog();
                    doo.Wait();
                    lbl_doors.Text = "Tür offen";
                }
                else
                {
                    //Hide();
                    ActionDoorClosed dc = new ActionDoorClosed();
                    dc.ShowDialog();
                    dc.Wait();
                    lbl_doors.Text = "Tür geschlossen";
                }
            }
        }
        private bool doorOpen;

        public double CO2
        {
            get { return co2; }
            set
            {
                co2 = value;
                if (value>50)
                {
                    //this.Hide();
                    EmergencyCO2 co2 = new EmergencyCO2();
                    co2.ShowDialog();
                    co2.Wait();
                    Show();
                }
            }
        }
        private double co2;

        private int visibleStatus = 0;
        System.Windows.Forms.Timer t = null;        
        

        public MainWindow()
        {
            InitializeComponent();
            InitializeCustomComponents();
            //Fenstergröße an Pi Display anpassen
            ////this.MaximumSize = new Size(800, 480);
            ////this.MinimumSize = new Size(800, 480);
            this.TopMost = true;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;            
            startTimer();
            Cursor.Hide();
            this.Cursor = Cursors.No;
            Cursor.Dispose();

            port.DataReceived += new SerialDataReceivedEventHandler(evaluate_Data);
            port.Open();
            port.ReadTimeout = 500;
            port.WriteTimeout = 500;


        }

        private void evaluate_Data(object sender, SerialDataReceivedEventArgs e)
        {
            string message = port.ReadExisting();
            
            foreach (char c in message)
            {
                switch (c)
                {
                    case '1':   //Tür auf
                        DoorOpen = true;
                        break;
                    case '2':   //Tür zu
                        DoorOpen = false;
                        break;
                    case '3':   //Fenster auf
                        WindowOpen = true;
                        break;
                    case '4':   //Fenster zu
                        WindowOpen = false;
                        break;
                    case '5':   //Feuer
                        EmergencyFire ef = new EmergencyFire();                        
                        ef.ShowDialog();
                        break;
                    case '6':   //Wasser 
                        EmergencyWater ew = new EmergencyWater();
                        ew.ShowDialog();
                        break;
                    case '7':   //CO2
                        CO2 = 51;
                        break;
                    default:
                        break;
                }
            }
           
        }        
        

        private void startTimer()
        {
            t = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            t.Tick += new EventHandler(updateTimeAndDate);           
            t.Enabled = true;
        }

        private void updateTimeAndDate(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("dddd dd.MM.yyyy");
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void InitializeCustomComponents()
        {                                   
            //Knopf initialisierung
            btn_emergency.Location = new Point(0,0);
            btn_emergency.Width = 400;
            btn_emergency.Height = 100;
            btn_emergency.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_settings.Location = new Point(400, 0);
            btn_settings.Width = 400;
            btn_settings.Height = 100;
            btn_settings.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_care.Location = new Point(0, 380);
            btn_care.Width = 400;
            btn_care.Height = 100;
            btn_care.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btn_family.Location = new Point(400, 380);
            btn_family.Width = 400;
            btn_family.Height = 100;
            btn_family.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lbl_temperatur.Location = new Point(0, 50);
            lbl_temperatur.Text = "Temperatur: 21°C";
            lbl_humidity.Location = new Point(0, 150);
            lbl_humidity.Text = "Luftfeuchtigkeit: 40%";

            btn_arrow_left.Location = new Point(0, 100);
            btn_arrow_left.Width = 100;
            btn_arrow_left.Height = 260;
            btn_arrow_left.FlatStyle = FlatStyle.Flat;
            btn_arrow_left.FlatAppearance.BorderSize = 0;
            //btn_arrow_left.FlatAppearance.BorderColor = Color.Transparent;

            btn_arrow_right.Location = new Point(700, 100);
            btn_arrow_right.Width = 100;
            btn_arrow_right.Height = 260;
            btn_arrow_right.FlatStyle = FlatStyle.Flat;
            btn_arrow_right.FlatAppearance.BorderSize = 0;
            //btn_arrow_right.FlatAppearance.BorderColor = Color.Transparent;

            pnl_dateTime.Location = new Point(100, 100);
            pnl_dateTime.Width = 600;
            pnl_dateTime.Height = 260;
            lbl_time.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_time.Location = new Point(150, 50);
            lbl_date.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_date.Location = new Point(100, 150);
            
            pnl_air.Location = new Point(100, 100);
            pnl_air.Width = 600;
            pnl_air.Height = 260;
            pnl_air.Visible = false;
            pnl_air.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lbl_temperatur.Location = new Point(0,50);
            lbl_temperatur.Text = "Temperatur: 21°C";
            lbl_humidity.Location = new Point(0, 150);
            lbl_humidity.Text = "Luftfeuchtigkeit: 40%";

            pnl_security.Location = new Point(100, 100);
            pnl_security.Width = 600;
            pnl_security.Height = 260;
            pnl_security.Visible = false;
            pnl_security.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lbl_window.Location = new Point(0, 50);
            lbl_window.Text = "Fenster geschlossen";
            lbl_doors.Location = new Point(0, 150);
            lbl_doors.Text = "Türen geschlossen";

            pnl_dev.Location = new Point(100, 100);
            pnl_dev.Width = 600;
            pnl_dev.Height = 260;
            pnl_dev.Visible = false;

            pnl_settings.Location = new Point(100, 95);
            pnl_settings.Width = 600;
            pnl_settings.Height = 260;
            pnl_settings.Visible = false;

        }

        private void btn_emergency_Click(object sender, EventArgs e)
        {
            //this.Hide();
            EmergencyCalling ec = new EmergencyCalling();
            ec.ShowDialog();            

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
                visibleStatus -= 1;
            }
            selectStatus();
        }

        private void btn_arrow_right_Click(object sender, EventArgs e)
        {
            if (visibleStatus == 3 || visibleStatus >3)
            {
                visibleStatus = 0;
            }
            else
            {
                visibleStatus += 1;
            }
            selectStatus();
        }        

        private void btn_care_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CareServiceCalling careServiceCalling = new CareServiceCalling();
            careServiceCalling.ShowDialog();
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FamilyCalling familyCalling = new FamilyCalling();
            familyCalling.ShowDialog();
        }

        private void selectStatus()
        {
            pnl_dateTime.Visible = false;
            pnl_air.Visible = false;
            pnl_security.Visible = false;
            pnl_settings.Visible = false;
            pnl_dev.Visible = false;

            switch (visibleStatus) 
            {
                case 0:
                    pnl_dateTime.Visible = true;                    
                    break;
                case 1:
                    pnl_air.Visible = true;
                    break;
                case 2:
                    pnl_security.Visible = true;
                    break;
                case 3:
                    pnl_dev.Visible = true;
                    break;
                case 4:
                    pnl_settings.Visible = false;
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        

        private void btn_dev_FireAlarm_Click(object sender, EventArgs e)
        {           
            //this.Hide();
            EmergencyFire ef = new EmergencyFire();
            ef.ShowDialog();

        }

        private void btn_dev_WaterAlarm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            EmergencyWater ew = new EmergencyWater();
            ew.ShowDialog();
        }

        private void btn_dev_doorOpen_Click(object sender, EventArgs e)
        {
            DoorOpen = true;
        }

        private void btn_dev__doorClosed_Click(object sender, EventArgs e)
        {
            DoorOpen = false;
        }

        private void btn_dev_WindowOpen_Click(object sender, EventArgs e)
        {
            WindowOpen = true;
        }

        private void btn_dev_WindowClosed_Click(object sender, EventArgs e)
        {
            WindowOpen = false;
        }

        private void btn_dev_CO2Alarm_Click(object sender, EventArgs e)
        {
            CO2 = 51;
        }

        private void sendCommandLouder(object sender, EventArgs e)
        {

        }

        private void sendCommandQuieter(object sender, EventArgs e)
        {

        }
    }
}

using System.Management;
using Lithium___Battery_Saver.Resources.Class_Resources;
using Microsoft.Win32;

namespace Lithium___Battery_Saver
{
    public partial class Form1 : Form
    {
        SideBar sb;
        PowerMode pm;
        MinMaxBattery mmb;
        Notify nf;
        public Form1()
        {
            InitializeComponent();
            PowerStatus status = SystemInformation.PowerStatus;
            sb = new SideBar(status);
            pm = new PowerMode(powerefficiencybtn, balancedbtn, performancebtn);
            mmb = new MinMaxBattery();
            nf = new Notify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code to start application on startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Lithium Battery Saver", Application.ExecutablePath);
            
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer1.Interval = (10);
            timer1.Tick += new EventHandler(timer_Tick1!);
            timer1.Interval = (1000);
            timer1.Tick += new EventHandler(timer_Tick2!);
            timer1.Start();
            timer2.Start();
            minbatterybox.Text = mmb.getMinBattery().ToString();
            maxbatterybox.Text = mmb.getMaxBattery().ToString();
        }
        private void timer_Tick1(object sender, EventArgs e)
        {
            sb.powerPercentage(circularProgressBar1);
            sb.batteryLifeRemaining(blifelabel);
            sb.plugIn(bpluginlabel, pluggedinpicture);
            pm.changeColor(pm.getPowerMode());
            details();
        }
        private void timer_Tick2(object sender, EventArgs e)
        {
            PowerStatus status = SystemInformation.PowerStatus;
            int bper = sb.getbper();
            if (status.PowerLineStatus == PowerLineStatus.Offline)
            {
                if (bper <= mmb.getMinBattery())
                    nf.notifymsg(notify, "Battery Underflow", "Please Plug in your charger", new Bitmap(Properties.Resources.alertred));
            }
            if (status.PowerLineStatus == PowerLineStatus.Online)
            {
                if (bper >= mmb.getMaxBattery())
                    nf.notifymsg(notify, "Battery Overflow", "Please Unplug your charger", new Bitmap(Properties.Resources.alertgreen));
            }
        }
        public void details()
        {
            try
            {
                ObjectQuery? query = new ObjectQuery("SELECT * FROM Win32_Battery");
                ManagementObjectSearcher? searcher = new(query);
                ManagementObjectCollection? collection = searcher.Get();
                foreach (ManagementObject mo in collection)
                {
                    switch (Int32.Parse(mo["Availability"].ToString()!))
                    {
                        case 1:
                        case 2:
                            availabilitylabel.Text = "Unknown";
                            break;
                        case 3:
                            availabilitylabel.Text = "Running or Full Power";
                            break;
                        case 4:
                            availabilitylabel.Text = "Warning";
                            break;
                        case 5:
                            availabilitylabel.Text = "In Test";
                            break;
                        case 6:
                            availabilitylabel.Text = "Not Applicable";
                            break;
                        case 7:
                            availabilitylabel.Text = "Power Off";
                            break;
                        case 8:
                            availabilitylabel.Text = "Off Line";
                            break;
                        case 9:
                            availabilitylabel.Text = "Off Duty";
                            break;
                        case 10:
                            availabilitylabel.Text = "Degraded";
                            break;
                        case 11:
                            availabilitylabel.Text = "Not Installed";
                            break;
                        case 12:
                            availabilitylabel.Text = "Install Error";
                            break;
                        case 13:
                            availabilitylabel.Text = "Power Save - Unknown";
                            break;
                        case 14:
                            availabilitylabel.Text = "Power Save - Low Power";
                            break;
                        case 15:
                            availabilitylabel.Text = "Power Save - Standby";
                            break;
                        case 16:
                            availabilitylabel.Text = "Power Cycle";
                            break;
                        case 17:
                            availabilitylabel.Text = "Power Save - Warning";
                            break;
                        case 18:
                            availabilitylabel.Text = "Paused";
                            break;
                        case 19:
                            availabilitylabel.Text = "Not Ready";
                            break;
                        case 20:
                            availabilitylabel.Text = "Not Configured";
                            break;
                        case 21:
                            availabilitylabel.Text = "Quiesced";
                            break;
                        default:
                            availabilitylabel.Text = "-";
                            break;
                    }
                    switch (Int32.Parse(mo["BatteryStatus"].ToString()!))
                    {
                        case 1:
                            statuslabel.Text = "Discharging";
                            break;
                        case 2:
                            statuslabel.Text = "Unknown";
                            break;
                        case 3:
                            statuslabel.Text = "Fully Charged";
                            break;
                        case 4:
                            statuslabel.Text = "Low";
                            break;
                        case 5:
                            statuslabel.Text = "Critical";
                            break;
                        case 6:
                            statuslabel.Text = "Charging";
                            break;
                        case 7:
                            statuslabel.Text = "Charging and High";
                            break;
                        case 8:
                            statuslabel.Text = "Charging and Low";
                            break;
                        case 9:
                            statuslabel.Text = "Chraging and Critical";
                            break;
                        case 10:
                            statuslabel.Text = "Undefined";
                            break;
                        case 11:
                            statuslabel.Text = "Partially Charged";
                            break;
                        default:
                            statuslabel.Text = "-";
                            break;
                    }
                    switch (Int32.Parse(mo["Chemistry"].ToString()!))
                    {
                        case 1:
                        case 2:
                            typelabel.Text = "Unknown";
                            break;
                        case 3:
                            typelabel.Text = "Lead Acid";
                            break;
                        case 4:
                            typelabel.Text = "Nickel Cadmium";
                            break;
                        case 5:
                            typelabel.Text = "Nickel Metal Hydride";
                            break;
                        case 6:
                            typelabel.Text = "Lithium-ion";
                            break;
                        case 7:
                            typelabel.Text = "Zinc air";
                            break;
                        case 8:
                            typelabel.Text = "Lithium Polymer";
                            break;
                        default:
                            typelabel.Text = "-";
                            break;
                    }
                    classlabel.Text = mo["CreationClassName"].ToString();
                    designvoltagelabel.Text = mo["DesignVoltage"].ToString() + " mV";
                    descriptionlabel.Text = mo["Description"].ToString();
                    idlabel.Text = mo["DeviceID"].ToString();
                    performancelabel.Text = mo["Status"].ToString();
                    powermgmtlabel.Text = mo["PowerManagementSupported"].ToString();
                    systemnamelabel.Text = mo["SystemName"].ToString();
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Exception Raised", MessageBoxButtons.OKCancel);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void controlsbutton_Click(object sender, EventArgs e)
        {
            detailspanel.Visible = false;
            controlspanel.Visible = true;
            minbatterybox.Text = mmb.getMinBattery().ToString();
        }

        private void detailsbutton_Click(object sender, EventArgs e)
        {
            controlspanel.Visible = false;
            detailspanel.Visible = true;
        }
        private void minbattery_keypressed(object sender, KeyPressEventArgs e)
        {
            mmb.onlyNumberinput(e);
        }
        private void maxbattery_keypressed(object sender, KeyPressEventArgs e)
        {
            mmb.onlyNumberinput(e);
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            mmb.submitbuttonclicked(minbatterybox, maxbatterybox);
        }

        private void powerefficiencybtn_Click(object sender, EventArgs e)
        {
            pm.pwrefficiencybtnclick();
        }
        private void balancedbtn_Click(object sender, EventArgs e)
        {
            pm.balancedbtnclick();
        }
        private void performancebtn_Click(object sender, EventArgs e)
        {
            pm.performancebtnclick();
        } 
    }
}
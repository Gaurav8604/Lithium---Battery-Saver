using System.Management;
namespace Lithium___Battery_Saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (2 * 1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            PowerStatus status = SystemInformation.PowerStatus;
            powerPercentage(status);
            batteryLifeRemaining(status);
            plugIn(status);
        }
        private void powerPercentage(PowerStatus status)
        {
            String bpercentage = status.BatteryLifePercent.ToString("P0");
            int bper = Int16.Parse(bpercentage.Remove(bpercentage.IndexOf('%')));
            bpercentagelabel.Text = bpercentage;
            if (bper <= 20)
                bpercentagepicture.BackgroundImage = new Bitmap(Properties.Resources.battery20);
            else if (bper <= 40)
                bpercentagepicture.BackgroundImage = new Bitmap(Properties.Resources.battery40);
            else if (bper <= 60)
                bpercentagepicture.BackgroundImage = new Bitmap(Properties.Resources.battery60);
            else if (bper <= 80)
                bpercentagepicture.BackgroundImage = new Bitmap(Properties.Resources.battery80);
            else if (bper <= 100)
                bpercentagepicture.BackgroundImage = new Bitmap(Properties.Resources.battery100);
        }
        private void batteryLifeRemaining(PowerStatus status)
        {

            if (status.BatteryLifeRemaining > 0)
            {
                blifelabel.Text = String.Format("{0}hr and {1}min", status.BatteryLifeRemaining / 3600, (status.BatteryLifeRemaining % 3600) / 60);
            }
            else
            {
                blifelabel.Text = "Unknown";
            }
        }
        private void plugIn(PowerStatus status)
        {
            if (status.PowerLineStatus == PowerLineStatus.Online)
            {
                bpluginlabel.Text = "Plugged In";
                pluggedinpicture.BackgroundImage = new Bitmap(Properties.Resources.pluggedin); 
            }
            else
            {
                bpluginlabel.Text = "Not Plugged In";
                pluggedinpicture.BackgroundImage= new Bitmap(Properties.Resources.notpluggedin);  
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void blifelabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
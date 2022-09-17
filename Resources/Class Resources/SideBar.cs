namespace Lithium___Battery_Saver.Resources.Class_Resources
{
    public class SideBar
    {
        PowerStatus status;
        public SideBar(PowerStatus s)
        {
            status = s;
        }
        public void powerPercentage(CircularProgressBar.CircularProgressBar circularProgressBar1)
        {
            String bpercentage = status.BatteryLifePercent.ToString("P0");
            int bper = Int16.Parse(bpercentage.Remove(bpercentage.IndexOf('%')));
            circularProgressBar1.Value = bper;
            circularProgressBar1.Text = (bper.ToString()) + "%";
            if (circularProgressBar1.Value <= 20)
                circularProgressBar1.ProgressColor = System.Drawing.Color.Red;
            else if (circularProgressBar1.Value <= 40)
                circularProgressBar1.ProgressColor = System.Drawing.Color.Orange;
            else if (circularProgressBar1.Value <= 60)
                circularProgressBar1.ProgressColor = System.Drawing.Color.Yellow;
            else if (circularProgressBar1.Value <= 80)
                circularProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            else if (circularProgressBar1.Value <= 100)
                circularProgressBar1.ProgressColor = System.Drawing.Color.Green;
        }
        public int getbper()
        {
            String bpercentage = status.BatteryLifePercent.ToString("P0");
            return Int16.Parse(bpercentage.Remove(bpercentage.IndexOf('%')));
        }
        public void batteryLifeRemaining(Label blifelabel)
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
        public void plugIn(Label bpluginlabel, PictureBox pluggedinpicture)
        {
            if (status.PowerLineStatus == PowerLineStatus.Online)
            {
                bpluginlabel.Text = "Plugged In";
                pluggedinpicture.BackgroundImage = new Bitmap(Properties.Resources.pluggedin);
            }
            else
            {
                bpluginlabel.Text = "Not Plugged In";
                pluggedinpicture.BackgroundImage = new Bitmap(Properties.Resources.notpluggedin);
            }
        }
    }
}

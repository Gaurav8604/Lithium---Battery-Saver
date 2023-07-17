using System.Diagnostics;

namespace Lithium___Battery_Saver.Resources.Class_Resources
{
    public class PowerMode
    {
        struct powermodes
        {
            public string mode;
        }
        powermodes balanced, performance, efficiency;
        Button powerefficiencybtn, balancedbtn, performancebtn;
        public PowerMode(Button pwreff, Button bal, Button perf)
        {
            efficiency.mode = "a1841308-3541-4fab-bc81-f71556f20b4a";
            balanced.mode = "381b4222-f694-41f0-9685-ff5bb260df2e";
            performance.mode = "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
            powerefficiencybtn = pwreff;
            balancedbtn = bal;
            performancebtn = perf;
        }
        public void cmd(string command)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C" + command,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = true,
            };
            Process.Start(startInfo);
        }
        public void pwrefficiencybtnclick()
        {
            string command = "powercfg setactive " + efficiency.mode;
            cmd(command);
            powerefficiencybtn.BackColor = Color.Green;
            balancedbtn.BackColor = Color.White;
            performancebtn.BackColor = Color.White;
        }
        public void balancedbtnclick()
        {
            string command = "powercfg setactive " + balanced.mode;
            cmd(command);
            powerefficiencybtn.BackColor = Color.White;
            balancedbtn.BackColor = Color.Green;
            performancebtn.BackColor = Color.White;
        }
        public void performancebtnclick()
        {
            string command = "powercfg setactive " + performance.mode;
            cmd(command);
            powerefficiencybtn.BackColor = Color.White;
            balancedbtn.BackColor = Color.White;
            performancebtn.BackColor = Color.Green;
        }
    }
    public class MinMaxBattery
    {
        public void submitbuttonclicked(TextBox minbatterybox, TextBox maxbatterybox)
        {
            if (minbatterybox.Text == "" || Int16.Parse(minbatterybox.Text) < 0 || Int16.Parse(minbatterybox.Text) > 100)
            {
                MessageBox.Show("Please enter value between 1 - 100", "Error", MessageBoxButtons.OK);
                minbatterybox.Text = getMinBattery().ToString();
            }
            else if (maxbatterybox.Text == "" || Int16.Parse(maxbatterybox.Text) < 0 || Int16.Parse(maxbatterybox.Text) > 100)
            {
                MessageBox.Show("Please enter value between 1 - 100", "Error", MessageBoxButtons.OK);
                maxbatterybox.Text = getMaxBattery().ToString();
            }
            else if (Int16.Parse(minbatterybox.Text) >= Int16.Parse(maxbatterybox.Text))
            {
                MessageBox.Show("Minimum value cannot exceed maximum value", "Error", MessageBoxButtons.OK);
                maxbatterybox.Text = getMaxBattery().ToString();
                minbatterybox.Text = getMinBattery().ToString();
            }
            else
            {
                putMinBattery(Int16.Parse(minbatterybox.Text));
                putMaxBattery(Int16.Parse(maxbatterybox.Text));
                MessageBox.Show("Submitted", "Message", MessageBoxButtons.OK);
            }
        }
        public void putMinBattery(int minBattery)
        {
            string filename = @"minbat.txt";
            try
            {
                if(File.Exists(filename))
                {
                    File.Delete(filename);
                }
                using (TextWriter tw = File.CreateText(filename))
                {
                    tw.WriteLine(minBattery);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Raised", MessageBoxButtons.OKCancel);
            }
        }
        public int getMinBattery()
        {
            string filename = @"minbat.txt";
            try
            {
                using (TextReader tr = File.OpenText(filename))
                {
                    if (new FileInfo(filename).Length != 0)
                        return Int16.Parse(tr.ReadToEnd());
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Raised", MessageBoxButtons.OKCancel);
            }
            return 0;
        }
        public void putMaxBattery(int maxBattery)
        {
            string filename = @"maxbat.txt";
            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                using (TextWriter tw = File.CreateText(filename))
                {
                    tw.WriteLine(maxBattery);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Raised", MessageBoxButtons.OKCancel);
            }
        }
        public int getMaxBattery()
        {
            string filename = @"maxbat.txt";
            try
            {
                using (TextReader tr = File.OpenText(filename))
                {
                    if (new FileInfo(filename).Length != 0)
                        return Int16.Parse(tr.ReadToEnd());
                    return 100;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Raised", MessageBoxButtons.OKCancel);
            }
            return 100;
        }
        public void onlyNumberinput(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

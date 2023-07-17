namespace Lithium___Battery_Saver.Resources.Class_Resources
{
    public class Notify
    {
        public void notifymsg(NotifyIcon notify, String baloontiptitle, String baloontiptext, Bitmap bm)
        {
            try
            {
                IntPtr ip = bm.GetHicon();
                Icon ic = Icon.FromHandle(ip);
                notify.Icon = ic;
                notify.Visible = true;
                notify.BalloonTipTitle = baloontiptitle;
                notify.BalloonTipText = baloontiptext;
                notify.ShowBalloonTip(100);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Exception");
            }
        }
    }
}

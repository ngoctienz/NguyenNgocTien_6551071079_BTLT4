namespace ControlEx3
{
    public partial class Form1 : Form
    {
        int done = 0;
        int speed = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            done+= speed;
            if (done > 100)
            {
                tmrTimer.Stop();
            }
            else
            {
                prgIndicator.Value = done;
                lblPercentage.Text = $"Percentage Complete: {done}%";
            }

        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            speed = trkSpeed.Value; 
        }
    }
}

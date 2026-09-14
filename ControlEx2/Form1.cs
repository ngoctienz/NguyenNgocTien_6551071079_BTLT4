using System;
using System.Text;
using System.Windows.Forms;

namespace ControlEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTravelDates(mcTravelDates.SelectionStart, mcTravelDates.SelectionEnd);
        }

        private void mcTravelDates_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateTravelDates(e.Start, e.End);
        }

        private void mcTravelDates_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateTravelDates(e.Start, e.End);
        }

        private void UpdateTravelDates(DateTime start, DateTime end)
        {
            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendLine("StartDate:");
            sbMessage.AppendLine(start.ToShortDateString());
            sbMessage.AppendLine();
            sbMessage.AppendLine("End Date:");
            sbMessage.Append(end.ToShortDateString());

            lblTravelDates.Text = sbMessage.ToString();
        }

        private void rbLongDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLongDate.Checked)
            {
                dtpLaunchDate.Format = DateTimePickerFormat.Long;
            }
        }

        private void rbShortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShortDate.Checked)
            {
                dtpLaunchDate.Format = DateTimePickerFormat.Short;
            }
        }
    }
}

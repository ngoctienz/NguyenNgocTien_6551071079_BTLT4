namespace ControlEx4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Xác định các nút (Buttons) của MessageBox
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (radOK.Checked)
                buttons = MessageBoxButtons.OK;
            else if (radOKCancel.Checked)
                buttons = MessageBoxButtons.OKCancel;
            else if (radRetryCancel.Checked)
                buttons = MessageBoxButtons.RetryCancel;
            else if (radYesNo.Checked)
                buttons = MessageBoxButtons.YesNo;
            else if (radYesNoCancel.Checked)
                buttons = MessageBoxButtons.YesNoCancel;

            // Xác định biểu tượng (Icon) của MessageBox
            MessageBoxIcon icon = MessageBoxIcon.None;
            if (radError.Checked)
                icon = MessageBoxIcon.Error;
            else if (radInformation.Checked)
                icon = MessageBoxIcon.Information;
            else if (radNone.Checked)
                icon = MessageBoxIcon.None;
            else if (radQuestion.Checked)
                icon = MessageBoxIcon.Question;
            else if (radWarning.Checked)
                icon = MessageBoxIcon.Warning;

            // Hiển thị MessageBox với nội dung và caption đã nhập
            MessageBox.Show(txtMessage.Text, txtCaption.Text, buttons, icon);
        }

        private void radLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radLeft.Checked)
                tabControl.Alignment = TabAlignment.Left;
        }

        private void radRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radRight.Checked)
                tabControl.Alignment = TabAlignment.Right;
        }

        private void radTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radTop.Checked)
                tabControl.Alignment = TabAlignment.Top;
        }

        private void radBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottom.Checked)
                tabControl.Alignment = TabAlignment.Bottom;
        }
    }
}

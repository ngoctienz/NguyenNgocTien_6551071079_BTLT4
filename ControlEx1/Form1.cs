namespace ControlEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;
            exText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void inputSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;
            exText.Font = new Font(exText.Font.FontFamily, (float)nudSize.Value);


        }
    }
}

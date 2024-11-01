namespace Message_Box_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "My Label";
        }
    }
}

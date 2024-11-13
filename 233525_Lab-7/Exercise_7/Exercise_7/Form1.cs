namespace Exercise_7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd,MMMMdd,yyyy");
            label2.Text = DateTime.Now.ToString(" hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

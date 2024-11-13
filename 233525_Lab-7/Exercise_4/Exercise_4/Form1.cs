namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(textBox1.Text);
            double celsius = (fahrenheit - 32) * 5 / 9;
            textBox2.Text = celsius.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

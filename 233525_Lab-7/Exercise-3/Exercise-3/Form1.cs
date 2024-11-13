namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Number   Square ");
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;

                listBox1.Items.Add($"{i}   :           {square}");
            }
        }
    }
}

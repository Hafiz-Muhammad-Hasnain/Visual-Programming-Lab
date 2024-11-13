using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Exercise_6
{
    public partial class Form1 : Form
    {
        int time_left;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            time_left = (int)numericUpDown1.Value;
            label3.Text = $"Time Left: {time_left} Seconds.";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_left > 0)
            {
                time_left--;
                label3.Text = $"Time Left: {time_left} Seconds.";
            }
            else
            {
              
                timer1.Stop();
                
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
                label3.Text = "Time Left: 0 Seconds.";
            }


        }
    }
}

namespace Check_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] names = { "Tamil Nadu", "Kerala", "Telangana", "Andhra", "Delhi" };
            foreach (string name in names)
            {
                comboBox1.Items.Add(name);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox2.Items.Clear();

         
            if (comboBox1.SelectedItem.ToString() == "Tamil Nadu")
            {
                comboBox2.Items.Add("Chennai");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("Pondi");
                comboBox2.Items.Add("Madurai");
                comboBox2.Items.Add("Kanchipuram");
            }
            else if (comboBox1.SelectedItem.ToString() == "Kerala")
            {
                comboBox2.Items.Add("Kollam");
                comboBox2.Items.Add("Cochin");
                comboBox2.Items.Add("Thiruvananthapuram");
            }
            
        }

    }
}


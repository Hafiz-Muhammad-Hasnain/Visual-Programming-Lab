namespace ChekBox_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string message = "You bought: ";
            if (checkBox1.Checked) message += "Pen ";
            if (checkBox2.Checked) message += "Book";
            if (checkBox3.Checked) message += "Pencil ";

            MessageBox.Show(message, "Purchase Summary");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Selected Gender: Male");
            else if (radioButton2.Checked)
                MessageBox.Show("Selected Gender: Female");
        }
    }
}

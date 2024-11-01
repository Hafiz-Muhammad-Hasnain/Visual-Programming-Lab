namespace Numeric_UpDown_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            decimal price = numericUpDown1.Value;
            decimal quantity = numericUpDown2.Value;
            decimal total = price * quantity;

            MessageBox.Show("The total price is $" + total.ToString("0.00"));

        }
    }
}

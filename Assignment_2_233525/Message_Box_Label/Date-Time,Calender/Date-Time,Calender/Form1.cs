namespace Date_Time_Calender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "DateTimePicker Date: " + dateTimePicker1.Text;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = "Month Calendar Date: " + monthCalendar1.SelectionStart.ToLongDateString();

        }
    }
}

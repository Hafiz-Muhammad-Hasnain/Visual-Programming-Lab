namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold); // Remove Bold
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // Add Bold

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic); // Remove Italic
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic); // Add Italic

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline); // Remove Underline
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline); // Add Underline

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

        }
    }
}

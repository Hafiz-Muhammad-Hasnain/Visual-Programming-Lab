namespace Exercise_9
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
            UpdateCharacterCount();
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            UpdateCharacterCount();
        }
        private void UpdateCharacterCount()
        {
           
            int charactersLeft = MaxCharacters - textBox_Input.Text.Length;
           
            label_CharCount.Text = $"Characters Left: {charactersLeft}";
        }
    }
}

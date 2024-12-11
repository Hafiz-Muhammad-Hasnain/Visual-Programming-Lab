using System.Windows;
using System.Windows.Controls;

namespace WPFComboBoxControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
                textBox.Text = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                textBox1.Text = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();
        }
    }
}

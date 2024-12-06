using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cricket_Team_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  ObservableCollection<string> Players { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>();
            ShowPlayer_ListBox.ItemsSource = Players;

        }

        private void Add_Player_Click(object sender, RoutedEventArgs e)
        {
            string Player_Name = PlayerNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(Player_Name))
            {
                MessageBox.Show("Player Name Can Not Be Empty.","Error!",MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Players.Contains(Player_Name))
            {
                MessageBox.Show("This Player is Already in The Team.","Error!",MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Players.Add(Player_Name);
            PlayerNameTextBox.Clear();
            MessageBox.Show("Player Added Successfully.","Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Remove_Player_Click(object sender, RoutedEventArgs e)
        {
            string Selected_Player = (string)ShowPlayer_ListBox.SelectedItem;
            if (Selected_Player == null)
            {
                MessageBox.Show("Please Select A Player To Remove.", "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Players.Remove(Selected_Player);
            ShowPlayer_ListBox.SelectedItem = null;
            MessageBox.Show("Player Remove Successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
    }
}

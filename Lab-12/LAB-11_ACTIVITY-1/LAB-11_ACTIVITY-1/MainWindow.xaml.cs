using System;
using System.Windows;
using System.Windows.Threading;

namespace LAB_11_ACTIVITY_1
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            CurrentTime = DateTime.Now; // Initialize CurrentTime with the current time

            // Set up a timer to update CurrentTime every second
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTime = DateTime.Now; 
        }

        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set
            {
                // Validate the value before setting it
                if (ValidateCurrentTime(value))
                {
                    SetValue(CurrentTimeProperty, value);
                }
                else
                {
                 
                    Console.WriteLine("Invalid time value. It cannot be in the future.");
                }
            }
        }

        public static readonly DependencyProperty CurrentTimeProperty =
            DependencyProperty.Register("CurrentTime", typeof(DateTime), typeof(MainWindow),
                new PropertyMetadata(DateTime.Now, OnCurrentTimeChanged, CoerceCurrentTime));

        // Callback method that is called when CurrentTime changes
        private static void OnCurrentTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow window = d as MainWindow;
            if (window != null)
            {
                DateTime newTime = (DateTime)e.NewValue;
                
                Console.WriteLine($"CurrentTime changed to: {newTime}");
            }
        }

        // Coerce value callback to ensure the CurrentTime is valid
        private static object CoerceCurrentTime(DependencyObject d, object value)
        {
            DateTime newTime = (DateTime)value;

            
            if (newTime > DateTime.Now)
            {
                return DateTime.Now; 
            }

            return value; 
        }

        // Validate value callback to check if the CurrentTime is valid
        private static bool ValidateCurrentTime(object value)
        {
            DateTime newTime = (DateTime)value;

            
            return newTime <= DateTime.Now; 
        }
    }
}
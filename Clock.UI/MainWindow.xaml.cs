using System;
using System.Windows;
using System.Windows.Threading;

namespace Clock.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            SetUpStartupLocation();
            StartTimer();
        }

        private void SetUpStartupLocation()
        {
            this.Left = SystemParameters.WorkArea.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Height - this.Height;
            this.Topmost = true;
        }

        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(UpdateTime);
            timer.Start();
        }

        private void UpdateTime(object sender, EventArgs args)
        {
            lblClock.Content = DateTime.Now.ToString("H:mm");
        }
    }
}

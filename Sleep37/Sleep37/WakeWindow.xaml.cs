using System.ComponentModel;
using System.Windows;
using Microsoft.HandsFree.Mouse;

namespace Sleep37
{
    /// <summary>
    /// Interaction logic for WakeWindow.xaml
    /// </summary>
    public partial class WakeWindow : Window
    {
        public WakeWindow()
        {
            InitializeComponent();
        }

        private void WakeWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            GazeMouse.Attach(this);
        }

        private void WakeWindow_OnClosing(object sender, CancelEventArgs e)
        {
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CalibrateButton_OnClick(object sender, RoutedEventArgs e)
        {
            GazeMouse.LaunchRecalibration();
        }

        private void WakeButton_OnClick(object sender, RoutedEventArgs e)
        {
            var app = (App)Application.Current;
            app.Shutdown();
        }

        private void AssistanceButton_OnClick(object sender, RoutedEventArgs e)
        {
            var assistanceWindow = new AssistanceWindows();
            assistanceWindow.ShowDialog();
        }
    }
}

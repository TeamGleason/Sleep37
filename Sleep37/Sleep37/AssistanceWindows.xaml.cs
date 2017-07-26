using System.ComponentModel;
using System.Windows;
using Microsoft.HandsFree.Mouse;

namespace Sleep37
{
    /// <summary>
    /// Interaction logic for AssistanceWindows.xaml
    /// </summary>
    public partial class AssistanceWindows : Window
    {
        public AssistanceWindows()
        {
            InitializeComponent();
        }

        private void AssistanceWindows_OnLoaded(object sender, RoutedEventArgs e)
        {
            GazeMouse.Attach(this);
        }

        private void AssistanceWindows_OnClosing(object sender, CancelEventArgs e)
        {
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

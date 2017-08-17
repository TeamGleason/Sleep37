using System.ComponentModel;
using System.Windows;
using Microsoft.HandsFree.GazePointer;
using System.Speech.Synthesis;
using System.Windows.Controls;

namespace Sleep37
{
    /// <summary>
    /// Interaction logic for AssistanceWindows.xaml
    /// </summary>
    public partial class AssistanceWindows
    {
        private readonly SpeechSynthesizer _speechSynthesizer;

        public AssistanceWindows()
        {
            InitializeComponent();

            _speechSynthesizer = new SpeechSynthesizer();
        }

        private void AssistanceWindows_OnLoaded(object sender, RoutedEventArgs e)
        {
            GazePointer.Attach(this);
        }

        private void AssistanceWindows_OnClosing(object sender, CancelEventArgs e)
        {
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void PhraseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var caption = button.Content as string;
            _speechSynthesizer.SpeakAsync(caption);
        }
    }
}

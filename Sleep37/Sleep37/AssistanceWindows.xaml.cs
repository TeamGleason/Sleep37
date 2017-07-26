using System.ComponentModel;
using System.Windows;
using Microsoft.HandsFree.Mouse;
using System.Speech.Synthesis;

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
            GazeMouse.Attach(this);
        }

        private void AssistanceWindows_OnClosing(object sender, CancelEventArgs e)
        {
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PainButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I'm in pain");
        }

        private void RepositionButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I need to reposition");
        }

        private void BathroomButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I need to go to the bathroom");
        }

        private void SuctionButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I need suction");
        }

        private void HeadacheButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I have a headache");
        }

        private void ItchButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I have an itch");
        }

        private void HotButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I'm hot");
        }

        private void ColdButton_OnClick(object sender, RoutedEventArgs e)
        {
            _speechSynthesizer.SpeakAsync("I'm cold");
        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace Sleep37
{
    public class UpdatingTime : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UpdatingTime()
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(100)
            };
            timer.Tick += (sender, args) =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Now)));
            };
            timer.Start();
        }

        public string Now => DateTime.Now.ToShortTimeString();
    }
}

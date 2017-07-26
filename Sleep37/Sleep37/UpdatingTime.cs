using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace Sleep37
{
    public class UpdatingTime : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _now;

        public UpdatingTime()
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(100)
            };
            timer.Tick += (sender, args) =>
            {
                Now = DateTime.Now.ToShortTimeString();
            };
            timer.Start();
        }

        public string Now
        {
            get { return _now; }
            private set
            {
                _now = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Now"));
            }
        }
    }
}

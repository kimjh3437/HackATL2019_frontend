using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HackATL_EEVM.Models
{
    public class DummyData : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string gbs { get; set; }
        public string booking { get; set; }

        public string _IsBookNow = "Booknow.png";
        public string IsBookNow
        {
            get
            {
                return _IsBookNow;
            }
            set
            {
                _IsBookNow = value;
                NotifyPropertyChanged("IsBookNow");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

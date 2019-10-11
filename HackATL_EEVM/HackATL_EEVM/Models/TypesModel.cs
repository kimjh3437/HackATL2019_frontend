using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HackATL_EEVM.Models
{
    public class TypesModel : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string Time { get; set; }
        public string status { get; set; }
        public string Desc { get; set; }

        private string _IsAddImage = "Add.png";
        public string IsAddImage
        {
            get
            {
                return _IsAddImage;
            }
            set
            {
                _IsAddImage = value;
                NotifyPropertyChanged("IsAddImage");
            }
        }

        private string _IsNotificationImage = "Bell.png";
        public string IsNotificationImage
        {
            get
            {
                return _IsNotificationImage;
            }
            set
            {
                _IsNotificationImage = value;
                NotifyPropertyChanged("IsNotificationImage");
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

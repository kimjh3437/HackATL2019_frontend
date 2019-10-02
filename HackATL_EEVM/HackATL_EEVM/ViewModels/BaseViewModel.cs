using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.Models.BindingModels;
using HackATL_EEVM.Services.Item_realted;

namespace HackATL_EEVM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IFirebaseItem<Item> FirebaseItem => DependencyService.Get<IFirebaseItem<Item>>();    
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public IUserStore<User> UserStore => DependencyService.Get<IUserStore<User>>();
        public IUserStore<UserDto> UserStoreDto => DependencyService.Get<IUserStore<UserDto>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        string time = string.Empty;
        public string Time
        {
            get { return time; }
            set { SetProperty(ref time, value); }
        }
        string location = string.Empty;
        public string Location
        {
            get { return location; }
            set { SetProperty(ref location, value); }
        }
        string type = string.Empty;
        public string Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }
        string day = string.Empty;
        public string Day
        {
            get { return day; }
            set { SetProperty(ref day, value); }
        }
        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }



        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

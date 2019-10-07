using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterDetailMaster : ContentPage
    {
        public ListView ListView;

        public MainMasterDetailMaster()
        {
            InitializeComponent();

            BindingContext = new MainMasterDetailMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainMasterDetailMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainMasterDetailMasterMenuItem> MenuItems { get; set; }

            public MainMasterDetailMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainMasterDetailMasterMenuItem>(new[]
                {
                    new MainMasterDetailMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MainMasterDetailMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MainMasterDetailMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MainMasterDetailMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MainMasterDetailMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
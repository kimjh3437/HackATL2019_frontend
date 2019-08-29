using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace HackATL_EEVM.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://facebook.com")));
            OpenWebCommand_FB = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/EmoryEVM/")));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenWebCommand_FB { get; }
    }
}
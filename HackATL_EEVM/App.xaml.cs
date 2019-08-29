using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackATL_EEVM.Services;
using HackATL_EEVM.Views;
using HackATL_EEVM;
using MonkeyCache.SQLite;
using HackATL_EEVM.Database;
using System.Threading.Tasks;
using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Views.Pages.FAQ_children;
using HackATL_EEVM.Views.Pages.FAQ_children.Livechat;

namespace HackATL_EEVM
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl = "https://eevmhackatl.azurewebsites.net";

        public static bool UseMockDataStore = false;
        
        public static User profile { get; set; }



        public static IAuthenticate Authenticator { get; private set; }

        public static bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;


        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }


        
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<AzureDataStore>();
            //DependencyService.Register<UserService>();


            DependencyService.Register<UserService>();
            DependencyService.Register<AzureDataStore>();
            //MainPage = new AdminNavigation());
            //MainPage = new livechat();
            //if (Settings.Username != null) 
            //    MainPage = new Main();
            //else if (!IsUserLoggedIn)
            //   MainPage = new NavigationPage(new HackATL_EEVM.Pages.LoginInterface.LoginPage());           
            //else
            MainPage = new Main();
            //Barrel.ApplicationId = "save_data";
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        
    }
}

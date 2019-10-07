using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackATL_EEVM.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http;
using HackATL_EEVM.Helpers_token;

namespace HackATL_EEVM.Pages.LoginInterface
{
    

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        HttpClient client;
        string Username_in, Password_in, Firstname_in, Lastname_in;
        
        User user;

        public SignUpPage()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");

            InitializeComponent();
            //Settings.Firstname = firstNameEntry.Text;
            //Settings.Lastname = lastNameEntry.Text;
            //Settings.Username = usernameEntry.Text;
            //Settings.Password = passwordEntry.Text;
            

            Username_in = usernameEntry.Text;
            Password_in = passwordEntry.Text;
            Firstname_in = firstNameEntry.Text;
            Lastname_in = lastNameEntry.Text;
            

        }
      
            
        //async void OnSignUpButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PopAsync();
        //}
        //async void toMain()
        //{
            
        //    Navigation.InsertPageBefore(new Main(), Navigation.NavigationStack.First());
        //    await Navigation.PopToRootAsync();
            
        //}

        private async void Signup_clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new Main(), Navigation.NavigationStack.First());
            await Navigation.PopToRootAsync();




            //if (Settings.Role == "Member")
            //    await Navigation.PushAsync(new Main());
            //else if (Settings.Role == "Admin")
            //    await Navigation.PushAsync(new Main());




        }
        async void signup_transfer(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        public async Task<bool> Overlap(User user_input)
        {
            
            bool stat;
            user = new User();
            var username_input = user_input.Username;
            var response = await client.GetAsync($"api/user/{username_input}");
            var user_string = await Task.Run(()=> response.Content.ReadAsStringAsync());
            user = JsonConvert.DeserializeObject<User>(user_string);
            var User_username = user.Username;

            if (username_input != null || username_input == User_username)
            {
                stat = false;
            }
            else
                stat = true;

            return stat;


        }
     

        bool AreDetailsValid(User user)
        {
            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password));
        }
        
    }
}



/* async void OnSignUpButtonClicked(object sender, EventArgs e)
       {
           var user = new User()
           {
               Username = usernameEntry.Text,
               Password = passwordEntry.Text,
               Phonenumber = phonenumberEntry.Text

           };
           var signUpSucceeded = AreDetailsValid(user);
           MessagingCenter.Send(this, "Addtothelist", user);
           if (signUpSucceeded)
           {
               var rootPage = Navigation.NavigationStack.FirstOrDefault();
               if (rootPage != null)
               {
                   App.IsUserLoggedIn = true;
                   Navigation.InsertPageBefore(new Main(), Navigation.NavigationStack.First());
                   await Navigation.PopToRootAsync();
               }
           }
           else
           {
               messageLabel.Text = "Sign up failed";
           }
       }
       */

/*public void Signup(object sender, EventArgs e)
{
    string username = usernameEntry.Text;
    string password = passwordEntry.Text;
    var client = new RestClient("https://eevmhack.auth0.com");
    var request = new RestRequest("dbconnections/signup", Method.POST);

    request.AddParameter("client_id", "FMJhXPJIsSXRNMFjXNg8g4Ucc4h774rx");
    request.AddParameter("email", username);
    request.AddParameter("password", password);
    request.AddParameter("connection", "eevmhackatlDB");

    IRestResponse response = client.Execute(request);
    UserSignup user = JsonConvert.DeserializeObject<UserSignup>(response.Content);
    if(user.user_id != null)
    {
        toMain();
    }



}
*/

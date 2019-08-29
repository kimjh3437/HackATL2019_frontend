using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using HackATL_EEVM.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models.BindingModels;

namespace HackATL_EEVM.Services
{
    

    public class UserService //: IUserStore<User>
    {
        HttpClient client;
        IEnumerable<User> users;
        bool conn;
         

        public UserService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri($"{App.AzureBackendUrl}/")
            };
            
            conn = App.IsConnected;
            //recall Isconnceted from App.xaml.cs. 


        }
        
        public async Task<User> LoginUserAsync(string Username, string Password)
        {
            var newUser = new UserDto
            {
                Username = Username,
                Password = Password,             
            };
            var user_serialized = JsonConvert.SerializeObject(newUser);
            HttpContent content = new StringContent(user_serialized);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync($"api/user/authenticate",content);
            if (response.IsSuccessStatusCode)
            {
                var response_string = await response.Content.ReadAsStringAsync();
                var verified = JsonConvert.DeserializeObject<User>(response_string);
                User user_verified = verified;
                //JObject token = JsonConvert.DeserializeObject<dynamic>(response_string);
                return verified;

            }
            else
            {
                Debug.WriteLine("Error occuered or invalid user");
                return null;
                
            }

                    
        }

        public async Task<bool> RegisterUserAsync(string username, string password, string firstname, string lastname)
        {
            var clientss = new HttpClient();
            var existingUser = new UserDto
            {
                Username = username,
                Password = password, 
                Firstname = firstname,
                Lastname = lastname
            };
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Firstname", username),
                new KeyValuePair<string, string>("Lastname", password),
                new KeyValuePair<string, string>("Username", firstname),
                new KeyValuePair<string, string>("Password", lastname)

            };
            var content = new HttpRequestMessage(HttpMethod.Post, App.AzureBackendUrl + "/api/user/register");
            content.Content = new FormUrlEncodedContent(keyValues);

            // var user_serialized = JsonConvert.SerializeObject(existingUser);
            // HttpContent content = new StringContent(user_serialized);
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //var response = await clientss.PostAsync(App.AzureBackendUrl + "/api/user/register", content);
            //var response_string = await response.Content.ReadAsStringAsync();
            //RegisterUserModel registered = JsonConvert.DeserializeObject<RegisterUserModel>(response_string);
            var response = await client.SendAsync(content);
            if (response.IsSuccessStatusCode)
            {
                var response_string = await response.Content.ReadAsStringAsync();
                User user_registered = JsonConvert.DeserializeObject<User>(response_string);
                Debug.WriteLine(response_string);
                var accessToken = user_registered.Token;
                var firstName = user_registered.FirstName;
                var lastName = user_registered.LastName;
                var userName = user_registered.Username;
                var role = user_registered.Role;

                Settings.AccessToken = accessToken;
                Settings.Firstname = firstName;
                Settings.Lastname = lastName;
                Settings.Role = role;
                Settings.isLogged = "true";

                App.Current.Properties.Add("savedPropA", "true");
                await App.Current.SavePropertiesAsync();
                

                return response.IsSuccessStatusCode;
            }
            Debug.WriteLine("Invalid Login");
            return false;
            
            
            

        }


        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {   
            //Retrieve user info only if there is network connection. 
            if(conn)
            {
                var user_Serialized = await client.GetStringAsync($"api/user/register");
                users = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<User>>(user_Serialized));
            }
            
            return users; 
        }

        public async Task<User> GetUserAsync(string username)
        {
            if(username != null && conn)
            {
                var user_serialized = await client.GetStringAsync($"api/user/{username}");
                return await Task.Run(() => JsonConvert.DeserializeObject<User>(user_serialized));
                    
            }
            return null;
        }

        //TODO
        //Include a case where User accont with given name already exists. 

        

        public async Task<bool> UpdateUserAsync(User user)
        {
            if (user == null || user.Username == null || conn)
                return false;
            var user_serialized = JsonConvert.SerializeObject(user);
            var middleware = Encoding.UTF8.GetBytes(user_serialized);
            var cont = new ByteArrayContent(middleware);
            var request = await client.PutAsync(new Uri($"api/user/{user.Username}"), cont);

            return request.IsSuccessStatusCode;

        }

        public async Task<bool>DeleteUserAsync(string username)
        {
            if (string.IsNullOrEmpty(username) && !conn)
                return false;

            var response = await client.DeleteAsync($"api/user/{username}");

            return response.IsSuccessStatusCode;
        }
        


    }
}

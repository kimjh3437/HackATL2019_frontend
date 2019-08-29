using HackATL_EEVM.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HackATL_EEVM.Services.Question_related
{
    public class QuestionService
    {
        HttpClient client;
        IEnumerable<Question> questionBoard;
        bool conn;

        public QuestionService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri($"{App.AzureBackendUrl}/")
            };

            conn = App.IsConnected;
        }

        
    }
}

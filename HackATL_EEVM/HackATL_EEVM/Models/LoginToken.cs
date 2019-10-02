using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Models
{
    public class LoginToken
    {
        public string id_token { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
    }
}

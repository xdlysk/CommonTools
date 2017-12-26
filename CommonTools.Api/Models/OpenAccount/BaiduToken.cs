using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonTools.Api.Models.OpenAccount
{
    public class BaiduToken
    {
        public string access_token;

        public int expires_in;

        public string refresh_token;

        public string scope;

        public string session_key;

        public string session_secret;
    }
}

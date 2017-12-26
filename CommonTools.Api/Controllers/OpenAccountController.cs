using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonTools.Api.Models.OpenAccount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CommonTools.Api.Controllers
{
    public class OpenAccountController : BaseController
    {
        private static string Baidu = "https://openapi.baidu.com/oauth/2.0/token?grant_type=authorization_code&code=CODE&client_id=YOUR_CLIENT_ID&client_secret=YOUR_CLIENT_SECRET&redirect_uri=YOUR_REGISTERED_REDIRECT_URI";

        private readonly IConfiguration _configuration;

        public OpenAccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index(string type)
        {
            switch (type)
            {
                case "baidu":
                    return AuthBaidu();
            }
            return View();
        }

        private RedirectResult AuthBaidu()
        {
            var code = Request.Query["code"];
            var redirect = Request.Query["redirect"];
            var baiduconfig = _configuration.GetSection("OpenAccount:Baidu");
            var clientid = baiduconfig.GetValue<string>("ApiKey");
            var secret = baiduconfig.GetValue<string>("SecretKey");
            var url = Baidu
                .Replace("CODE", code)
                .Replace("YOUR_CLIENT_ID", clientid)
                .Replace("YOUR_CLIENT_SECRET", secret)
                .Replace("YOUR_REGISTERED_REDIRECT_URI", redirect);

            var res =Newtonsoft.Json.JsonConvert.DeserializeObject<BaiduToken>( GetHttpClient().GetStringAsync(url).Result);

            return Redirect(redirect);
        }
    }
}
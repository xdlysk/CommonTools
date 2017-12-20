using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommonTools.Api.Controllers
{
    public class EncryptionController : BaseController
    {
        [HttpPost("/rsaprivatekeyjava2dotnet")]
        public string RSAPrivateKeyJava2DotNet([FromBody]string privateKey)
        {
            return Encryption.RSAKeyConvert.RSAPrivateKeyJava2DotNet(privateKey);
        }
    }
}
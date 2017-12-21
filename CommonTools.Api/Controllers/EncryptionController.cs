using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommonTools.Api.Controllers
{
    public class EncryptionController : BaseController
    {
        [HttpPost("rsaprivatekeyjava2dotnet")]
        public string RSAPrivateKeyJava2DotNet([FromBody]string key)
        {
            try
            {
                return Encryption.RSAKeyConvert.RSAPrivateKeyJava2DotNet(key);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        [HttpPost("rsaprivatekeydotnet2java")]
        public string RSAPrivateKeyDotNet2Java([FromBody]string key)
        {
            try
            {
                return Encryption.RSAKeyConvert.RSAPrivateKeyJava2DotNet(key);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpPost("rsapublickeyjava2dotnet")]
        public string RSAPublicKeyJava2DotNet([FromBody]string key)
        {
            try
            {
                return Encryption.RSAKeyConvert.RSAPublicKeyJava2DotNet(key);
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }

        [HttpPost("rsapublickeydotnet2java")]
        public string RSAPublicKeyDotNet2Java([FromBody]string key)
        {
            try
            {
                return Encryption.RSAKeyConvert.RSAPublicKeyDotNet2Java(key);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
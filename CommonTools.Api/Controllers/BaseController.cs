﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommonTools.Api.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {

        protected HttpClient GetHttpClient()
        {
            return new HttpClient();
        }
            
    }
}
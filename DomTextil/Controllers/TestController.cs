﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomTextil.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public String Index()
        {
            string ip = Request.UserHostAddress;
            return ip;
        }

       
    }
}
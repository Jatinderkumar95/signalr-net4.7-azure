using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    [RoutePrefix("api/ping")]
    public class PingController : ApiController
    {
        public PingController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            DispachHubs.DispachHub.SendDispatch();
            return "Ping Successfull";
        }
    }
}

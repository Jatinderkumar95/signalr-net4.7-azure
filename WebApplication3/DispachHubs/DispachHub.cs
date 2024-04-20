using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebApplication3.DispachHubs
{
    [HubName("DispatchHub")]
    public class DispachHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<DispachHub>();
        public DispachHub()
        {
                
        }

        public static void SendDispatch()
        {
            //for single insert and update case
            var update = new { IsUpdate = true, UpdateDatetime = DateTime.UtcNow };
            hubContext.Clients.All.DispatchScheduleUpdate(update);
        }

    }
}
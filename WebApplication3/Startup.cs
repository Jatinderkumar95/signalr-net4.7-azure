using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
//using Microsoft.Owin.Cors;
//using Microsoft.Owin.Security.Cookies;
//using Microsoft.Owin.Security.OAuth;

namespace WebApplication3
{
    //[assembly: OwinStartup(typeof(WebApplication3.tartup))]
    public class Startup
    {
        public static string AzureSignalRConnectionString { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            //var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            // Web API configuration and services
            //app.Use("")
            // Enforce HTTP Strict-Transport-Security 
            //app.Use(typeof(HstsMiddleware));
            AzureSignalRConnectionString = Convert.ToString(ConfigurationManager.ConnectionStrings["Azure:SignalR:ConnectionString"].ConnectionString.ToString());


            //setup push notification
            //app.UsePushNotification(RedisPushNotification);
            //GlobalHost.TraceManager.Switch.Level = SourceLevels.Information;
            app.MapAzureSignalR(this.GetType().Name, new HubConfiguration() { 
                
                EnableJavaScriptProxies = true });
            //app.UseCors(CorsOptions.AllowAll);
            //app.MapAzureSignalR(
            //    "/signalr",
            //    GetType().Name, new HubConfiguration
            //    {   // tried all combinations of boolean values below.
            //        EnableDetailedErrors = true,
            //        EnableJSONP = true,
            //        EnableJavaScriptProxies = true
            //    }, options =>
            //    {

            //        options.ConnectionCount = 5; // tried increasing and decreasing that number.
            //        options.ConnectionString = AzureSignalRConnectionString;
            //        options.AccessTokenLifetime = TimeSpan.FromDays(1); // tried even removing.
            //    }
            //);

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapHub<DispachHubs.DispachHub>("/signalr");
            //});
        }

    }
}



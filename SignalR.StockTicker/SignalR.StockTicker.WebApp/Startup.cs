﻿using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(SignalR.StockTicker.WebApp.Startup), "Configuration")]

namespace SignalR.StockTicker.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigureSignalR(app);
        }
    }
}

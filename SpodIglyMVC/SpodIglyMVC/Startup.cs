using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.SqlServer;
using Hangfire.Dashboard;

[assembly: OwinStartup(typeof(SpodIglyMVC.Startup))]

namespace SpodIglyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.UseHangfire(config =>
            {
                config.UseAuthorizationFilters(new AuthorizationFilter
                {
                    Roles = "Admin"
                });

                config.UseSqlServerStorage("StoreContext");
                config.UseServer();
            });
        }
    }
}

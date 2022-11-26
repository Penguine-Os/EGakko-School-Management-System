using EGakko_DAL.Data;
using EGakko_Models;
using EGakko_Web.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGakko_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var userManager = services.GetRequiredService<UserManager<CustomUser>>();
                    var rolmangager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var ApplicationDbContext = services.GetRequiredService<ApplicationDbContext>();
                    IdentityDataInitializer.CreateRoles(rolmangager, ApplicationDbContext).Wait();
                    IdentityDataInitializer.SeedIdentityUsers(userManager, rolmangager).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Error opgetreden, while seeding the database.");
                }
            }
            //IdentityDataInitializer.CreateRoles(serviceProvider);
            //IdentityDataInitializer.SeedIdentityUsers(userManager, roleManager);

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

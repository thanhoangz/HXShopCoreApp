﻿using HXShopCoreApp.Data.EF;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace HXShopCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var service = scope.ServiceProvider;
                try
                {
                    var dbInitializer = service.GetService<DbInitializer>();
                    dbInitializer.Seed().Wait();

                }
                catch (Exception ex)
                {

                    var logger = service.GetService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database");
                }

            }
            host.Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();



    }
}

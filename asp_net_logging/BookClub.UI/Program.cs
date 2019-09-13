﻿using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
//using NLog.Web;
using Serilog;
using Serilog.Formatting.Json;

namespace BookClub.UI
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(Configuration)
                    .WriteTo.File(new JsonFormatter(), @"d:\temp\logs\bookclub-ui.json")
                    .CreateLogger();

            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(Configuration)
            //    //.WriteTo.File(new JsonFormatter(), @"c:\temp\logs\book-club.json", shared: true)
            //    .WriteTo.Seq("http://localhost:5341")
            //    .CreateLogger();

            //var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            try
            {
                Log.Information("Starting web host");
                //logger.Info("Starting web host");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                //logger.Error(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
               // NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()                
                .UseSerilog();               
                //.UseNLog();
    }
}

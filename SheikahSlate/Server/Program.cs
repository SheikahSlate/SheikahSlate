﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SheikahSlate.Shared;

namespace SheikahSlate.Server
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            _ = JsonParse.ReadItems();
            CreateHostBuilder(args).Build().Run();
            //Parse the JSON, return lists of classes
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}

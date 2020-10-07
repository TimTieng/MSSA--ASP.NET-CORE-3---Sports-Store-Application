/*
Class: ISTA 322 - Developing Web Applications with ASP.NET CORE
Student: Tim Tieng
Instructor: Christine Lee
Date: 26 August 2020
Description: Sports Store MVC Application 
Last Revised On: 23 September 2020
Last Revised By: Tim Tieng
Revisions Made: 
    1. Added Seed Data - Ended on page 140 (31Aug2020)
    2. Continued with Project (Added Pagination) 
    3. Started implementing navigation controls
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SportsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//Explanation of code: 
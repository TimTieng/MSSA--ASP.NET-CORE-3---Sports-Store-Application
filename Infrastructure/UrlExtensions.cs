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
    4. Adding Shopping Cart Feature
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
    }
}

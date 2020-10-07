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
    4. Adding Shopping Cart Feature and Session States
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace SportsStore.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null
            ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using EasyHttp.Http;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.Get("http://localhost:5656");

            Console.WriteLine();
            Console.WriteLine(response.RawText);
            Console.WriteLine();

            var encoding = "application/x-www-form-urlencoded";
            var data = new Dictionary<string, object>();
            client.Post("http://localhost:5656/nuget", data, encoding);

        }
    }
}

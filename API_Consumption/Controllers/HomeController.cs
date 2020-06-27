using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using API_Consumption.Models;

namespace API_Consumption.Controllers
{
    public class HomeController : Controller
    {
        string BASE_URL = "https://rss.itunes.apple.com/api/v1/us/ios-apps/top-free/all/100/explicit.json";
        string itunesData = "";

        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //Parks parks = null;
            Models.OuterJSON feed = null;

            client.BaseAddress = new Uri(BASE_URL);

            try
            {
                HttpResponseMessage response = client.GetAsync(BASE_URL).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    itunesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!itunesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    feed = JsonConvert.DeserializeObject<OuterJSON>(itunesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(feed);
        }
    }
}

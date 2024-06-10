﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Web_ASM_Nhom6.Models;

namespace Web_ASM_Nhom6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public string url = "http://localhost:29015/api/Menu";
        public string url2 = "http://localhost:29015/api/Restaurant";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lienhe()
        {
            return View();
        }
        public IActionResult Dangky()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Restaurant(int id)
        {
            Restaurant restaurant = new Restaurant();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync($"{url2}/{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    restaurant = JsonConvert.DeserializeObject<Restaurant>(apiResponse);
                }
            };
            return View(restaurant);
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Web_ASM_Nhom6.Models;

namespace Web_ASM_Nhom6.Controllers
{
    public class ProductController : Controller
    {
        private string url = "http://localhost:29015/api/Products";
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> categories = new List<Product>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:29015/api/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }

            return View(categories);
        }
    }
}

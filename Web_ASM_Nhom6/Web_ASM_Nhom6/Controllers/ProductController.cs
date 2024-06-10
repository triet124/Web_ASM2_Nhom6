using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Web_ASM_Nhom6.Models;


namespace Web_ASM_Nhom6.Controllers
{
    public class ProductController : Controller
    {

        //
        private string url = "http://localhost:29015/api/Product";
        //
        private string urlmenu = "http://localhost:29015/api/Menu";
        private string urlrestaurant = "http://localhost:29015/api/Restaurant";


        [HttpGet]
        public async Task<IActionResult> Index(string search, decimal? minPrice, decimal? maxPrice, string city)
        {
            List<Product> products = new List<Product>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }

            // Filter by search keyword
            if (!string.IsNullOrEmpty(search))
            {
                foreach (var keyword in search.Split(' '))
                {
                    products = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
                }
            }

            // Filter by price range
            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value).ToList();
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value).ToList();
            }

            // Get distinct MenuIds from the list of products
            var menuIds = products.Select(p => p.MenuId).Distinct().ToList();

            // Fetch Menu information based on MenuIds
            List<Menu> menus = new List<Menu>();

            using (var httpClient = new HttpClient())
            {
                foreach (var menuId in menuIds)
                {
                    var menuResponse = await httpClient.GetAsync($"{urlmenu}/{menuId}");
                    string menuApiResponse = await menuResponse.Content.ReadAsStringAsync();
                    var menu = JsonConvert.DeserializeObject<Menu>(menuApiResponse);
                    menus.Add(menu);
                }
            }

            // Get distinct RestaurantIds from the list of menus
            var restaurantIds = menus.Select(m => m.RestaurantId).Distinct().ToList();

            // Fetch Restaurant information based on RestaurantIds
            List<Restaurant> restaurants = new List<Restaurant>();

            using (var httpClient = new HttpClient())
            {
                foreach (var restaurantId in restaurantIds)
                {
                    var restaurantResponse = await httpClient.GetAsync($"{urlrestaurant}/{restaurantId}");
                    string restaurantApiResponse = await restaurantResponse.Content.ReadAsStringAsync();
                    var restaurant = JsonConvert.DeserializeObject<Restaurant>(restaurantApiResponse);
                    restaurants.Add(restaurant);
                }
            }

            // Add city and address information to the products
            foreach (var product in products)
            {
                var menu = menus.FirstOrDefault(m => m.MenuId == product.MenuId);
                if (menu != null)
                {
                    var restaurant = restaurants.FirstOrDefault(r => r.RestaurantId == menu.RestaurantId);
                    if (restaurant != null)
                    {
                        var a  = restaurants.FirstOrDefault(r => r.RestaurantId == menu.RestaurantId);
                        if (restaurant != null)
                        {

                        }
                    }
                }
            }

            return View(products);
        }



        [HttpGet("id")]
        public async Task<IActionResult> GetIDMenuOfProduct(int id)
        {
            List<Product> products = new List<Product>();


            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);


            string apiResponse = await response.Content.ReadAsStringAsync();

            products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);



            var result = new List<Product>();

            foreach (var item in products)
            {
                if (item.MenuId == id)
                {
                    result.Add(item);
                }
            }

            return View(result);
        }



        //Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }





        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product),
                    Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(url, content))
                {
                    string apiRes = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiRes);
                }
            }

            return RedirectToAction("Index");
        }






        //[HttpPost]
        //public async Task<IActionResult> Add(Product product)
        //{
        //    Product products = new Product();

        //    using (var httpClient = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(product),
        //            Encoding.UTF8, "application/json");
        //        using (var response = await httpClient.PostAsync(url, content))
        //        {
        //            string apiRes = await response.Content.ReadAsStringAsync();
        //            products = JsonConvert.DeserializeObject<Product>(apiRes);
        //        }
        //    }
        //    return RedirectToAction("Index");
        //}



        //Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Product products = new Product();
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{url}/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "API Error: " + response.ReasonPhrase);
                    return View("Index", new List<Category>());
                }
            }
            return View(products);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{url}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "API Error: " + response.ReasonPhrase);
                    return View("Delete", new Product { ProductId = id });
                }
            }
        }

        //Update
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product products = new Product();
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{url}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "API Error: " + response.ReasonPhrase);
                    return View("Index", new List<Product>());
                }
            }
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product),
                    Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync($"{url}/{product.ProductId}", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "API Error: " + response.ReasonPhrase);
                    return View(product);
                }
            }
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}


    }
}

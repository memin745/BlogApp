using BlogApp.BusinessLayer.Concrete;
using BlogApp.EntitityLayer.Entities;
using BlogAppWebUI.Dtos.ArticleDtos;
using BlogAppWebUI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;

namespace BlogAppWebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClient;

        public ArticleController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task< IActionResult> Index()
        {
            var client = _httpClient.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7147/api/Article");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultArticleDto>>(JsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateArticle()
        {
            var client = _httpClient.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7147/api/Category");
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            List<SelectListItem> values2 =(from item in values
                                           select new SelectListItem
                                           {
                                               Text=item.CategoryName,
                                               Value=item.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v=values2;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleDto createArticleDto)
       {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            
            var status = createArticleDto.ArticleStatus = true;
            var time = createArticleDto.ActicleTime = DateTime.Now;
            var category=createArticleDto.Categories.FirstOrDefault();
            var client = _httpClient.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createArticleDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7147/api/Article", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var client = _httpClient.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7147/api/Article/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var articleDetails = JsonConvert.DeserializeObject<ResultArticleDto>(jsonData);

                return View(articleDetails);  // Buradaki değişiklik
            }

            return NotFound();
        }


    }
}

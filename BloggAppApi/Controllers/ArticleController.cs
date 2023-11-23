using BlogApp.BusinessLayer.Abstract;
using BlogApp.DtoLayer.ArticleDto;
using BlogApp.EntitityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public IActionResult ArticleList()
        {
            var values = _articleService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateArticle(CreateArticleDto createArticleDto)
        {
            Article article = new Article()
            {
                ActicleName = createArticleDto.ActicleName,
                ActicleTime = createArticleDto.ActicleTime,
                ArticleContent = createArticleDto.ArticleContent,
                ArticleImage = createArticleDto.ArticleImage,
                ArticleTitle = createArticleDto.ArticleTitle,
                ArticleStatus = createArticleDto.ArticleStatus,
                Categories = createArticleDto.Categories,
                Comments = createArticleDto.Comments,
                User = createArticleDto.User,
                UserID = createArticleDto.UserID,
                
            };
            _articleService.TAdd(article);
            return Ok("Makale Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var value = _articleService.TGetById(id);
            _articleService.TDelete(value);
            return Ok("Makale Başarılı Bir Şekilde Silindi");

        }
        [HttpPut]
        public IActionResult UpdateArticle(UpdateArticleDto updateArticleDto)
        {
            Article article = new Article()
            {
                ActicleName = updateArticleDto.ActicleName,
                ActicleTime = updateArticleDto.ActicleTime,
                ArticleContent = updateArticleDto.ArticleContent,
                ArticleImage = updateArticleDto.ArticleImage,
                ArticleTitle = updateArticleDto.ArticleTitle,
                ArticleStatus = updateArticleDto.ArticleStatus,
                Categories = updateArticleDto.Categories,
                Comments = updateArticleDto.Comments,
                User = updateArticleDto.User,
                UserID = updateArticleDto.UserID,
                ArticleID=updateArticleDto.ArticleID

            };
            _articleService.TUpdate(article);
            return Ok("Makale Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var value = _articleService.TGetById(id);
            return Ok(value);
        }

    }
}

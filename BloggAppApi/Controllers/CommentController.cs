using BlogApp.BusinessLayer.Abstract;
using BlogApp.DtoLayer.CategoryDto;
using BlogApp.DtoLayer.CommentDto;
using BlogApp.EntitityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(CreateCommentDto createCommentDto)
        {
            Comment comment = new Comment()
            {   
                Article=createCommentDto.Article,
                ArticleID=createCommentDto.ArticleID,
                CommentContent=createCommentDto.CommentContent,
                CommentTime=createCommentDto.CommentTime,
                UserID=createCommentDto.UserID,
                User = createCommentDto.User
            };
            _commentService.TAdd(comment);
            return Ok("Yorum Başaralı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public IActionResult CommentCategory(int id)
        {
            var value = _commentService.TGetById(id);
            _commentService.TDelete(value);
            return Ok("Yorum Başaralı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public IActionResult CommentCategory(UpdateCommentDto updateCommentDto)
        {
            Comment comment = new Comment()
            {
                Article = updateCommentDto.Article,
                ArticleID = updateCommentDto.ArticleID,
                CommentContent = updateCommentDto.CommentContent,
                CommentTime = updateCommentDto.CommentTime,
                UserID = updateCommentDto.UserID,
                User = updateCommentDto.User,
                CommentID=updateCommentDto.CommentID
                
            };
            _commentService.TUpdate(comment);
            return Ok("Yorum Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("GetComment")]
        public IActionResult GetComment(int id)
        {
            var value = _commentService.TGetById(id);
            return Ok(value);
        }
    }
}

using BlogApp.BusinessLayer.Abstract;
using BlogApp.DtoLayer.ArticleDto;
using BlogApp.DtoLayer.UserDto;
using BlogApp.EntitityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserService _userService;

        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto createUserDto)
        {
            User user = new User()
            {
                UserName = createUserDto.UserName,
                UserEmail=createUserDto.UserEmail,
                UserPassword = createUserDto.UserPassword,
            };

            _userService.TAdd(user);
            return Ok("Makale Başarılı Bir Şekilde Eklendi");
        }
    }
}

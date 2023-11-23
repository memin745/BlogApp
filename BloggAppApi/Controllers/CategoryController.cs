using AutoMapper;
using BlogApp.BusinessLayer.Abstract;
using BlogApp.DtoLayer.CategoryDto;
using BlogApp.EntitityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServise _categoryServise;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryServise categoryServise, IMapper mapper)
        {
            _categoryServise = categoryServise;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryServise.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCateforyDto createCateforyDto)
        {
            _categoryServise.TAdd(new Category()
            {
                Articles=createCateforyDto.Articles,
                CategoryName=createCateforyDto.CategoryName,
            });
           
            return Ok("Kategori Başaralı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value=_categoryServise.TGetById(id);
            _categoryServise.TDelete(value);
            return Ok("Category Başaralı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                Articles = updateCategoryDto.Articles,
                CategoryID=updateCategoryDto.CategoryID,

            };
            _categoryServise.TUpdate(category);
            return Ok("CAtegory Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value=_categoryServise.TGetById(id) ;
            return Ok(value);
        }

    }
}

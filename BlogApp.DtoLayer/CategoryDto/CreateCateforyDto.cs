using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DtoLayer.CategoryDto
{
    public class CreateCateforyDto
    {
        public string? CategoryName { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}

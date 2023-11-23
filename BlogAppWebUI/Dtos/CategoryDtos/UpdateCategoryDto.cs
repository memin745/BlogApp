using BlogApp.EntitityLayer.Entities;

namespace BlogAppWebUI.Dtos.CategoryDtos
{
	public class UpdateCategoryDto
	{
		public int CategoryID { get; set; }
		public string? CategoryName { get; set; }
		public List<Article> Articles { get; set; } = new List<Article>();
	}
}

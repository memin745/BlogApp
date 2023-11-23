using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DtoLayer.ArticleDto
{
    public class UpdateArticleDto
    {
        public int ArticleID { get; set; }
        public string? ActicleName { get; set; }
        public string? ArticleTitle { get; set; }
        public string? ArticleContent { get; set; }
        public string? ArticleImage { get; set; }
        public bool? ArticleStatus { get; set; }
        public DateTime ActicleTime { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } = null!;
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.EntitityLayer.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string? CommentContent { get; set; }
        public DateTime CommentTime { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set; } = null!;
        public int? UserID { get; set; }
        public User User { get; set; } = null!;
    }
}

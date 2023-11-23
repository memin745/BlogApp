using BlogApp.DataAccesLayer.Abstract;
using BlogApp.DataAccesLayer.Concrete;
using BlogApp.DataAccesLayer.Repositories;
using BlogApp.EntitityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DataAccesLayer.EntitityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BloggAppContext context) : base(context)
        {
        }

        public List<Article> GetArticleWithCategories()
        {
            var context= new BloggAppContext();
            var values=context.Articles.Include(x => x.Categories).ToList();
            return values;
        }
    }
}

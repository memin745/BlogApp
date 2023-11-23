using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BusinessLayer.Abstract
{
    public interface IArticleService:IGenericServise<Article>
    {
        List<Article> TGetArticleWithCategories();

    }
}

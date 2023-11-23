using BlogApp.BusinessLayer.Abstract;
using BlogApp.DataAccesLayer.Abstract;
using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TAdd(Article entity)
        {
            _articleDal.Add(entity);
        }

        public void TDelete(Article entity)
        {
            _articleDal.Delete(entity);
        }

        public List<Article> TGetArticleWithCategories()
        {
            return _articleDal.GetArticleWithCategories();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetListAll()
        {
            return _articleDal.GetListAll();
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}

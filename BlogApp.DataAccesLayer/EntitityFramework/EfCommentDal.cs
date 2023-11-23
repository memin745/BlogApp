using BlogApp.DataAccesLayer.Abstract;
using BlogApp.DataAccesLayer.Concrete;
using BlogApp.DataAccesLayer.Repositories;
using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DataAccesLayer.EntitityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BloggAppContext context) : base(context)
        {
        }
    }
}

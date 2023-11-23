using AutoMapper;
using BlogApp.DtoLayer.ArticleDto;
using BlogApp.EntitityLayer.Entities;

namespace BloggAppApi.Mapping
{
    public class ArticleMapping:Profile
    {
        public ArticleMapping()
        {
            CreateMap<Article,ResultArticleDto>().ReverseMap();
            CreateMap<Article,CreateArticleDto>().ReverseMap();
            CreateMap<Article,GetArticleDto>().ReverseMap();
            CreateMap<Article,UpdateArticleDto>().ReverseMap();
        }
    }
}

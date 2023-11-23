using AutoMapper;
using BlogApp.DtoLayer.CommentDto;
using BlogApp.EntitityLayer.Entities;

namespace BloggAppApi.Mapping
{
    public class CommentMapping:Profile
    {
        public CommentMapping()
        {
            CreateMap<Comment,ResultCommentDto>().ReverseMap();
            CreateMap<Comment,CreateCommentDto>().ReverseMap();
            CreateMap<Comment,GetCommentDto>().ReverseMap();
            CreateMap<Comment,UpdateCommentDto>().ReverseMap();
        }
    }
}

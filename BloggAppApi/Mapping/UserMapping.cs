using AutoMapper;
using BlogApp.DtoLayer.UserDto;
using BlogApp.EntitityLayer.Entities;

namespace BloggAppApi.Mapping
{
    public class UserMapping:Profile
    {
        public UserMapping()
        {
            CreateMap<User,ResultUserDto>().ReverseMap();
            CreateMap<User,CreateUserDto>().ReverseMap();
            CreateMap<User,GetUserDto>().ReverseMap();
            CreateMap<User,UpdateUserDto>().ReverseMap();
        }
    }
}

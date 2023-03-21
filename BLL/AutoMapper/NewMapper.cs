using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DTO.UserDto;
using Entities;

namespace BLL.AutoMapper
{
    public class NewMapper:Profile
    {
        public NewMapper()
        {
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>().ReverseMap();

            CreateMap<User,UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();

            CreateMap<User,UserToListDto>().ReverseMap();
        }
    }
}

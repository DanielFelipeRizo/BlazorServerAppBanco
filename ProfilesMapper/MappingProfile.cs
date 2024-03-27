using AutoMapper;
using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.ModelsDTO;

namespace BlazorServerAppBanco.ProfilesMapper
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<SecUser, SecUserDTO>().ReverseMap();
        }
    }
}

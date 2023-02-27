using AutoMapper;
using EntityFrameworkApi.Dtos;
using EntityFrameworkApi.Entities;

namespace EntityFrameworkApi.Profiles
{
    public class EntityFrameworkProfiles:Profile
    {

      public EntityFrameworkProfiles()
        {
            CreateMap<Developers, DevelopersDto>().ReverseMap();
        }


    }
}

using Api.Dtos;
using Api.Models;
using AutoMapper;

namespace Api.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rol, RolDto>();
            CreateMap<RolDto, Rol>();
        }
    }
}

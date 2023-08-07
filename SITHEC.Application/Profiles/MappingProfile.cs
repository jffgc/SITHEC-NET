using AutoMapper;
using SITHEC.Application.Dtos.Human;
using SITHEC.Domain;

namespace SITHEC.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Human, HumanListDto>().ReverseMap();
            CreateMap<Human, HumanDetailDto>().ReverseMap();
            CreateMap<Human, CreateHumanDto>().ReverseMap();
            CreateMap<Human, UpdateHumanDto>().ReverseMap();
        }
    }
}

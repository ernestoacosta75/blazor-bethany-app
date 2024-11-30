using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopH.Application.Services.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                .ReverseMap();

            CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CountryId))
                .ReverseMap();

            CreateMap<TimeRegistration, TimeRegistrationDto>()
                .ReverseMap();
        }
    }
}

using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopH.Application.Services.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}

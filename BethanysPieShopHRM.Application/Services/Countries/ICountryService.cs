using BethanysPieShopHRM.Application.Dtos;

namespace BethanysPieShopHRM.Application.Services.Countries
{
    public interface ICountryService
    {
        Task<CountryDto?> AddCountry(CountryDto countryDto);
        Task<CountryDto?> UpdateCountry(CountryDto countryDto);
        Task RemoveCountry(int countryId);
        Task<CountryDto?> GetCountryById(int countryId);
        Task<IEnumerable<CountryDto>> GetAllCountries();
    }
}

using BethanysPieShopHRM.Application.Dtos;

namespace BethanysPieShopHRM.Application.Services.Countries
{
    public interface ICountryService
    {
        void AddCountry(CountryDto countryDto);
        Task UpdateCountry(CountryDto countryDto);
        Task RemoveCountry(CountryDto countryDto);
        Task<CountryDto?> GetCountryById(int countryId);
        Task<IEnumerable<CountryDto>> GetAllCountries();
    }
}

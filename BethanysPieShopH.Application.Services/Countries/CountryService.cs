using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Countries;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopH.Application.Services.Countries
{
    public class CountryService : ICountryService
    {

        private readonly IRepository<Country> _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(IRepository<Country> countryRepository, IMapper mapper)
        {
            ArgumentNullException.ThrowIfNull(countryRepository);
            ArgumentNullException.ThrowIfNull(mapper);

            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<CountryDto?> AddCountry(CountryDto countryDto)
        {
            ArgumentNullException.ThrowIfNull(countryDto);
            var country = await _countryRepository.Add(_mapper.Map<Country>(countryDto));

            return _mapper.Map<CountryDto>(country);
        }

        public async Task<CountryDto?> UpdateCountry(CountryDto countryDto)
        {
            ArgumentNullException.ThrowIfNull(countryDto);

            var country = _countryRepository.Update(countryDto?.Id, _mapper.Map<Country>(countryDto));

            return _mapper.Map<CountryDto>(country);
        }

        public async Task RemoveCountry(int countryId)
        {
            ArgumentNullException.ThrowIfNull(countryId);
            await _countryRepository.Delete(countryId);
        }

        public async Task<CountryDto?> GetCountryById(int countryId)
        {
            ArgumentNullException.ThrowIfNull(countryId);
            var country = await _countryRepository.GetById(countryId);
            return _mapper.Map<CountryDto>(country);
        }

        public async Task<IEnumerable<CountryDto>> GetAllCountries()
        {
            var countries = _countryRepository.GetAll();
            return await _mapper.ProjectTo<CountryDto>(countries)
                .OrderBy(_ => _.Id)
                .ToListAsync();
        }
    }
}

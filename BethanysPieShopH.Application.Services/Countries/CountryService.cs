﻿using AutoMapper;
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
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public void AddCountry(CountryDto countryDto)
        {
            _countryRepository.Add(_mapper.Map<Country>(countryDto));
        }

        public async Task UpdateCountry(CountryDto countryDto)
        {
            var existingCountry = await _countryRepository.GetById(countryDto.Id);

            if (existingCountry != null)
            {
                _mapper.Map(countryDto, existingCountry);
                _countryRepository.Update(existingCountry);
            }
        }

        public async Task RemoveCountry(CountryDto countryDto)
        {
            var countryToDelete = await _countryRepository.GetById(countryDto.Id);

            if (countryToDelete != null)
            {
                _countryRepository.Delete(countryToDelete);
            }
        }

        public async Task<CountryDto?> GetCountryById(int countryId)
        {
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
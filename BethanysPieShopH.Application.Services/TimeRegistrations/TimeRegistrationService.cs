using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopH.Application.Services.TimeRegistrations
{
    public class TimeRegistrationService : ITimeRegistrationService
    {
        private readonly ITimeRegistrationRepository<TimeRegistration> _timeRegistrationRepository;
        private readonly IMapper _mapper;

        public TimeRegistrationService(ITimeRegistrationRepository<TimeRegistration> timeRegistrationRepository,
            IMapper mapper)
        {
            ArgumentNullException.ThrowIfNull(timeRegistrationRepository);
            ArgumentNullException.ThrowIfNull(mapper);

            _timeRegistrationRepository = timeRegistrationRepository;
            _mapper = mapper;
        }
        public async Task<List<TimeRegistrationDto>> GetTimeRegistrationsForEmployee(int employeeId)
        {
            var timeRegistrations = _timeRegistrationRepository
                .GetTimeRegistrationForEmployee(employeeId);

            return await _mapper.ProjectTo<TimeRegistrationDto>(timeRegistrations)
                .OrderBy(_ => _.StartTime)
                .ToListAsync();
        }

        public async Task<List<TimeRegistrationDto>> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start)
        {
            var timeRegistrations = _timeRegistrationRepository
                .GetPagedTimeRegistrationForEmployee(employeeId, pageSize, start);

            return await _mapper.ProjectTo<TimeRegistrationDto>(timeRegistrations)
                .OrderBy(_ => _.StartTime)
                .ToListAsync();
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _timeRegistrationRepository
                .GetTimeRegistrationCountForEmployeeId(employeeId);
        }
    }
}

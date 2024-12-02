using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Cache;
using BethanysPieShopHRM.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;

namespace BethanysPieShopH.Application.Services.TimeRegistrations
{
    public class TimeRegistrationService : ITimeRegistrationService
    {
        private readonly ITimeRegistrationRepository<TimeRegistration> _timeRegistrationRepository;
        private readonly IMapper _mapper;
        private readonly ICacheService _cacheService;

        public TimeRegistrationService(ITimeRegistrationRepository<TimeRegistration> timeRegistrationRepository,
            IMapper mapper, ICacheService cacheService)
        {
            ArgumentNullException.ThrowIfNull(timeRegistrationRepository);
            ArgumentNullException.ThrowIfNull(mapper);
            ArgumentNullException.ThrowIfNull(cacheService);

            _timeRegistrationRepository = timeRegistrationRepository;
            _mapper = mapper;
            _cacheService = cacheService;
        }
        public async Task<List<TimeRegistrationDto>> GetTimeRegistrationsForEmployee(int employeeId)
        {
            string cacheKey = $"TimeRegistrations_{employeeId}";

            if (!_cacheService.TryGet(cacheKey, out List<TimeRegistrationDto> timeRegistrations))
            {
                var timeRegistrationsEntities = await _timeRegistrationRepository
                    .GetTimeRegistrationForEmployee(employeeId);

                timeRegistrations = _mapper
                    .Map<List<TimeRegistrationDto>>(timeRegistrationsEntities.OrderBy(_ => _.StartTime))
                    .Select(_ => new TimeRegistrationDto
                    {
                        TimeRegistrationId = _.TimeRegistrationId,
                        StartTime = _.StartTime,
                        EndTime = _.EndTime,
                        PerformedTaskDescription = _.PerformedTaskDescription,
                    })
                    .ToList();

                _cacheService.Set(cacheKey, timeRegistrations, TimeSpan.FromMinutes(10));
            }
                

            return timeRegistrations;
        }

        public async Task<List<TimeRegistrationDto>> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start)
        {
            string cacheKey = $"TimeRegistrations_{employeeId}_{pageSize}_{start}";

            if (!_cacheService.TryGet(cacheKey, out List<TimeRegistrationDto> timeRegistrations))
            {
                var timeRegistrationsEntities = await _timeRegistrationRepository
                .GetPagedTimeRegistrationForEmployee(employeeId, pageSize, start);

                timeRegistrations = _mapper
                .Map<List<TimeRegistrationDto>>(timeRegistrationsEntities.OrderBy(_ => _.StartTime))
                .Select(_ => new TimeRegistrationDto
                {
                    TimeRegistrationId = _.TimeRegistrationId,
                    StartTime = _.StartTime,
                    EndTime = _.EndTime,
                    PerformedTaskDescription = _.PerformedTaskDescription,
                })
                .ToList();

                _cacheService.Set(cacheKey, timeRegistrations, TimeSpan.FromMinutes(10));
            }
                
            return timeRegistrations;
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _timeRegistrationRepository
                .GetTimeRegistrationCountForEmployeeId(employeeId);
        }
    }
}

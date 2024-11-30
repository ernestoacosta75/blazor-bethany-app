using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Application.Services.TimeRegistrations
{
    public interface ITimeRegistrationService
    {
        Task<List<TimeRegistrationDto>> GetTimeRegistrationsForEmployee(int employeeId);
        Task<List<TimeRegistrationDto>> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start);
        Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
    }
}

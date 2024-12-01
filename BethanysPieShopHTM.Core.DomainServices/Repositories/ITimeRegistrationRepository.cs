using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHTM.Core.DomainServices.Repositories
{
    public interface ITimeRegistrationRepository<TEntity> where TEntity : class
    {
        Task<List<TimeRegistration>> GetTimeRegistrationForEmployee(int employeeId);
        Task<List<TimeRegistration>> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start);
        Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
    }
}

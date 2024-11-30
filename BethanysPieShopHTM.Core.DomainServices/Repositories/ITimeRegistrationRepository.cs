using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHTM.Core.DomainServices.Repositories
{
    public interface ITimeRegistrationRepository<TEntity> where TEntity : class
    {
        IQueryable<TimeRegistration> GetTimeRegistrationForEmployee(int employeeId);
        IQueryable<TimeRegistration> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start);
        Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
    }
}

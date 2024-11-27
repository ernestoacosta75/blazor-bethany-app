using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHTM.Core.DomainServices.Repositories
{
    public interface ITimeRegistrationRepository<TEntity> where TEntity : class
    {
        Task<List<TimeRegistration>> GetTimeRegistrationForEmployee(int employeeId);
    }
}

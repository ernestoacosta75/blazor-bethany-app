using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.DatabaseContext;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Infrastructure.Repositories
{
    public class TimeRegistrationRepository : Repository<TimeRegistration>, ITimeRegistrationRepository<TimeRegistration>
    {
        private readonly AppDbContext _appDbContext;

        public TimeRegistrationRepository(IDbContextFactory<AppDbContext> dbContextFactory) : base(dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }

        public IQueryable<TimeRegistration> GetTimeRegistrationForEmployee(int employeeId)
        {
            return _appDbContext.TimeRegistrations
                .Where(_ => _.EmployeeId == employeeId)
                .OrderBy(_ => _.StartTime);
        }

        public IQueryable<TimeRegistration> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start)
        {
            return _appDbContext.TimeRegistrations
                .Where(_ => _.EmployeeId == employeeId)
                .OrderBy(_ => _.StartTime)
                .Skip(start)
                .Take(pageSize);
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _appDbContext.TimeRegistrations
                .Where(_ => _.EmployeeId == employeeId)
                .CountAsync();
        }
    }
}

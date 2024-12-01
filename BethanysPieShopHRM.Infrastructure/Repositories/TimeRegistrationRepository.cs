using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.DatabaseContext;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BethanysPieShopHRM.Infrastructure.Repositories
{
    public class TimeRegistrationRepository : Repository<TimeRegistration>, ITimeRegistrationRepository<TimeRegistration>
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public TimeRegistrationRepository(IDbContextFactory<AppDbContext> dbContextFactory) : base(dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<TimeRegistration>> GetTimeRegistrationForEmployee(int employeeId)
        {
            return await _dbContextFactory.CreateDbContext().TimeRegistrations
                .Where(_ => _.EmployeeId == employeeId)
                .OrderBy(_ => _.StartTime)
                .ToListAsync();
        }

        public async Task<List<TimeRegistration>> GetPagedTimeRegistrationForEmployee(
            int employeeId, int pageSize, int start)
        {
            return await _dbContextFactory.CreateDbContext().TimeRegistrations
                .AsNoTracking()
                .Where(_ => _.EmployeeId == employeeId)
                .OrderBy(_ => _.StartTime)
                .Skip(start)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _dbContextFactory.CreateDbContext().TimeRegistrations
                .Where(_ => _.EmployeeId == employeeId)
                .CountAsync();
        }
    }
}

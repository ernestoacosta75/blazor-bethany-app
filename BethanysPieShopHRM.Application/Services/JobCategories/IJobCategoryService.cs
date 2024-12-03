using BethanysPieShopHRM.Application.Dtos;

namespace BethanysPieShopHRM.Application.Services.JobCategories
{
    public interface IJobCategoryService
    {
        Task<JobCategoryDto?> AddJobCategory(JobCategoryDto jobCategoryDto);
        Task<JobCategoryDto?> UpdateJobCategory(JobCategoryDto jobCategoryDto);
        Task RemoveJobCategory(int jobCategoryId);
        Task<JobCategoryDto?> GetJobCategoryById(int jobCategoryId);
        Task<IEnumerable<JobCategoryDto>> GetAllJobCategories();
    }
}

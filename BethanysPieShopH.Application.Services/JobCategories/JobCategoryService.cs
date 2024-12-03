using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.JobCategories;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopH.Application.Services.JobCategories
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly IRepository<JobCategory> _jobCategoryRepository;
        private readonly IMapper _mapper;

        public JobCategoryService(IRepository<JobCategory> jobCategoryRepository, IMapper mapper)
        {
            ArgumentNullException.ThrowIfNull(jobCategoryRepository);
            ArgumentNullException.ThrowIfNull(mapper);

            _jobCategoryRepository = jobCategoryRepository;
            _mapper = mapper;
        }

        public async Task<JobCategoryDto?> AddJobCategory(JobCategoryDto jobCategoryDto)
        {
            ArgumentNullException.ThrowIfNull(jobCategoryDto);
            var jobCategory = await _jobCategoryRepository.Add(_mapper.Map<JobCategory>(jobCategoryDto));

            return _mapper.Map<JobCategoryDto>(jobCategory);
        }

        public async Task<JobCategoryDto?> UpdateJobCategory(JobCategoryDto jobCategoryDto)
        {
            ArgumentNullException.ThrowIfNull(jobCategoryDto);

            var jobCategory = _jobCategoryRepository.Update(jobCategoryDto?.JobCategoryId, _mapper.Map<JobCategory>(jobCategoryDto));

            return _mapper.Map<JobCategoryDto>(jobCategory);
        }

        public async Task RemoveJobCategory(int jobCategoryId)
        {
            ArgumentNullException.ThrowIfNull(jobCategoryId);
            await _jobCategoryRepository.Delete(jobCategoryId);
        }

        public async Task<JobCategoryDto?> GetJobCategoryById(int jobCategoryId)
        {
            ArgumentNullException.ThrowIfNull(jobCategoryId);
            var jobCategory = await _jobCategoryRepository.GetById(jobCategoryId);
            return _mapper.Map<JobCategoryDto>(jobCategory);
        }

        public async Task<IEnumerable<JobCategoryDto>> GetAllJobCategories()
        {
            var jobCategories = _jobCategoryRepository.GetAll();
            return await _mapper.ProjectTo<JobCategoryDto>(jobCategories)
                .OrderBy(_ => _.JobCategoryId)
                .ToListAsync();
        }
    }
}

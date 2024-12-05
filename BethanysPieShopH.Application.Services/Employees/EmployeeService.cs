using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BethanysPieShopH.Application.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeService(IRepository<Employee> employeeRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            ArgumentNullException.ThrowIfNull(employeeRepository);
            ArgumentNullException.ThrowIfNull(mapper);
            ArgumentNullException.ThrowIfNull(webHostEnvironment);
            ArgumentNullException.ThrowIfNull(httpContextAccessor);

            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<EmployeeDto?> AddEmployee(EmployeeDto employeeDto)
        {
            ArgumentNullException.ThrowIfNull(employeeDto);
            var employee =  await _employeeRepository.Add(_mapper.Map<Employee>(employeeDto));
            
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto?> UpdateEmployee(EmployeeDto employeeDto)
        {
            ArgumentNullException.ThrowIfNull(employeeDto);

            if (employeeDto.ImageContent is not null)
            {
                string currentUrl = _httpContextAccessor.HttpContext.Request.Host.Value;
                var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{employeeDto.ImageName}";
                var fileStream = System.IO.File.Create(path);

                fileStream.Write(employeeDto.ImageContent, 0, employeeDto.ImageContent.Length);
                fileStream.Close();

                employeeDto.ImageName = $"https://{currentUrl}/uploads/{employeeDto.ImageName}";
            }

            var empMapped = _mapper.Map<Employee>(employeeDto);
            var employee = await _employeeRepository.Update(employeeDto?.Id, empMapped);

            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task RemoveEmployee(int employeeId)
        {
            ArgumentNullException.ThrowIfNull(employeeId);
            await _employeeRepository.Delete(employeeId);
        }

        public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            ArgumentNullException.ThrowIfNull(employeeId);
            var employee = await _employeeRepository.GetById(employeeId);
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAll();
            return await _mapper.ProjectTo<EmployeeDto>(employees)
                .OrderBy(_ => _.Id)
                .ToListAsync();
        }
    }
}

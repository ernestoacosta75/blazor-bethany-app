using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopH.Application.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            ArgumentNullException.ThrowIfNull(employeeRepository);
            ArgumentNullException.ThrowIfNull(mapper);

            _employeeRepository = employeeRepository;
            _mapper = mapper;
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

            var empMapped = _mapper.Map<Employee>(employeeDto);
            var employee = _employeeRepository.Update(employeeDto?.Id, empMapped);

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

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
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            _employeeRepository.Add(_mapper.Map<Employee>(employeeDto));
        }

        public async Task UpdateEmployee(EmployeeDto employeeDto)
        {
            var existingEmployee = await _employeeRepository.GetById(employeeDto.Id);

            if (existingEmployee != null)
            {
                _mapper.Map(employeeDto, existingEmployee);
                _employeeRepository.Update(existingEmployee);
            }
        }

        public async Task RemoveEmployee(EmployeeDto employeeDto)
        {
            var employeeToDelete = await _employeeRepository.GetById(employeeDto.Id);

            if (employeeToDelete != null)
            {
                _employeeRepository.Delete(employeeToDelete);
            }
        }

        public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
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

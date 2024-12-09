using System.Text.Json;
using AutoMapper;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Client.Services
{
    public class ClientEmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public ClientEmployeeService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }
        public async Task<EmployeeDto?> AddEmployee(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDto?> UpdateEmployee(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployees()
        {
            var list = await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDto>>
            (await _httpClient.GetStreamAsync("/api/employees"),
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

            return list;
        }
    }
}

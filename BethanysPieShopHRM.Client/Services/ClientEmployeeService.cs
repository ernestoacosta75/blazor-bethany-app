using System.Text.Json;
using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Shared;
using Blazored.LocalStorage;

namespace BethanysPieShopHRM.Client.Services
{
    public class ClientEmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public ClientEmployeeService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            ArgumentNullException.ThrowIfNull(localStorageService);

            _httpClient = httpClient;
            _localStorageService = localStorageService;
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
            bool employeeExpirationExists = await _localStorageService.ContainKeyAsync(Constants.EmployeesListExpirationKey);

            if (employeeExpirationExists)
            {
                DateTime employeeListExpiration = await _localStorageService.GetItemAsync<DateTime>
                    (Constants.EmployeesListExpirationKey);

                if (employeeListExpiration > DateTime.Now)
                {
                    // Getting from local storage
                    if (await _localStorageService.ContainKeyAsync(Constants.EmployeesListKey))
                    {
                        return (await _localStorageService.GetItemAsync<IEnumerable<EmployeeDto>>(Constants.EmployeesListKey))!;
                    }
                }
            }

            var list = await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDto>>
            (await _httpClient.GetStreamAsync("/api/employees"),
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

            // storing the data in local storage
            await _localStorageService.SetItemAsync(Constants.EmployeesListKey, list);
            
            // storing expiration date of the data in the local storage
            await _localStorageService.SetItemAsync(Constants.EmployeesListExpirationKey, DateTime.Now.AddMinutes(1));

            return list;
        }
    }
}

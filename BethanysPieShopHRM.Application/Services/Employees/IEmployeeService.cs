using BethanysPieShopHRM.Application.Dtos;

namespace BethanysPieShopHRM.Application.Services.Employees
{
    public interface IEmployeeService
    {
        Task<EmployeeDto?> AddEmployee(EmployeeDto employeeDto);
        Task<EmployeeDto?> UpdateEmployee(EmployeeDto employeeDto);
        Task RemoveEmployee(int employeeId);
        Task<EmployeeDto?> GetEmployeeById(int employeeId);
        Task<IEnumerable<EmployeeDto>> GetAllEmployees();
    }
}

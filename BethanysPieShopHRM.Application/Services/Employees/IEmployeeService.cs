using BethanysPieShopHRM.Application.Dtos;

namespace BethanysPieShopHRM.Application.Services.Employees
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeDto employeeDto);
        Task UpdateEmployee(EmployeeDto employeeDto);
        Task RemoveEmployee(EmployeeDto employeeDto);
        Task<EmployeeDto?> GetEmployeeById(int employeeId);
        Task<IEnumerable<EmployeeDto>> GetAllEmployees();
    }
}

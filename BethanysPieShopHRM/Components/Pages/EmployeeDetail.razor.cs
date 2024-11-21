using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public EmployeeDto Employee { get; set; } = new EmployeeDto();

        [Inject]
        public IEmployeeService? EmployeeService { get; set; }
        
        protected async override void OnInitialized()
        {
            Employee = await EmployeeService.GetEmployeeById(EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}

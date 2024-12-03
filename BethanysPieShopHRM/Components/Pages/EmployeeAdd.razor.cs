using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeAdd
    {
        [SupplyParameterFromForm]
        public EmployeeDto Employee { get; set; }

        protected string Message = string.Empty;
        protected bool IsSaved = false;

        [Inject]
        public IEmployeeService? EmployeeService { get; set; }

        protected override void OnInitialized()
        {
            Employee ??= new();
        }

        private async Task OnSubmit()
        {
            EmployeeService.AddEmployee(Employee);
            IsSaved = true;
            Message = "Employee added successfully";
        }
    }
}

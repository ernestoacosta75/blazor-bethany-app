using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Client.Pages
{
    public partial class EmployeeOverview
    {
        public List<EmployeeDto> Employees { get; set; } = default!;
        private EmployeeDto? _selectedEmployee;
        private string Title = "Employee overview";

        [Inject]
        public IEmployeeService? EmployeeService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(EmployeeDto selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}

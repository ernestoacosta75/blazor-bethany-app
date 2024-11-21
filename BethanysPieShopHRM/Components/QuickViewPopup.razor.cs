using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial  class QuickViewPopup
    {
        [Parameter]
        public EmployeeDto? Employee { get; set; }

        private EmployeeDto? _employee;    // To be used in the UI

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}

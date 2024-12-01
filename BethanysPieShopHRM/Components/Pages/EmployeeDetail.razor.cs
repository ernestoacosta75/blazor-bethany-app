﻿using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHTM.Core.DomainServices.DatabaseContext;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public EmployeeDto Employee { get; set; } = new EmployeeDto();
        public List<TimeRegistrationDto> TimeRegistrations { get; set; } = [];

        private float itemHeight = 50;

        [Inject]
        public IEmployeeService? EmployeeService { get; set; }

        [Inject]
        public ITimeRegistrationService? TimeRegistrationService { get; set; }
        
        protected override async Task OnParametersSetAsync()
        {
            if (EmployeeService is not null)
            {
                Employee = (await EmployeeService.GetEmployeeById(EmployeeId))!;
            }
        }


        public async ValueTask<ItemsProviderResult<TimeRegistrationDto>> LoadTimeRegistrations(
            ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await TimeRegistrationService.GetTimeRegistrationCountForEmployeeId(EmployeeId);

            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItems = await TimeRegistrationService.GetPagedTimeRegistrationForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

            return new ItemsProviderResult<TimeRegistrationDto>(listItems, totalNumberOfTimeRegistrations);
        }
        
        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}

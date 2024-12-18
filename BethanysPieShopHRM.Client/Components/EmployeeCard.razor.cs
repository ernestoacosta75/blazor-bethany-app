﻿using BethanysPieShopHRM.Application.Dtos;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Client.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public EmployeeDto Employee { get; set; } = default!;

        // Events
        [Parameter] 
        public EventCallback<EmployeeDto> EmployeeQuickViewClicked { get; set; }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("last name can't be empty");
            }
        }
    }
}

﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        // Events
        [Parameter] 
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}

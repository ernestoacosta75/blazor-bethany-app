﻿using BethanysPieShopHRM.Application.Dtos;
using BethanysPieShopHRM.Application.Services.Countries;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Application.Services.JobCategories;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeEdit
    {
        [Inject] 
        public IEmployeeService? EmployeeService { get; set; }
        
        [Inject] 
        public ICountryService? CountryService { get; set; }

        [Inject]
        public IJobCategoryService? JobCategoryService { get; set; }

        [Parameter] 
        public int EmployeeId { get; set; }

        [SupplyParameterFromForm] 
        public EmployeeDto Employee { get; set; } = new();

        public IEnumerable<CountryDto> Countries { get; set; } = [];
        public IEnumerable<JobCategoryDto> JobCategories { get; set; } = [];

        protected bool Saved = false;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Countries = (await CountryService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryService.GetAllJobCategories()).ToList();

            Employee = await EmployeeService.GetEmployeeById(EmployeeId);
        }

        protected async Task HandleValidSubmit()
        {
            //if (selectedFile != null)//take first image
            //{
            //    var file = selectedFile;
            //    Stream stream = file.OpenReadStream();
            //    MemoryStream ms = new();
            //    await stream.CopyToAsync(ms);
            //    stream.Close();

            //    Employee.ImageName = file.Name;
            //    Employee.ImageContent = ms.ToArray();
            //}

            await EmployeeService.UpdateEmployee(Employee);
            StatusClass = "alert-success";
            Message = "Employee updated successfully.";
            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";

        }
    }
}
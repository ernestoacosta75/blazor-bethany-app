﻿using BethanysPieShopHRM.Shared.Domain;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopHRM.Application.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? Street { get; set; }

        public string? Zip { get; set; }

        public string? City { get; set; }

        public int? CountryId { get; set; }

        public CountryDto? Country { get; set; }

        public string? PhoneNumber { get; set; }

        public bool Smoker { get; set; } = false;

        public MaritalStatus? MaritalStatus { get; set; }

        public Gender? Gender { get; set; }

        public bool IsOnHoliday { get; set; } = false;


        [StringLength(1000, ErrorMessage = "Comment length can't exceed 1000 characters.")]
        public string Comment { get; set; } = string.Empty;

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public int? JobCategoryId { get; set; }

        public JobCategory? JobCategory { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
        public byte[]? ImageContent { get; set; }
        public string? ImageName { get; set; }
    }
}

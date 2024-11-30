﻿namespace BethanysPieShopHRM.Application.Dtos
{
    public class TimeRegistrationDto
    {
        public int TimeRegistrationId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PerformedTaskDescription { get; set; } = string.Empty;
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BethanysPieShopHTM.Core.DomainServices.Migrations
{
    /// <inheritdoc />
    public partial class TimeRegistrationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeRegistrations",
                columns: new[] { "TimeRegistrationId", "EmployeeId", "EndTime", "PerformedTaskDescription", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 2, 13, 6, 22, 0, DateTimeKind.Unspecified), "Task 1", new DateTime(2024, 7, 1, 23, 42, 16, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 8, 11, 14, 38, 40, 0, DateTimeKind.Unspecified), "Task 2", new DateTime(2024, 1, 3, 22, 18, 59, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2);
        }
    }
}

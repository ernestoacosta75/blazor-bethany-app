using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShopHTM.Core.DomainServices.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeIdStartTimeIndexToTimeRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TimeRegistrations_EmployeeId",
                table: "TimeRegistrations");

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 19, 16, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 8, 44, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 17, 39, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 3, 12, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 23, 4, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 0, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 2, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 10, 21, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 22, 38, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 21, 6, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 4, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 20, 53, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 9, 6, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 14, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 11, 30, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 18, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 2, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 9, 32, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 18, 13, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 19, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 6, 18, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 45, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 10, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 21, 4, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 3, 6, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 3, 14, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 0, 58, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 11, 9, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 23, 33, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 19, 0, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 7, 31, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 11, 3, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 3, 41, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 28, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 20, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 8, 1, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 3, 53, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 11, 19, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 10, 6, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 18, 0, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 1, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 21, 11, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 3, 38, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 18, 7, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 50, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 23, 27, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 17, 17, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 4, 23, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 4, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 4, 1, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 21, 12, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 12, 2, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 4, 8, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 9, 32, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 1, 2, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 20, 30, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 4, 3, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 16, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 22, 23, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 23, 29, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 12, 59, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 6, 45, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 19, 6, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 17, 6, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 13, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 6, 7, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 2, 59, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 1, 33, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 2, 20, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 3, 28, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 5, 50, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 15, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 7, 42, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 3, 39, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 8, 33, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 0, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 1, 11, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 7, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 18, 22, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 21, 47, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 4, 51, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 6, 52, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 27, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 8, 14, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 14, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 7, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 23, 33, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 12, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 20, 6, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 8, 17, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 46, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 23, 14, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 18, 57, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 17, 37, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 20, 25, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 1, 31, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 2, 4, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 16, 54, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 6, 44, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 18, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 24, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 1, 24, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 41, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 3, 7, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 36, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 5, 30, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 33, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 11, 47, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 10, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 20, 46, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 23, 36, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 21, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 13, 16, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 15, 11, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 9, 18, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 11, 35, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 12, 38, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 4, 39, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 20, 34, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 18, 6, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 4, 43, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 3, 14, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 5, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 12, 26, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 6, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 2, 24, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 18, 10, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 11, 50, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 19, 48, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 31, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 10, 26, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 7, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 13, 42, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 12, 23, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 5, 21, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 20, 48, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 20, 50, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 4, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 7, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 20, 46, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 2, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 45, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 1, 43, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 21, 48, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 7, 0, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 21, 49, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 16, 54, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 5, 31, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 13, 32, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 6, 57, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 10, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 46, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 1, 34, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 2, 3, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 21, 42, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 7, 12, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 1, 57, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 3, 8, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 46, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 23, 56, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 20, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 11, 9, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 9, 2, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 18, 36, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 20, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 3, 24, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 13, 16, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 12, 36, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 38, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 31, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 38, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 14, 8, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 13, 55, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 0, 4, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 23, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 18, 17, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 19, 15, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 12, 38, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 36, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 10, 27, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 9, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 2, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 14, 47, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 20, 22, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 5, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 11, 52, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 3, 47, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 21, 49, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 5, 17, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 1, 53, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 54, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 10, 21, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 3, 10, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 23, 4, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 4, 48, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 6, 30, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 21, 30, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 5, 21, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 14, 1, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 21, 54, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 9, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 10, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 32, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 17, 40, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 8, 2, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 10, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 4, 55, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 17, 34, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 6, 3, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 10, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 14, 58, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 3, 9, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 21, 50, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 3, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 2, 41, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 32, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 1, 37, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 4, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 19, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 23, 18, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 9, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 13, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 10, 7, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 4, 48, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 17, 4, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 10, 2, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 20, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 22, 37, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 1, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 9, 59, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 1, 46, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 3, 37, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 23, 50, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 12, 34, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 7, 0, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 9, 44, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 7, 7, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 58, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 23, 58, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 13, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 7, 56, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 2, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 8, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 47, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 4, 19, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 31, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 14, 59, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 8, 38, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 10, 8, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 23, 42, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 22, 3, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 54, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 8, 51, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 8, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 6, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 3, 29, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 12, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 13, 16, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 4, 17, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 2, 38, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 0, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 22, 27, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 19, 13, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 18, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 9, 21, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 19, 34, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 0, 56, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 5, 46, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 7, 38, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 12, 50, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 5, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 10, 31, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 3, 32, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 3, 26, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 7, 10, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 14, 39, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 8, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 14, 4, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 10, 40, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 1, 31, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 54, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 20, 52, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 5, 6, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 23, 38, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 12, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 57, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 18, 45, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 8, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 23, 35, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 20, 20, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 9, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 19, 32, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 14, 31, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 20, 18, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 4, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 20, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 11, 16, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 6, 35, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 22, 46, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 14, 4, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 21, 40, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 3, 25, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 10, 14, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 13, 8, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 7, 12, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 22, 51, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 14, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 15, 55, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 23, 27, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 17, 56, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 12, 7, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 19, 59, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 19, 39, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 22, 36, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 18, 12, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 6, 41, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 17, 53, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 2, 38, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 19, 2, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 9, 7, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 11, 54, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 5, 11, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 1, 31, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 20, 33, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 6, 15, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 23, 14, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 21, 5, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 1, 55, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 15, 25, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 23, 27, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 1, 56, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 6, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 36, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 8, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 24, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 0, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 8, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 9, 43, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 22, 54, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 3, 58, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 7, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 13, 41, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 11, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 17, 12, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 34, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 4, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 15, 24, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 13, 40, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 8, 14, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 8, 30, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 10, 59, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 3, 50, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 12, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 4, 34, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 3, 55, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 18, 25, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 17, 48, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 3, 15, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 23, 9, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 21, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 21, 41, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 12, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 10, 13, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 17, 7, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 17, 32, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 19, 36, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 7, 40, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 13, 46, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 31, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 14, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 52, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 11, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 9, 27, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 19, 3, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 15, 13, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 14, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 18, 53, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 18, 21, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 5, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 4, 22, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 14, 27, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 11, 1, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 54, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 5, 21, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 14, 57, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 8, 23, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 19, 24, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 1, 6, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 18, 36, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 8, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 38, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 20, 51, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 20, 59, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 21, 22, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 23, 44, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 1, 58, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 14, 57, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 5, 8, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 6, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 8, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 9, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 6, 52, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 2, 29, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 4, 13, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 7, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 3, 57, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 23, 10, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 0, 54, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 5, 53, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 16, 26, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 34, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 4, 35, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 55, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 13, 52, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 4, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 4, 36, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 9, 34, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 8, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 1, 1, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 9, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 4, 14, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 9, 43, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 5, 46, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 3, 40, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 6, 18, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 10, 13, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 15, 26, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 8, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 18, 41, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 18, 9, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 8, 40, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 21, 50, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 14, 30, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 49, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 11, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 20, 25, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 11, 26, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 10, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 23, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 13, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 19, 8, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 14, 16, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 5, 2, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 22, 48, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 4, 33, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 47, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 14, 49, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 9, 43, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 10, 27, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 7, 57, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 17, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 15, 39, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 12, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 20, 32, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 22, 59, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 1, 7, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 13, 25, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 3, 42, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 41, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 6, 34, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 17, 26, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 7, 37, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 15, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 15, 43, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 3, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 23, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 17, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 1, 38, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 6, 45, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 7, 24, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 6, 27, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 3, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 2, 45, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 15, 1, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 23, 41, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 18, 25, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 5, 6, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 22, 27, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 1, 41, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 7, 16, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 17, 2, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 9, 19, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 0, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 4, 37, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 1, 51, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 13, 40, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 18, 47, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 16, 51, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 19, 23, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 20, 30, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 39, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 23, 19, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 31, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 9, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 23, 38, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 17, 23, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 37, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 8, 2, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 43, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 12, 24, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 4, 13, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 3, 55, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 6, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 9, 16, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 56, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 22, 48, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 4, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 1, 24, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 7, 11, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 23, 21, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 16, 52, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 3, 23, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 5, 10, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 14, 17, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 4, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 17, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 22, 15, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 20, 47, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 5, 25, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 9, 1, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 16, 55, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 37, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 12, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 2, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 22, 12, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 13, 4, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 39, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 8, 48, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 8, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 5, 47, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 9, 6, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 54, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 13, 4, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 13, 57, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 7, 41, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 1, 2, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 10, 54, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 6, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 19, 20, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 20, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 5, 10, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 6, 15, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 31, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 20, 39, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 20, 4, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 19, 4, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 13, 3, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 10, 48, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 36, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 19, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 28, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 22, 38, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 28, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 4, 41, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 4, 42, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 15, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 11, 13, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 16, 50, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 15, 3, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 9, 35, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 2, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 14, 2, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 3, 6, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 12, 1, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 13, 11, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 10, 47, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 23, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 49, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 7, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 30, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 8, 55, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 11, 51, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 3, 39, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 3, 23, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 14, 0, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 1, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 13, 18, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 3, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 54, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 17, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 9, 12, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 23, 16, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 3, 41, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 20, 33, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 3, 47, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 18, 26, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 15, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 16, 36, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 4, 29, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 21, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 8, 39, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 55, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 20, 59, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 5, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 3, 6, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 2, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 0, 27, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 6, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 23, 10, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 2, 49, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 5, 17, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 14, 24, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 8, 41, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 26, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 25, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 21, 30, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 18, 52, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 10, 25, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 1, 46, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 8, 8, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 6, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 0, 33, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 3, 10, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 13, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 16, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 23, 21, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 26, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 23, 58, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 9, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 9, 14, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 12, 42, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 3, 43, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 10, 44, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 16, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 13, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 23, 56, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 21, 9, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 20, 52, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 6, 44, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 17, 58, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 9, 42, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 2, 12, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 3, 40, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 23, 26, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 9, 30, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 43, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 20, 3, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 7, 44, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 8, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 17, 20, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 23, 47, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 5, 21, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 22, 30, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 12, 50, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 43, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 17, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 21, 23, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 16, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 23, 35, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 2, 12, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 31, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 37, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 34, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 23, 13, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 20, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 17, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 4, 19, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 4, 17, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 22, 40, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 4, 43, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 14, 43, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 18, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 7, 5, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 4, 24, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 17, 19, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 4, 31, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 9, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 12, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 2, 34, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 10, 49, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 18, 36, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 8, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 18, 26, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 29, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 5, 15, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 23, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 12, 15, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 58, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 14, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 1, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 9, 31, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 4, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 9, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 25, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 23, 58, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 17, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 3, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 19, 38, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 15, 34, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 8, 5, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 19, 40, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 5, 28, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 19, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 15, 21, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 3, 46, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 15, 5, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 12, 45, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 5, 46, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 21, 31, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 7, 54, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 2, 39, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 4, 59, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 23, 9, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 14, 20, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 10, 6, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 14, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 21, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 4, 36, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 17, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 13, 12, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 5, 48, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 4, 24, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 53, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 9, 53, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 12, 54, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 7, 41, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 5, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 17, 6, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 22, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 7, 15, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 6, 34, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 17, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 44, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 12, 39, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 6, 19, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 14, 18, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 25, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 16, 21, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 40, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 10, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 8, 33, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 1, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 8, 12, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 7, 44, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 12, 38, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 11, 6, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 9, 53, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 8, 41, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 5, 23, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 15, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 3, 36, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 10, 32, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 8, 28, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 36, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 6, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 6, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 44, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 6, 42, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 4, 45, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 23, 23, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 30, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 16, 24, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 21, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 5, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 19, 48, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 7, 57, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 9, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 36, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 2, 25, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 12, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 42, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 15, 0, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 2, 12, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 5, 58, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 22, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 2, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 8, 1, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 6, 48, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 9, 54, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 7, 55, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 2, 51, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 14, 43, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 20, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 10, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 14, 5, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 1, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 23, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 18, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 19, 51, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 8, 42, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 36, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 15, 10, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 17, 12, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 5, 57, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 9, 46, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 11, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 15, 48, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 21, 7, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 3, 39, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 12, 4, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 2, 14, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 8, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 9, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 9, 22, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 7, 56, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 12, 2, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 13, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 7, 9, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 10, 52, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 1, 4, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 0, 54, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 23, 4, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 18, 35, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 21, 14, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 20, 23, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 2, 58, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 6, 15, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 10, 10, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 22, 52, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 5, 46, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 7, 15, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 3, 18, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 14, 48, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 6, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 2, 12, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 10, 37, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 20, 13, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 6, 44, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 2, 4, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 10, 5, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 6, 47, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 11, 8, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 27, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 19, 54, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 35, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 2, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 21, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 4, 53, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 54, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 3, 27, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 16, 18, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 12, 41, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 1, 37, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 1, 27, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 32, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 5, 54, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 36, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 31, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 12, 16, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 17, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 7, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 3, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 22, 59, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 4, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 32, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 16, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 2, 45, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 15, 50, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 13, 39, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 20, 23, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 7, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 0, 43, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 21, 40, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 19, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 33, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 14, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 9, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 16, 40, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 18, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 20, 51, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 10, 20, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 11, 52, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 17, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 7, 16, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 7, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 0, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 14, 9, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 23, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 16, 42, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 3, 28, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 0, 27, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 45, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 11, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 22, 32, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 18, 54, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 3, 6, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 11, 34, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 15, 56, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 8, 24, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 18, 11, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 12, 28, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 43, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 2, 10, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 10, 7, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 10, 43, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 9, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 9, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 45, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 6, 18, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 1, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 14, 2, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 2, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 11, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 10, 53, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 21, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 22, 39, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 4, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 21, 36, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 5, 7, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 17, 17, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 9, 40, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 10, 31, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 5, 18, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 59, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 21, 48, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 18, 31, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 4, 54, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 2, 58, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 22, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 16, 47, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 6, 15, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 4, 27, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 18, 13, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 7, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 12, 17, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 13, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 18, 5, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 19, 35, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 8, 5, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 22, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 14, 6, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 19, 14, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 31, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 7, 57, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 4, 3, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 5, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 22, 55, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 20, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 13, 43, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 10, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 2, 8, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 12, 38, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 1, 48, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 5, 16, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 12, 16, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 11, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 18, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 7, 13, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 9, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 5, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 23, 40, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 17, 59, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 5, 29, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 7, 52, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 4, 20, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 6, 34, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 7, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 19, 8, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 10, 23, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 13, 45, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 2, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 4, 39, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 38, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 15, 35, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 7, 24, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 1, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 8, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 9, 57, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 21, 30, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 11, 41, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 7, 24, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 46, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 4, 55, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 23, 49, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 23, 46, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 20, 36, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 5, 11, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 14, 23, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 6, 19, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 10, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 15, 3, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 3, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 3, 40, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 10, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 1, 27, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 19, 0, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 2, 41, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 14, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 29, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 13, 55, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 1, 7, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 5, 33, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 46, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 9, 46, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 18, 37, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 5, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 2, 19, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 6, 46, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 32, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 9, 54, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 13, 58, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 20, 30, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 19, 29, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 3, 21, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 1, 19, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 3, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 22, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 1, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 11, 37, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 3, 20, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 18, 9, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 13, 22, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 21, 39, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 17, 59, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 10, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 24, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 6, 27, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 19, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 8, 23, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 21, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 10, 4, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 12, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 8, 38, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 32, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 2, 27, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 32, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 21, 27, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 15, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 13, 14, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 32, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 2, 52, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 22, 52, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 58, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 8, 16, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 2, 8, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 23, 1, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 9, 2, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 2, 1, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 1, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 12, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 3, 4, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 17, 8, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 1, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 15, 31, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 2, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 23, 13, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 25, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 23, 21, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 21, 44, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 7, 57, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 19, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 20, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 20, 49, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 12, 50, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 5, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 23, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 5, 39, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 9, 35, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 49, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 19, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 5, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 8, 22, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 23, 35, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 1, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 49, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 22, 54, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 3, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 13, 36, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 5, 4, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 13, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 20, 25, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 20, 28, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 5, 23, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 19, 26, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 4, 38, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 11, 40, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 7, 7, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 23, 15, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 2, 58, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 15, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 19, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 23, 6, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 13, 23, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 21, 30, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 2, 1, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 43, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 18, 44, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 19, 50, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 6, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 20, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 1, 52, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 22, 36, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 17, 13, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 9, 7, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 19, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 6, 8, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 2, 37, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 14, 21, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 3, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 6, 58, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 12, 27, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 14, 41, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 8, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 2, 59, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 17, 1, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 3, 53, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 18, 11, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 3, 47, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 18, 2, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 1, 12, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 38, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 18, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 4, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 8, 3, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 10, 56, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 4, 29, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 12, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 23, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 7, 12, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 22, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 4, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 21, 40, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 5, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 10, 24, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 3, 35, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 19, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 24, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 6, 5, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 10, 18, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 7, 8, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 25, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 15, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 28, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 10, 28, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 5, 1, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 23, 40, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 11, 14, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 17, 13, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 10, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 0, 4, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 10, 43, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 18, 23, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 21, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 0, 40, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 20, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 0, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 29, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 17, 11, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 1, 24, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 3, 4, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 53, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 9, 52, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 3, 51, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 3, 3, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 18, 33, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 6, 20, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 5, 42, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 22, 3, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 46, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 16, 36, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 5, 22, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 6, 29, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 5, 26, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 16, 30, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 6, 35, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 19, 42, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 3, 35, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 10, 23, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 25, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 12, 31, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 7, 19, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 18, 33, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 7, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 21, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 46, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 3, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 13, 6, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 18, 51, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 13, 28, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 4, 14, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 47, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 1, 47, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 19, 32, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 12, 27, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 15, 43, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 56, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 2, 3, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 15, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 9, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 11, 42, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 11, 33, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 7, 35, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 44, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 19, 13, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 17, 3, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 14, 42, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 58, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 1, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 17, 33, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 0, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 4, 3, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 15, 28, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 11, 23, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 13, 48, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 16, 13, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 18, 26, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 13, 24, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 43, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 20, 49, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 19, 59, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 22, 51, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 13, 57, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 23, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 15, 4, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 6, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 17, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 1, 13, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 9, 39, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 25, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 0, 12, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 13, 43, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 12, 53, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 19, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 6, 29, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 12, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 2, 43, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 15, 46, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 37, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 21, 59, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 43, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 43, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 9, 47, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 21, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 23, 10, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 21, 10, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 5, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 21, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 22, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 12, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 22, 27, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 13, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 23, 39, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 21, 4, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 23, 59, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 3, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 17, 59, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 1, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 17, 29, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 37, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 15, 58, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 5, 39, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 20, 59, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 0, 27, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 21, 38, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 10, 5, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 5, 24, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 8, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 23, 29, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 19, 44, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 15, 57, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 18, 54, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 3, 54, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 11, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 2, 19, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 27, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 13, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 5, 58, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 7, 13, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 3, 22, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 3, 42, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 13, 16, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 3, 14, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 4, 34, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 9, 55, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 18, 10, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 15, 35, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 18, 45, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 32, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 18, 45, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 10, 3, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 15, 23, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 55, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 20, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 7, 19, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 19, 10, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 1, 20, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 9, 30, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 14, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 16, 41, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 20, 12, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 3, 17, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 14, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 3, 15, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 4, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 20, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 3, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 22, 23, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 34, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 12, 5, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 20, 13, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 3, 1, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 17, 8, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 21, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 3, 15, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 3, 28, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 14, 27, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 18, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 9, 44, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 13, 37, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 21, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 12, 21, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 13, 58, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 7, 36, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 20, 15, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 21, 13, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 43, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 5, 50, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 1, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 19, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 6, 42, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 11, 38, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 47, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 6, 57, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 9, 33, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 22, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 1, 16, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 22, 17, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 0, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 7, 39, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 19, 46, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 15, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 14, 5, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 15, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 17, 10, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 17, 51, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 18, 55, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 22, 14, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 7, 59, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 4, 12, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 11, 5, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 10, 58, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 15, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 9, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 22, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 24, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 15, 58, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 5, 10, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 4, 7, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 3, 56, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 22, 21, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 7, 37, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 9, 39, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 46, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 1, 18, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 21, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 3, 59, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 0, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 18, 26, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 7, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 12, 9, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 7, 13, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 19, 11, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 4, 53, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 15, 34, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 5, 53, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 15, 42, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 28, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 3, 13, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 22, 14, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 5, 38, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 13, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 13, 49, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 21, 39, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 5, 8, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 3, 37, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 7, 11, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 2, 33, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 55, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 6, 35, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 23, 3, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 4, 49, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 16, 27, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 19, 47, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 2, 36, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 19, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 9, 17, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 18, 36, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 17, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 19, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 12, 57, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 14, 37, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 12, 34, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 4, 42, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 19, 36, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 19, 15, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 30, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 10, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 4, 43, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 19, 7, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 18, 5, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 9, 57, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 5, 32, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 32, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 3, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 5, 14, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 6, 6, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 12, 9, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 17, 16, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 20, 9, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 12, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 10, 3, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 19, 25, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 6, 59, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 17, 12, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 23, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 13, 59, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 5, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 16, 43, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 15, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 3, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 9, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 22, 36, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 2, 37, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 14, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 22, 13, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 7, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 18, 20, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 5, 10, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 23, 9, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 1, 3, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 21, 30, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 38, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 22, 33, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 19, 11, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 5, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 9, 25, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 8, 25, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 16, 1, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 39, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 6, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 4, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 4, 5, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 19, 40, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 3, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 7, 58, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 23, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 11, 22, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 9, 29, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 16, 53, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 22, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 3, 25, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 7, 53, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 6, 19, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 11, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 6, 1, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 19, 32, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 6, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 21, 50, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 5, 13, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 19, 2, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 44, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 4, 26, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 13, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 14, 4, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 53, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 6, 32, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 5, 26, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 21, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 22, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 21, 59, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 5, 27, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 15, 17, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 18, 23, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 2, 56, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 2, 25, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 36, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 13, 30, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 0, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 9, 15, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 57, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 16, 36, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 5, 3, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 11, 6, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 19, 48, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 30, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 4, 5, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 4, 55, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 1, 15, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 2, 54, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 18, 56, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 21, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 10, 17, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 21, 48, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 55, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 4, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 8, 18, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 16, 31, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 7, 1, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 5, 21, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 4, 50, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 4, 16, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 4, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 11, 19, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 10, 58, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 12, 24, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 16, 17, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 16, 35, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 28, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 6, 19, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 5, 53, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 20, 45, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 3, 8, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 9, 31, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 1, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 14, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 4, 29, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 12, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 54, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 21, 49, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 7, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 14, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 3, 44, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 14, 29, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 15, 41, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 2, 17, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 4, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 21, 47, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 1, 33, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 11, 34, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 9, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 25, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 4, 6, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 21, 14, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 7, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 17, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 8, 51, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 18, 18, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 12, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 7, 39, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 21, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 14, 13, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 5, 17, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 15, 29, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 11, 29, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 44, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 21, 2, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 13, 58, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 35, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 43, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 51, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 20, 9, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 14, 8, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 5, 33, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 49, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 22, 53, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 19, 18, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 1, 50, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 55, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 38, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 7, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 16, 43, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 2, 54, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 8, 48, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 1, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 19, 35, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 41, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 18, 10, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 15, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 11, 11, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 19, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 2, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 19, 4, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 14, 13, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 19, 24, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 16, 34, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 6, 8, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 6, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 3, 25, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 3, 41, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 20, 39, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 19, 59, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 6, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 13, 3, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 22, 58, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 12, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 14, 8, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 5, 50, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 22, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 9, 11, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 40, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 1, 33, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 0, 14, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 21, 52, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 7, 41, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 1, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 22, 26, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 20, 8, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 6, 2, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 2, 43, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 21, 32, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 7, 5, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 19, 56, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 23, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 19, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 10, 55, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 9, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 9, 15, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 46, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 22, 8, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 55, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 2, 54, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 12, 6, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 56, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 14, 21, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 8, 55, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 28, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 15, 12, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 2, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 11, 19, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 4, 6, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 10, 44, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 5, 15, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 6, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 20, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 0, 5, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 21, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 22, 44, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 7, 59, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 9, 6, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 9, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 23, 6, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 18, 6, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 14, 50, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 22, 13, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 23, 23, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 54, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 10, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 1, 32, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 22, 14, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 10, 2, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 17, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 12, 32, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 1, 55, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 8, 14, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 5, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 41, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 0, 4, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 18, 29, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 21, 23, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 17, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 7, 56, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 40, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 7, 35, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 28, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 7, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 43, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 23, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 8, 6, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 14, 30, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 26, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 18, 11, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 15, 38, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 9, 21, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 49, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 20, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 39, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 9, 4, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 2, 15, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 13, 20, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 9, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 0, 53, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 38, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 18, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 57, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 11, 58, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 4, 11, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 4, 33, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 2, 22, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 22, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 15, 2, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 21, 20, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 19, 18, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 10, 48, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 7, 7, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 1, 2, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 19, 5, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 23, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 56, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 12, 17, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 9, 47, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 8, 25, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 23, 48, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 15, 55, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 0, 53, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 23, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 4, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 36, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 7, 48, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 21, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 10, 31, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 3, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 12, 44, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 10, 22, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 12, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 17, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 20, 36, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 17, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 9, 20, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 22, 39, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 8, 48, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 52, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 22, 46, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 1, 26, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 14, 55, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 2, 48, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 8, 47, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 14, 25, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 7, 20, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 13, 11, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 21, 30, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 6, 41, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 23, 43, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 23, 25, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 31, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 9, 17, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 2, 0, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 23, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 17, 20, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 0, 44, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 22, 2, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 22, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 10, 53, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 9, 16, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 13, 45, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 23, 41, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 18, 29, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 19, 39, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 21, 9, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 10, 44, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 22, 55, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 10, 0, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 20, 44, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 18, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 10, 8, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 12, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 1, 50, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 6, 18, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 0, 8, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 59, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 21, 50, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 51, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 2, 49, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 18, 10, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 19, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 22, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 20, 37, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 22, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 7, 17, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 58, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 36, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 8, 42, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 17, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 17, 22, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 21, 59, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 7, 40, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 6, 31, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 17, 12, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 23, 49, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 15, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 3, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 48, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 6, 16, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 0, 53, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 12, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 20, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 4, 31, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 7, 15, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 21, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 53, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 2, 5, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 53, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 18, 3, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 40, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 17, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 13, 47, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 22, 3, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 1, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 7, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 10, 15, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 13, 51, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 1, 42, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 14, 57, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 11, 5, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 20, 58, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 11, 47, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 34, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 12, 11, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 7, 33, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 19, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 7, 32, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 6, 43, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 15, 5, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 4, 31, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 20, 7, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 21, 15, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 18, 31, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 1, 7, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 15, 55, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 6, 37, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 26, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 1, 10, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 7, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 15, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 1, 46, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 21, 58, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 6, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 18, 54, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 22, 7, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 22, 35, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 3, 7, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 5, 0, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 9, 2, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 14, 25, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 41, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 2, 10, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 19, 16, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 3, 24, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 8, 59, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 14, 25, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 5, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 9, 5, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 17, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 10, 34, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 27, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 23, 26, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 2, 32, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 6, 42, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 25, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 12, 22, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 12, 49, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 19, 45, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 2, 45, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 18, 45, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 10, 51, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 3, 16, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 6, 31, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 12, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 19, 58, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 9, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 44, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 18, 11, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 0, 56, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 22, 8, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 11, 8, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 18, 7, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 17, 52, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 23, 25, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 18, 45, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 20, 53, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 23, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 3, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 5, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 23, 27, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 5, 27, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 0, 19, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 23, 2, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 8, 22, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 3, 48, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 18, 7, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 12, 17, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 21, 42, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 10, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 12, 46, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 5, 28, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 7, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 44, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 22, 50, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 22, 59, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 49, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 31, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 6, 52, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 45, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 20, 37, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 49, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 20, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 20, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 3, 39, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 2, 3, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 4, 43, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 0, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 8, 28, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 16, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 9, 31, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 45, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 0, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 20, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 11, 42, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 17, 40, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 13, 35, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 10, 36, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 7, 29, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 1, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 37, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 16, 17, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 20, 10, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 15, 58, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 22, 8, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 1, 59, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 13, 18, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 8, 47, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 5, 28, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 19, 3, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 3, 21, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 6, 54, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 0, 3, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 3, 18, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 6, 6, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 7, 42, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 19, 19, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 14, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 17, 5, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 12, 54, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 20, 40, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 28, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 20, 25, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 5, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 20, 28, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 19, 14, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 15, 38, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 22, 54, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 3, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 2, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 23, 50, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 3, 16, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 13, 42, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 56, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 13, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 20, 57, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TimeRegistrations_EmployeeId_StartTime",
                table: "TimeRegistrations",
                columns: new[] { "EmployeeId", "StartTime" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TimeRegistrations_EmployeeId_StartTime",
                table: "TimeRegistrations");

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 23, 40, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 1, 58, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 5, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 13, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 8, 14, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 4, 53, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 13, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 22, 15, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 8, 19, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 20, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 2, 29, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 23, 43, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 18, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 18, 11, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 7, 46, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 11, 28, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 7, 6, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 4, 49, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 13, 22, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 12, 24, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 1, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 16, 30, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 50, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 2, 46, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 11, 25, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 7, 35, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 22, 56, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 56, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 20, 57, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 1, 14, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 3, 7, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 22, 27, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 22, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 7, 35, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 5, 42, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 20, 21, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 6, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 7, 23, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 9, 45, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 8, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 51, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 20, 44, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 8, 44, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 6, 22, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 19, 59, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 7, 25, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 7, 36, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 21, 49, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 18, 31, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 14, 22, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 4, 54, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 9, 34, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 16, 56, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 16, 49, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 12, 34, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 15, 56, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 7, 41, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 18, 38, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 6, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 22, 4, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 8, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 20, 58, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 12, 4, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 20, 56, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 13, 42, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 1, 20, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 4, 31, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 21, 34, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 9, 34, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 1, 0, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 4, 1, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 0, 45, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 21, 42, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 16, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 14, 20, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 20, 57, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 8, 45, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 29, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 4, 15, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 19, 52, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 22, 1, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 15, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 10, 27, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 7, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 22, 26, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 19, 57, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 5, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 19, 5, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 14, 54, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 7, 45, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 1, 44, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 20, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 4, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 20, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 8, 26, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 37, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 11, 31, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 8, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 12, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 9, 29, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 15, 43, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 12, 59, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 20, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 1, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 8, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 20, 19, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 21, 37, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 15, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 8, 34, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 49, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 55, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 8, 23, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 22, 56, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 23, 16, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 22, 35, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 7, 43, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 7, 50, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 20, 34, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 5, 58, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 7, 23, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 9, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 5, 12, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 16, 20, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 12, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 0, 26, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 11, 40, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 18, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 1, 57, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 4, 47, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 13, 38, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 23, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 43, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 27, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 6, 31, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 5, 3, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 19, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 18, 12, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 6, 28, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 23, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 8, 22, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 5, 43, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 13, 36, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 21, 3, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 19, 51, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 21, 57, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 5, 27, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 37, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 20, 21, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 11, 2, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 8, 46, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 22, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 20, 1, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 11, 34, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 11, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 15, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 17, 31, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 11, 40, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 1, 14, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 7, 48, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 21, 22, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 11, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 53, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 10, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 0, 55, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 21, 50, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 3, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 14, 47, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 28, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 15, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 19, 59, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 1, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 13, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 11, 6, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 20, 34, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 22, 19, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 1, 38, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 2, 22, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 1, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 0, 6, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 6, 51, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 10, 39, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 3, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 20, 57, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 22, 47, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 14, 0, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 10, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 18, 10, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 20, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 22, 59, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 8, 1, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 12, 57, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 2, 39, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 17, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 1, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 3, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 21, 15, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 12, 7, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 6, 29, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 13, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 18, 43, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 20, 12, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 19, 17, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 9, 58, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 2, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 48, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 15, 35, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 1, 0, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 45, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 51, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 4, 30, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 6, 28, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 13, 27, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 26, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 20, 35, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 5, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 22, 17, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 19, 54, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 11, 17, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 7, 32, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 2, 33, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 20, 3, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 9, 28, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 25, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 4, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 9, 1, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 22, 16, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 10, 56, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 1, 18, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 18, 58, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 16, 7, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 43, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 21, 50, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 5, 38, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 14, 23, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 2, 22, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 16, 19, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 16, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 9, 28, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 1, 50, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 16, 26, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 7, 11, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 9, 36, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 54, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 14, 39, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 3, 42, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 14, 57, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 5, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 22, 22, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 21, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 14, 54, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 44, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 12, 42, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 11, 30, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 57, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 14, 18, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 44, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 16, 7, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 18, 21, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 0, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 22, 7, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 21, 25, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 7, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 5, 26, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 15, 3, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 9, 57, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 12, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 19, 39, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 22, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 48, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 53, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 8, 21, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 52, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 14, 3, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 23, 2, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 18, 47, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 8, 58, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 19, 56, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 17, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 3, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 4, 46, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 11, 24, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 20, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 8, 16, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 12, 7, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 21, 51, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 55, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 5, 44, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 21, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 1, 40, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 22, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 20, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 10, 3, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 8, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 22, 13, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 17, 37, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 30, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 13, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 12, 20, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 10, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 8, 33, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 50, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 5, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 14, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 10, 3, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 31, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 14, 34, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 11, 4, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 11, 32, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 7, 15, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 17, 19, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 32, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 15, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 2, 27, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 20, 59, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 0, 8, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 6, 40, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 18, 48, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 2, 2, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 16, 54, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 32, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 15, 56, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 17, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 23, 53, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 7, 37, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 13, 57, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 4, 22, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 7, 43, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 21, 52, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 18, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 7, 0, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 18, 50, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 19, 10, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 16, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 11, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 6, 31, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 3, 27, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 12, 57, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 2, 57, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 53, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 43, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 3, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 3, 37, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 13, 30, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 46, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 5, 38, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 23, 19, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 17, 4, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 21, 7, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 20, 48, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 27, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 19, 53, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 55, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 18, 33, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 19, 7, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 9, 46, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 13, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 17, 41, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 12, 57, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 6, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 22, 1, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 4, 6, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 1, 5, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 18, 21, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 4, 12, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 5, 23, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 6, 39, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 23, 18, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 12, 44, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 22, 36, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 48, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 3, 16, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 10, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 11, 16, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 1, 31, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 21, 36, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 14, 4, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 13, 10, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 7, 13, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 11, 56, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 15, 36, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 2, 2, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 23, 14, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 13, 11, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 9, 51, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 20, 22, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 19, 6, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 8, 40, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 13, 26, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 1, 5, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 46, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 1, 3, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 1, 34, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 17, 44, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 5, 8, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 8, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 6, 1, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 3, 47, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 20, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 12, 52, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 16, 14, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 3, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 7, 21, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 16, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 14, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 16, 53, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 29, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 19, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 17, 38, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 17, 34, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 23, 41, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 11, 53, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 13, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 1, 45, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 18, 57, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 4, 52, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 22, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 16, 25, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 1, 40, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 7, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 5, 1, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 17, 56, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 31, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 3, 6, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 9, 46, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 23, 53, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 5, 35, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 3, 9, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 39, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 7, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 8, 44, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 3, 59, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 49, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 14, 33, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 10, 6, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 15, 49, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 14, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 4, 28, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 10, 0, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 23, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 13, 31, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 4, 26, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 22, 7, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 9, 17, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 42, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 4, 36, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 4, 49, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 32, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 29, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 2, 48, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 17, 25, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 12, 28, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 7, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 0, 48, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 6, 49, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 7, 2, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 13, 9, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 21, 26, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 52, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 38, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 1, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 3, 41, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 15, 1, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 8, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 8, 9, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 8, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 11, 44, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 29, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 8, 53, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 8, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 6, 6, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 32, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 6, 21, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 4, 3, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 1, 28, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 15, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 3, 45, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 10, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 2, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 7, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 2, 5, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 8, 17, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 9, 22, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 33, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 16, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 10, 36, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 11, 21, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 9, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 10, 31, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 6, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 1, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 0, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 40, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 12, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 2, 26, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 9, 15, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 22, 5, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 19, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 1, 20, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 10, 24, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 14, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 16, 7, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 9, 15, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 23, 14, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 9, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 5, 2, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 15, 29, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 7, 32, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 7, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 22, 30, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 14, 21, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 4, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 11, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 20, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 8, 22, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 22, 14, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 12, 14, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 0, 22, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 9, 35, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 56, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 13, 57, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 4, 43, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 8, 53, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 44, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 17, 56, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 11, 18, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 10, 12, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 38, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 22, 31, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 24, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 10, 22, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 10, 33, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 6, 6, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 18, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 14, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 10, 0, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 12, 11, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 4, 29, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 21, 40, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 21, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 4, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 0, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 2, 59, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 1, 14, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 53, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 11, 55, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 16, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 43, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 21, 18, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 3, 14, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 15, 0, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 3, 33, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 7, 54, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 12, 46, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 18, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 2, 18, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 22, 31, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 12, 24, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 3, 31, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 6, 38, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 10, 30, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 5, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 2, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 1, 45, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 11, 9, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 3, 23, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 18, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 20, 12, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 13, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 11, 24, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 54, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 3, 21, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 30, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 14, 7, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 5, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 8, 3, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 10, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 21, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 5, 41, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 18, 50, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 10, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 21, 56, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 11, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 1, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 7, 23, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 16, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 6, 1, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 22, 40, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 19, 53, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 37, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 13, 50, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 55, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 14, 16, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 12, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 5, 32, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 59, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 1, 8, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 18, 25, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 9, 12, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 47, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 21, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 11, 57, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 14, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 18, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 20, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 7, 31, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 9, 16, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 47, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 12, 49, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 13, 40, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 22, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 54, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 8, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 46, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 6, 33, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 23, 28, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 14, 27, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 20, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 22, 47, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 8, 3, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 21, 43, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 12, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 41, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 9, 53, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 13, 59, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 2, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 21, 19, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 3, 37, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 6, 37, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 20, 1, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 12, 59, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 20, 34, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 9, 33, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 22, 53, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 3, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 22, 4, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 42, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 3, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 20, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 19, 28, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 31, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 0, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 10, 17, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 13, 58, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 3, 1, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 12, 27, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 12, 10, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 17, 8, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 11, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 14, 21, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 10, 24, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 11, 5, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 8, 52, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 6, 16, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 18, 34, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 33, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 16, 2, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 1, 45, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 17, 35, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 8, 43, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 7, 24, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 1, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 18, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 21, 41, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 14, 38, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 10, 6, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 14, 7, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 31, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 9, 48, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 8, 25, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 6, 10, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 6, 29, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 14, 16, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 17, 47, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 4, 44, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 23, 32, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 22, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 5, 33, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 18, 20, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 44, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 11, 52, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 41, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 10, 16, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 19, 11, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 52, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 9, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 2, 21, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 9, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 4, 2, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 12, 37, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 7, 36, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 15, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 33, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 9, 2, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 18, 16, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 2, 14, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 0, 49, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 6, 20, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 3, 0, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 10, 47, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 5, 20, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 13, 52, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 17, 16, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 4, 34, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 20, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 21, 35, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 20, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 6, 12, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 50, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 14, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 19, 0, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 16, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 20, 28, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 8, 57, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 22, 30, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 8, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 20, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 37, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 18, 20, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 4, 45, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 13, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 6, 46, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 9, 22, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 34, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 7, 21, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 19, 39, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 0, 18, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 22, 31, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 14, 32, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 17, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 11, 55, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 18, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 23, 54, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 46, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 21, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 10, 26, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 10, 56, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 29, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 12, 16, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 37, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 9, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 1, 4, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 11, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 21, 7, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 23, 49, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 1, 59, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 19, 33, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 21, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 6, 10, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 29, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 11, 54, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 9, 59, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 11, 31, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 20, 10, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 6, 33, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 8, 46, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 22, 17, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 20, 12, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 18, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 9, 41, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 10, 28, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 47, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 7, 48, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 5, 2, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 15, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 0, 4, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 11, 43, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 20, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 10, 23, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 13, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 17, 21, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 5, 56, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 23, 42, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 9, 17, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 12, 34, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 3, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 20, 13, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 51, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 17, 30, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 20, 27, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 4, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 20, 18, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 3, 32, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 15, 12, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 34, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 22, 26, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 23, 57, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 23, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 58, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 11, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 19, 15, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 20, 32, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 36, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 22, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 12, 14, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 1, 10, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 6, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 5, 50, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 3, 24, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 23, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 11, 20, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 10, 35, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 6, 34, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 2, 16, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 21, 29, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 6, 22, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 4, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 14, 38, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 16, 3, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 40, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 8, 48, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 45, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 1, 17, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 15, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 0, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 19, 1, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 2, 15, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 17, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 5, 35, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 12, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 6, 18, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 8, 34, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 14, 22, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 42, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 21, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 23, 37, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 10, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 52, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 19, 5, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 11, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 15, 19, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 0, 28, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 8, 41, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 10, 28, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 4, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 19, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 57, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 1, 50, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 27, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 12, 34, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 12, 33, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 12, 43, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 23, 30, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 15, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 18, 25, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 13, 57, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 5, 10, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 9, 8, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 7, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 5, 4, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 14, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 4, 3, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 41, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 23, 6, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 10, 3, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 20, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 14, 24, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 20, 24, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 0, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 3, 50, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 3, 7, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 10, 59, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 12, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 3, 51, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 5, 30, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 5, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 4, 33, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 18, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 19, 34, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 13, 4, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 21, 8, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 1, 14, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 3, 3, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 1, 36, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 19, 11, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 17, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 23, 47, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 0, 49, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 14, 59, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 13, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 2, 6, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 31, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 18, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 16, 52, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 14, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 1, 36, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 1, 7, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 19, 23, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 2, 53, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 18, 9, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 19, 38, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 16, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 52, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 3, 14, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 43, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 20, 37, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 43, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 16, 6, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 15, 7, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 13, 35, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 0, 41, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 20, 32, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 17, 26, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 13, 7, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 6, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 5, 1, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 18, 11, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 21, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 14, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 5, 42, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 7, 52, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 3, 57, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 18, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 21, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 49, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 10, 4, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 6, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 5, 41, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 12, 48, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 21, 50, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 5, 0, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 18, 4, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 3, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 7, 4, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 35, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 21, 37, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 18, 52, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 1, 26, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 23, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 2, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 15, 46, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 16, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 12, 16, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 13, 34, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 1, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 6, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 14, 18, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 5, 13, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 7, 35, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 4, 46, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 22, 53, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 1, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 23, 7, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 2, 21, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 32, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 15, 1, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 17, 45, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 16, 2, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 1, 18, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 5, 40, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 51, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 11, 18, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 37, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 11, 14, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 2, 25, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 1, 57, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 2, 44, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 20, 34, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 18, 41, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 21, 36, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 7, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 58, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 4, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 9, 32, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 48, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 3, 52, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 11, 44, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 18, 26, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 51, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 10, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 16, 19, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 0, 15, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 19, 31, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 19, 34, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 6, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 10, 17, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 20, 41, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 9, 41, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 18, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 5, 21, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 21, 19, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 23, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 2, 22, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 6, 18, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 30, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 7, 17, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 29, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 2, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 12, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 18, 26, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 18, 37, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 9, 45, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 17, 21, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 13, 59, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 15, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 1, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 0, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 14, 53, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 2, 21, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 7, 10, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 3, 52, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 4, 9, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 18, 9, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 17, 28, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 22, 12, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 10, 15, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 11, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 5, 10, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 3, 31, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 2, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 25, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 9, 35, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 15, 12, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 17, 36, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 22, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 23, 8, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 9, 38, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 27, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 8, 30, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 5, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 8, 41, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 7, 3, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 11, 27, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 2, 55, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 21, 16, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 5, 25, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 23, 40, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 14, 57, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 11, 59, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 5, 21, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 12, 7, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 5, 10, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 11, 53, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 58, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 49, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 1, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 22, 54, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 17, 23, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 1, 50, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 1, 8, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 15, 11, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 2, 43, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 1, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 15, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 9, 18, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 9, 31, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 5, 36, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 24, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 9, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 19, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 4, 32, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 58, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 18, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 19, 7, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 23, 42, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 18, 58, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 8, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 9, 36, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 30, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 8, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 5, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 2, 57, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 23, 11, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 22, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 8, 20, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 1, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 2, 13, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 22, 54, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 19, 46, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 7, 25, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 19, 52, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 7, 33, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 4, 50, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 4, 24, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 9, 14, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 2, 53, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 21, 25, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 23, 30, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 13, 9, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 14, 39, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 15, 22, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 2, 58, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 14, 3, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 55, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 11, 17, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 20, 1, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 23, 30, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 39, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 5, 3, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 2, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 22, 48, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 9, 26, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 2, 21, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 3, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 1, 8, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 9, 40, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 1, 7, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 22, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 18, 25, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 11, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 16, 40, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 1, 10, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 21, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 18, 4, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 13, 23, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 14, 5, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 23, 48, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 19, 51, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 2, 27, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 20, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 21, 28, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 1, 39, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 16, 1, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 21, 36, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 4, 40, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 18, 52, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 14, 26, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 11, 27, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 11, 59, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 10, 20, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 29, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 18, 53, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 22, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 33, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 1, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 6, 52, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 7, 39, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 21, 49, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 4, 29, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 5, 38, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 1, 26, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 18, 33, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 20, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 11, 21, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 28, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 19, 23, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 5, 55, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 9, 37, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 21, 50, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 17, 39, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 18, 32, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 17, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 5, 11, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 10, 53, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 2, 16, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 21, 46, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 20, 48, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 51, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 13, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 21, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 18, 1, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 17, 44, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 34, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 6, 10, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 7, 23, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 20, 10, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 2, 49, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 9, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 4, 16, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 8, 10, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 15, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 5, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 13, 40, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 20, 25, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 20, 56, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 8, 21, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 13, 49, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 20, 6, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 0, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 44, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 18, 17, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 19, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 4, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 12, 8, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 6, 35, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 12, 57, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 17, 53, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 10, 40, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 4, 0, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 57, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 23, 48, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 14, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 0, 27, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 9, 15, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 23, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 19, 33, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 23, 38, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 18, 34, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 21, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 13, 58, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 12, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 1, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 9, 30, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 16, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 22, 37, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 23, 19, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 8, 33, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 25, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 22, 8, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 49, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 23, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 35, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 18, 37, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 7, 12, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 15, 56, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 2, 33, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 22, 41, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 23, 7, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 2, 22, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 54, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 13, 25, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 26, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 16, 36, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 4, 1, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 4, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 47, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 10, 53, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 58, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 22, 18, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 5, 22, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 3, 31, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 9, 58, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 11, 35, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 6, 23, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 13, 21, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 8, 16, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 8, 32, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 5, 8, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 16, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 57, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 17, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 21, 51, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 17, 53, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 46, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 13, 46, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 37, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 22, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 38, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 5, 30, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 12, 4, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 11, 51, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 9, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 2, 4, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 16, 59, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 11, 52, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 19, 12, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 18, 42, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 1, 58, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 5, 17, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 13, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 2, 38, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 1, 54, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 23, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 12, 2, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 11, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 2, 42, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 23, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 18, 26, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 19, 45, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 1, 56, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 9, 35, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 38, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 20, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 10, 28, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 3, 33, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 40, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 11, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 1, 31, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 0, 31, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 6, 59, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 7, 59, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 44, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 8, 53, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 3, 17, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 11, 15, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 2, 7, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 13, 33, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 18, 53, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 7, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 11, 56, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 3, 49, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 24, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 5, 58, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 19, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 17, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 21, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 0, 58, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 50, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 4, 15, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 18, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 5, 25, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 23, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 6, 52, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 21, 45, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 41, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 6, 37, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 6, 59, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 2, 38, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 6, 28, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 2, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 32, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 14, 13, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 10, 22, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 19, 6, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 8, 24, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 21, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 23, 38, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 16, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 21, 1, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 9, 53, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 3, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 2, 19, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 18, 38, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 1, 11, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 14, 24, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 20, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 11, 55, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 18, 38, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 6, 54, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 22, 51, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 14, 39, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 5, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 19, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 6, 29, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 6, 30, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 23, 37, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 8, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 3, 46, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 10, 58, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 13, 42, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 1, 12, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 2, 7, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 21, 29, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 5, 22, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 5, 24, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 11, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 12, 40, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 22, 46, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 4, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 6, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 1, 33, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 12, 42, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 7, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 10, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 1, 51, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 6, 57, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 23, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 16, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 55, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 9, 30, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 0, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 12, 46, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 39, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 15, 52, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 54, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 3, 36, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 1, 13, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 2, 22, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 4, 5, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 22, 46, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 8, 56, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 20, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 15, 53, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 20, 4, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 37, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 9, 48, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 11, 36, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 3, 31, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 40, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 19, 29, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 49, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 7, 50, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 7, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 22, 41, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 5, 55, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 15, 40, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 17, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 21, 19, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 51, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 19, 36, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 36, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 16, 42, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 23, 33, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 18, 23, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 8, 36, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 5, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 23, 56, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 10, 53, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 17, 14, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 12, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 17, 7, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 16, 49, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 21, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 7, 13, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 7, 34, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 14, 50, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 13, 49, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 22, 52, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 2, 12, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 2, 51, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 22, 32, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 1, 25, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 13, 6, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 7, 10, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 6, 1, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 12, 58, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 44, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 15, 21, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 14, 5, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 19, 45, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 5, 18, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 12, 34, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 23, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 17, 51, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 22, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 17, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 22, 59, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 23, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 7, 56, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 2, 37, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 8, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 40, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 18, 38, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 10, 18, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 10, 31, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 11, 27, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 17, 42, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 8, 27, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 4, 15, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 11, 50, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 20, 14, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 15, 10, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 2, 57, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 6, 20, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 10, 11, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 6, 54, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 9, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 8, 22, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 13, 13, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 7, 59, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 7, 57, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 7, 41, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 4, 20, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 7, 8, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 4, 8, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 18, 41, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 6, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 0, 53, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 1, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 14, 44, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 15, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 1, 37, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 55, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 7, 23, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 17, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 1, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 40, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 59, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 16, 27, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 22, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 10, 48, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 9, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 20, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 5, 4, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 32, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 15, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 13, 21, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 21, 37, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 9, 40, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 12, 51, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 40, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 23, 22, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 17, 8, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 9, 47, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 5, 21, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 4, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 1, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 17, 54, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 8, 47, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 15, 30, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 5, 18, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 13, 28, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 17, 2, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 2, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 52, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 18, 51, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 8, 26, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 20, 25, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 20, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 17, 55, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 11, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 20, 14, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 37, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 17, 38, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 5, 30, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 11, 8, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 19, 23, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 6, 31, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 48, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 12, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 3, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 2, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 17, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 15, 16, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 2, 33, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 8, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 1, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 6, 59, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 4, 45, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 20, 40, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 13, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 1, 54, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 19, 44, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 17, 56, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 17, 27, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 6, 50, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 59, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 20, 11, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 20, 17, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 15, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 4, 25, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 17, 19, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 36, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 2, 5, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 12, 10, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 5, 27, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 22, 21, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 6, 47, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 15, 57, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 6, 47, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 2, 38, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 6, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 14, 6, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 17, 58, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 18, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 23, 28, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 12, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 22, 19, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 4, 42, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 7, 6, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 7, 35, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 3, 28, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 1, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 9, 17, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 18, 27, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 4, 21, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 13, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 5, 10, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 14, 57, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 15, 17, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 6, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 17, 52, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 5, 56, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 14, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 22, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 9, 42, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 1, 1, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 7, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 8, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 2, 30, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 3, 26, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 2, 13, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 7, 38, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 4, 51, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 22, 26, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 12, 49, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 18, 51, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 19, 29, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 21, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 16, 33, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 10, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 13, 30, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 13, 37, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 22, 46, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 6, 20, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 11, 14, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 42, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 3, 59, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 1, 51, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 12, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 23, 46, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 4, 46, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 10, 42, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 19, 58, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 34, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 50, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 4, 21, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 18, 45, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 47, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 6, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 21, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 14, 31, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 1, 9, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 12, 59, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 9, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 4, 33, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 12, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 12, 9, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 3, 33, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 8, 42, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 22, 32, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 22, 42, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 21, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 16, 31, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 39, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 13, 48, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 13, 17, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 17, 31, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 15, 52, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 6, 19, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 8, 37, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 17, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 21, 27, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 8, 16, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 2, 18, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 5, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 14, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 13, 50, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 8, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 14, 34, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 6, 20, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 4, 36, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 43, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 9, 2, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 2, 52, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 4, 52, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 20, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 22, 46, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 23, 38, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 13, 10, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 13, 55, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 12, 5, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 9, 22, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 7, 20, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 6, 20, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 5, 47, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 7, 47, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 4, 0, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 21, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 18, 3, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 20, 26, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 18, 47, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 18, 39, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 20, 2, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 2, 33, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 20, 11, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 7, 46, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 20, 1, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 13, 36, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 20, 25, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 11, 0, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 2, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 23, 1, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 11, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 5, 26, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 3, 14, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 18, 8, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 7, 55, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 22, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 22, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 1, 31, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 15, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 17, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 15, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 7, 56, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 46, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 8, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 6, 1, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 19, 24, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 0, 58, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 19, 11, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 10, 14, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 16, 13, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 2, 57, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 9, 9, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 11, 22, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 18, 20, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 6, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 9, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 11, 34, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 7, 54, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 55, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 14, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 21, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 4, 13, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 8, 45, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 3, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 4, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 57, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 22, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 1, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 10, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 3, 39, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 41, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 3, 1, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 0, 15, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 11, 33, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 6, 39, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 6, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 3, 7, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 19, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 9, 12, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 9, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 22, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 22, 25, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 27, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 30, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 5, 3, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 4, 23, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 21, 43, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 4, 39, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 5, 8, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 23, 41, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 45, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 20, 24, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 22, 13, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 6, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 22, 41, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 13, 19, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 18, 22, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 20, 45, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 4, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 15, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 54, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 6, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 4, 20, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 3, 44, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 23, 50, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 9, 7, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 11, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 14, 22, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 10, 1, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 23, 17, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 40, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 13, 55, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 24, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 5, 21, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 30, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 3, 0, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 8, 44, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 17, 23, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 19, 35, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 15, 58, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 23, 57, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 21, 23, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 23, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 47, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 6, 32, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 21, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 8, 20, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 2, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 21, 59, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 7, 59, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 49, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 26, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 3, 50, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 3, 43, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 4, 40, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 22, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 3, 46, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 12, 49, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 11, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 22, 15, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 14, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 45, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 23, 8, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 7, 47, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 9, 22, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 3, 4, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 14, 55, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 2, 7, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 22, 39, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 15, 28, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 17, 29, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 18, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 20, 14, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 27, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 23, 49, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 54, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 19, 50, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 23, 8, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 7, 59, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 10, 15, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 11, 13, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 18, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 4, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 16, 15, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 18, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 14, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 7, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 14, 28, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 20, 25, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 50, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 6, 3, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 1, 50, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 47, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 3, 9, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 2, 17, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 20, 4, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 10, 25, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 18, 58, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 3, 43, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 11, 0, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 7, 15, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 11, 17, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 23, 55, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 53, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 18, 44, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 8, 46, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 10, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 13, 26, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 47, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 4, 31, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 4, 2, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 12, 50, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 20, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 8, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 4, 14, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 18, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 6, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 3, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 1, 45, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 6, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 14, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 8, 17, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 13, 59, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 13, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 12, 35, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 17, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 9, 47, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 11, 24, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 6, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 10, 45, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 3, 35, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 11, 11, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 16, 50, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 21, 1, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 3, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 17, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 21, 54, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 22, 16, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 29, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 12, 24, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 2, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 22, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 13, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 0, 34, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 2, 12, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 23, 7, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 20, 33, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 13, 21, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 5, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 11, 37, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 44, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 17, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 17, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 13, 52, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 13, 9, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 5, 38, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 7, 10, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 9, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 17, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 6, 21, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 6, 2, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 7, 41, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 7, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 8, 23, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 47, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 15, 39, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 9, 9, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 22, 55, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 22, 20, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 17, 37, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 24, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 18, 22, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 6, 30, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 15, 12, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 5, 49, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 12, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 2, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 6, 28, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 10, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 9, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 16, 9, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 11, 55, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 21, 12, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 13, 20, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 2, 31, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 4, 57, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 1, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 21, 8, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 12, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 13, 36, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 23, 0, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 13, 57, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 43, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 23, 50, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 7, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 20, 12, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 14, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 11, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 14, 25, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 20, 11, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 10, 38, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 1, 28, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 3, 24, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 10, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 13, 18, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 15, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 21, 0, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 7, 42, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 9, 13, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 22, 36, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 10, 9, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 8, 30, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 19, 49, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 9, 11, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 6, 39, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 0, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 40, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 20, 26, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TimeRegistrations_EmployeeId",
                table: "TimeRegistrations",
                column: "EmployeeId");
        }
    }
}

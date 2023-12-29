using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployerManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(8776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 29, 21, 11, 2, 326, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CreatedAt", "CreatedBy", "EmailAddress", "FirstName", "LastModifiedAt", "LastName", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9549), "Seeder", "john.doe@example.com", "John", new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9550), "Doe", "Seeder" },
                    { 2, 25, new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9553), "Seeder", "jane.smith@example.com", "Jane", new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9553), "Smith", "Seeder" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 29, 21, 11, 2, 326, DateTimeKind.Local).AddTicks(9816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(8776));
        }
    }
}

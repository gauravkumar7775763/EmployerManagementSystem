using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployerManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 29, 23, 1, 11, 118, DateTimeKind.Local).AddTicks(9071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "City", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", "", "Mumbai", "Maharashtra", 12345.0 },
                    { 2, "456 Oak St", "", "Pune", "Maharashtra", 67890.0 }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "AddressId", "CreatedAt", "EmailAddress", "FirstName", "LastModifiedAt", "LastName" },
                values: new object[] { 1, new DateTime(2023, 12, 29, 23, 1, 11, 119, DateTimeKind.Local).AddTicks(601), "gaurav.thakur@gmail.com", "Gaurav", new DateTime(2023, 12, 29, 23, 1, 11, 119, DateTimeKind.Local).AddTicks(602), "Thakur" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "AddressId", "CreatedAt", "EmailAddress", "FirstName", "LastModifiedAt", "LastName" },
                values: new object[] { 2, new DateTime(2023, 12, 29, 23, 1, 11, 119, DateTimeKind.Local).AddTicks(605), "Amrish.Thakur@gmail.com", "Amrish", new DateTime(2023, 12, 29, 23, 1, 11, 119, DateTimeKind.Local).AddTicks(605), "Thakur" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressId",
                table: "Employees",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Address_AddressId",
                table: "Employees",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Address_AddressId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(8776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 29, 23, 1, 11, 118, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EmailAddress", "FirstName", "LastModifiedAt", "LastName" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9549), "john.doe@example.com", "John", new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9550), "Doe" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EmailAddress", "FirstName", "LastModifiedAt", "LastName" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9553), "jane.smith@example.com", "Jane", new DateTime(2023, 12, 29, 22, 16, 49, 903, DateTimeKind.Local).AddTicks(9553), "Smith" });
        }
    }
}

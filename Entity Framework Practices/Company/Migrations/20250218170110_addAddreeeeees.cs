using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class addAddreeeeees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeAddress",
                keyColumn: "EmpAddressId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "EmpAddressId", "Address", "EmployeeId" },
                values: new object[] { 2, "October", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeAddress",
                keyColumn: "EmpAddressId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "EmpAddressId", "Address", "EmployeeId" },
                values: new object[] { 1, "October", 0 });
        }
    }
}

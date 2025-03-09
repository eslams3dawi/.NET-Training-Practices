﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class MONAUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

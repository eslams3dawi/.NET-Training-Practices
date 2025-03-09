using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class Auditing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeptProject_Departments_departmentId",
                table: "DeptProject");

            migrationBuilder.DropForeignKey(
                name: "FK_DeptProject_Projects_projectId",
                table: "DeptProject");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Projects",
                newName: "PName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Projects",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "DeptProject",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "DeptProject",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DeptProject_projectId",
                table: "DeptProject",
                newName: "IX_DeptProject_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_DeptProject_departmentId",
                table: "DeptProject",
                newName: "IX_DeptProject_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "DeptName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeptProject_Departments_DepartmentId",
                table: "DeptProject",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeptProject_Projects_ProjectId",
                table: "DeptProject",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeptProject_Departments_DepartmentId",
                table: "DeptProject");

            migrationBuilder.DropForeignKey(
                name: "FK_DeptProject_Projects_ProjectId",
                table: "DeptProject");

            migrationBuilder.RenameColumn(
                name: "PName",
                table: "Projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "DeptProject",
                newName: "projectId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "DeptProject",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DeptProject_ProjectId",
                table: "DeptProject",
                newName: "IX_DeptProject_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_DeptProject_DepartmentId",
                table: "DeptProject",
                newName: "IX_DeptProject_departmentId");

            migrationBuilder.RenameColumn(
                name: "DeptName",
                table: "Departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeptProject_Departments_departmentId",
                table: "DeptProject",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeptProject_Projects_projectId",
                table: "DeptProject",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

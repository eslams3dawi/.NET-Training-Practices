using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddProcEmpDeptByID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROC GetEmployeeDepartmentById @Id INT
            AS
                BEGIN
                    SELECT * FROM Employees 
                    WHERE DepartmentId = @Id
                END"
            );
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC GetEmployeeDepartmentById");
        }
    }
}

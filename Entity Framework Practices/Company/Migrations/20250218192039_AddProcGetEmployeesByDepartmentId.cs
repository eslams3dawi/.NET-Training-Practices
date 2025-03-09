using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddProcGetEmployeesByDepartmentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE PROC GetEmployeesByDepartmentId @Id INT
AS
    BEGIN
        SELECT * FROM EMPLOYEES
        WHERE DepartmentId = @Id
    END
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC GetEmployeesByDepartmentId");
        }
    }
}

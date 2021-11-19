using Microsoft.EntityFrameworkCore.Migrations;

namespace Myapplication.Migrations
{
    public partial class yyzzkkll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "SerialNo", "EmployeeId", "EmployeeName", "EmployeeSalary" },
                values: new object[] { 1, 2, "Abhishek", 100000 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "SerialNo", "EmployeeId", "EmployeeName", "EmployeeSalary" },
                values: new object[] { 2, 4, "John", 100000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "SerialNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "SerialNo",
                keyValue: 2);
        }
    }
}

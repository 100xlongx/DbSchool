using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class NewGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 7, "Venting", 0.55f, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

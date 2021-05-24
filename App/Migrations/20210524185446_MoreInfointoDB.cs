using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class MoreInfointoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseName",
                value: "Spanish");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseName",
                value: "Geometry");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseName",
                value: "Mathematics");

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 4, "Mathematics", 0.75f, 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 5, "Mathematics", 0.85f, 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 6, "Geometry", 0.75f, 3 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "classification" },
                values: new object[] { 4, 0, "Sussy", "Backa", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseName",
                value: null);
        }
    }
}

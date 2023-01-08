using Microsoft.EntityFrameworkCore.Migrations;

namespace EGakko_Web.Migrations
{
    public partial class AddTeacherSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeacherSubjects",
                columns: new[] { "SubjectId", "TeacherId", "Id" },
                values: new object[,]
                {
                    { 3, 1, 1 },
                    { 4, 1, 2 },
                    { 8, 2, 3 },
                    { 9, 2, 4 },
                    { 2, 3, 5 },
                    { 5, 3, 6 },
                    { 6, 3, 7 },
                    { 45, 3, 8 },
                    { 7, 4, 9 },
                    { 12, 4, 10 },
                    { 10, 5, 11 },
                    { 11, 5, 12 },
                    { 24, 5, 13 },
                    { 18, 5, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "TeacherSubjects",
                keyColumns: new[] { "SubjectId", "TeacherId" },
                keyValues: new object[] { 45, 3 });
        }
    }
}

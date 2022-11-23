using Microsoft.EntityFrameworkCore.Migrations;

namespace EGakko_Web.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "StudyFields");

            migrationBuilder.InsertData(
                table: "StudyFields",
                columns: new[] { "Id", "Description", "GradeLevel", "Name", "SubjectId" },
                values: new object[,]
                {
                    { 1, null, "3rd Degree", "Modern Language-Sciences", null },
                    { 12, null, "3rd Degree", "Logistical Maritime Administration", null },
                    { 10, null, "3rd Degree", "Economy - Modern Languages", null },
                    { 9, null, "3rd Degree", "Economics - Mathematics", null },
                    { 8, null, "3rd Degree", "Tourism", null },
                    { 7, null, "3rd Degree", "Human Sciences", null },
                    { 11, null, "3rd Degree", "Commerce", null },
                    { 5, null, "3rd Degree", "Latin - Modern Languages", null },
                    { 4, null, "3rd Degree", "Latin mathematics", null },
                    { 3, null, "3rd Degree", "Science Mathematics", null },
                    { 2, null, "3rd Degree", "Engineering Sciences", null },
                    { 6, null, "3rd Degree", "latin -  Sciences", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 32, "Economics", null },
                    { 25, "Behavioral sciences", null },
                    { 26, "Cultural sciences", null },
                    { 27, "Human geography", null },
                    { 28, "Touristic culture", null },
                    { 29, "Touristic organization", null },
                    { 30, "Touristic spaces", null },
                    { 31, "Internship", null },
                    { 33, "Economics law", null },
                    { 39, "Economic Geography", null },
                    { 35, "Applied computer science / Dactylo", null },
                    { 36, "Accounting", null },
                    { 37, "Law", null },
                    { 38, "Business Economics", null },
                    { 24, "Natural sciences", null },
                    { 40, "Sales", null },
                    { 41, "Economics seminar", null },
                    { 42, "PAV", null },
                    { 43, "Applied Economics: Law", null },
                    { 34, "Logistics and maritime cases", null },
                    { 23, "Seminar", null },
                    { 17, "Applied physics", null },
                    { 21, "Scientific work chemistry", null },
                    { 1, "Dutch", null },
                    { 2, "French", null },
                    { 3, "English", null },
                    { 4, "German", null },
                    { 5, "Spanish", null },
                    { 6, "Latin", null },
                    { 7, "Mathematics", null },
                    { 8, "Geography", null },
                    { 9, "History", null },
                    { 22, "Research competencies", null },
                    { 10, "Biology", null },
                    { 12, "Physics", null },
                    { 13, @"Philosophical subjects
                ", null },
                    { 14, "Physical education", null },
                    { 15, "Applied biochemistry", null },
                    { 16, "Applied chemistry", null },
                    { 44, "Introduction to International Trade", null },
                    { 18, "Applied ecology", null },
                    { 19, "Applied computer science", null },
                    { 20, "Scientific work physics", null },
                    { 11, "Chemistry", null },
                    { 45, "Duits/Spaans", null }
                });

            migrationBuilder.InsertData(
                table: "FieldSubjects",
                columns: new[] { "Id", "FieldId", "HoursPerWeek", "IsCoreSubject", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, 5, true, 1 },
                    { 34, 3, 2, false, 14 },
                    { 20, 2, 2, false, 14 },
                    { 12, 1, 2, false, 14 },
                    { 96, 2, 2, false, 13 },
                    { 84, 7, 2, false, 13 },
                    { 72, 6, 2, false, 13 },
                    { 59, 5, 2, false, 13 },
                    { 47, 4, 2, false, 13 },
                    { 33, 3, 2, false, 13 },
                    { 19, 2, 2, false, 13 },
                    { 48, 4, 2, false, 14 },
                    { 11, 1, 2, false, 13 },
                    { 51, 4, 2, false, 12 },
                    { 37, 3, 2, false, 12 },
                    { 10, 1, 2, false, 12 },
                    { 75, 6, 2, false, 11 },
                    { 50, 4, 2, false, 11 },
                    { 36, 3, 2, false, 11 },
                    { 9, 1, 2, false, 11 },
                    { 74, 6, 2, false, 10 },
                    { 49, 4, 1, false, 10 },
                    { 35, 3, 2, false, 10 },
                    { 76, 6, 2, false, 12 },
                    { 21, 2, 3, false, 10 },
                    { 60, 5, 2, false, 14 },
                    { 85, 7, 2, false, 14 },
                    { 4, 1, 2, false, 45 },
                    { 103, 2, 7, false, 31 },
                    { 102, 2, 2, false, 30 },
                    { 101, 2, 2, false, 29 },
                    { 100, 2, 2, false, 28 },
                    { 89, 7, 3, false, 26 },
                    { 87, 7, 4, true, 25 },
                    { 98, 2, 1, false, 24 },
                    { 88, 7, 2, false, 24 },
                    { 63, 5, 2, false, 24 },
                    { 73, 6, 2, false, 14 },
                    { 86, 7, 1, false, 23 },
                    { 61, 5, 1, false, 22 },
                    { 39, 3, 1, false, 21 },
                    { 38, 3, 1, false, 20 },
                    { 104, 2, 1, false, 19 },
                    { 26, 2, 1, false, 19 },
                    { 25, 2, 3, false, 18 },
                    { 24, 2, 3, false, 17 },
                    { 23, 2, 3, false, 16 },
                    { 22, 2, 3, false, 15 },
                    { 97, 2, 2, false, 14 },
                    { 62, 5, 2, false, 23 },
                    { 8, 1, 2, false, 10 },
                    { 95, 2, 1, false, 9 },
                    { 83, 7, 2, false, 9 },
                    { 79, 7, 2, false, 3 },
                    { 67, 6, 2, false, 3 },
                    { 54, 5, 3, false, 3 },
                    { 42, 4, 2, false, 3 },
                    { 29, 3, 2, false, 3 },
                    { 15, 2, 2, false, 3 },
                    { 3, 1, 3, false, 3 },
                    { 91, 2, 3, false, 2 },
                    { 78, 7, 3, false, 2 },
                    { 66, 6, 3, false, 2 },
                    { 92, 2, 3, false, 3 },
                    { 53, 5, 4, false, 2 },
                    { 28, 3, 3, false, 2 },
                    { 14, 2, 2, false, 2 },
                    { 2, 1, 4, true, 2 },
                    { 90, 2, 4, false, 1 },
                    { 77, 7, 5, true, 1 },
                    { 65, 6, 5, true, 1 },
                    { 52, 5, 5, true, 1 },
                    { 40, 4, 5, true, 1 },
                    { 27, 3, 5, true, 1 },
                    { 13, 2, 3, false, 1 },
                    { 41, 4, 3, false, 2 },
                    { 99, 2, 3, false, 5 },
                    { 43, 4, 4, true, 6 },
                    { 55, 5, 4, true, 6 },
                    { 71, 6, 2, false, 9 },
                    { 58, 5, 2, false, 9 },
                    { 46, 4, 2, false, 9 },
                    { 32, 3, 2, false, 9 },
                    { 18, 2, 1, false, 9 },
                    { 7, 1, 2, false, 9 },
                    { 94, 2, 1, false, 8 },
                    { 82, 7, 2, false, 8 },
                    { 70, 6, 2, false, 8 },
                    { 57, 5, 1, false, 8 },
                    { 45, 4, 1, false, 8 },
                    { 31, 3, 2, false, 8 },
                    { 17, 2, 2, false, 8 },
                    { 6, 1, 2, false, 8 },
                    { 93, 2, 2, true, 7 },
                    { 81, 7, 3, false, 7 },
                    { 69, 6, 5, true, 7 },
                    { 56, 5, 3, true, 7 },
                    { 44, 4, 7, true, 7 },
                    { 30, 3, 7, true, 7 },
                    { 16, 2, 4, true, 7 },
                    { 5, 1, 5, true, 7 },
                    { 68, 6, 4, true, 6 },
                    { 64, 5, 2, false, 45 },
                    { 80, 7, 2, false, 45 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "FieldSubjects",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "StudyFields",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

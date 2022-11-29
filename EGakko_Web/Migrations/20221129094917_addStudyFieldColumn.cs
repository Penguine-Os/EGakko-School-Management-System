using Microsoft.EntityFrameworkCore.Migrations;

namespace EGakko_Web.Migrations
{
    public partial class addStudyFieldColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "StudyFields",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconName",
                value: "Moderne talen - wetenschappen.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconName",
                value: "techniek- wetenschapppen.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconName",
                value: "techniek- wetenschapppen.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "IconName",
                value: "Latijn.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 5,
                column: "IconName",
                value: "Latijn.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 6,
                column: "IconName",
                value: "Latijn.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 7,
                column: "IconName",
                value: "humane- wetenschappen.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 8,
                column: "IconName",
                value: "toerisme.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 9,
                column: "IconName",
                value: "Economie- wiskunde.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 10,
                column: "IconName",
                value: "Economie- wiskunde.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 11,
                column: "IconName",
                value: "Economie- wiskunde.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 12,
                column: "IconName",
                value: "Handel.png");

            migrationBuilder.UpdateData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: 13,
                column: "IconName",
                value: "Handel.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconName",
                table: "StudyFields");
        }
    }
}

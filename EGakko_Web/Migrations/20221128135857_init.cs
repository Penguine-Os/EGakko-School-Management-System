﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EGakko_Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FName = table.Column<string>(maxLength: 100, nullable: false),
                    LName = table.Column<string>(maxLength: 100, nullable: false),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<int>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomName = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salary = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DiplomaTitle = table.Column<string>(nullable: true),
                    CustomUserIdTeacher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_CustomUserIdTeacher",
                        column: x => x.CustomUserIdTeacher,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FieldId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyFields_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => new { x.SubjectId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FieldSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCoreSubject = table.Column<bool>(nullable: false),
                    HoursPerWeek = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldSubjects_StudyFields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "StudyFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentDate = table.Column<DateTime>(nullable: false),
                    FeesArePayed = table.Column<bool>(nullable: false),
                    CustomUserIdStudent = table.Column<string>(nullable: true),
                    FieldId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_CustomUserIdStudent",
                        column: x => x.CustomUserIdStudent,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_StudyFields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "StudyFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxScore = table.Column<int>(nullable: false),
                    Summery = table.Column<string>(nullable: true),
                    Activity = table.Column<int>(nullable: false),
                    FieldSubjectId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityEvaluations_FieldSubjects_FieldSubjectId",
                        column: x => x.FieldSubjectId,
                        principalTable: "FieldSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityEvaluations_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSchedules",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    FieldSubjectId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSchedules", x => new { x.FieldSubjectId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_FieldSubjects_FieldSubjectId",
                        column: x => x.FieldSubjectId,
                        principalTable: "FieldSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    EvaluationId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => new { x.StudentId, x.EvaluationId });
                    table.ForeignKey(
                        name: "FK_Results_ActivityEvaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "ActivityEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1, "3A" },
                    { 2, "4A" },
                    { 3, "5A" },
                    { 4, "6A" },
                    { 5, "6B" }
                });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Business Organization" },
                    { 4, "Economics & Trade" },
                    { 3, "STEM" },
                    { 2, "Human Studies" },
                    { 1, "Languages" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Capacity", "ClassRoomName" },
                values: new object[,]
                {
                    { 6, 20, "B101" },
                    { 5, 25, "A105" },
                    { 1, 25, "A101" },
                    { 2, 15, "A102" },
                    { 3, 30, "A103" },
                    { 4, 20, "A104" },
                    { 19, 20, "B104" },
                    { 18, 30, "B103" },
                    { 17, 20, "B102" },
                    { 16, 25, "B101" },
                    { 20, 15, "B105" },
                    { 14, 15, "C104" },
                    { 7, 20, "B102" },
                    { 15, 25, "C105" },
                    { 9, 15, "B104" },
                    { 10, 30, "B105" },
                    { 8, 15, "B103" },
                    { 12, 20, "C102" },
                    { 13, 15, "C103" },
                    { 11, 30, "C101" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 25, "Behavioral sciences" },
                    { 32, "Economics" },
                    { 26, "Cultural sciences" },
                    { 27, "Human geography" },
                    { 28, "Touristic culture" },
                    { 29, "Touristic organization" },
                    { 30, "Touristic spaces" },
                    { 31, "Internship" },
                    { 33, "Economics law" },
                    { 43, "Applied Economics: Law" },
                    { 35, "Applied computer science - Dactylo" },
                    { 36, "Accounting" },
                    { 37, "Law" },
                    { 38, "Business Economics" },
                    { 39, "Economic Geography" },
                    { 40, "Sales" },
                    { 41, "Economics seminar" },
                    { 42, "PAV" },
                    { 24, "Natural sciences" },
                    { 34, "Logistics and maritime cases" },
                    { 23, "Seminar" },
                    { 8, "Geography" },
                    { 21, "Scientific work chemistry" },
                    { 1, "Dutch" },
                    { 2, "French" },
                    { 3, "English" },
                    { 4, "German" },
                    { 5, "Spanish" },
                    { 6, "Latin" },
                    { 7, "Mathematics" },
                    { 44, "Introduction to International Trade" },
                    { 9, "History" },
                    { 22, "Research competencies" },
                    { 10, "Biology" },
                    { 12, "Physics" },
                    { 13, "Philosophical subjects" },
                    { 14, "Physical education" },
                    { 15, "Applied biochemistry" },
                    { 16, "Applied chemistry" },
                    { 17, "Applied physics" },
                    { 18, "Applied ecology" },
                    { 19, "Applied computer science" },
                    { 20, "Scientific work physics" },
                    { 11, "Chemistry" },
                    { 45, "Duits/Spaans" }
                });

            migrationBuilder.InsertData(
                table: "StudyFields",
                columns: new[] { "Id", "Description", "FieldId", "Name" },
                values: new object[,]
                {
                    { 1, "", 1, "Modern Language-Sciences" },
                    { 5, "", 1, "Latin - Modern Languages" },
                    { 11, "", 1, "Economy - Modern Languages" },
                    { 7, "", 2, "Human Sciences" },
                    { 8, "", 2, "Tourism" },
                    { 2, "", 3, "Engineering Sciences" },
                    { 3, "", 3, "Science Mathematics" },
                    { 4, "", 3, "Latin mathematics" },
                    { 6, "", 3, "latin -  Sciences" },
                    { 9, "", 4, "Economics - Mathematics" },
                    { 10, "", 4, "Economy - Modern Languages" },
                    { 12, "", 4, "Commerce" },
                    { 13, "", 5, "Logistical Maritime Administration" }
                });

            migrationBuilder.InsertData(
                table: "FieldSubjects",
                columns: new[] { "Id", "FieldId", "HoursPerWeek", "IsCoreSubject", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, 5, true, 1 },
                    { 35, 3, 2, false, 10 },
                    { 34, 3, 2, false, 14 },
                    { 33, 3, 2, false, 13 },
                    { 32, 3, 2, false, 9 },
                    { 31, 3, 2, false, 8 },
                    { 30, 3, 7, true, 7 },
                    { 29, 3, 2, false, 3 },
                    { 28, 3, 3, false, 2 },
                    { 27, 3, 5, true, 1 },
                    { 104, 2, 1, false, 19 },
                    { 36, 3, 2, false, 11 },
                    { 103, 2, 7, false, 31 },
                    { 101, 2, 2, false, 29 },
                    { 100, 2, 2, false, 28 },
                    { 99, 2, 3, false, 5 },
                    { 98, 2, 1, false, 24 },
                    { 97, 2, 2, false, 14 },
                    { 96, 2, 2, false, 13 },
                    { 95, 2, 1, false, 9 },
                    { 94, 2, 1, false, 8 },
                    { 93, 2, 2, true, 7 },
                    { 92, 2, 3, false, 3 },
                    { 102, 2, 2, false, 30 },
                    { 91, 2, 3, false, 2 },
                    { 37, 3, 2, false, 12 },
                    { 39, 3, 1, false, 21 },
                    { 74, 6, 2, false, 10 },
                    { 73, 6, 2, false, 14 },
                    { 72, 6, 2, false, 13 },
                    { 71, 6, 2, false, 9 },
                    { 70, 6, 2, false, 8 },
                    { 69, 6, 5, true, 7 },
                    { 68, 6, 4, true, 6 },
                    { 67, 6, 2, false, 3 },
                    { 66, 6, 3, false, 2 },
                    { 65, 6, 5, true, 1 },
                    { 38, 3, 1, false, 20 },
                    { 51, 4, 2, false, 12 },
                    { 49, 4, 1, false, 10 },
                    { 48, 4, 2, false, 14 },
                    { 47, 4, 2, false, 13 },
                    { 46, 4, 2, false, 9 },
                    { 45, 4, 1, false, 8 },
                    { 44, 4, 7, true, 7 },
                    { 43, 4, 4, true, 6 },
                    { 42, 4, 2, false, 3 },
                    { 41, 4, 3, false, 2 },
                    { 40, 4, 5, true, 1 },
                    { 50, 4, 2, false, 11 },
                    { 90, 2, 4, false, 1 },
                    { 26, 2, 1, false, 19 },
                    { 25, 2, 3, false, 18 },
                    { 62, 5, 2, false, 23 },
                    { 61, 5, 1, false, 22 },
                    { 60, 5, 2, false, 14 },
                    { 59, 5, 2, false, 13 },
                    { 58, 5, 2, false, 9 },
                    { 57, 5, 1, false, 8 },
                    { 56, 5, 3, true, 7 },
                    { 55, 5, 4, true, 6 },
                    { 54, 5, 3, false, 3 },
                    { 53, 5, 4, false, 2 },
                    { 63, 5, 2, false, 24 },
                    { 52, 5, 5, true, 1 },
                    { 11, 1, 2, false, 13 },
                    { 10, 1, 2, false, 12 },
                    { 9, 1, 2, false, 11 },
                    { 8, 1, 2, false, 10 },
                    { 7, 1, 2, false, 9 },
                    { 6, 1, 2, false, 8 },
                    { 5, 1, 5, true, 7 },
                    { 4, 1, 2, false, 45 },
                    { 3, 1, 3, false, 3 },
                    { 2, 1, 4, true, 2 },
                    { 12, 1, 2, false, 14 },
                    { 64, 5, 2, false, 45 },
                    { 77, 7, 5, true, 1 },
                    { 78, 7, 3, false, 2 },
                    { 24, 2, 3, false, 17 },
                    { 23, 2, 3, false, 16 },
                    { 22, 2, 3, false, 15 },
                    { 21, 2, 3, false, 10 },
                    { 20, 2, 2, false, 14 },
                    { 19, 2, 2, false, 13 },
                    { 18, 2, 1, false, 9 },
                    { 17, 2, 2, false, 8 },
                    { 16, 2, 4, true, 7 },
                    { 15, 2, 2, false, 3 },
                    { 14, 2, 2, false, 2 },
                    { 13, 2, 3, false, 1 },
                    { 89, 7, 3, false, 26 },
                    { 88, 7, 2, false, 24 },
                    { 87, 7, 4, true, 25 },
                    { 86, 7, 1, false, 23 },
                    { 85, 7, 2, false, 14 },
                    { 84, 7, 2, false, 13 },
                    { 83, 7, 2, false, 9 },
                    { 82, 7, 2, false, 8 },
                    { 81, 7, 3, false, 7 },
                    { 80, 7, 2, false, 45 },
                    { 79, 7, 2, false, 3 },
                    { 75, 6, 2, false, 11 },
                    { 76, 6, 2, false, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityEvaluations_FieldSubjectId",
                table: "ActivityEvaluations",
                column: "FieldSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityEvaluations_TeacherId",
                table: "ActivityEvaluations",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_ClassId",
                table: "ClassSchedules",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_LocationId",
                table: "ClassSchedules",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_TeacherId",
                table: "ClassSchedules",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldSubjects_FieldId",
                table: "FieldSubjects",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldSubjects_SubjectId",
                table: "FieldSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_EvaluationId",
                table: "Results",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CustomUserIdStudent",
                table: "Students",
                column: "CustomUserIdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FieldId",
                table: "Students",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyFields_FieldId",
                table: "StudyFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CustomUserIdTeacher",
                table: "Teachers",
                column: "CustomUserIdTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherId",
                table: "TeacherSubjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "ClassSchedules");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "ActivityEvaluations");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "FieldSubjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "StudyFields");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Field");
        }
    }
}

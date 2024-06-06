using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRanking.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicReputations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicReputationScore = table.Column<double>(type: "float", nullable: false),
                    FacultyQuality = table.Column<double>(type: "float", nullable: false),
                    ResearchOutput = table.Column<double>(type: "float", nullable: false),
                    StudentSatisfaction = table.Column<double>(type: "float", nullable: false),
                    InternationalCollaboration = table.Column<double>(type: "float", nullable: false),
                    AwardsAndRecognitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicReputations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitationCount = table.Column<int>(type: "int", nullable: false),
                    PublicationCount = table.Column<int>(type: "int", nullable: false),
                    HIndex = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployerReputations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenditurePerEmployees = table.Column<double>(type: "float", nullable: false),
                    EmployerReputationScore = table.Column<double>(type: "float", nullable: false),
                    EmployerFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobPlacementRate = table.Column<double>(type: "float", nullable: false),
                    AverageSalary = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerReputations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentRate = table.Column<double>(type: "float", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageSalary = table.Column<double>(type: "float", nullable: false),
                    TopEmployers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentSectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacultyStudentRatios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaleAmount = table.Column<int>(type: "int", nullable: false),
                    FemaleAmount = table.Column<int>(type: "int", nullable: false),
                    StudentCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyStudentRatios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForeignStudentRatios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentCountries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperiorCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentAmount = table.Column<int>(type: "int", nullable: false),
                    InternationalStudentAmount = table.Column<int>(type: "int", nullable: false),
                    UsefullUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignStudentRatios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternationalTeachersRatios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherCountries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperiorCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeachersAmount = table.Column<int>(type: "int", nullable: false),
                    InternationalTeacherAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternationalTeachersRatios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchNetworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Members = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollaboratingOrganizations = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchNetworks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentStability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalStudents = table.Column<int>(type: "int", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentsRemaining = table.Column<int>(type: "int", nullable: false),
                    StudentsMoved = table.Column<int>(type: "int", nullable: false),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionStatement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityAccreditingBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalPerimeterInclusions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalPerimeterExclusions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicReputations");

            migrationBuilder.DropTable(
                name: "Citations");

            migrationBuilder.DropTable(
                name: "EmployerReputations");

            migrationBuilder.DropTable(
                name: "EmploymentResults");

            migrationBuilder.DropTable(
                name: "FacultyStudentRatios");

            migrationBuilder.DropTable(
                name: "ForeignStudentRatios");

            migrationBuilder.DropTable(
                name: "InternationalTeachersRatios");

            migrationBuilder.DropTable(
                name: "ResearchNetworks");

            migrationBuilder.DropTable(
                name: "StudentStability");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

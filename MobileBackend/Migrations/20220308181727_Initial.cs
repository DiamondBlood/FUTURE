using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileBackend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FatDownProgress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatDownProgressId = table.Column<int>(type: "int", nullable: false),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FatDownProgress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MuscleUpProgress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MuscleUpProgressId = table.Column<int>(type: "int", nullable: false),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleUpProgress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReliefProgress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReliefProgressId = table.Column<int>(type: "int", nullable: false),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReliefProgress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserFatDownProgress",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FatDownProgressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserMuscleUpProgress",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MuscleUpProgress = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserReliefProgress",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ReliefID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FatDownProgress");

            migrationBuilder.DropTable(
                name: "MuscleUpProgress");

            migrationBuilder.DropTable(
                name: "ReliefProgress");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "UserFatDownProgress");

            migrationBuilder.DropTable(
                name: "UserMuscleUpProgress");

            migrationBuilder.DropTable(
                name: "UserReliefProgress");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rugby_stat_tracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: true),
                    Hometown = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Minutes = table.Column<int>(type: "int", nullable: false),
                    Tries = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IndividualGames",
                columns: new[] { "Id", "Minutes", "PlayerId", "Position", "Tries" },
                values: new object[,]
                {
                    { 1, 80, null, 13, 1 },
                    { 2, 80, null, 13, 1 },
                    { 3, 80, null, 13, 1 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Birthdate", "Hometown", "Name", "Position" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson, MO", "Eric Davidson", 13 },
                    { 2, new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson, New Zealand", "Aidan Milne", 12 },
                    { 3, new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Victor Romero", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualGames_PlayerId",
                table: "IndividualGames",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndividualGames");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}

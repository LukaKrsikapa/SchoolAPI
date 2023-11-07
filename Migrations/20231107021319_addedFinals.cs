using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedFinals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Finals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finals_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Finals_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Finals",
                columns: new[] { "Id", "CourseId", "Date", "Mark", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, "Primer polaganja 1", 1 },
                    { 2, 1, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, "Primer polaganja 2", 2 },
                    { 3, 2, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, "Primer polaganja 3", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finals_CourseId",
                table: "Finals",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Finals_StudentId",
                table: "Finals",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Finals");
        }
    }
}

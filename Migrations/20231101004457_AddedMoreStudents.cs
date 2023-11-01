using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, 2, "Radovan", "Andjelkovic" },
                    { 4, 1, "Kristina", "Jakovljevic" },
                    { 5, 1, "Tijana", "Gladic" },
                    { 6, 1, "Andrija", "Marjanovic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRecord.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentClass", "StudentName" },
                values: new object[] { 4, 9, "POPO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);
        }
    }
}

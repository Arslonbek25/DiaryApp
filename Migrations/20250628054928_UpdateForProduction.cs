using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForProduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Went hiking with friends. Great weather and views.", "Went Hiking" });

            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Drove to the coast. Enjoyed the scenic route.", "Road Trip" });

            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Tried diving. Saw colorful fish and coral.", "Diving Adventure" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title" },
                values: new object[] { "With bros", "Went hiking" });

            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Title" },
                values: new object[] { "123", "Drove" });

            migrationBuilder.UpdateData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title" },
                values: new object[] { "abc", "Diving" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntry",
                columns: new[] { "Id", "Content", "DateCreated", "Title" },
                values: new object[,]
                {
                    { 1, "With bros", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Went hiking" },
                    { 2, "123", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Drove" },
                    { 3, "abc", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntry",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

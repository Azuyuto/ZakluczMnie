using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZakluczMnie.Data.Migrations
{
    /// <inheritdoc />
    public partial class insert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Riddles",
                columns: new[] { "Id", "Number", "Url" },
                values: new object[,]
                {
                    { new Guid("05099cbc-9500-48a6-b5a5-de15e9a9bba5"), 1, "Start" },
                    { new Guid("f2b6ed62-902c-4002-a74d-c846b4feb74f"), 2, "Next" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Riddles",
                keyColumn: "Id",
                keyValue: new Guid("05099cbc-9500-48a6-b5a5-de15e9a9bba5"));

            migrationBuilder.DeleteData(
                table: "Riddles",
                keyColumn: "Id",
                keyValue: new Guid("f2b6ed62-902c-4002-a74d-c846b4feb74f"));
        }
    }
}

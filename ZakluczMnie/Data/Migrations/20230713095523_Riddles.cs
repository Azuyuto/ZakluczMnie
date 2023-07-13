using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZakluczMnie.Data.Migrations
{
    /// <inheritdoc />
    public partial class Riddles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Riddles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riddles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRiddles",
                columns: table => new
                {
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RiddleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnded = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRiddles", x => new { x.AspNetUserId, x.RiddleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRiddle_Riddle",
                        column: x => x.RiddleId,
                        principalTable: "Riddles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRiddle_User",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRiddles_RiddleId",
                table: "AspNetUserRiddles",
                column: "RiddleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserRiddles");

            migrationBuilder.DropTable(
                name: "Riddles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}

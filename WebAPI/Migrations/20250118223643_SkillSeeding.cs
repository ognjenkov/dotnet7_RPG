using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SkillSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { new Guid("0eecdf70-2df9-4af6-950a-47a2d9d3c053"), 10, "Frenzy" },
                    { new Guid("d60cbb2b-5794-4917-99fb-270e82354562"), 30, "Fireball" },
                    { new Guid("e8cfa961-505f-492a-a138-2ae61a233c83"), 20, "Blizzard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0eecdf70-2df9-4af6-950a-47a2d9d3c053"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d60cbb2b-5794-4917-99fb-270e82354562"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e8cfa961-505f-492a-a138-2ae61a233c83"));
        }
    }
}

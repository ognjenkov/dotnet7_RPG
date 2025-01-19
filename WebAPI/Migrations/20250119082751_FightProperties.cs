using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FightProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Defeats",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fights",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Victories",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { new Guid("0b00ab8a-8d78-4087-b3f8-eff2bafce08e"), 10, "Frenzy" },
                    { new Guid("195ec359-0cf7-4a6b-9f66-aaccb40a8bcf"), 20, "Blizzard" },
                    { new Guid("892a4e8f-f006-4553-a5d2-cec1bddccae8"), 30, "Fireball" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0b00ab8a-8d78-4087-b3f8-eff2bafce08e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("195ec359-0cf7-4a6b-9f66-aaccb40a8bcf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("892a4e8f-f006-4553-a5d2-cec1bddccae8"));

            migrationBuilder.DropColumn(
                name: "Defeats",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Fights",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Victories",
                table: "Characters");

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
    }
}

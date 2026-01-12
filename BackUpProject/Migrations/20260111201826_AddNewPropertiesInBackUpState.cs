using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackUpProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertiesInBackUpState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastBackUp",
                table: "PathToBackUps");

            migrationBuilder.AddColumn<string>(
                name: "DbName",
                table: "BackUpStates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastBackUp",
                table: "BackUpStates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DbName",
                table: "BackUpStates");

            migrationBuilder.DropColumn(
                name: "LastBackUp",
                table: "BackUpStates");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastBackUp",
                table: "PathToBackUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

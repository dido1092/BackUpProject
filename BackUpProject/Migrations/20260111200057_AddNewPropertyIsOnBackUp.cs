using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackUpProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertyIsOnBackUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOnBackUp",
                table: "PathToBackUps",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnBackUp",
                table: "PathToBackUps");
        }
    }
}

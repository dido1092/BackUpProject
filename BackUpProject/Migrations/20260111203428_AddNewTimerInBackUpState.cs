using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackUpProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTimerInBackUpState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Timer",
                table: "BackUpStates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timer",
                table: "BackUpStates");
        }
    }
}

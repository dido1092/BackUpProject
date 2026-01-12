using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackUpProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTableBackupState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnBackUp",
                table: "PathToBackUps");

            migrationBuilder.CreateTable(
                name: "BackUpStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateIsOn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackUpStates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackUpStates");

            migrationBuilder.AddColumn<bool>(
                name: "IsOnBackUp",
                table: "PathToBackUps",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

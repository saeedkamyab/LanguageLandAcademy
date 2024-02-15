using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagmentSystem.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class rewrittingLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LevelType",
                table: "Levels",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "LevelName",
                table: "Levels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LevelDescription",
                table: "Levels",
                newName: "Description");

            migrationBuilder.AddColumn<double>(
                name: "Fee",
                table: "Levels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Levels");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Levels",
                newName: "LevelType");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Levels",
                newName: "LevelName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Levels",
                newName: "LevelDescription");
        }
    }
}

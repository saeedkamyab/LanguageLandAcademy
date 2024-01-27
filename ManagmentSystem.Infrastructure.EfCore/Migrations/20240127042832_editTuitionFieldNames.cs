using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagmentSystem.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class editTuitionFieldNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinanceDescription",
                table: "Tuitions");

            migrationBuilder.RenameColumn(
                name: "FinanceStatus",
                table: "Tuitions",
                newName: "TuitionStatus");

            migrationBuilder.RenameColumn(
                name: "FinancePayDate",
                table: "Tuitions",
                newName: "TuitionPayDate");

            migrationBuilder.RenameColumn(
                name: "FinanceAmount",
                table: "Tuitions",
                newName: "TuitionAmount");

            migrationBuilder.AddColumn<string>(
                name: "TuitionDescription",
                table: "Tuitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TuitionDescription",
                table: "Tuitions");

            migrationBuilder.RenameColumn(
                name: "TuitionStatus",
                table: "Tuitions",
                newName: "FinanceStatus");

            migrationBuilder.RenameColumn(
                name: "TuitionPayDate",
                table: "Tuitions",
                newName: "FinancePayDate");

            migrationBuilder.RenameColumn(
                name: "TuitionAmount",
                table: "Tuitions",
                newName: "FinanceAmount");

            migrationBuilder.AddColumn<string>(
                name: "FinanceDescription",
                table: "Tuitions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}

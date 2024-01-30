using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagmentSystem.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class ManagmentSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tuitions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuitionAmount = table.Column<double>(type: "float", nullable: false),
                    TuitionStatus = table.Column<bool>(type: "bit", nullable: false),
                    TuitionPayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TuitionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuitions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tuitions");
        }
    }
}

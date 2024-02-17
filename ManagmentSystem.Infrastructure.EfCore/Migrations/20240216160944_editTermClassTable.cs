using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagmentSystem.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class editTermClassTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TermClass_Rooms_RoomId",
                table: "TermClass");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_TermClass_RoomId",
                table: "TermClass");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "TermClass");

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "TermClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "TermClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "TermClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "TermClass",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TermClass");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "TermClass");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "TermClass");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TermClass");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "TermClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AccountId = table.Column<long>(type: "bigint", nullable: false),
                    TermClassId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_TermClass_Id",
                        column: x => x.Id,
                        principalTable: "TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TermClass_RoomId",
                table: "TermClass",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_TermClass_Rooms_RoomId",
                table: "TermClass",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class iasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonImages");

            migrationBuilder.DropColumn(
                name: "PersonImageId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "PersonImageBase64String",
                table: "People",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonImageBase64String",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "PersonImageId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PersonImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Base64String = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedById = table.Column<int>(type: "int", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonImages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class laste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Researches_PublicationId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_PublicationId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Authors",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AuthorPublication",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    PublicationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPublication", x => new { x.AuthorsId, x.PublicationsId });
                    table.ForeignKey(
                        name: "FK_AuthorPublication_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPublication_Researches_PublicationsId",
                        column: x => x.PublicationsId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPublication_PublicationsId",
                table: "AuthorPublication",
                column: "PublicationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPublication");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "PublicationId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_PublicationId",
                table: "Authors",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Researches_PublicationId",
                table: "Authors",
                column: "PublicationId",
                principalTable: "Researches",
                principalColumn: "Id");
        }
    }
}

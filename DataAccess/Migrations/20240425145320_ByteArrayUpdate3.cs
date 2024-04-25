using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ByteArrayUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBase64ByteArray",
                table: "Collaborations");

            migrationBuilder.AddColumn<string>(
                name: "ImageBase64String",
                table: "Collaborations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBase64String",
                table: "Collaborations");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageBase64ByteArray",
                table: "Collaborations",
                type: "longblob",
                nullable: false);
        }
    }
}

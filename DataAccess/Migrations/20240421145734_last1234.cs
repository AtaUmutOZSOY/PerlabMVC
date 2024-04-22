using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class last1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "PersonImages",
                newName: "Base64String");

            migrationBuilder.AddColumn<int>(
                name: "PersonImageId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonImageId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "Base64String",
                table: "PersonImages",
                newName: "ImagePath");
        }
    }
}

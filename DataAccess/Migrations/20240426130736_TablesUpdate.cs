using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TablesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Researches");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "People");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "People");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "People");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "NewsFeeds");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "CarouselImages");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Authors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "UserOperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "UserOperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "UserOperationClaims",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "UserOperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "UserOperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "UserOperationClaims",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Researches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Researches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Researches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Researches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Researches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Researches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "People",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "People",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "OperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "OperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "OperationClaims",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "OperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "OperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "OperationClaims",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "NewsFeeds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "NewsFeeds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "NewsFeeds",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "NewsFeeds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "NewsFeeds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "NewsFeeds",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Collaborations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Collaborations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Collaborations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Collaborations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Collaborations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Collaborations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "CarouselImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "CarouselImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "CarouselImages",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "CarouselImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "CarouselImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "CarouselImages",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Authors",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Authors",
                type: "datetime(6)",
                nullable: true);
        }
    }
}

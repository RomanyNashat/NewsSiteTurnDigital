using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsSiteTurnDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewsItemsIsFirstPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "NewsItems");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NewsItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFirstPage",
                table: "NewsItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "NewsItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "NewsCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "NewsCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NewsCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "NewsCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "NewsCategories",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "IsFirstPage",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "NewsCategories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "NewsCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NewsCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "NewsCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "NewsCategories");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "NewsItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

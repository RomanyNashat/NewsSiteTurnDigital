using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsSiteTurnDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_Admin_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "123456@TurnDigital");

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 8, 14, 9, 303, DateTimeKind.Local).AddTicks(702));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "85967485@TurnDigital");

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3862));
        }
    }
}

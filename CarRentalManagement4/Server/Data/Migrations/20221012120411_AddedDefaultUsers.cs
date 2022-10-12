using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement4.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0c36f20c-c1b1-4ab5-9366-33544d417668");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "2af796d7-6fbf-49c8-99d3-e37c44355d2d");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 650, DateTimeKind.Local).AddTicks(5089), new DateTime(2022, 10, 12, 19, 4, 10, 651, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 651, DateTimeKind.Local).AddTicks(6080), new DateTime(2022, 10, 12, 19, 4, 10, 651, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 652, DateTimeKind.Local).AddTicks(7309), new DateTime(2022, 10, 12, 19, 4, 10, 652, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 652, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 10, 12, 19, 4, 10, 652, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1108), new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1113), new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1116), new DateTime(2022, 10, 12, 19, 4, 10, 653, DateTimeKind.Local).AddTicks(1117) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7f249cf5-fa45-4c29-a91d-a68a0e97a24d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "debc0212-9b5d-4ea5-bf68-20535e623363");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 6, DateTimeKind.Local).AddTicks(1357), new DateTime(2022, 10, 12, 18, 25, 48, 7, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 7, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 10, 12, 18, 25, 48, 7, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(4671), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8733), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8738), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8741), new DateTime(2022, 10, 12, 18, 25, 48, 8, DateTimeKind.Local).AddTicks(8742) });
        }
    }
}

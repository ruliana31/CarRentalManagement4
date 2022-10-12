using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement4.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "7f249cf5-fa45-4c29-a91d-a68a0e97a24d", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "debc0212-9b5d-4ea5-bf68-20535e623363", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 944, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(6871), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7222) });
        }
    }
}

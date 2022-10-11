using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement4.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 10, 11, 20, 56, 54, 944, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(993), "Black", "System" },
                    { 2, "System", new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 10, 11, 20, 56, 54, 946, DateTimeKind.Local).AddTicks(1889), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3374), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(3705), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(6871), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(6876), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7217), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7220), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 10, 11, 20, 56, 54, 947, DateTimeKind.Local).AddTicks(7222), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

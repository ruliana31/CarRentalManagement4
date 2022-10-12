using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;


namespace CarRentalManagement4.Server.Data.Migrations
{
    public partial class AddingDuendeKeys : Migration
    {
        private string name;
        private object table;

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name = "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "59ee94d7-c97a-431f-a243-fbc8e19feb49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e742eabd-b3a1-4d6a-adde-310ac3c98ac8");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 156, DateTimeKind.Local).AddTicks(6265), new DateTime(2022, 10, 12, 19, 11, 15, 158, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 158, DateTimeKind.Local).AddTicks(1706), new DateTime(2022, 10, 12, 19, 11, 15, 158, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 159, DateTimeKind.Local).AddTicks(8155), new DateTime(2022, 10, 12, 19, 11, 15, 159, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 159, DateTimeKind.Local).AddTicks(8556), new DateTime(2022, 10, 12, 19, 11, 15, 159, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2742), new DateTime(2022, 10, 12, 19, 11, 15, 160, DateTimeKind.Local).AddTicks(2743) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

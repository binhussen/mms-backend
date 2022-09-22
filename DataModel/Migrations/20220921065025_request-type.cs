using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class requesttype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "08344018-b79b-4728-b902-96667305328c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0bfb514d-2df0-4949-8362-1857d535ee0c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5c595692-70f3-4c5f-87f3-d0b4bf7e6847");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "RequestHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Unspecified).AddTicks(9675), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Unspecified).AddTicks(9676), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Unspecified).AddTicks(9678), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9599), new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9603), new DateTime(2022, 9, 21, 9, 50, 24, 573, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2182e60f-bcdb-472c-b3a3-cbaa55c387bc", "207adadc-884d-4a72-a79a-bcc7652687f8", "mmd", "MMD" },
                    { "690ce6ce-6def-457b-9d3e-7ae032c23191", "80e238ee-a1a7-4cfb-85f5-9706ada7d5d1", "storeman", "storeman" },
                    { "6f9ab7fe-f405-4cf0-9156-b61c12e09e66", "d97aa17b-2b92-400c-8906-95063946c7aa", "Admin", "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2182e60f-bcdb-472c-b3a3-cbaa55c387bc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "690ce6ce-6def-457b-9d3e-7ae032c23191");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6f9ab7fe-f405-4cf0-9156-b61c12e09e66");

            migrationBuilder.DropColumn(
                name: "type",
                table: "RequestHeaders");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Unspecified).AddTicks(4072), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3974), new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3987), new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3989), new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3991), new DateTime(2022, 8, 28, 15, 2, 40, 292, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08344018-b79b-4728-b902-96667305328c", "b68f1275-efc8-45e3-ac8c-90ee2011c005", "Admin", "Admin" },
                    { "0bfb514d-2df0-4949-8362-1857d535ee0c", "0a6d6854-5ff4-4483-8db6-e3dc0e398b33", "storeman", "storeman" },
                    { "5c595692-70f3-4c5f-87f3-d0b4bf7e6847", "6c513015-fcf9-4ae8-8065-f50d3c280812", "mmd", "MMD" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class stores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7d26ee3c-fff3-44d0-aa47-4e2af568f2f1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c0634576-91f8-469e-b765-86dfcfe12e65");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f8bc4d77-0a5e-480b-9038-e7f6d6c1a4e1");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Unspecified).AddTicks(6541), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Unspecified).AddTicks(6565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6242), new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6257), new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6259), new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6261), new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6263), new DateTime(2022, 11, 2, 11, 29, 3, 477, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "157b15ce-8eff-4ca9-8632-f13c9d26a924", "00ab3b70-f091-4e9b-aaea-e594e0944f07", "storeman", "storeman" },
                    { "a558bf95-cb21-4493-a250-da9d7dac8434", "d2317e8a-6c1b-4c2f-8a99-10bc298ddee4", "mmd", "MMD" },
                    { "bf39e758-8fb9-48ed-9339-b127f2fe0dc6", "cd20b2ca-3f5d-4b76-b25b-9586a1866061", "Admin", "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "157b15ce-8eff-4ca9-8632-f13c9d26a924");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a558bf95-cb21-4493-a250-da9d7dac8434");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bf39e758-8fb9-48ed-9339-b127f2fe0dc6");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Unspecified).AddTicks(932), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Unspecified).AddTicks(952), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(846), new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(861), new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(863), new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(865), new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(866), new DateTime(2022, 11, 2, 11, 24, 21, 313, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d26ee3c-fff3-44d0-aa47-4e2af568f2f1", "1d7a3db3-856d-4b8f-a1b5-6db79450a53a", "mmd", "MMD" },
                    { "c0634576-91f8-469e-b765-86dfcfe12e65", "969ed7f5-b07b-4ea2-b960-80f80e7d2e27", "storeman", "storeman" },
                    { "f8bc4d77-0a5e-480b-9038-e7f6d6c1a4e1", "1be96ce9-ab94-4ddb-b4e5-bd85dd895fc8", "Admin", "Admin" }
                });
        }
    }
}

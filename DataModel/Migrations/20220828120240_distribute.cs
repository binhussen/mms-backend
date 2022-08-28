using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class distribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "076093ab-a771-41e9-b455-a8fd2f76af0c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "865d662b-00f9-469b-a037-e2f43b1e11bb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cba76640-1065-45ab-a596-26ee75556a50");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Unspecified).AddTicks(7502), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7424), new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7434), new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7436), new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7437), new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 8, 26, 22, 50, 21, 876, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "076093ab-a771-41e9-b455-a8fd2f76af0c", "f67ca778-d4a5-46cd-a3b0-5a53638ff82c", "storeman", "storeman" },
                    { "865d662b-00f9-469b-a037-e2f43b1e11bb", "def45cad-f32f-4b23-8ee5-ee277eb09142", "Admin", "Admin" },
                    { "cba76640-1065-45ab-a596-26ee75556a50", "b8cb37d2-b276-4c62-92b2-99a3de974857", "mmd", "MMD" }
                });
        }
    }
}

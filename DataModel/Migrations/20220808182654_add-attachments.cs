using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class addattachments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5a7de58b-bd94-4748-931c-4569662bae3d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5ebf5f68-41d4-4686-877a-31a2fd9dc657");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d76b4438-0c88-4741-8688-30eda06a9b7c");

            migrationBuilder.AddColumn<string>(
                name: "attachments",
                table: "Approves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7869), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7876), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7876), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7878), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Unspecified).AddTicks(7878), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7788), new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7801), new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7803), new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7804), new DateTime(2022, 8, 8, 21, 26, 54, 493, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32276ecd-f93e-4296-b8f3-8435db09b5ab", "e5cb8083-03d8-425e-9f67-29b591f67536", "Admin", "Admin" },
                    { "4d9d08e9-faef-401f-a213-b0aca6a2df9e", "23bc48d4-8051-4679-aefa-26f5f3d46673", "storeman", "storeman" },
                    { "dbfc5b3b-ccef-4f7a-a6e2-32a2d2509122", "faa5cc01-f55a-45d7-8764-9e5c5fe2c877", "mmd", "MMD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "32276ecd-f93e-4296-b8f3-8435db09b5ab");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4d9d08e9-faef-401f-a213-b0aca6a2df9e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dbfc5b3b-ccef-4f7a-a6e2-32a2d2509122");

            migrationBuilder.DropColumn(
                name: "attachments",
                table: "Approves");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6775), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6777), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6639), new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6655), new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6658), new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6659), new DateTime(2022, 8, 8, 21, 4, 7, 756, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a7de58b-bd94-4748-931c-4569662bae3d", "cf81c9c3-2071-4315-b094-352029fd635d", "storeman", "storeman" },
                    { "5ebf5f68-41d4-4686-877a-31a2fd9dc657", "b49ae7cb-be5e-4d5b-a602-5e8c1e74c155", "Admin", "Admin" },
                    { "d76b4438-0c88-4741-8688-30eda06a9b7c", "c669f29d-69f2-45ec-b89a-27aa01af38eb", "mmd", "MMD" }
                });
        }
    }
}

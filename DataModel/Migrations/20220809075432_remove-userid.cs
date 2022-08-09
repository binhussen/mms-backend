using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class removeuserid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "userId",
                table: "Distributes");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(272), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Unspecified).AddTicks(275), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(137), new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(152), new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(178), new DateTime(2022, 8, 9, 10, 54, 32, 157, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44115d80-cb02-483b-b65c-f1cf8dde2701", "ce9e9d02-3e60-4c56-9382-e225954e5332", "storeman", "storeman" },
                    { "51b30786-74ca-4ae2-bc0f-390aa7afd182", "ebefce79-4aa4-4318-873a-fecfd8ff4fae", "mmd", "MMD" },
                    { "64113ad6-c667-460b-a69a-cd4bb11d3b19", "f3a06028-9c15-40db-abc9-cf30a0d9327e", "Admin", "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "44115d80-cb02-483b-b65c-f1cf8dde2701");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "51b30786-74ca-4ae2-bc0f-390aa7afd182");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "64113ad6-c667-460b-a69a-cd4bb11d3b19");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Distributes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}

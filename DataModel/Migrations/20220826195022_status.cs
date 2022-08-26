using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ba64a89-14f6-4541-b726-6031a8633771");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2cae8b48-ce95-4042-9e57-9478590cf7b1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d46e8e1c-5403-4110-8526-becd0e4923f1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Unspecified).AddTicks(3466), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3337), new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3351), new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3354), new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3355), new DateTime(2022, 8, 26, 22, 34, 31, 526, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ba64a89-14f6-4541-b726-6031a8633771", "c7911519-f013-4b63-82f6-020eb8da0ea9", "Admin", "Admin" },
                    { "2cae8b48-ce95-4042-9e57-9478590cf7b1", "bcd6fcbf-c9d3-4f99-983e-8fc65ccd7a23", "storeman", "storeman" },
                    { "d46e8e1c-5403-4110-8526-becd0e4923f1", "df25bccd-e380-483b-acdf-7e34c1421cb5", "mmd", "MMD" }
                });
        }
    }
}

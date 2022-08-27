using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class distr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "503c4b5b-5d07-4cce-8fb7-85a72186b6e0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7b3935ec-1ad4-4076-ba13-81ab9a3ace6a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d61161de-7d58-4090-90bb-25b701bae57f");

            migrationBuilder.AddColumn<int>(
                name: "distributeQuantity",
                table: "RequestItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "distributeQuantity",
                table: "RequestItems");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Unspecified).AddTicks(6598), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6511), new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6525), new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6526), new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 8, 26, 22, 24, 6, 563, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "503c4b5b-5d07-4cce-8fb7-85a72186b6e0", "3000467d-103d-4a4e-95e4-32ff83ff65fc", "storeman", "storeman" },
                    { "7b3935ec-1ad4-4076-ba13-81ab9a3ace6a", "1eb5a342-be04-4f3e-8c15-8474f3b8c0c1", "Admin", "Admin" },
                    { "d61161de-7d58-4090-90bb-25b701bae57f", "8475f820-cfbf-4582-898a-63e20f2fcd72", "mmd", "MMD" }
                });
        }
    }
}

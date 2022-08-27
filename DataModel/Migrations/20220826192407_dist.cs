using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class dist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5a20edab-c465-445c-bec0-d4f993e0f8c9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b94a7bb8-6a49-4bc2-a810-9c307abf8ec7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f17aa31b-e420-48bd-aff1-d99b1db53dcc");

            migrationBuilder.RenameColumn(
                name: "approvedQuantity",
                table: "Distributes",
                newName: "distributeQuantity");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "distributeQuantity",
                table: "Distributes",
                newName: "approvedQuantity");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Unspecified).AddTicks(5189), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5068), new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5086), new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5087), new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5091), new DateTime(2022, 8, 20, 17, 16, 4, 338, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a20edab-c465-445c-bec0-d4f993e0f8c9", "7e2b2a6b-204a-467c-ac2c-6071b1625366", "storeman", "storeman" },
                    { "b94a7bb8-6a49-4bc2-a810-9c307abf8ec7", "d9a699d1-f2d3-4689-a395-1f0ae697674e", "mmd", "MMD" },
                    { "f17aa31b-e420-48bd-aff1-d99b1db53dcc", "cbea3c62-a6f8-4943-9fca-b93613c16792", "Admin", "Admin" }
                });
        }
    }
}

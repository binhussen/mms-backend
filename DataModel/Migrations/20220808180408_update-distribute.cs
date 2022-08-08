using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class updatedistribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "33fcc74d-265a-4faa-a0c9-e76cb6abd580");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3fc8cda0-d45c-4949-b7b4-081b9cc21d8b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9983c6cd-45e3-4141-8c2a-90a8e1637a7a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Distributes");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                columns: new[] { "birthDate", "timeLimit" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7582), new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7596), new DateTime(2022, 8, 1, 10, 39, 47, 957, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33fcc74d-265a-4faa-a0c9-e76cb6abd580", "d69a8986-163e-486d-a17d-480acc7d035c", "Admin", "Admin" },
                    { "3fc8cda0-d45c-4949-b7b4-081b9cc21d8b", "895ad922-498e-4f70-b10a-9f4be6c73b14", "mmd", "MMD" },
                    { "9983c6cd-45e3-4141-8c2a-90a8e1637a7a", "0a4be211-9047-458a-b5cc-3028e8c37334", "storeman", "storeman" }
                });
        }
    }
}

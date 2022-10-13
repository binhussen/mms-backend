using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class manager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3fdbdc8c-5878-4ffa-afb7-b0c3c88dba0b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "41c2d1fc-cdd9-4744-bb3e-e323a883dcbc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "64fbf566-5f0e-4dc6-b633-2b152e210191");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9e171307-0263-4112-82dc-db9326e6b11f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d6527b0b-e5fe-43c0-86ca-21a8f0a6001f");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Unspecified).AddTicks(8143), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8026), new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8030), new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8031), new DateTime(2022, 10, 13, 11, 12, 8, 582, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05f31de7-9840-4b85-b227-11e38b142c57", "f92c60a8-aa28-4a95-8c97-c62235f0cde0", "View", "VIEW" },
                    { "3326eebc-4126-40e0-bb38-91a7df3af072", "a9f110b5-d8fb-4e51-a6a1-4e62158fcdef", "Request", "REQUEST" },
                    { "4aeea1f2-fac5-46a7-806c-4efed96623f2", "98943de1-ff47-4c75-ab0e-41342090facc", "Manager", "MANAGER" },
                    { "b4fc5608-7d52-43e5-a12d-64abe589644b", "1161b83a-7c55-4d78-997d-89af81478532", "Admin", "ADMIN" },
                    { "c8b3bd84-d740-4d27-9109-a9a1a9c7914a", "960d1388-299d-4c4e-9fe8-8ada288cbc94", "StoreMan", "STOREMAN" },
                    { "f9cfdf74-ee00-45c9-bf90-63622e2d614c", "8ddfd6cb-0a06-4ade-b40c-2d1edee5dfc4", "Approve", "APPROVE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "05f31de7-9840-4b85-b227-11e38b142c57");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3326eebc-4126-40e0-bb38-91a7df3af072");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4aeea1f2-fac5-46a7-806c-4efed96623f2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b4fc5608-7d52-43e5-a12d-64abe589644b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c8b3bd84-d740-4d27-9109-a9a1a9c7914a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f9cfdf74-ee00-45c9-bf90-63622e2d614c");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 1,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 2,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 3,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 4,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customerId",
                keyValue: 5,
                column: "timeLimit",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Unspecified).AddTicks(3171), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 1,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2894), new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 2,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 3,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2926), new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 4,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2929), new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Hrs",
                keyColumn: "hrId",
                keyValue: 5,
                columns: new[] { "birthDate", "higherDate" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 10, 11, 14, 2, 56, 194, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fdbdc8c-5878-4ffa-afb7-b0c3c88dba0b", "b5506daf-ad82-4361-b0fb-fcd87c0cfe2a", "Approve", "APPROVE" },
                    { "41c2d1fc-cdd9-4744-bb3e-e323a883dcbc", "8de8ad72-1c4d-45c9-b83b-1d27b656b1e3", "Request", "REQUEST" },
                    { "64fbf566-5f0e-4dc6-b633-2b152e210191", "70562755-c81e-4410-90b8-7b1eaf6bbef7", "View", "VIEW" },
                    { "9e171307-0263-4112-82dc-db9326e6b11f", "6d62899b-4c55-4c29-97fa-7f115fd1112b", "StoreMan", "STOREMAN" },
                    { "d6527b0b-e5fe-43c0-86ca-21a8f0a6001f", "0f372265-a926-4f8d-9a67-9a72ae9f539c", "Admin", "ADMIN" }
                });
        }
    }
}

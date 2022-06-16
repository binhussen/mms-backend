﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "NotifyHeaders",
                columns: table => new
                {
                    notifyHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    attachments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifyHeaders", x => x.notifyHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "RequestHeaders",
                columns: table => new
                {
                    requestHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    attachments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHeaders", x => x.requestHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "StoreHeaders",
                columns: table => new
                {
                    storeHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemNoInExpenditureRegister = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noOfEntryInTheRegisterOfIncomingGoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notifyHeaderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreHeaders", x => x.storeHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "NotifyItems",
                columns: table => new
                {
                    notifyItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    notifyHeaderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifyItems", x => x.notifyItemId);
                    table.ForeignKey(
                        name: "FK_NotifyItems_NotifyHeaders_notifyHeaderId",
                        column: x => x.notifyHeaderId,
                        principalTable: "NotifyHeaders",
                        principalColumn: "notifyHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestItems",
                columns: table => new
                {
                    requestItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedQuantity = table.Column<int>(type: "int", nullable: false),
                    RemainQuantity = table.Column<int>(type: "int", nullable: false),
                    requestHeaderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestItems", x => x.requestItemId);
                    table.ForeignKey(
                        name: "FK_RequestItems_RequestHeaders_requestHeaderId",
                        column: x => x.requestHeaderId,
                        principalTable: "RequestHeaders",
                        principalColumn: "requestHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreItems",
                columns: table => new
                {
                    storeItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    serialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shelfNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    availability = table.Column<bool>(type: "bit", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    storeHeaderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItems", x => x.storeItemId);
                    table.ForeignKey(
                        name: "FK_StoreItems_StoreHeaders_storeHeaderId",
                        column: x => x.storeHeaderId,
                        principalTable: "StoreHeaders",
                        principalColumn: "storeHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Approves",
                columns: table => new
                {
                    ApproveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedQuantity = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approves", x => x.ApproveId);
                    table.ForeignKey(
                        name: "FK_Approves_RequestItems_RequestId",
                        column: x => x.RequestId,
                        principalTable: "RequestItems",
                        principalColumn: "requestItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approves_StoreItems_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreItems",
                        principalColumn: "storeItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributes",
                columns: table => new
                {
                    DistributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ApproveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributes", x => x.DistributeId);
                    table.ForeignKey(
                        name: "FK_Distributes_Approves_ApproveId",
                        column: x => x.ApproveId,
                        principalTable: "Approves",
                        principalColumn: "ApproveId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Distributes_Customer_UserId",
                        column: x => x.UserId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approves_RequestId",
                table: "Approves",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Approves_StoreId",
                table: "Approves",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributes_ApproveId",
                table: "Distributes",
                column: "ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributes_UserId",
                table: "Distributes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotifyItems_notifyHeaderId",
                table: "NotifyItems",
                column: "notifyHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestItems_requestHeaderId",
                table: "RequestItems",
                column: "requestHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreItems_storeHeaderId",
                table: "StoreItems",
                column: "storeHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distributes");

            migrationBuilder.DropTable(
                name: "NotifyItems");

            migrationBuilder.DropTable(
                name: "Approves");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "NotifyHeaders");

            migrationBuilder.DropTable(
                name: "RequestItems");

            migrationBuilder.DropTable(
                name: "StoreItems");

            migrationBuilder.DropTable(
                name: "RequestHeaders");

            migrationBuilder.DropTable(
                name: "StoreHeaders");
        }
    }
}
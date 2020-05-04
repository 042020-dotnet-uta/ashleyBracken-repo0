using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StoreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PotionID = table.Column<int>(nullable: false),
                    PotionQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Potions",
                columns: table => new
                {
                    PotionID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PotionName = table.Column<string>(nullable: true),
                    PotionDescription = table.Column<string>(nullable: true),
                    PotionPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potions", x => x.PotionID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<string>(nullable: true),
                    StoreID = table.Column<int>(nullable: false),
                    ManaPotionsBought = table.Column<int>(nullable: false),
                    HealthPotionsBought = table.Column<int>(nullable: false),
                    StaminaPotionsBought = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreInventories",
                columns: table => new
                {
                    StoreInventoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreID = table.Column<int>(nullable: false),
                    InventoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreInventories", x => x.StoreInventoryID);
                    table.ForeignKey(
                        name: "FK_StoreInventories_Inventory_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventory",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreInventories_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreID",
                table: "Orders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInventories_InventoryID",
                table: "StoreInventories",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInventories_StoreID",
                table: "StoreInventories",
                column: "StoreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Potions");

            migrationBuilder.DropTable(
                name: "StoreInventories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}

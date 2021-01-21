using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CrustId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrustEntityId = table.Column<long>(type: "bigint", nullable: true),
                    SizeEntityId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustEntityId",
                        column: x => x.CrustEntityId,
                        principalTable: "Crusts",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityId",
                        column: x => x.SizeEntityId,
                        principalTable: "Sizes",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APizzaModelEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Toppings_Pizzas_APizzaModelEntityId",
                        column: x => x.APizzaModelEntityId,
                        principalTable: "Pizzas",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedStoreEntityId = table.Column<long>(type: "bigint", nullable: true),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Users_Stores_SelectedStoreEntityId",
                        column: x => x.SelectedStoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOrdered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PizzaEntityId = table.Column<long>(type: "bigint", nullable: true),
                    UserEntityId = table.Column<long>(type: "bigint", nullable: true),
                    StoreEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Orders_Pizzas_PizzaEntityId",
                        column: x => x.PizzaEntityId,
                        principalTable: "Pizzas",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreEntityId",
                        column: x => x.StoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "EntityId", "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 201L, 0, "Double-dough", 5m },
                    { 203L, 0, "Deep Dish", 6m },
                    { 202L, 0, "St. Louis", 4m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 101L, "Large", 10m },
                    { 102L, "Medium", 8m },
                    { 103L, "Samll", 6m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "OrderEntityId" },
                values: new object[,]
                {
                    { 2L, "PizzaHut", null },
                    { 3L, "Domino", null },
                    { 4L, "RoundTable", null }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "APizzaModelEntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 301L, null, "Pineapple", 3m },
                    { 302L, null, "Olives", 1m },
                    { 303L, null, "Pepperoni", 4m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaEntityId",
                table: "Orders",
                column: "PizzaEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserEntityId",
                table: "Orders",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityId",
                table: "Pizzas",
                column: "CrustEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderEntityId",
                table: "Pizzas",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityId",
                table: "Pizzas",
                column: "SizeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_OrderEntityId",
                table: "Stores",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaModelEntityId",
                table: "Toppings",
                column: "APizzaModelEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrderEntityId",
                table: "Users",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SelectedStoreEntityId",
                table: "Users",
                column: "SelectedStoreEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Orders_OrderEntityId",
                table: "Pizzas",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Orders_OrderEntityId",
                table: "Stores",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Orders_OrderEntityId",
                table: "Users",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzaEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Stores_SelectedStoreEntityId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserEntityId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

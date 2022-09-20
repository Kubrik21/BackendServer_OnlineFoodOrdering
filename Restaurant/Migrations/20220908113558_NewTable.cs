using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderAdresSec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderPostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderElements",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderElementQuantity = table.Column<int>(type: "int", nullable: false),
                    OrderElementValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderElements", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderElements_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderElements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderElements_ProductId",
                table: "OrderElements",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderElements");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

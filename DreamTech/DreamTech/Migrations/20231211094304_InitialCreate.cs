using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamTech.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    SealerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SealerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "sealers",
                columns: table => new
                {
                    SealerId = table.Column<int>(type: "int", nullable: false),
                    SealerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SealerNic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SealerCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sealers", x => x.SealerId);
                    table.ForeignKey(
                        name: "FK_sealers_users_SealerId",
                        column: x => x.SealerId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSealer",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SealerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSealer", x => new { x.ProductID, x.SealerId });
                    table.ForeignKey(
                        name: "FK_ProductSealer_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSealer_sealers_SealerId",
                        column: x => x.SealerId,
                        principalTable: "sealers",
                        principalColumn: "SealerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSealer_SealerId",
                table: "ProductSealer",
                column: "SealerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSealer");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "sealers");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}

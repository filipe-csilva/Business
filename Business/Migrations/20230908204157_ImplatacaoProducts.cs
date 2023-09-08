using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Business.Migrations
{
    /// <inheritdoc />
    public partial class ImplatacaoProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    GTIN = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    GroupIDId = table.Column<int>(type: "integer", nullable: false),
                    PricePurchase = table.Column<float>(type: "numeric(18,2)", nullable: false, defaultValue: 0f),
                    PriceCoast = table.Column<float>(type: "numeric(18,2)", nullable: false, defaultValue: 0f),
                    PriceSale = table.Column<float>(type: "numeric(18,2)", nullable: false, defaultValue: 0f),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    SupplierId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Group_GroupIDId",
                        column: x => x.GroupIDId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientByProduct",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientByProduct", x => new { x.ClientsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ClientByProduct_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientByProduct_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientByProduct_ProductsId",
                table: "ClientByProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GroupIDId",
                table: "Product",
                column: "GroupIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierId",
                table: "Product",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientByProduct");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}

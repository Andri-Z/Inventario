using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventario.Migrations
{
    /// <inheritdoc />
    public partial class InventarioDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "InventarioDB");

            migrationBuilder.CreateTable(
                name: "categorias",
                schema: "InventarioDB",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                schema: "InventarioDB",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    contacto = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    rnc = table.Column<int>(type: "int", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                schema: "InventarioDB",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    precio_unitario = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    idProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.id);
                    table.CheckConstraint("ck_costo", "[costo] >= 0");
                    table.CheckConstraint("ck_precioUnitario", "[precio_unitario] >= 0");
                    table.ForeignKey(
                        name: "FK_productos_categorias_idCategoria",
                        column: x => x.idCategoria,
                        principalSchema: "InventarioDB",
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_proveedores_idProveedor",
                        column: x => x.idProveedor,
                        principalSchema: "InventarioDB",
                        principalTable: "proveedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productos_idCategoria",
                schema: "InventarioDB",
                table: "productos",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_productos_idProveedor",
                schema: "InventarioDB",
                table: "productos",
                column: "idProveedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productos",
                schema: "InventarioDB");

            migrationBuilder.DropTable(
                name: "categorias",
                schema: "InventarioDB");

            migrationBuilder.DropTable(
                name: "proveedores",
                schema: "InventarioDB");
        }
    }
}

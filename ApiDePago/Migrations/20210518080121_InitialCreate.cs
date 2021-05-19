using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiDePago.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detalleDePagos",
                columns: table => new
                {
                    IDPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTarjeta = table.Column<string>(type: "nvarchar (25)", nullable: true),
                    NumeroTarjeta = table.Column<string>(type: "nvarchar (16)", nullable: true),
                    VencimientoTarjeta = table.Column<string>(type: "nvarchar (5)", nullable: true),
                    CodigoSeguridad = table.Column<string>(type: "nvarchar (3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleDePagos", x => x.IDPago);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleDePagos");
        }
    }
}

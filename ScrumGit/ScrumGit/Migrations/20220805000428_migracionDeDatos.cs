using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrumGit.Migrations
{
    public partial class migracionDeDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    Idproducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    ImagenProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.Idproducto);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomnbreRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionRol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Idusuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    rolIdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Idusuario);
                    table.ForeignKey(
                        name: "FK_usuario_rol_rolIdRol",
                        column: x => x.rolIdRol,
                        principalTable: "rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuario_rolIdRol",
                table: "usuario",
                column: "rolIdRol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "rol");
        }
    }
}

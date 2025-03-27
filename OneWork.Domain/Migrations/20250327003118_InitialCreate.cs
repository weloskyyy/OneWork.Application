using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OneWork.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Completada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "Id", "Completada", "Descripcion", "Titulo" },
                values: new object[,]
                {
                    { 1, false, "Verificar y responder correos pendientes", "Revisar correos" },
                    { 2, true, "Reunion diaria a las 10:00 AM para discutir avances", "Reunion con el equipo" },
                    { 3, true, "Actualizar el READNE del proyecto OneWork", "Actualizar documentacion" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}

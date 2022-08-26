using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAndNutrition.App.Persistencia.Migrations
{
    public partial class Un : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoMusculares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrenInferior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrenSuperior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoMusculares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Macronutrientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriaDiarias = table.Column<float>(type: "real", nullable: false),
                    Proteina = table.Column<float>(type: "real", nullable: false),
                    Carbohidratos = table.Column<float>(type: "real", nullable: false),
                    Grasas = table.Column<float>(type: "real", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macronutrientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanEjercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutinaBasico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutinaIntermedio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutinaAvanzada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEjercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    peso = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    ActividadFisica = table.Column<int>(type: "int", nullable: false),
                    ObjetivoAlcanzar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanNutricionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionActividad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoRutina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Musculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeticiones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiempo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "GrupoMusculares");

            migrationBuilder.DropTable(
                name: "Macronutrientes");

            migrationBuilder.DropTable(
                name: "PlanEjercicios");

            migrationBuilder.DropTable(
                name: "PlanNutricionales");

            migrationBuilder.DropTable(
                name: "Rutinas");
        }
    }
}

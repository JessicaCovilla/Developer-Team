﻿// <auto-generated />
using System;
using GymAndNutrition.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymAndNutrition.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220826194639_Un")]
    partial class Un
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GymAndNutrition.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GymAndNutrition.App.Dominio.GrupoMuscular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cardio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrenInferior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrenSuperior")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GrupoMusculares");
                });

            modelBuilder.Entity("GymAndNutrition.App.Dominio.Macronutrientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CaloriaDiarias")
                        .HasColumnType("real");

                    b.Property<float>("Carbohidratos")
                        .HasColumnType("real");

                    b.Property<float>("Grasas")
                        .HasColumnType("real");

                    b.Property<float>("Proteina")
                        .HasColumnType("real");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Macronutrientes");
                });

            modelBuilder.Entity("GymAndNutrition.App.Dominio.PlanEjercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RutinaAvanzada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutinaBasico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutinaIntermedio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanEjercicios");
                });

            modelBuilder.Entity("GymAndNutrition.App.Dominio.PlanNutricional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActividadFisica")
                        .HasColumnType("int");

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<int>("ObjetivoAlcanzar")
                        .HasColumnType("int");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlanNutricionales");
                });

            modelBuilder.Entity("GymAndNutrition.App.Dominio.Rutina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescripcionActividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Musculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Repeticiones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tiempo")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoRutina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rutinas");
                });
#pragma warning restore 612, 618
        }
    }
}

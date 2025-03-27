﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneWork.Domain.Data;

#nullable disable

namespace OneWork.Domain.Migrations
{
    [DbContext(typeof(OneWorkContext))]
    [Migration("20250327004815_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OneWork.Domain.Entities.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Completada")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Completada = false,
                            Descripcion = "Verificar y responder correos pendientes",
                            Titulo = "Revisar correos"
                        },
                        new
                        {
                            Id = 2,
                            Completada = true,
                            Descripcion = "Reunion diaria a las 10:00 AM para discutir avances",
                            Titulo = "Reunion con el equipo"
                        },
                        new
                        {
                            Id = 3,
                            Completada = true,
                            Descripcion = "Actualizar el READNE del proyecto OneWork",
                            Titulo = "Actualizar documentacion"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

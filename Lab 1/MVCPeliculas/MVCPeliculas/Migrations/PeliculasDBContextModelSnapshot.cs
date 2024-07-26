﻿// <auto-generated />
using System;
using MVCPeliculas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCPeliculas.Migrations
{
    [DbContext(typeof(PeliculasDBContext))]
    partial class PeliculasDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCPeliculas.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Nombre = "Comedia"
                        },
                        new
                        {
                            id = 2,
                            Nombre = "Romance"
                        },
                        new
                        {
                            id = 3,
                            Nombre = "Aventura"
                        },
                        new
                        {
                            id = 4,
                            Nombre = "Accion"
                        },
                        new
                        {
                            id = 5,
                            Nombre = "Ficcion"
                        },
                        new
                        {
                            id = 6,
                            Nombre = "Drama"
                        });
                });

            modelBuilder.Entity("MVCPeliculas.Models.Peliculas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaLanzmiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Director = "Hermanas Wachowski",
                            FechaLanzmiento = new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 4,
                            Precio = 9.99m,
                            Titulo = "Matriz recargado"
                        },
                        new
                        {
                            ID = 2,
                            Director = "Peter Jackson",
                            FechaLanzmiento = new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 3,
                            Precio = 11.99m,
                            Titulo = "El senior de los anillos:Las dos torres"
                        },
                        new
                        {
                            ID = 3,
                            Director = "Chris Columbus",
                            FechaLanzmiento = new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 5,
                            Precio = 9.99m,
                            Titulo = "Harry Potter y la camara secreta"
                        });
                });

            modelBuilder.Entity("MVCPeliculas.Models.Peliculas", b =>
                {
                    b.HasOne("MVCPeliculas.Models.Genero", "Genero")
                        .WithMany("Peliculas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("MVCPeliculas.Models.Genero", b =>
                {
                    b.Navigation("Peliculas");
                });
#pragma warning restore 612, 618
        }
    }
}

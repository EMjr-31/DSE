﻿// <auto-generated />
using System;
using DESAFIO1_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DESAFIO1_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240810040839_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DESAFIO1_MVC.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "",
                            Nombre = "Recursos Humanos"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "",
                            Nombre = "Tecnología"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "",
                            Nombre = "Ventas"
                        });
                });

            modelBuilder.Entity("DESAFIO1_MVC.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaContratacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentoId = 1,
                            Descripcion = "",
                            FechaContratacion = new DateTime(2010, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "John Doe",
                            Salario = 50000m
                        },
                        new
                        {
                            Id = 2,
                            DepartamentoId = 2,
                            Descripcion = "",
                            FechaContratacion = new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Jane Smith",
                            Salario = 70000m
                        },
                        new
                        {
                            Id = 3,
                            DepartamentoId = 3,
                            Descripcion = "",
                            FechaContratacion = new DateTime(2012, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1982, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Mark Johnson",
                            Salario = 55000m
                        },
                        new
                        {
                            Id = 4,
                            DepartamentoId = 1,
                            Descripcion = "",
                            FechaContratacion = new DateTime(2005, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1978, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Emily Davis",
                            Salario = 75000m
                        },
                        new
                        {
                            Id = 5,
                            DepartamentoId = 2,
                            Descripcion = "",
                            FechaContratacion = new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaNacimiento = new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Michael Brown",
                            Salario = 60000m
                        });
                });

            modelBuilder.Entity("DESAFIO1_MVC.Models.Empleado", b =>
                {
                    b.HasOne("DESAFIO1_MVC.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });
#pragma warning restore 612, 618
        }
    }
}

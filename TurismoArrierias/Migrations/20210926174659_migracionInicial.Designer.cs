﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurismoArrierias.Datos;

namespace TurismoArrierias.Migrations
{
    [DbContext(typeof(AplicationDBcontext))]
    [Migration("20210926174659_migracionInicial")]
    partial class migracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TurismoArrierias.Models.usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugarResidencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
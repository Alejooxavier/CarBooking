﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Database;

namespace Persistence.Database.Migrations
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.CategoriaVehiculo", b =>
                {
                    b.Property<int>("IdCategoriaVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoCategoriaVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdCategoriaVehiculo");

                    b.ToTable("CategoriasVehiculo");
                });

            modelBuilder.Entity("Model.TipoVehiculo", b =>
                {
                    b.Property<int>("IdTipoVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaVehiculoIdCategoriaVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("EstadoTipoVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("IdCategoriaVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTipoVehiculo");

                    b.HasIndex("CategoriaVehiculoIdCategoriaVehiculo");

                    b.ToTable("TiposVehiculo");
                });

            modelBuilder.Entity("Model.TipoVehiculo", b =>
                {
                    b.HasOne("Model.CategoriaVehiculo", "CategoriaVehiculo")
                        .WithMany("TipoVehiculos")
                        .HasForeignKey("CategoriaVehiculoIdCategoriaVehiculo");

                    b.Navigation("CategoriaVehiculo");
                });

            modelBuilder.Entity("Model.CategoriaVehiculo", b =>
                {
                    b.Navigation("TipoVehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}

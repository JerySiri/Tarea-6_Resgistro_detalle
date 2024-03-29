﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_Detalle.DAL;

namespace Registro_Detalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210314181240_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Registro_Detalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            Descripcion = "Descuenta",
                            Nombre = "Descuentador",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 2,
                            Descripcion = "Vende",
                            Nombre = "Vendedor",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 3,
                            Descripcion = "Cobra",
                            Nombre = "Cobrador",
                            VecesAsignado = 0
                        });
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RolesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolesId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("Registro_Detalle.Entidades.Roles", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Usuarios", b =>
                {
                    b.HasOne("Registro_Detalle.Entidades.Roles", "rol")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("rol");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Roles", b =>
                {
                    b.Navigation("RolesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}

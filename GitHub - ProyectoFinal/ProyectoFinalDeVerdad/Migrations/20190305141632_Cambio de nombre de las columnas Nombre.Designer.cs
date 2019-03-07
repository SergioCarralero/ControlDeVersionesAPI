﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal;

namespace ProyectoFinalDeVerdad.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190305141632_Cambio de nombre de las columnas Nombre")]
    partial class CambiodenombredelascolumnasNombre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.EntityFrameworkHiLoSequence", "'EntityFrameworkHiLoSequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoFinal.Entidades.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCategoria")
                        .IsRequired();

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.Desarrollador", b =>
                {
                    b.Property<int>("DesarrolladorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreDesarrollador")
                        .IsRequired();

                    b.HasKey("DesarrolladorId");

                    b.ToTable("Desarrolladores");
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.Juego", b =>
                {
                    b.Property<int>("JuegoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<int>("DesarrolladorId");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("date");

                    b.Property<string>("NombreJuego")
                        .IsRequired();

                    b.Property<decimal>("Precio");

                    b.Property<int>("UnidadesStock");

                    b.HasKey("JuegoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("DesarrolladorId");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Contrasena")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("NombreUsuario")
                        .IsRequired();

                    b.Property<decimal>("Saldo");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.UsuarioJuego", b =>
                {
                    b.Property<int>("JuegoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("JuegoId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuariosJuegos");
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.Juego", b =>
                {
                    b.HasOne("ProyectoFinal.Entidades.Categoria", "Categoria")
                        .WithMany("Juegos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoFinal.Entidades.Desarrollador", "Desarrollador")
                        .WithMany("Juegos")
                        .HasForeignKey("DesarrolladorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoFinal.Entidades.UsuarioJuego", b =>
                {
                    b.HasOne("ProyectoFinal.Entidades.Juego", "Juego")
                        .WithMany("ListaUsuarios")
                        .HasForeignKey("JuegoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoFinal.Entidades.Usuario", "Usuario")
                        .WithMany("ListaJuegos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

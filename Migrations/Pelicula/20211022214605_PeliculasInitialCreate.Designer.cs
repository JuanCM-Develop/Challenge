﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RetoAlk.Migrations.Pelicula
{
    [DbContext(typeof(PeliculaContext))]
    [Migration("20211022214605_PeliculasInitialCreate")]
    partial class PeliculasInitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.Property<string>("PelSeriQueApareceTitulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonajesAsociadosNombre")
                        .HasColumnType("TEXT");

                    b.HasKey("PelSeriQueApareceTitulo", "PersonajesAsociadosNombre");

                    b.HasIndex("PersonajesAsociadosNombre");

                    b.ToTable("PeliculaPersonaje");
                });

            modelBuilder.Entity("RetoAlk.Models.Requests.Pelicula", b =>
                {
                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Calificacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen")
                        .HasColumnType("TEXT");

                    b.HasKey("Titulo");

                    b.ToTable("Pelicula");
                });

            modelBuilder.Entity("RetoAlk.Models.Requests.Personaje", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Historia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen")
                        .HasColumnType("TEXT");

                    b.Property<float>("Peso")
                        .HasColumnType("REAL");

                    b.HasKey("Nombre");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.HasOne("RetoAlk.Models.Requests.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PelSeriQueApareceTitulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetoAlk.Models.Requests.Personaje", null)
                        .WithMany()
                        .HasForeignKey("PersonajesAsociadosNombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

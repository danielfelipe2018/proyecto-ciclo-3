﻿// <auto-generated />
using System;
using MedicalApp.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalApp.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211009224506_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MedicalApp.App.Dominio.Agendamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CiudadId")
                        .HasColumnType("int");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraCita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.Property<int>("TipoCita")
                        .HasColumnType("int");

                    b.Property<float>("Valor_Consulta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("SedeId");

                    b.ToTable("Agendamientos");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoIdentificacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Sede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreSede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("MedicalApp.App.Dominio.Persona");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("MedicalApp.App.Dominio.Persona");

                    b.Property<int>("Convenio")
                        .HasColumnType("int");

                    b.Property<int>("TipoPaciente")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Agendamiento", b =>
                {
                    b.HasOne("MedicalApp.App.Dominio.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.HasOne("MedicalApp.App.Dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.HasOne("MedicalApp.App.Dominio.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.HasOne("MedicalApp.App.Dominio.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId");

                    b.Navigation("Ciudad");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Sede", b =>
                {
                    b.HasOne("MedicalApp.App.Dominio.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("MedicalApp.App.Dominio.Usuario", b =>
                {
                    b.HasOne("MedicalApp.App.Dominio.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}

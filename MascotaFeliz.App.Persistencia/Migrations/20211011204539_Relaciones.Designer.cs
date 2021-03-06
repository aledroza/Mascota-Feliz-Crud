// <auto-generated />
using System;
using MascotaFeliz.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211011204539_Relaciones")]
    partial class Relaciones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Dueño", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdDueño")
                        .HasColumnType("int");

                    b.Property<string>("IdentificacionDueño")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreMascota")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Dueño");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CodigoMascota")
                        .HasColumnType("int");

                    b.Property<int?>("DueñoId")
                        .HasColumnType("int");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<string>("IdentificacionDueño")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.Property<string>("Planes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DueñoId");

                    b.HasIndex("PlanId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdentificacionMedico")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Planes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bienestar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diamante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Elite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.VisitaDomiciliaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CodigoMascota")
                        .HasColumnType("int");

                    b.Property<string>("EstadodeAnimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVisita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaCardiaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdVisita")
                        .HasColumnType("int");

                    b.Property<int>("IdentificacionMedico")
                        .HasColumnType("int");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("MedicoId");

                    b.ToTable("VisitaDomiciliaria");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Dueño", null)
                        .WithMany("Mascota")
                        .HasForeignKey("DueñoId");

                    b.HasOne("MascotaFeliz.App.Dominio.Planes", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.VisitaDomiciliaria", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Mascota", null)
                        .WithMany("VisitaDomiciliaria")
                        .HasForeignKey("MascotaId");

                    b.HasOne("MascotaFeliz.App.Dominio.Medico", null)
                        .WithMany("VisitaDomiciliaria")
                        .HasForeignKey("MedicoId");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Dueño", b =>
                {
                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.Navigation("VisitaDomiciliaria");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Medico", b =>
                {
                    b.Navigation("VisitaDomiciliaria");
                });
#pragma warning restore 612, 618
        }
    }
}

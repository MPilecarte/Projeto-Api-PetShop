// <auto-generated />
using System;
using ApiPetShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPetShop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221219203013_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiPetShop.Data.Animal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("DataUltVacina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Porte")
                        .HasColumnType("int");

                    b.Property<string>("RGA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Animais");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DataUltVacina = "20-02-2022",
                            Especie = "Cão",
                            Genero = 2,
                            Idade = "2 anos",
                            Nome = "Yotan",
                            Porte = 3,
                            RGA = "31-121-995"
                        },
                        new
                        {
                            id = 2,
                            DataUltVacina = "05-09-2022",
                            Especie = "Cão",
                            Genero = 2,
                            Idade = "7 meses",
                            Nome = "RapMon",
                            Porte = 3,
                            RGA = "12-091-994"
                        },
                        new
                        {
                            id = 3,
                            DataUltVacina = "13-05-2022",
                            Especie = "Cão",
                            Genero = 2,
                            Idade = "3 meses",
                            Nome = "Geurem",
                            Porte = 2,
                            RGA = "01-091-997"
                        },
                        new
                        {
                            id = 4,
                            DataUltVacina = "07-12-2022",
                            Especie = "Cão",
                            Genero = 2,
                            Idade = "5 anos",
                            Nome = "Mickey",
                            Porte = 1,
                            RGA = "18-021-994"
                        },
                        new
                        {
                            id = 5,
                            DataUltVacina = "03-04-2022",
                            Especie = "Cão",
                            Genero = 1,
                            Idade = "1 ano",
                            Nome = "Holly",
                            Porte = 1,
                            RGA = "04-121-992"
                        },
                        new
                        {
                            id = 6,
                            DataUltVacina = "19-08-2022",
                            Especie = "Gato",
                            Genero = 2,
                            Idade = "4 meses",
                            Nome = "Curry",
                            Porte = 1,
                            RGA = "13-121-995"
                        },
                        new
                        {
                            id = 7,
                            DataUltVacina = "25-03-2022",
                            Especie = "Petauro-do-açucar",
                            Genero = 2,
                            Idade = "2 anos",
                            Nome = "Odeg",
                            Porte = 1,
                            RGA = "04-121-992"
                        });
                });

            modelBuilder.Entity("ApiPetShop.Models.Enum.TutorAnimal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroCasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TutorAnimais");
                });

            modelBuilder.Entity("ApiPetShop.Models.Servico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("DataAgendada")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicoPrestado")
                        .HasColumnType("int");

                    b.Property<float>("ValorServico")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}

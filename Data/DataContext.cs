using Microsoft.EntityFrameworkCore;
using ApiPetShop.Models;
using ApiPetShop.Models.Enum;


namespace ApiPetShop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {

        }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<TutorAnimal> TutorAnimais { get; set; }
        public DbSet<Servico> Servicos{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData
            (
                new Animal() { id = 1, Nome = "Yotan", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "2 anos", Genero = GeneroEnum.Macho , RGA = "31-121-995" , DataUltVacina = "20-02-2022" },
                new Animal() { id = 2, Nome = "RapMon", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "7 meses", Genero = GeneroEnum.Macho , RGA = "12-091-994", DataUltVacina = "05-09-2022" },
                new Animal() { id = 3, Nome = "Geurem", Especie = "Cão", Porte = PorteEnum.Medio, Idade = "3 meses", Genero = GeneroEnum.Macho, RGA = "01-091-997", DataUltVacina = "13-05-2022" },
                new Animal() { id = 4, Nome = "Mickey", Especie = "Cão", Porte = PorteEnum.Pequeno, Idade = "5 anos", Genero = GeneroEnum.Macho, RGA = "18-021-994", DataUltVacina = "07-12-2022" },
                new Animal() { id = 5, Nome = "Holly", Especie = "Cão", Porte = PorteEnum.Pequeno, Idade = "1 ano", Genero = GeneroEnum.Femea, RGA = "04-121-992", DataUltVacina = "03-04-2022" },
                new Animal() { id = 6, Nome = "Curry", Especie = "Gato", Porte = PorteEnum.Pequeno, Idade = "4 meses", Genero = GeneroEnum.Macho, RGA = "13-121-995", DataUltVacina = "19-08-2022" },
                new Animal() { id = 7, Nome = "Odeg", Especie = "Petauro-do-açucar", Porte = PorteEnum.Pequeno, Idade = "2 anos", Genero = GeneroEnum.Macho, RGA = "04-121-992", DataUltVacina = "25-03-2022" }
            );

            /*modelBuilder.Entity<TutorAnimal>().HasData
            (
                new TutorAnimal() { id = 1, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 2, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 3, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 4, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 5, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 6, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  },
                new TutorAnimal() { id = 7, NomeDono = "", DataNasc = , CPF = , Telefone = , Endereco = "", Bairro = "", NroCasa = "", CEP =  }
            );

            modelBuilder.Entity<TutorAnimal>().HasData(

            );*/
        }

    }
}

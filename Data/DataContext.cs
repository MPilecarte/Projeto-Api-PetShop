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
        public DbSet<Animal> Animal { get; set; }
        public DbSet<TutorAnimal> Dono { get; set; }
        public DbSet<Servico> Servico{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData
            (
                new Animal() { id = 1, Nome = "Yotan", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "2 anos", Genero = GeneroEnum.Macho , Dono = "", RGA = 3-112-195 , DataUltVacina = "20-02-2022" },
                new Animal() { id = 2, Nome = "RapMon", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "", Genero = GeneroEnum.Macho , Dono = "", RGA = 2-091-994, DataUltVacina = "05-09-2022" },
                new Animal() { id = 3, Nome = "Geurem", Especie = "", Porte = PorteEnum.Medio, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = 04-121-992, DataUltVacina = "13-05-2022" },
                new Animal() { id = 4, Nome = "Mickey", Especie = "", Porte = PorteEnum.Pequeno, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = 04-121-992, DataUltVacina = "07-12-2022" },
                new Animal() { id = 5, Nome = "Holly", Especie = "", Porte = PorteEnum.Medio, Idade = "", Genero = GeneroEnum.Femea, Dono = "", RGA = 04-121-992, DataUltVacina = "03-04-2022" },
                new Animal() { id = 6, Nome = "", Especie = "", Porte = PorteEnum.Grande, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = 04-121-992, DataUltVacina = "19-08-2022" },
                new Animal() { id = 7, Nome = "", Especie = "", Porte = PorteEnum.Pequeno, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = 04-121-992, DataUltVacina = "25-03-2022" }
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

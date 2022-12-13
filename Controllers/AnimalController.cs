using ApiPetShop.Models;
using ApiPetShop.Models.Enum;
//using Microsoft.AspNetCore.Mvc;
using System;
using ApiPetShop.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiPetShop.Controller
{
    [ApiController]
    [Route("[Controller]")]

    public class AnimalController : ControllerBase
    {
        private static List<Animal> animais = new List<Animal>()
        {
            new Animal() { id = 1, Nome = "Yotan", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "2 anos", Genero = GeneroEnum.Macho , Dono = "fdfs", RGA = "3-112-195" , DataUltVacina = "20-02-2022" },
            new Animal() { id = 2, Nome = "RapMon", Especie = "Cão", Porte = PorteEnum.Grande, Idade = "", Genero = GeneroEnum.Macho , Dono = "", RGA = "2-091-994", DataUltVacina = "05-09-2022" },
            new Animal() { id = 3, Nome = "Geurem", Especie = "Cão", Porte = PorteEnum.Medio, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = "04-121-992", DataUltVacina = "13-05-2022" },
            new Animal() { id = 4, Nome = "Mickey", Especie = "Cão", Porte = PorteEnum.Pequeno, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = "04-121-992", DataUltVacina = "07-12-2022" },
            new Animal() { id = 5, Nome = "Holly", Especie = "Cão", Porte = PorteEnum.Medio, Idade = "", Genero = GeneroEnum.Femea, Dono = "", RGA = "04-121-992", DataUltVacina = "03-04-2022" },
            new Animal() { id = 6, Nome = "", Especie = "Gato", Porte = PorteEnum.Grande, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = "04-121-992", DataUltVacina = "19-08-2022" },
            new Animal() { id = 7, Nome = "", Especie = "", Porte = PorteEnum.Pequeno, Idade = "", Genero = GeneroEnum.Macho, Dono = "", RGA = "04-121-992", DataUltVacina = "25-03-2022" }
        };


        [HttpGet("Get")]
        public IActionResult Get()
        {
            return Ok(animais);
        }

        [HttpPost("Post")]
        public IActionResult PostAnimal(Animal novoAnimal)
        {
            animais.Add(novoAnimal);
            return Ok(animais);
        }
    }
}
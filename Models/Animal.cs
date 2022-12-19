using ApiPetShop.Models.Enum;

namespace ApiPetShop.Data
{
    public class Animal
    {
        public int id { get; set; }
        public string? Nome { get; set; }
        public string Especie { get; set; }
        public PorteEnum Porte { get; set; }
        public string Idade { get; set; }
        public GeneroEnum Genero { get; set; }
        public string RGA { get; set; }
        public string DataUltVacina { get; set; }
        //public DateTime DataUltVacina { get; set; }
    }
}
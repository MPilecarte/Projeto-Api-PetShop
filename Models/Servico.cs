using ApiPetShop.Models.Enum;

namespace ApiPetShop.Models
{
    public class Servico
    {
        public int id { get; set; }
        public TipoServicoEnum ServicoPrestado { get; set; }
        public float ValorServico { get; set; }
        public DateTime? DataAgendada { get; set; }
    }
}
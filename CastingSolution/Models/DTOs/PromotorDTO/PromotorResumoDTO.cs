using CastingSolution.Models.Enums;

namespace CastingSolution.Models.DTOs.PromotorDTO
{
    public class PromotorResumoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string FuncaoPrincipal { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public StatusPromotor Status { get; set; }
        public bool IsFavorito { get; set; }

    }
}

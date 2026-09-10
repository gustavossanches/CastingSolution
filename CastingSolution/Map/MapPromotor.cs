using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;

namespace CastingSolution.Map
{
    public static class MapPromotor
    {
        public static ICollection<PromotorResumoDTO> MapToListaPromotorDTO(ICollection<Promotor> promotores)
        {
            return promotores.Select(p => new PromotorResumoDTO
            {
                Id = p.Id,
                Nome = p.Nome,
                FuncaoPrincipal = p.FuncaoPrincipal,
                Cidade = p.Cidade,
                Telefone = p.Telefone,
                Status = p.Status,
                IsFavorito = p.IsFavorito
            }).ToList();
        }
    }
}

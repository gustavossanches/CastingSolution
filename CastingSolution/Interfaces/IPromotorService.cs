using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;

namespace CastingSolution.Interfaces;

public interface IPromotorService
{
    Task CreateAsync(Promotor promotor);
    Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo();
}

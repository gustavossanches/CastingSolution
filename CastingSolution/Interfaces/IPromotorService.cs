using CastingSolution.Common;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDetalheDTO;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Interfaces;

public interface IPromotorService
{
    Task<Result> CreateAsync(CriarPromotorViewModel promotor);
    Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo();
    Task<PromotorDetalheDTO?> PromotorDetalhe(int promotorIid);
}

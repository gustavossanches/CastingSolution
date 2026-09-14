using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Interfaces;

public interface IPromotorService
{
    Task CreateAsync(CriarPromotorViewModel promotor);
    Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo(); 
}

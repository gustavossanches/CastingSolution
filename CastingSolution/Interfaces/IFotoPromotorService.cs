using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Interfaces;

public interface IFotoPromotorService
{
    Task SalvarFotoAsync(ICollection<String> fotoBase64, int promotorId, string nomePromotor);
}

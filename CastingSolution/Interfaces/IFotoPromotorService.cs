using CastingSolution.Common;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Interfaces;

public interface IFotoPromotorService
{
    Task<Result> SalvarFotoAsync(ICollection<String> fotoBase64, int promotorId, string nomePromotor);
    Task<List<FotoPromotor>> BuscarFotos(int id);
    Task<FotoPromotor?> BuscarFoto(int id);
}

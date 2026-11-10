using CastingSolution.Common;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Interfaces;

public interface IDocumentoPromotorService
{
    Task<Result> SalvarDocumentoAsync(ICollection<String> DocumentoBase64, int promotorId);
    Task<List<DocumentoPromotor>> BuscarDocumentos(int id);
    Task<DocumentoPromotor> BuscarDocumento(int id);
}

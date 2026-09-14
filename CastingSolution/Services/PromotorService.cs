using CastingSolution.Interfaces;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.Enums;
using CastingSolution.Repository;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Services;

public class PromotorService : IPromotorService
{
    private readonly IRepository<Promotor> _promotorRepository;

    public PromotorService(IRepository<Promotor> promotorRepository)
    {
        _promotorRepository = promotorRepository;
    }

    public async Task CreateAsync(CriarPromotorViewModel promotor)
    {
        var promotorMapeado = Map.MapPromotor.MapToPromotor(promotor);
        promotorMapeado.Status = StatusPromotor.Ativo;

        await _promotorRepository.AddAsync(promotorMapeado);
        await _promotorRepository.SaveChangesAsync();
    }

    public async Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo()
    {
        var promotores = await _promotorRepository.GetAllAsync();
        var promotoresMapeados = Map.MapPromotor.MapToListaPromotorDTO(promotores.ToList());
        return promotoresMapeados;
    }
     
}

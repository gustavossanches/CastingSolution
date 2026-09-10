using CastingSolution.Models;
using CastingSolution.Models.Enums;
using CastingSolution.Repository;
using CastingSolution.Interfaces;
using CastingSolution.Models.DTOs.PromotorDTO;

namespace CastingSolution.Services;

public class PromotorService : IPromotorService
{
    private readonly IRepository<Promotor> _promotorRepository;

    public PromotorService(IRepository<Promotor> promotorRepository)
    {
        _promotorRepository = promotorRepository;
    }

    public async Task CreateAsync(Promotor promotor)
    {
        promotor.Status = StatusPromotor.Ativo;
        await _promotorRepository.AddAsync(promotor);
        await _promotorRepository.SaveChangesAsync();
    }

    public async Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo()
    {
        var promotores = await _promotorRepository.GetAllAsync();
        var promotoresMapeados = Map.MapPromotor.MapToListaPromotorDTO(promotores.ToList());
        return promotoresMapeados;
    }
}

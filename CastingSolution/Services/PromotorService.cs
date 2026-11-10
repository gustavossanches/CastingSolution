using CastingSolution.Common;
using CastingSolution.Interfaces;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDetalheDTO;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.Enums;
using CastingSolution.Models.ViewModel.PromotorViewModel;
using CastingSolution.Repository;

namespace CastingSolution.Services;

public class PromotorService : IPromotorService
{
    private readonly IRepository<Promotor> _promotorRepository;
    private readonly IFotoPromotorService _fotoPromotorService;

    public PromotorService(IRepository<Promotor> promotorRepository, IFotoPromotorService fotoPromotorService)
    {
        _promotorRepository = promotorRepository;
        _fotoPromotorService = fotoPromotorService;
    }

    public async Task<Result> CreateAsync(CriarPromotorViewModel promotor)
    {
        var promotorMapeado = Map.MapPromotor.MapToPromotor(promotor);
        promotorMapeado.Status = StatusPromotor.Ativo;

        await _promotorRepository.AddAsync(promotorMapeado);

        if (promotor.FotosBase64.Any())
        {
            await _fotoPromotorService.SalvarFotoAsync(promotor.FotosBase64, promotorMapeado.Id, promotor.Nome);
        }
        return Result.Success();

    }


    public async Task<PromotorDetalheDTO?> PromotorDetalhe(int promotorId)
    {
        var promotor = await _promotorRepository.GetByIdAsync(promotorId);
        if (promot
        {
            return null;
        }

        var promotorDTO = Map.MapPromotor.MapToPromotorDetalheDTO(promotor);

        var fotos = await _fotoPromotorService.BuscarFotos(promotorId);
        promotorDTO.Fotos = fotos;
        //fazer a busca dos documentos também

        return promotorDTO;
    }


    public async Task<ICollection<PromotorResumoDTO>> ListarPromotorResumo()
    {
        var promotores = await _promotorRepository.GetAllAsync();
        var promotoresMapeados = Map.MapPromotor.MapToListaPromotorDTO(promotores.ToList());
        return promotoresMapeados;
    }

}

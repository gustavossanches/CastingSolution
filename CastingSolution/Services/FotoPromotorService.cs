using CastingSolution.Interfaces;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.Enums;
using CastingSolution.Models.ViewModel.PromotorViewModel;
using CastingSolution.Repository;
using System.Text.RegularExpressions;

namespace CastingSolution.Services;

public class FotoPromotorService : IFotoPromotorService
{
    private readonly IRepository<FotoPromotor> _fotoPromotorRepository;

    public FotoPromotorService(IRepository<FotoPromotor> fotoPromotorRepository)
    {
        _fotoPromotorRepository = fotoPromotorRepository;
    }

    public async Task SalvarFotoAsync(ICollection<String> fotosBase64, int promotorId, string nomePromotor)
    {
        string nomePasta = Util.SanitizarNomePasta(nomePromotor);

        string caminhoPasta = "C:\\Promotores\\" + nomePasta;
        Util.CriarDiretorio(caminhoPasta);

        int ordem = 0;
        foreach (var foto in fotosBase64)
        {
            string fotoBase64 = foto.Substring(foto.IndexOf(',') + 1);
            string nomeArquivo = Guid.NewGuid().ToString() + ".jpg";
            string caminhoArquivo = Path.Combine(caminhoPasta, nomeArquivo);
            byte[] bytesFoto = Convert.FromBase64String(fotoBase64);
            await File.WriteAllBytesAsync(caminhoArquivo, bytesFoto);
            var fotoPromotor = new FotoPromotor
            {
                Ordem = ordem,
                PromotorId = promotorId,
                CaminhoArquivo = caminhoArquivo
            };
            ordem = ordem++;

            await _fotoPromotorRepository.AddAsync(fotoPromotor);
        }
    }

    //public async Task




}

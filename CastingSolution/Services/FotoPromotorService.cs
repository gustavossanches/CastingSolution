using CastingSolution.Common;
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

    public async Task<Result> SalvarFotoAsync(ICollection<String> fotosBase64, int promotorId, string nomePromotor)
    {
        List<string> caminhosSalvos = new List<string>();
        List<FotoPromotor> fotosPromotor = new List<FotoPromotor>();

        try
        {
            string nomePasta = Util.SanitizarNomePasta(nomePromotor);

            string caminhoPasta = "C:\\Promotores\\" + nomePasta;
            Util.CriarDiretorio(caminhoPasta);


            int ordem = 0;
            foreach (var foto in fotosBase64)
            {
                string nomeArquivo = Guid.NewGuid().ToString() + ".jpg";
                string caminhoArquivo = Path.Combine(caminhoPasta, nomeArquivo);
                string fotoBase64 = foto.Substring(foto.IndexOf(',') + 1);
                byte[] bytesFoto = Convert.FromBase64String(fotoBase64);
                 
                caminhosSalvos.Add(caminhoArquivo);
                await File.WriteAllBytesAsync(caminhoArquivo, bytesFoto);
                var fotoPromotor = new FotoPromotor
                {
                    Ordem = ordem,
                    PromotorId = promotorId,
                    CaminhoArquivo = caminhoArquivo,
                    IsPrincipal = ordem == 0,
                    DataUpload = DateTime.Now,
                };

                fotosPromotor.Add(fotoPromotor);

                ordem++;
            }

            await _fotoPromotorRepository.AddListAsync(fotosPromotor);

        }
        catch (Exception)
        { 
            foreach (var caminhoArquivo in caminhosSalvos)
            {
                File.Delete(caminhoArquivo);
            }
            return Result.Failure(new Error("SALVAR_FOTO_ERRO", "Ocorreu um erro ao salvar as fotos do promotor."));
        }

        return Result.Success();
    } 


}

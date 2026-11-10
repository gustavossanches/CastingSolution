using CastingSolution.Common;
using CastingSolution.Interfaces;
using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.Enums;
using CastingSolution.Models.ViewModel.PromotorViewModel;
using CastingSolution.Repository;
using System.Text.RegularExpressions;

namespace CastingSolution.Services;

public class DocumentoPromotorService : IDocumentoPromotorService
{
    private readonly IRepository<DocumentoPromotor> _documentoPromotorRepository;

    public DocumentoPromotorService(IRepository<DocumentoPromotor> documentoPromotorRepository)
    {
        _documentoPromotorRepository = documentoPromotorRepository;
    }

    public async Task<Result> SalvarDocumentoAsync(ICollection<String> documentosBase64, int promotorId)
    {
        List<string> caminhosSalvos = new List<string>();
        List<FotoPromotor> fotosPromotor = new List<FotoPromotor>();

        try
        {  
            int ordem = 0;
            foreach (var foto in documentosBase64)
            {
                string nomeArquivo = Guid.NewGuid().ToString(); 
                string fotoBase64 = foto.Substring(foto.IndexOf(',') + 1);
                byte[] bytesFoto = Convert.FromBase64String(fotoBase64); 
                var fotoPromotor = new FotoPromotor
                {
                    Ordem = ordem,
                    PromotorId = promotorId,
                    NomeArquivo = nomeArquivo,
                    IsPrincipal = ordem == 0,
                    DataUpload = DateTime.Now,
                    Conteudo = bytesFoto
                };

                fotosPromotor.Add(fotoPromotor);

                ordem++;
            }

            //await _fotoPromotorRepository.AddListAsync(fotosPromotor);

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

    public async Task<List<DocumentoPromotor>> BuscarDocumentos(int id)
    {
        var TodasFotos = await _documentoPromotorRepository.GetAllAsync();

        //var fotosPromotor = TodasFotos.Where(f => f.PromotorId == id).OrderBy(f => f.Ordem).ToList();

        //return fotosPromotor;
        return null;
    }

    public async Task<DocumentoPromotor?> BuscarDocumento(int id)
    {
        //return await _fotoPromotorRepository.GetByIdAsync(id);
        return null;
    }
}

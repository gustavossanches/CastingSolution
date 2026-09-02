using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class DocumentoPromotor
{
    public int Id { get; set; }
    public int PromotorId { get; set; }
    public string CaminhoArquivo { get; set; } = string.Empty;
    public TipoDocumento TipoDocumento { get; set; }
    public DateTime DataUpload { get; set; }
    public StatusDocumento Status { get; set; }
    public string Obs { get; set; } = string.Empty;

    public Promotor Promotor { get; set; } = null!;
}

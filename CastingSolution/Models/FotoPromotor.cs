namespace CastingSolution.Models;

public class FotoPromotor
{
    public int Id { get; set; }
    public int PromotorId { get; set; } 
    public byte[] Conteudo { get; set; }
    public string NomeArquivo { get; set; }
    public bool IsPrincipal { get; set; }
    public int Ordem { get; set; }
    public DateTime DataUpload { get; set; }

    public Promotor Promotor { get; set; } = null!;
}

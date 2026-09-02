using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class Pagamento
{
    public int Id { get; set; }
    public int CastingPromotorId { get; set; }
    public decimal Valor { get; set; }
    public StatusPagamento Status { get; set; }
    public DateTime? DataPrevista { get; set; }
    public DateTime? DataPagamento { get; set; }
    public string Comprovante { get; set; } = string.Empty;

    public CastingPromotor CastingPromotor { get; set; } = null!;
}

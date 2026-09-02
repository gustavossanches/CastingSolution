using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class CastingPromotor
{
    public int Id { get; set; }
    public int PromotorId { get; set; }
    public int CastingId { get; set; }
    public StatusCastingPromotor Status { get; set; }
    public string FuncaoRealizada { get; set; } = string.Empty;
    public int Ordem { get; set; }

    public Promotor Promotor { get; set; } = null!;
    public Casting Casting { get; set; } = null!;
    public Pagamento? Pagamento { get; set; }
}

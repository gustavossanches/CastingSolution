using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class Casting
{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public Area Area { get; set; }
    public StatusCasting Status { get; set; }
    public int MaximoPromotores { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public Evento Evento { get; set; } = null!;
    public ICollection<CastingPromotor> Promotores { get; set; } = new List<CastingPromotor>();
}

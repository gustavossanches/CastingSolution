using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class Evento
{
    public int Id { get; set; }
    public string Local { get; set; } = string.Empty;
    public string Cliente { get; set; } = string.Empty;
    public string DetalhesEvento { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public decimal ValorPromotores { get; set; }
    public decimal ValorCobrado { get; set; }
    public StatusEvento Status { get; set; }

    public ICollection<Casting> ListaCasting { get; set; } = new List<Casting>();
}

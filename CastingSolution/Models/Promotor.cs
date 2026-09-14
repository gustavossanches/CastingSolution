using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class Promotor
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? Cidade { get; set; }
    public string? FuncaoPrincipal { get; set; }
    public int? Altura { get; set; }
    public string? CorOlhos { get; set; }
    public string? CorCabelo { get; set; }
    public Genero? Genero { get; set; }
    public string? TamanhoCamiseta { get; set; }
    public string? TamanhoCalca { get; set; }
    public StatusPromotor? Status { get; set; }
    public string? Observacoes { get; set; }
    public bool IsFavorito { get; set; }
    public int? Nota { get; set; }

    public ICollection<DocumentoPromotor> Documentos { get; set; } = new List<DocumentoPromotor>();
    public ICollection<FotoPromotor> Fotos { get; set; } = new List<FotoPromotor>();
    public ICollection<CastingPromotor> Castings { get; set; } = new List<CastingPromotor>();
}

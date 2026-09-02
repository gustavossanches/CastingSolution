using CastingSolution.Models.Enums;

namespace CastingSolution.Models;

public class Promotor
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public string Cidade { get; set; } = string.Empty;
    public string FuncaoPrincipal { get; set; } = string.Empty;
    public int Altura { get; set; }
    public string CorOlhos { get; set; } = string.Empty;
    public string CorCabelo { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public string TamanhoCamiseta { get; set; } = string.Empty;
    public string TamanhoCalca { get; set; } = string.Empty;
    public StatusPromotor Status { get; set; }
    public string Observacoes { get; set; } = string.Empty;
    public bool IsFavorito { get; set; }
    public int Nota { get; set; }

    public ICollection<DocumentoPromotor> Documentos { get; set; } = new List<DocumentoPromotor>();
    public ICollection<FotoPromotor> Fotos { get; set; } = new List<FotoPromotor>();
    public ICollection<CastingPromotor> Castings { get; set; } = new List<CastingPromotor>();
}

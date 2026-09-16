using System.ComponentModel.DataAnnotations;
using CastingSolution.Models.Enums;

namespace CastingSolution.Models.ViewModel.PromotorViewModel
{
    /// <summary>
    /// ViewModel para o formulário de criação de promotores.  
    /// </summary>
    public class CriarPromotorViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Telefone inválido")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Display(Name = "Função Principal")]
        public string? FuncaoPrincipal { get; set; }

        [Range(0, 300, ErrorMessage = "Altura deve ser entre 0 e 300 cm")]
        [Display(Name = "Altura (cm)")]
        public int? Altura { get; set; }

        [Display(Name = "Cor dos Olhos")]
        public string? CorOlhos { get; set; }

        [Display(Name = "Cor do Cabelo")]
        public string? CorCabelo { get; set; }

        [Display(Name = "Gênero")]
        public Genero? Genero { get; set; }

        [Display(Name = "Tamanho Camiseta")]
        public string? TamanhoCamiseta { get; set; }

        [Display(Name = "Tamanho Calça")]
        public string? TamanhoCalca { get; set; }

        [Display(Name = "Observações")]
        public string? Observacoes { get; set; }

        [Display(Name = "Favorito")]
        public bool IsFavorito { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve ser entre 0 e 10")]
        [Display(Name = "Nota (0-10)")]
        public int? Nota { get; set; }

        /// <summary>
        /// Fotos em base64 enviadas pelo formulário para vinculação ao promotor.
        /// </summary>
        public List<string> FotosBase64 { get; set; } = new();
    }
}

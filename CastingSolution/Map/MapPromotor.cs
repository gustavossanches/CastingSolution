using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDTO;
using CastingSolution.Models.Enums;
using CastingSolution.Models.ViewModel.PromotorViewModel;

namespace CastingSolution.Map
{
    public static class MapPromotor
    {
        public static ICollection<PromotorResumoDTO> MapToListaPromotorDTO(ICollection<Promotor> promotores)
        {
            return promotores.Select(p => new PromotorResumoDTO
            {
                Id = p.Id,
                Nome = p.Nome,
                FuncaoPrincipal = p.FuncaoPrincipal,
                Cidade = p.Cidade,
                Telefone = p.Telefone,
                Status = p.Status ?? StatusPromotor.Ativo,
                IsFavorito = p.IsFavorito
            }).ToList();
        }
        public static Promotor MapToPromotor(CriarPromotorViewModel viewModel)
        {
            return new Promotor
            {
                Nome = viewModel.Nome,
                Email = viewModel.Email,
                Telefone = viewModel.Telefone,
                DataNascimento = viewModel.DataNascimento,
                Cidade = viewModel.Cidade,
                FuncaoPrincipal = viewModel.FuncaoPrincipal,
                Altura = viewModel.Altura,
                CorOlhos = viewModel.CorOlhos,
                CorCabelo = viewModel.CorCabelo,
                Genero = viewModel.Genero,
                TamanhoCamiseta = viewModel.TamanhoCamiseta,
                TamanhoCalca = viewModel.TamanhoCalca,
                Observacoes = viewModel.Observacoes,
                IsFavorito = viewModel.IsFavorito,
                //Fotos = viewModel.Fotos,
                Nota = viewModel.Nota
            };
        }

    }
}

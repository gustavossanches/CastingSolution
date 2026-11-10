using CastingSolution.Models;
using CastingSolution.Models.DTOs.PromotorDetalheDTO;
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
        public static PromotorDetalheDTO MapToPromotorDetalheDTO(Promotor promotor)
        {

            return new PromotorDetalheDTO
            {
                Id = promotor.Id,
                Nome = promotor.Nome,
                Email = promotor.Email,
                FuncaoPrincipal = promotor.FuncaoPrincipal,
                Cidade = promotor.Cidade,
                Telefone = promotor.Telefone,
                DataNascimento = promotor.DataNascimento,
                Altura = promotor.Altura,
                CorOlhos = promotor.CorOlhos,
                CorCabelo = promotor.CorCabelo,
                Genero = promotor.Genero,
                TamanhoCamiseta = promotor.TamanhoCamiseta,
                TamanhoCalca = promotor.TamanhoCalca,
                Status = promotor.Status ?? StatusPromotor.Ativo,
                Observacoes = promotor.Observacoes,
                IsFavorito = promotor.IsFavorito,
                Nota = promotor.Nota,
                Documentos = promotor.Documentos,
                Fotos = promotor.Fotos
            };
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

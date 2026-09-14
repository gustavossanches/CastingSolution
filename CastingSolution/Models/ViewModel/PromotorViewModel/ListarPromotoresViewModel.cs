using CastingSolution.Models.DTOs.PromotorDTO;

namespace CastingSolution.Models.ViewModel.PromotorResumoViewModel
{
    public class ListarPromotoresViewModel
    {
        public ICollection<PromotorResumoDTO> Promotores { get; set; } = new List<PromotorResumoDTO>();
    }
}

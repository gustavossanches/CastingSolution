using CastingSolution.Models;

namespace CastingSolution.Models.DTOs;

public class HomeViewModel
{
    public List<Evento> EventosAtivos { get; set; } = new List<Evento>();
}

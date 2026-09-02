using CastingSolution.Models;

namespace CastingSolution.Interfaces;

public interface IEventoService
{
    Task<IEnumerable<Evento>> GetAllAsync();
    Task<Evento?> GetByIdAsync(int id);
    Task CreateAsync(Evento evento);
    Task UpdateAsync(Evento evento);
    Task DeleteAsync(int id);
}

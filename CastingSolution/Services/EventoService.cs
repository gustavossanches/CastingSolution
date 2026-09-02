using CastingSolution.Models;
using CastingSolution.Models.Enums;
using CastingSolution.Repository;
using CastingSolution.Interfaces;

namespace CastingSolution.Services;

public class EventoService : IEventoService
{
    private readonly IRepository<Evento> _eventoRepository;

    public EventoService(IRepository<Evento> eventoRepository)
    {
        _eventoRepository = eventoRepository;
    }

    public async Task<IEnumerable<Evento>> GetAllAsync()
    {
        return await _eventoRepository.GetAllAsync();
    }

    public async Task<Evento?> GetByIdAsync(int id)
    {
        return await _eventoRepository.GetByIdAsync(id);
    }

    public async Task CreateAsync(Evento evento)
    {
        evento.Status = StatusEvento.PendenteCliente;
        await _eventoRepository.AddAsync(evento);
        await _eventoRepository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Evento evento)
    {
        await _eventoRepository.UpdateAsync(evento);
        await _eventoRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _eventoRepository.DeleteAsync(id);
        await _eventoRepository.SaveChangesAsync();
    }
}

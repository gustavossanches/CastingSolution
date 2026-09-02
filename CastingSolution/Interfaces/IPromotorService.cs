using CastingSolution.Models;

namespace CastingSolution.Interfaces;

public interface IPromotorService
{
    Task CreateAsync(Promotor promotor);
}

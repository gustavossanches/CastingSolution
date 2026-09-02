using CastingSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace CastingSolution.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Promotor> Promotores { get; set; }
    public DbSet<DocumentoPromotor> DocumentosPromotor { get; set; }
    public DbSet<FotoPromotor> FotosPromotor { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Casting> Castings { get; set; }
    public DbSet<CastingPromotor> CastingPromotores { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
}

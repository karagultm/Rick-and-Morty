using Microsoft.EntityFrameworkCore;
using RickAndMortyAPI.Models; // Modellerin bulunduğu namespace (örneğin, RickAndMortyAPI.Models)

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Character> Characters { get; set; }
}

using Microsoft.EntityFrameworkCore;

namespace Mission6_Whitworth.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<movieFormClass> Movies { get; set; }
}
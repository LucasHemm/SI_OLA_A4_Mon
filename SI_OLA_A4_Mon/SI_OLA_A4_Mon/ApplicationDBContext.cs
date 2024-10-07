using Microsoft.EntityFrameworkCore;

namespace SI_OLA_A4_Mon;

public class ApplicationDbContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }

    // Constructor that accepts DbContextOptions
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    // Constructor that accepts no arguments
    public ApplicationDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Only configure SQL Server if no options are provided (to avoid overriding options in tests)
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=si_ola_a4_mon;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
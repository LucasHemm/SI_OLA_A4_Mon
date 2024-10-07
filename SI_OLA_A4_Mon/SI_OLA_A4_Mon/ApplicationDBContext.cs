using Microsoft.EntityFrameworkCore;
using SI_OLA_A4_Mon.Domains;
using SI_OLA_A4_Mon.Domains.CustomerDomain;
using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.PaymentDomain;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;
using SI_OLA_A4_Mon.Domains.TrailerDomain;
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon;

public class ApplicationDbContext : DbContext
{
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<PaymentInfo> PaymentInfos { get; set; }
    public DbSet<RentalAgreement> RentalAgreements { get; set; }   
    public DbSet<Trailer> Trailers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<RentalDuration> RentalDurations { get; set; }
    public DbSet<Location> Locations { get; set; }
    
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
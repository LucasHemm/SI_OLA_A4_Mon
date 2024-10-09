using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.PaymentDomain;
using SI_OLA_A4_Mon.Domains.PaymentDomain.Models;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain;

public class RentalAgreementDomainFacade
{
    private ApplicationDbContext context;
    
    public RentalAgreementDomainFacade(ApplicationDbContext context)
    {
        this.context = context;
    }
    
    //Create RentalAgreement
    public RentalAgreement CreateRentalAgreement(RentalDuration duration, Payment payment, Trailer trailer, Customer customer)
    {
        RentalAgreement rentalAgreement = new RentalAgreement(duration, payment, trailer, customer);
        context.RentalAgreements.Add(rentalAgreement);
        context.SaveChanges();
        return rentalAgreement;
    }
    
    //Update RentalAgreement
    public void UpdateRentalAgreement(int id, RentalDuration duration, Payment payment, Trailer trailer, Customer customer)
    {
        RentalAgreement rentalAgreement = new RentalAgreement(id, duration, payment, trailer, customer);
        context.RentalAgreements.Update(rentalAgreement);
        context.SaveChanges();
    }
    
    
    
}
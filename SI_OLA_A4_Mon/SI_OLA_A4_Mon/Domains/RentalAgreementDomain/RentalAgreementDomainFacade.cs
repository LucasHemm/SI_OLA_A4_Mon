using Microsoft.EntityFrameworkCore;
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
    
    
    //Get RentalAgreement including all related entities
    public RentalAgreement GetRentalAgreement(int id)
    {
        return context.RentalAgreements
            .Include(r => r.duration)
            .Include(r => r.payment)
            .Include(r => r.trailer)
            .Include(r => r.trailer.location)
            .Include(r => r.customer)
            .Include(r => r.customer.address) 
            .Include(r => r.customer.paymentInfo) 
            .FirstOrDefault(r => r.id == id);
    }
  
    
    
    
}
using SI_OLA_A4_Mon.Domains.CustomerDomain;
using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.PaymentDomain;
using SI_OLA_A4_Mon.Domains.TrailerDomain;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain;

public class RentalAgreement
{
    public int id { get; set; } //primary key
    private RentalDuration duration { get; set; }
    private Payment payment { get; set; }
    private Trailer trailer { get; set; }
    private Customer customer { get; set; }
    
    public RentalAgreement(int id, RentalDuration duration, Payment payment, Trailer trailer, Customer customer)
    {
        this.id = id;
        this.duration = duration;
        this.payment = payment;
        this.trailer = trailer;
        this.customer = customer;
    }
    
    //without id
    public RentalAgreement(RentalDuration duration, Payment payment, Trailer trailer, Customer customer)
    {
        this.duration = duration;
        this.payment = payment;
        this.trailer = trailer;
        this.customer = customer;
    }
    
    public RentalAgreement()
    {
    }
    
}


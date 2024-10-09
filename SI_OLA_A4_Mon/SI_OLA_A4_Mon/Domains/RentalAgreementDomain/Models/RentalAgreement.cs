using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.PaymentDomain;
using SI_OLA_A4_Mon.Domains.PaymentDomain.Models;
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;

public class RentalAgreement
{
    public int id { get; private set; } //primary key
    public RentalDuration duration { get; private set; }
    public Payment payment { get; private set; }
    public Customer customer { get; private set; }
    public Trailer trailer { get; private set; }
    
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


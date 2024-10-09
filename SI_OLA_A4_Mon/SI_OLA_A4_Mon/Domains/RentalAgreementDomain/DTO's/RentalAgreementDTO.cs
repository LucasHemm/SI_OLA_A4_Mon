using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain.DTO_s;

public class RentalAgreementDTO
{
    public CustomerDTO customer { get; set; }
    public PaymentDTO payment { get; set; }
    public RentalDurationDTO rentalDuration { get; set; }
    public TrailerDTO trailer { get; set; }
    
    public RentalAgreementDTO(CustomerDTO customer, PaymentDTO payment, RentalDurationDTO rentalDuration, TrailerDTO trailer)
    {
        this.customer = customer;
        this.payment = payment;
        this.rentalDuration = rentalDuration;
        this.trailer = trailer;
    }
    
    public RentalAgreementDTO()
    {
    }
    
}
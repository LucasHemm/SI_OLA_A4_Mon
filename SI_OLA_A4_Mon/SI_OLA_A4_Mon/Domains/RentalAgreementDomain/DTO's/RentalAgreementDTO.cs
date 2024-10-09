using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;
using SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain.DTO_s;

public class RentalAgreementDTO
{
    public int id { get; set; }
    public CustomerDTO customer { get; set; }
    public PaymentDTO payment { get; set; }
    public RentalDurationDTO rentalDuration { get; set; }
    public TrailerDTO trailer { get; set; }
    
    public RentalAgreementDTO(int id, CustomerDTO customer, PaymentDTO payment, RentalDurationDTO rentalDuration, TrailerDTO trailer)
    {
        this.id = id;
        this.customer = customer;
        this.payment = payment;
        this.rentalDuration = rentalDuration;
        this.trailer = trailer;
    }
    
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
    
    public RentalAgreementDTO(RentalAgreement rentalAgreement)
    {
        this.id = rentalAgreement.id;
        this.customer = new CustomerDTO(rentalAgreement.customer);
        this.payment = new PaymentDTO(rentalAgreement.payment);
        this.rentalDuration = new RentalDurationDTO(rentalAgreement.duration);
        this.trailer = new TrailerDTO(rentalAgreement.trailer);
    }
    
   
}
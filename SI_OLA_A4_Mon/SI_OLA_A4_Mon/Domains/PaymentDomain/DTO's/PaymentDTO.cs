using SI_OLA_A4_Mon.Domains.PaymentDomain.Models;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

public class PaymentDTO
{
    public int id { get; set; }
    public bool hasInsurance { get; set; }
    public bool hasPaid { get; set; }
    public bool hasLateFee { get; set; }
    
    public PaymentDTO(int id, bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        this.id = id;
        this.hasInsurance = hasInsurance;
        this.hasPaid = hasPaid;
        this.hasLateFee = hasLateFee;
    }
    
    public PaymentDTO(bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        this.hasInsurance = hasInsurance;
        this.hasPaid = hasPaid;
        this.hasLateFee = hasLateFee;
    }
    
    public PaymentDTO()
    {
    }
    
    public PaymentDTO(Payment payment)
    {
        this.id = payment.id;
        this.hasInsurance = payment.hasInsurance;
        this.hasPaid = payment.hasPaid;
        this.hasLateFee = payment.hasLateFee;
    }
}
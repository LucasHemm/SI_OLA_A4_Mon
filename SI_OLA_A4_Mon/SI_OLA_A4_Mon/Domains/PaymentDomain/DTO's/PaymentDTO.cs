namespace SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

public class PaymentDTO
{
    
    public bool hasInsurance { get; set; }
    public bool hasPaid { get; set; }
    public bool hasLateFee { get; set; }
    
    public PaymentDTO(bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        this.hasInsurance = hasInsurance;
        this.hasPaid = hasPaid;
        this.hasLateFee = hasLateFee;
    }
    
    public PaymentDTO()
    {
    }
}
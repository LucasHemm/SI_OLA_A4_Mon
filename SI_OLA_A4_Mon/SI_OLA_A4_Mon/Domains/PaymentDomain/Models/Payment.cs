namespace SI_OLA_A4_Mon.Domains.PaymentDomain.Models;

public class Payment
{
    public int id { get; private set; } //primary key
    public bool hasInsurance { get; private set; }
    public bool hasPaid { get; private set; }
    public bool hasLateFee { get; private set; }
    
    public Payment(int id, bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        this.id = id;
        this.hasInsurance = hasInsurance;
        this.hasPaid = hasPaid;
        this.hasLateFee = hasLateFee;
    }
    
    //without id
    public Payment(bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        this.hasInsurance = hasInsurance;
        this.hasPaid = hasPaid;
        this.hasLateFee = hasLateFee;
    }
    
    public Payment()
    {
    }
}
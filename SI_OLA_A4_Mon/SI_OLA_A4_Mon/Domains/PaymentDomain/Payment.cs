namespace SI_OLA_A4_Mon.Domains.PaymentDomain;

public class Payment
{
    public int id { get; set; } //primary key
    private bool hasInsurance { get; set; }
    private bool hasPaid { get; set; }
    private bool hasLateFee { get; set; }
    
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
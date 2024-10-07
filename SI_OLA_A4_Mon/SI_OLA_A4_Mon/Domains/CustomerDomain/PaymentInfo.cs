namespace SI_OLA_A4_Mon.Domains.CustomerDomain;

public class PaymentInfo
{
    public int id { get; set; } //primary key
    private string cardNumber { get; set; }
    private Customer cardHolder { get; set; }
    private DateOnly expirationDate { get; set; }
    
    public PaymentInfo(int id, string cardNumber, Customer cardHolder, DateOnly expirationDate)
    {
        this.id = id;
        this.cardNumber = cardNumber;
        this.cardHolder = cardHolder;
        this.expirationDate = expirationDate;
    }
    
    //without id
    public PaymentInfo(string cardNumber, Customer cardHolder, DateOnly expirationDate)
    {
        this.cardNumber = cardNumber;
        this.cardHolder = cardHolder;
        this.expirationDate = expirationDate;
    }
    
    public PaymentInfo()
    {
    }
}
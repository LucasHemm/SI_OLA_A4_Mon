using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

public class PaymentInfo
{
    public int id { get; private set; } //primary key
    public string cardNumber { get; private set; }
    public DateTime expirationDate { get; private set; }
    
    public PaymentInfo(int id, string cardNumber, DateTime expirationDate)
    {
        this.id = id;
        this.cardNumber = cardNumber;
        this.expirationDate = expirationDate;
    }
    
    //without id
    public PaymentInfo(string cardNumber, DateTime expirationDate)
    {
        this.cardNumber = cardNumber;
        this.expirationDate = expirationDate;
    }
    
    public PaymentInfo(PaymentInfoDTO paymentInfoDto)
    {
        this.id = paymentInfoDto.id;
        this.cardNumber = paymentInfoDto.cardNumber;
        this.expirationDate = paymentInfoDto.expirationDate;
    }
    
    public PaymentInfo()
    {
    }
}
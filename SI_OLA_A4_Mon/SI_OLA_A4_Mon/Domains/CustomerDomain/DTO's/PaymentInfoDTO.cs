using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

public class PaymentInfoDTO
{
    public int id { get; set; }  
    public string cardNumber { get; set; }
    public DateTime expirationDate { get; set; }
    
   
    public PaymentInfoDTO(int id, string cardNumber, DateTime expirationDate)
    {
        this.id = id;
        this.cardNumber = cardNumber;
        this.expirationDate = expirationDate;
        
    }
    
    public PaymentInfoDTO(PaymentInfo paymentInfo)
    {
        this.id = paymentInfo.id;
        this.cardNumber = paymentInfo.cardNumber;
        this.expirationDate = paymentInfo.expirationDate;
    }
    
    public PaymentInfoDTO()
    {
    }
    
    
}
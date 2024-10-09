using SI_OLA_A4_Mon.Domains.PaymentDomain.Models;

namespace SI_OLA_A4_Mon.Domains.PaymentDomain;

public class PaymentDomainFacade
{
    private ApplicationDbContext context;
    
    public PaymentDomainFacade(ApplicationDbContext context)
    {
        this.context = context;
    }
    
    //public int id { get; set; } //primary key
    //private bool hasInsurance { get; set; }
    //private bool hasPaid { get; set; }
    //private bool hasLateFee { get; set; }
    
    //create payment and save to db
    public void CreatePayment(bool hasInsurance, bool hasPaid, bool hasLateFee)
    {
        Payment payment = new Payment(hasInsurance, hasPaid, hasLateFee);
        //save to db
        context.Payments.Add(payment);
        context.SaveChanges();
    }
}
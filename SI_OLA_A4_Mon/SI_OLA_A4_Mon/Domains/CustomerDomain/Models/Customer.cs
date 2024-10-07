using SI_OLA_A4_Mon.Domains.RentalAgreementDomain;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

public class Customer
{
    public int id { get; set; } //primary key
    private string name { get; set; }
    private string email { get; set; }
    private Address address { get; set; }
    public PaymentInfo paymentInfo { get; set; }
    private string password { get; set; }
    private List<RentalAgreement> rentalAgreements { get; set; }
    
    public Customer(int id, string name, string email, Address address, PaymentInfo paymentInfo, string password, List<RentalAgreement> rentalAgreements)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        this.password = password;
        this.rentalAgreements = rentalAgreements;
        
    }
    
    //without id
    public Customer(string name, string email, Address address, PaymentInfo paymentInfo, string password)
    {
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        this.password = password;
    }
    
    //update method
    public void UpdateCustomer(int id, string name, string email, Address address, PaymentInfo paymentInfo, string password)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        this.password = password;
    }
    
    //get payment info
    public PaymentInfo GetPaymentInfo()
    {
        return paymentInfo;
    }
    public Customer()
    {
    }
}
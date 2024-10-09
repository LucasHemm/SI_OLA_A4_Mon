using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

public class Customer
{
    public int id { get; private set; } //primary key
    public string name { get; private set; }
    public string email { get; private set; }
    public Address address { get; private set; }
    public PaymentInfo paymentInfo { get; private set; }
    public string password { get; private set; }
    
    public Customer(int id, string name, string email, Address address, PaymentInfo paymentInfo, string password)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        this.password = password;
        
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

    public Customer(CustomerDTO customerDto)
    {
        this.id = customerDto.id;
        this.name = customerDto.name;
        this.email = customerDto.email;
        this.address = new Address(customerDto.address);
        this.paymentInfo = new PaymentInfo(customerDto.paymentInfo);
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
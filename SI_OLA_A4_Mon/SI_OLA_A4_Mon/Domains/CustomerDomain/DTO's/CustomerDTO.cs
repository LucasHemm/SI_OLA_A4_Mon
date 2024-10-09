using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

public class CustomerDTO
{
    public int id { get; set; }  
    public string name { get; set; }
    public string email { get; set; }
    public AddressDTO address { get; set; }
    public PaymentInfoDTO paymentInfo { get; set; }
    public string password { get; set; }
    
    private List<RentalAgreementDTO> rentalAgreementDTOs { get; set; }

    
    public CustomerDTO(int id, string name, string email, AddressDTO address, PaymentInfoDTO paymentInfo, string password)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        this.password = password;
        
    }
    public CustomerDTO(int id, string name, string email, AddressDTO address, PaymentInfoDTO paymentInfo)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.address = address;
        this.paymentInfo = paymentInfo;
        
    }
    public CustomerDTO(Customer customer)
    {
        this.id = customer.id;
        this.name = customer.name;
        this.email = customer.email;
        this.address = new AddressDTO(customer.address);
        this.paymentInfo = new PaymentInfoDTO(customer.paymentInfo);
    }
    
    public CustomerDTO()
    {
    }
    
}
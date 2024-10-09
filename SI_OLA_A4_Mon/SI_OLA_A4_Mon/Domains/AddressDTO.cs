namespace SI_OLA_A4_Mon.Domains;

public class AddressDTO
{
    public int id { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string zipCode { get; set; }
    
    public AddressDTO(string street, string city, string zipCode)
    {
        this.street = street;
        this.city = city;
        this.zipCode = zipCode;
    }
    
    public AddressDTO(Address address)
    {
        this.id = address.id;
        this.street = address.street;
        this.city = address.city;
        this.zipCode = address.zipCode;
    }
    
    public AddressDTO()
    {
    }
}
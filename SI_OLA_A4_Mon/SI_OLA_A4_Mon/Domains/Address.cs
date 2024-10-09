using System.ComponentModel.DataAnnotations;

namespace SI_OLA_A4_Mon.Domains;

public class Address
{
    
    public int id { get; private set; } //primary key
    public string street { get; private set; }
    public string city { get; private set; }
    public string zipCode { get; private set; }
    
    public Address(int id, string street, string city, string zipCode)
    {
        this.id = id;
        this.street = street;
        this.city = city;
        this.zipCode = zipCode;
    }
    
    //without id
    public Address(string street, string city, string zipCode)
    {
        this.street = street;
        this.city = city;
        this.zipCode = zipCode;
    }
    
    public Address(AddressDTO addressdto)
    {
        this.id = addressdto.id;
        this.street = addressdto.street;
        this.city = addressdto.city;
        this.zipCode = addressdto.zipCode;
    }
    
    public Address()
    {
    }
}
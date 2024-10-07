using System.ComponentModel.DataAnnotations;

namespace SI_OLA_A4_Mon.Domains;

public class Address
{
    
    public int id { get; set; } //primary key
    private string street { get; set; }
    private string city { get; set; }
    private string zipCode { get; set; }
    
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
    
    public Address()
    {
    }
}
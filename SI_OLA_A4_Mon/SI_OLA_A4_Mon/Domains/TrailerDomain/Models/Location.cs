namespace SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

public class Location
{
    public int id { get; set; } //primary key
    private string companyName { get; set; }
    private Address address { get; set; }
    
    public Location(int id, string companyName, Address address)
    {
        this.id = id;
        this.companyName = companyName;
        this.address = address;
    }
    
    //without id
    public Location(string companyName, Address address)
    {
        this.companyName = companyName;
        this.address = address;
    }
    
    public Location()
    {
    }
}
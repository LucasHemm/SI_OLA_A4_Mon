using SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

public class Location
{
    public int id { get; set; } //primary key
    public string companyName { get; private set; }
    public string address { get; private set; }
    
    public Location(int id, string companyName, string address)
    {
        this.id = id;
        this.companyName = companyName;
        this.address = address;
    }
    
    //without id
    public Location(string companyName, string address)
    {
        this.companyName = companyName;
        this.address = address;
    }
    
    public Location()
    {
    }
    
    public Location(LocationDTO location)
    {
        this.id = location.id;
        this.companyName = location.companyName;
        this.address = location.address;
    }
}
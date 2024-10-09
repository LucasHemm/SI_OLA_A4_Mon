using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

public class LocationDTO
{
    public int id { get; set; }
    public string companyName { get; set; }
    public string address { get; set; }
    
    public LocationDTO(int id, string companyName, string address)
    {
        this.id = id;
        this.companyName = companyName;
        this.address = address;
    }
    
    //without id
    public LocationDTO(string companyName, string address)
    {
        this.companyName = companyName;
        this.address = address;
    }
    
    public LocationDTO()
    {
    }
    
    public LocationDTO(Location location)
    {
        this.id = location.id;
        this.companyName = location.companyName;
        this.address = location.address;
    }

}
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

public class TrailerDTO
{
    public int id { get; set; } 
    public string trailerNumber { get; set; }
    public string status { get; set; }
    public LocationDTO location { get; set; }
    
    public TrailerDTO(int id, string trailerNumber, string status, LocationDTO location)
    {
        this.id = id;
        this.trailerNumber = trailerNumber;
        this.status = status;
        this.location = location;
    }
    
    //without id
    public TrailerDTO(string trailerNumber, string status, LocationDTO location)
    {
        this.trailerNumber = trailerNumber;
        this.status = status;
        this.location = location;
    }
    
    public TrailerDTO()
    {
    }

    public TrailerDTO(Trailer trailer)
    {
        this.id = trailer.id;
        this.trailerNumber = trailer.trailerNumber;
        this.status = trailer.status;
        this.location = new LocationDTO(trailer.location);
    }

}


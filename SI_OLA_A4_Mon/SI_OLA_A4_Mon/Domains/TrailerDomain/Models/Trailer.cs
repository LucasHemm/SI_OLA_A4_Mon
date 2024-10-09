using SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

public class Trailer
{
    public int id { get; set; } //primary key
    public string trailerNumber { get; private set; }
    public string status { get; private set; }
    public Location location { get; private set; }
    
    public Trailer(int id, string trailerNumber, string status, Location location)
    {
        this.id = id;
        this.trailerNumber = trailerNumber;
        this.status = status;
        this.location = location;
    }
    
    //without id
    public Trailer(string trailerNumber, string status, Location location)
    {
        this.trailerNumber = trailerNumber;
        this.status = status;
        this.location = location;
    }
    
    public Trailer()
    {
    }
    
    public Trailer(TrailerDTO trailer)
    {
        this.trailerNumber = trailer.trailerNumber;
        this.status = trailer.status;
        this.location = new Location(trailer.location);
    }

}
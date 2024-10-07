namespace SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

public class Trailer
{
    public int id { get; set; } //primary key
    private string trailerNumber { get; set; }
    private string status { get; set; }
    private Location location { get; set; }
    
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

}
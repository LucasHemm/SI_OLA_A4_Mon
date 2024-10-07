using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain;

public class TrailerDomainFacade
{
    
    private ApplicationDbContext context;
    
    public TrailerDomainFacade(ApplicationDbContext context)
    {
        this.context = context;
    }
    
    //Create trailer and save to db
    public void CreateTrailer(string trailerNumber, string status, Location location)
    {
        Trailer trailer = new Trailer(trailerNumber, status, location);
        //save to db
        context.Trailers.Add(trailer);
        context.SaveChanges();
    }
    
    //Update trailer and save to db
    public void UpdateTrailer(int id, string trailerNumber, string status, Location location)
    {
        Trailer trailer = new Trailer(id, trailerNumber, status, location);
        //save to db
        context.Trailers.Update(trailer);
        context.SaveChanges();
    }
    
    //Delete trailer from db
    public void DeleteTrailer(int id)
    {
        Trailer trailer = context.Trailers.Find(id);
        context.Trailers.Remove(trailer);
        context.SaveChanges();
    }
    
    //Get all trailers
    public List<Trailer> GetAllTrailers()
    {
        return context.Trailers.ToList();
    }
    
    //Get trailer by id
    public Trailer GetTrailerById(int id)
    {
        return context.Trailers.Find(id) ?? throw new Exception("Trailer not found");
    }
    
    //Create location and save to db
    public void CreateLocation(string companyName, Address address)
    {
        Location location = new Location(companyName, address);
        //save to db
        context.Locations.Add(location);
        context.SaveChanges();
    }
    
    //Update location and save to db
    public void UpdateLocation(int id, string companyName, Address address)
    {
        Location location = new Location(id, companyName, address);
        //save to db
        context.Locations.Update(location);
        context.SaveChanges();
    }
    
    //Delete location from db
    public void DeleteLocation(int id)
    {
        Location location = context.Locations.Find(id);
        context.Locations.Remove(location);
        context.SaveChanges();
    }
    
    //Get all locations
    public List<Location> GetAllLocations()
    {
        return context.Locations.ToList();
    }
    
    //Get location by id
    public Location GetLocationById(int id)
    {
        return context.Locations.Find(id) ?? throw new Exception("Location not found");
    }
    
    
    
}
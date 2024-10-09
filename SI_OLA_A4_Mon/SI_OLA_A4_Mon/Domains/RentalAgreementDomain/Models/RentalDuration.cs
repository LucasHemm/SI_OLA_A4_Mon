namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;

public class RentalDuration
{
    public int id { get; set; } //primary key
    public DateTime startDate { get; private set; }
    public DateTime endDate { get; private set; }
    
    public RentalDuration(int id, DateTime startDate, DateTime endDate)
    {
        this.id = id;
        this.startDate = startDate;
        this.endDate = endDate;
    }
    
    //without id
    public RentalDuration(DateTime startDate, DateTime endDate)
    {
        this.startDate = startDate;
        this.endDate = endDate;
    }
    
    public RentalDuration()
    {
    }
    
}
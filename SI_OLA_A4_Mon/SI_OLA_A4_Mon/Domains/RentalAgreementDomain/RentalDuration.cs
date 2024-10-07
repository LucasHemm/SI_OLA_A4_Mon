namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain;

public class RentalDuration
{
    public int id { get; set; } //primary key
    private DateTime startDate { get; set; }
    private DateTime endDate { get; set; }
    
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
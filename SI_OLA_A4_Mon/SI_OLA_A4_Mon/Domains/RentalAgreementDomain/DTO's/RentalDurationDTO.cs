using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain.DTO_s;

public class RentalDurationDTO
{
    public int id { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    
    public RentalDurationDTO(int id, DateTime startDate, DateTime endDate)
    {
        this.id = id;
        this.startDate = startDate;
        this.endDate = endDate;
    }
    
    //without id
    public RentalDurationDTO(DateTime startDate, DateTime endDate)
    {
        this.startDate = startDate;
        this.endDate = endDate;
    }
    
    public RentalDurationDTO()
    {
    }
    
    public RentalDurationDTO(RentalDuration rentalDuration)
    {
        this.id = rentalDuration.id;
        this.startDate = rentalDuration.startDate;
        this.endDate = rentalDuration.endDate;
    }
    
}
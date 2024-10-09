using Microsoft.AspNetCore.Mvc;
using SI_OLA_A4_Mon.Domains.CustomerDomain;
using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;
using SI_OLA_A4_Mon.Domains.PaymentDomain.Models;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain.Models;
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.RentalAgreementDomain;

[ApiController]
[Route("api/[controller]")]
public class RentalAgreementController : ControllerBase
{
    private readonly RentalAgreementDomainFacade _rentalAgreementDomainFacade;
    private readonly CustomerDomainFacade _customerDomainFacade;

    public RentalAgreementController(RentalAgreementDomainFacade rentalAgreementDomainFacade, CustomerDomainFacade customerDomainFacade)
    {
        _rentalAgreementDomainFacade = rentalAgreementDomainFacade;
        _customerDomainFacade = customerDomainFacade;
    }

    // POST: api/RentalAgreement
    [HttpPost]
    public IActionResult CreateRentalAgreement([FromBody] RentalAgreementDTO rentalAgreementDto)
    {
        try
        {
            RentalDuration duration = new RentalDuration(rentalAgreementDto.rentalDuration);
            Payment payment = new Payment(rentalAgreementDto.payment);
            Trailer trailer = new Trailer(rentalAgreementDto.trailer);
            Customer customer = _customerDomainFacade.GetCustomer(rentalAgreementDto.customer.id);
            
            _rentalAgreementDomainFacade.CreateRentalAgreement(duration, payment, trailer, customer);
            
            return Ok("Rental agreement created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex.Message);
        }
        
    }

    // GET: api/RentalAgreement/{id}
    [HttpGet("{id}")]
    public IActionResult GetRentalAgreement(int id)
    {
        try
        {
            var rentalAgreement = _rentalAgreementDomainFacade.GetRentalAgreement(id);
            if (rentalAgreement == null)
            {
                return NotFound("Rental agreement not found");
            }
            
            RentalAgreementDTO rentalAgreementDto = new RentalAgreementDTO(rentalAgreement);
            
            return Ok(rentalAgreementDto);
            
        }catch(Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex.Message);
        }
        
    }
    
   
    
}
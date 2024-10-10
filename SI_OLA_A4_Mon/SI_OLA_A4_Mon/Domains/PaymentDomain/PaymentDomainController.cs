using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;

namespace SI_OLA_A4_Mon.Domains.PaymentDomain;
[ApiController]
[Route("api/[controller]")]
public class PaymentDomainController : ControllerBase
{
    private readonly PaymentDomainFacade _paymentDomainFacade;
    
    public PaymentDomainController(PaymentDomainFacade paymentDomainFacade)
    {
        _paymentDomainFacade = paymentDomainFacade;
    }
    
    // POST: api/PaymentDomain
    [HttpPost]
    public IActionResult CreatePayment([FromBody] PaymentDTO paymentDto)
    {
        try
        {
            _paymentDomainFacade.CreatePayment(paymentDto.hasInsurance, paymentDto.hasPaid, paymentDto.hasLateFee);
            return Ok("Payment created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SI_OLA_A4_Mon.Domains.TrailerDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.TrailerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.TrailerDomain;

[ApiController]
[Route("api/[controller]")]
public class TrailerDomainController : ControllerBase
{
    private readonly TrailerDomainFacade _trailerDomainFacade;

    public TrailerDomainController(TrailerDomainFacade trailerDomainFacade)
    {
        _trailerDomainFacade = trailerDomainFacade;
    }

    // POST: api/TrailerDomain
    [HttpPost]
    public IActionResult CreateTrailer([FromBody] TrailerDTO trailerDto)
    {
        Console.WriteLine(trailerDto);
        try
        {
            Trailer trailer = new Trailer(trailerDto);
            _trailerDomainFacade.CreateTrailer(trailer);
            return Ok("Trailer created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex.Message);
        }
    }

    // GET: api/TrailerDomain/{id}
    [HttpGet("{id}")]
    public IActionResult GetTrailer(int id)
    {
        try
        {
            var trailer = _trailerDomainFacade.GetTrailerById(id);
            if (trailer == null)
            {
                return NotFound("Trailer not found");
            }

            TrailerDTO trailerDto = new TrailerDTO(trailer);

            return Ok(trailerDto);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return BadRequest(ex.Message);
        }
    }
    
}
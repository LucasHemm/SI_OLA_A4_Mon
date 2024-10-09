using Microsoft.AspNetCore.Mvc;
using SI_OLA_A4_Mon.Domains;
using SI_OLA_A4_Mon.Domains.CustomerDomain;
using SI_OLA_A4_Mon.Domains.CustomerDomain.DTO_s;
using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

namespace SI_OLA_A4_Mon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDomainFacade _customerDomainFacade;

        public CustomerController(CustomerDomainFacade customerDomainFacade)
        {
            _customerDomainFacade = customerDomainFacade;
        }

        // POST: api/Customer
        [HttpPost]
        public IActionResult CreateCustomer([FromBody] CustomerDTO customerDto)
        {
            try
            {
                var address = new Address(customerDto.address);

                var paymentInfo = new PaymentInfo(customerDto.paymentInfo);

                _customerDomainFacade.CreateCustomer(customerDto.name, customerDto.email, address, paymentInfo, customerDto.password);
                
                return Ok("Customer created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Customer/{id}
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            try
            {
                var customer = _customerDomainFacade.GetCustomer(id);
                if (customer == null)
                {
                    return NotFound("Customer not found");
                }
                
                CustomerDTO customerDto = new CustomerDTO(customer);
                
                return Ok(customerDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Customer/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerDTO customerDto)
        {
            try
            {
                Address address = new Address(customerDto.address);

                PaymentInfo paymentInfo = new PaymentInfo(customerDto.paymentInfo);

                _customerDomainFacade.UpdateCustomer(id, customerDto.name, customerDto.email, address, paymentInfo, customerDto.password);
                
                return Ok("Customer updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Customer
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            try
            {
                var customers = _customerDomainFacade.GetAllCustomers();
                Console.WriteLine(customers.Count);
                List<CustomerDTO> customerDtos = new List<CustomerDTO>();
                foreach (Customer c in customers)
                {
                    customerDtos.Add(new CustomerDTO(c));
                }

                Console.WriteLine(customerDtos.Count + "here");
                

                return Ok(customerDtos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Customer/with-payment-info/{id}
        
    }
}

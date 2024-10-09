using Microsoft.EntityFrameworkCore;
using SI_OLA_A4_Mon.Domains.CustomerDomain.Models;

namespace SI_OLA_A4_Mon.Domains.CustomerDomain;

public class CustomerDomainFacade
{
    
    private ApplicationDbContext context;
    
    public CustomerDomainFacade(ApplicationDbContext context)
    {
        this.context = context;
    }
    // public int id { get; set; } //primary key
    //private string name { get; set; }
    //private string email { get; set; }
    //private Address address { get; set; }
    //private PaymentInfo paymentInfo { get; set; }
    //private string password { get; set; }
    //private List<RentalAgreement> rentalAgreements { get; set; }
    //create method for creating customer
    public void CreateCustomer(string name, string email, Address address, PaymentInfo paymentInfo, string password)
    {
        Customer customer = new Customer(name, email, address, paymentInfo, password);
        //add customer to database
        context.Customers.Add(customer);
        context.SaveChanges();
        
    }
    
    //update customer
    public void UpdateCustomer(int id, string name, string email, Address address, PaymentInfo paymentInfo, string password)
    {
        Customer customer = context.Customers.Find(id)??
            throw new Exception("Customer not found");
        customer.UpdateCustomer(id, name, email, address, paymentInfo, password);
        context.SaveChanges();
    }
    
    //get customer
    public Customer GetCustomer(int id) 
    {
        return context.Customers
            .Include(c => c.address)       // Include Address
            .Include(c => c.paymentInfo)   // Include PaymentInfo
            .FirstOrDefault(c => c.id == id) ?? throw new Exception("Customer not found");
    }
    public Customer GetCustomerWithPaymentInfo(int id)
    {
        return context.Customers.Include(c => c.paymentInfo).FirstOrDefault(c => c.id == id) ??
            throw new Exception("Customer not found");
    }
    
    //get all customer
    public List<Customer> GetAllCustomers()
    {
       return context.Customers
            .Include(c => c.address)       // Include Address
            .Include(c => c.paymentInfo).ToList()   // Include PaymentInfo
            ?? throw new Exception("Customer not found");
    }
   
    
    
    
}
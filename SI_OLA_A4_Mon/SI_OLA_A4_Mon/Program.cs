using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SI_OLA_A4_Mon;
using SI_OLA_A4_Mon.Domains.CustomerDomain;
using SI_OLA_A4_Mon.Domains.PaymentDomain;
using SI_OLA_A4_Mon.Domains.RentalAgreementDomain;
using SI_OLA_A4_Mon.Domains.TrailerDomain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Facades
builder.Services.AddScoped<CustomerDomainFacade>();
builder.Services.AddScoped<PaymentDomainFacade>();
builder.Services.AddScoped<RentalAgreementDomainFacade>();
builder.Services.AddScoped<TrailerDomainFacade>();

// Enable Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    // Apply any pending migrations and create the database if it doesn't exist
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
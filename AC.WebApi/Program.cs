using AC.Data.Context;
using AC.Data.Repository;
using AC.Data.Validator;
using AC.Manager.Implementation;
using AC.Manager.Interfaces;
using AC.Manager.Mappings;
using AC.WebApi;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new Startup(builder.Configuration, builder.Services);
startup.ConfigureServices();
/*builder.Services.AddControllers().
     AddFluentValidation(p => 
     {
        p.RegisterValidatorsFromAssemblyContaining<AlterCustomerValidator>();
        p.RegisterValidatorsFromAssemblyContaining<NewCustomerValidator>();
    }); 

builder.Services.AddAutoMapper(typeof(NewCustomerMappingProfile), typeof(AlterCustomerMappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<AcContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AcConnection")));
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<AcContext>();
builder.Services.AddScoped<ICustomerManager, CustomerManager>();*/


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


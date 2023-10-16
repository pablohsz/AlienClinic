using AC.Data.Context;
using AC.Data.Repository;
using AC.Data.Validator;
using AC.Manager.Implementation;
using AC.Manager.Interfaces;
using AC.Manager.Mappings;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace AC.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IServiceCollection Services { get; }

        public Startup(IConfiguration configuration, IServiceCollection services)
        {
            Configuration = configuration;
            Services = services;
        }


        public void ConfigureServices()
        {
            // Dependency injection
            Services.AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<AcContext>()
                .AddScoped<ICustomerManager, CustomerManager>();

            AddDbContext();
            ConfigureAutoMapper();
            ConfigureValidators();
        }

        private void AddDbContext()
        {
            Services.AddDbContext<AcContext>
                (options => options.UseSqlServer
                (Configuration.GetConnectionString("AcConnection")));
        }

        private void ConfigureAutoMapper()
        {
            Services.AddAutoMapper(typeof(NewCustomerMappingProfile), typeof(AlterCustomerMappingProfile));
        }

        private void ConfigureValidators()
        {
            Services.AddControllers().AddFluentValidation(
                p => {
                         p.RegisterValidatorsFromAssemblyContaining<AlterCustomerValidator>();
                         p.RegisterValidatorsFromAssemblyContaining<NewCustomerValidator>();
                     });
        }

    }
}

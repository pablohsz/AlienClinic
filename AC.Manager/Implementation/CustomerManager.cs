using AC.Core.Domain;
using AC.Core.Shared.ModelViews;
using AC.Manager.Interfaces;
using AutoMapper;

namespace AC.Manager.Implementation
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository customerRepository;

        private readonly IMapper mapper;

        public CustomerManager(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await customerRepository.GetCustumerAsync();
        }

        public async Task<Customer> GetCustumerAsync(int id)
        {
            return await customerRepository.GetCustumerByIdAsync(id);
        }

        public async Task DeleteCustumerAsync(int id)
        {
           await customerRepository.DeleteCustumerAsync(id);

        }

        public async Task<Customer> InsertCustumerAsync(NewCustomer newCustomer)
        {
            var customer = mapper.Map<Customer>(newCustomer);
            return await customerRepository.InsertCustumerAsync(customer);
        }

        public async Task<Customer> UpdateCustumerAsync(AlterCustomer alterCustomer)
        {
            var customer = mapper.Map<Customer>(alterCustomer);
            return await customerRepository.UpdateCustumerAsync(customer);
        }
    }
}

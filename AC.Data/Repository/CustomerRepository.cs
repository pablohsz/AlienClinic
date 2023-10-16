using AC.Core.Domain;
using AC.Core.Shared.ModelViews;
using AC.Data.Context;
using AC.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AC.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly AcContext context;
        public CustomerRepository(AcContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustumerAsync()
        {
            return await context.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<Customer> GetCustumerByIdAsync(int id)
        {
            return await context.Customers.FindAsync(id);
        }

        public async Task<Customer> InsertCustumerAsync(Customer customer)
        {
            await context.Customers.AddAsync(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateCustumerAsync(Customer alterCustomer)
        {
            var custumerSearch = await context.Customers.AsNoTracking().FirstOrDefaultAsync(
                c => c.Id == alterCustomer.Id);
            if (custumerSearch == null)
            {
                return null;
            }
            context.Update(alterCustomer);
            await context.SaveChangesAsync();
            return alterCustomer;
        }

        public async Task DeleteCustumerAsync(int id)
        {
            var custumerSearch = await context.Customers.FindAsync(id);
            context.Customers.Remove(custumerSearch);
            await context.SaveChangesAsync();
        }


    }
}

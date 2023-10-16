using AC.Core.Domain;
using AC.Core.Shared.ModelViews;

namespace AC.Manager.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustumerByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustumerAsync();
        Task<Customer> InsertCustumerAsync(Customer customer);
        Task<Customer> UpdateCustumerAsync(Customer alterCustomer);
        Task DeleteCustumerAsync(int id);
    }
}

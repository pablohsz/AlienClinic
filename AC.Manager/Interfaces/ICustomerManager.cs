using AC.Core.Domain;
using AC.Core.Shared.ModelViews;

namespace AC.Manager.Interfaces
{
    public interface ICustomerManager
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustumerAsync(int id);
        Task<Customer> InsertCustumerAsync(NewCustomer newCustomer);
        Task<Customer> UpdateCustumerAsync(AlterCustomer alterCustomer);
        Task DeleteCustumerAsync(int id);
    }
}

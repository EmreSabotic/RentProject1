namespace RentProjectAPI.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer?> GetSingleCustomer(int id);

        Task<List<Customer>> AddCustomer(Customer singlecustomer);
        Task<List<Customer>?> UpdateCustomer(int id, Customer request);
        Task<List<Customer>?> DeleteCustomer(int id);

    }
}

namespace RentProjectAPI.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Customer? GetSingleCustomer(int id);

        List<Customer> AddCustomer(Customer singlecustomer);
        List<Customer>? UpdateCustomer(int id, Customer request);
        List<Customer>? DeleteCustomer(int id);

    }
}

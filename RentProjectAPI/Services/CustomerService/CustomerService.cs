using RentProjectAPI.Models;

namespace RentProjectAPI.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> Customers = new List<Customer>
            {

                new Customer
                {
                    ID = 1,
                    KullaniciAdi = "Hunckol",
                    CustomerAdi = "Emre",
                    CustomerSoyadi = "Şeftali",
                    TC = "40882421098",
                    Mail = "emresabotic30@hotmail.com",
                    Telefon = "05374240918",
                    Aciklama = "İlk Müşteri."
                },
                new Customer
                {
                    ID = 2,
                    KullaniciAdi = "basaranefe",
                    CustomerAdi = "Efe",
                    CustomerSoyadi = "Başaran",
                    TC = "5342534256",
                    Mail = "efebasaran@hotmail.com",
                    Telefon = "05312456752",
                    Aciklama = "İkinci Müşteri."

                }


            };

        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context; 
        }
        public List<Customer> AddCustomer(Customer singlecustomer)
        {
            Customers.Add(singlecustomer);
            return Customers;
        }

        public List<Customer>? DeleteCustomer(int id)
        {
            var singlecustomer = Customers.Find(x => x.ID == id);
            if (singlecustomer is null)
                return null;

            Customers.Remove(singlecustomer);
            return Customers;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var singlecustomer1 = await _context.tblCustomer.ToListAsync();
            return singlecustomer1;
        }

        public Customer GetSingleCustomer(int id)
        {
            var singlecustomer = Customers.Find(x => x.ID == id);
            if (singlecustomer is null)
                return null;
            return singlecustomer;
        }

        public List<Customer>? UpdateCustomer(int id, Customer request)
        {
            var singlecustomer = Customers.Find(x => x.ID == id);
            if (singlecustomer is null)
                return null;

            singlecustomer.KullaniciAdi = request.KullaniciAdi;
            singlecustomer.CustomerAdi = request.CustomerAdi;
            singlecustomer.CustomerSoyadi = request.CustomerSoyadi;
            singlecustomer.TC = request.TC;
            singlecustomer.Mail = request.Mail;
            singlecustomer.Telefon = request.Telefon;
            singlecustomer.Aciklama = request.Aciklama;
            return Customers;
        }
    }
}

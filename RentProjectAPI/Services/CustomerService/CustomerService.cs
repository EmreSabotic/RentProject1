using RentProjectAPI.Models;

namespace RentProjectAPI.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
       

        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context; 
        }
        public async Task<List<Customer>> AddCustomer(Customer singlecustomer)
        {
            _context.tblCustomer.Add(singlecustomer);
            await _context.SaveChangesAsync();
            return await _context.tblCustomer.ToListAsync();
        }

        public async Task<List<Customer>?> DeleteCustomer(int id)
        {
            var singlecustomer = await _context.tblCustomer.FindAsync(id);
            if (singlecustomer is null)
                return null;

            _context.tblCustomer.Remove(singlecustomer);
            await _context.SaveChangesAsync();
            return await _context.tblCustomer.ToListAsync();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var singlecustomer1 = await _context.tblCustomer.ToListAsync();
            return singlecustomer1;
        }

        public async Task<Customer?> GetSingleCustomer(int id)
        {
            var singlecustomer = await _context.tblCustomer.FindAsync(id);
            if (singlecustomer is null)
                return null;
            return singlecustomer;
        }

        public async Task<List<Customer>?> UpdateCustomer(int id, Customer request)
        {
            var singlecustomer = await _context.tblCustomer.FindAsync(id);
            if (singlecustomer is null)
                return null;

            singlecustomer.KullaniciAdi = request.KullaniciAdi;
            singlecustomer.CustomerAdi = request.CustomerAdi;
            singlecustomer.CustomerSoyadi = request.CustomerSoyadi;
            singlecustomer.Aktiflik=request.Aktiflik;
            singlecustomer.TC = request.TC;
            singlecustomer.Mail = request.Mail;
            singlecustomer.Telefon = request.Telefon;
            singlecustomer.LastVisitInDate= request.LastVisitInDate;
            singlecustomer.LastVisitOutDate = request.LastVisitOutDate;
            singlecustomer.CustomerType = request.CustomerType;
            singlecustomer.Aciklama = request.Aciklama;

            await _context.SaveChangesAsync();
            return await _context.tblCustomer.ToListAsync();
        }
    }
}

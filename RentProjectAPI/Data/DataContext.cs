global using Microsoft.EntityFrameworkCore;

namespace RentProjectAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
             => optionsBuilder.UseSqlServer("Data Source=LAPTOP-KIFERO8A;Initial Catalog=RentProjesiDB;User ID=sa;Password=E13971397.P;TrustServerCertificate=true");
        
      
        public DbSet<Customer> tblCustomer { get; set; }
    } 
}


global using Microsoft.EntityFrameworkCore;

namespace RentProjectAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
             => optionsBuilder.UseSqlServer("Data Source=DESKTOP-37OLJFD\\SQL2012;Initial Catalog=RentProjesiDB;User ID=sa;Password=;TrustServerCertificate=true");
        
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\LAPTOP-KIFERO8A;Database=RentProjesiDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        */
        public DbSet<Customer> tblCustomer { get; set; }
    } 
}


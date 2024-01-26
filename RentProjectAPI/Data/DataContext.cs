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
        public DbSet<Birim> tblBirim { get; set; }
        public DbSet<Cari> tblCari { get; set; }
        public DbSet<Depo> tblDepo { get; set; }
        public DbSet<Döviz> tblDöviz { get; set; }
        public DbSet<Hareket> tblHareket { get; set; }
        public DbSet<İade> tblİade { get; set; }
        public DbSet<Kasa> tblKasa { get; set; }
        public DbSet<Kategoriler> tblKategoriler { get; set; }
        public DbSet<Kullanici> tblKullanici { get; set; }
        public DbSet<PcMaster> tblPcMaster { get; set; }
        public DbSet<PcPosMaster> tblPcPosMaster { get; set; }
        public DbSet<Stok> tblStok { get; set; }
        public DbSet<Urunler> tblUrunler { get; set; }
    } 
}


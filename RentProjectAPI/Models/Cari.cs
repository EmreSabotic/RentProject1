namespace RentProjectAPI.Models
{
    public class Cari
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime BelgeTarihi { get; set; }
        public string DokumanSaati { get; set; }
        public decimal Alacak { get; set; }
        public decimal Borç { get; set; }
        public decimal Bakiye { get; set; }
        public string Aciklama { get; set; }
    }
}

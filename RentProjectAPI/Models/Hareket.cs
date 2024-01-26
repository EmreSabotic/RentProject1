namespace RentProjectAPI.Models
{
    public class Hareket
    {
        public int ID { get; set; }
        public int UrunID { get; set; }
        public int CustomerID { get; set; }
        public int SatanPersonelID { get; set; }
        public int KategoriID { get; set; }
        public string SatisTuru { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Adet { get; set; }
    }
}

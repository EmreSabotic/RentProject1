namespace RentProjectAPI.Models
{
    public class Stok
    {
        public int ID { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public bool Aktiflik { get; set; }
        public int Birim { get; set; }
        public decimal BirimCarpan { get; set; }
        public int PerakendeKDVID { get; set; }
        public int ToptanKDVID { get; set; }
        public int AsgariSure { get; set; }
        public int AzamiSure { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int FiyatID { get; set; }

  
    }
}


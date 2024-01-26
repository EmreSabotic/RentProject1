namespace RentProjectAPI.Models
{
    public class Depo
    {
        public int ID { get; set; }
        public string Adres { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}

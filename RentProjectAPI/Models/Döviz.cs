namespace RentProjectAPI.Models
{
    public class Döviz
    {
        public int ID { get; set; }
        public decimal DövizKuru { get; set; }
        public string DövizAdi { get; set; }
        public string DövizKodu { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}

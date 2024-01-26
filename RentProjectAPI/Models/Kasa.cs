namespace RentProjectAPI.Models
{
    public class Kasa
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string İslemTuru { get; set; }
        public decimal İslemTutari { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Aciklama { get; set; }

    }
}

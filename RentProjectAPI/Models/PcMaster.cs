namespace RentProjectAPI.Models
{
    public class PcMaster
    {
        public int ID { get; set; }
        public string BelgeKodu { get; set; }
        public DateTime BelgeTarihi { get; set; }
        public string HareketTuru { get; set; }
        public int KasaID { get; set; }
        public int CariID { get; set; }
        public string Adres { get; set; }
        public decimal DetayIskontoTutari { get; set; }
        public decimal TutarIskontosu { get; set; }
        public decimal YuzdeIskontosu { get; set; }
        public int DovizID { get; set; }
        public decimal DovizKuru { get; set; }
        public string Aciklama { get; set; }
        public int DepoID { get; set; }
        public int ChangedUserID { get; set; }
        public DateTime ChangedDateTime { get; set; }
        public DateTime EndDayDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsCancel { get; set; }
        public bool Is3rdPartySend { get; set; }
        public int SatisTuru { get; set; }
    }
}

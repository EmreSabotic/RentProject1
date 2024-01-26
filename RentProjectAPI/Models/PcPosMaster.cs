namespace RentProjectAPI.Models
{
    public class PcPosMaster
    {
        public int ID { get; set; }
        public int PcMasterID { get; set; }
        public int StokID { get; set; }
        public int BirimID { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal KDVOrani { get; set; }
        public decimal IskontoYuzde { get; set; }
        public decimal IskontoTutar { get; set; }
        public int DovizID { get; set; }
        public decimal DovizKuru { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public int RowNo { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int ChangedUserID { get; set; }
        public decimal GunSonuBirimFiyati { get; set; }
        public int PlasiyerID { get; set; }
        public decimal ArttirimYuzde { get; set; }
        public decimal ArttirimTutar { get; set; }
        public string UrunAciklama { get; set; }
        public int IadeNedeniID { get; set; }
        public string IadeAciklama { get; set; }
    }
}

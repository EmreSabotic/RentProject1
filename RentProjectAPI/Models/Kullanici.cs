namespace RentProjectAPI.Models
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string PersonelAdiSoyadi { get; set; }
        public string PersonelKullaniciAdi { get; set; }
        public string PersonelSifre { get; set; }
        public bool Aktiflik { get; set; }
        public string PersonelTC { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelTelefonNo { get; set; }
        public bool IsAdmin { get; set; }
        public string IPNumber { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public string UserType { get; set; }
        public string Aciklama { get; set; }
        public bool IsPlasiyer { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}

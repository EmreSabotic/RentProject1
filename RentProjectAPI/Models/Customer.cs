﻿namespace RentProjectAPI.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string CustomerAdi { get; set; }
        public string CustomerSoyadi { get; set; }
        public bool Aktiflik { get; set; }
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public DateTime LastVisitInDate { get; set; }
        public DateTime LastVisitOutDate { get; set; }
        public string CustomerType { get; set; }
       
        public string Aciklama { get; set; }


    }
}


using Microsoft.EntityFrameworkCore;
using RentProjectAPI.Models;

namespace RentProjectAPI.Services.KullaniciService
{

  
    public class KullaniciService : IKullaniciService
    {
        private readonly DataContext _context;
        public KullaniciService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Kullanici>> AddKullanici(Kullanici singlekullanici)
        {
            _context.tblKullanici.Add(singlekullanici);
            await _context.SaveChangesAsync();
            return await _context.tblKullanici.ToListAsync();
        }

        public async Task<List<Kullanici>?> DeleteKullanici(int id)
        {
            var singlekullanici = await _context.tblKullanici.FindAsync(id);
            if (singlekullanici is null)
                return null;
            _context.tblKullanici.Remove(singlekullanici);
            await _context.SaveChangesAsync();
            return await _context.tblKullanici.ToListAsync();
        }

        public async Task<List<Kullanici>> GetAllKullanicis()
        {
            var singlekullanici = await _context.tblKullanici.ToListAsync();
            return singlekullanici;
        }

        public async Task<Kullanici?> GetSingleKullanici(int id)
        {
            var singlekullanici = await _context.tblKullanici.FindAsync(id);
            if (singlekullanici is null)
                return null;
            return singlekullanici;
        }

        public async Task<List<Kullanici>?> UpdateKullanici(int id, Kullanici request)
        {
            var singlekullanici = await _context.tblKullanici.FindAsync(id);
            if (singlekullanici is null)
                return null;

            singlekullanici.PersonelAdiSoyadi = request.PersonelAdiSoyadi;
            singlekullanici.PersonelKullaniciAdi = request.PersonelKullaniciAdi;
            singlekullanici.PersonelSifre = request.PersonelSifre;
            singlekullanici.Aktiflik = request.Aktiflik;
            singlekullanici.PersonelTC = request.PersonelTC;
            singlekullanici.PersonelMail = request.PersonelMail;
            singlekullanici.PersonelTelefonNo = request.PersonelTelefonNo;
            singlekullanici.IsAdmin = request.IsAdmin;
            singlekullanici.IPNumber = request.IPNumber;
            singlekullanici.LastLoginDate = request.LastLoginDate;
            singlekullanici.LastLogoutDate = request.LastLogoutDate;
            singlekullanici.UserType = request.UserType;
            singlekullanici.Aciklama = request.Aciklama;
            singlekullanici.IsPlasiyer = request.IsPlasiyer;
            singlekullanici.CreateDateTime = request.CreateDateTime;


            await _context.SaveChangesAsync();
            return await _context.tblKullanici.ToListAsync();
        }
    }
}

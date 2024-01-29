using Microsoft.EntityFrameworkCore;
using RentProjectAPI.Models;

namespace RentProjectAPI.Services.KategorilerService
{
    public class KategorilerService : IKategorilerService
    {
        private readonly DataContext _context;
        public KategorilerService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Kategoriler>> AddKategori(Kategoriler singlekategori)
        {
            _context.tblKategoriler.Add(singlekategori);
            await _context.SaveChangesAsync();
            return await _context.tblKategoriler.ToListAsync();
        }

        public async Task<List<Kategoriler>?> DeleteKategori(int id)
        {
            var singlekategori = await _context.tblKategoriler.FindAsync(id);
            if (singlekategori is null)
                return null;
            _context.tblKategoriler.Remove(singlekategori);
            await _context.SaveChangesAsync();
            return await _context.tblKategoriler.ToListAsync();
        }

        public async Task<List<Kategoriler>> GetAllKategoris()
        {
            var singlekategori = await _context.tblKategoriler.ToListAsync();
            return singlekategori;
        }

        public async Task<Kategoriler?> GetSingleKategori(int id)
        {
            var singlekategori = await _context.tblKategoriler.FindAsync(id);
            if (singlekategori is null)
                return null;
            return singlekategori;
        }

        public async Task<List<Kategoriler>?> UpdateKategori(int id, Kategoriler request)
        {
            var singlekategori = await _context.tblKategoriler.FindAsync(id);
            if (singlekategori is null)
                return null;

            singlekategori.Kategori = request.Kategori;
            singlekategori.KategoriAdi = request.KategoriAdi;
           

            await _context.SaveChangesAsync();
            return await _context.tblKategoriler.ToListAsync();
        }
    }
}

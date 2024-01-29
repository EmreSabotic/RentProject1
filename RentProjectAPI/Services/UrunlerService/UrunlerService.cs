using Microsoft.EntityFrameworkCore;
using RentProjectAPI.Models;

namespace RentProjectAPI.Services.UrunlerService
{
    public class UrunlerService : IUrunlerService
    {
        private readonly DataContext _context;
        public UrunlerService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Urunler>> AddUrun(Urunler singleurun)
        {
            _context.tblUrunler.Add(singleurun);
            await _context.SaveChangesAsync();
            return await _context.tblUrunler.ToListAsync();
        }

        public async Task<List<Urunler>?> DeleteUrun(int id)
        {
            var singleurun = await _context.tblUrunler.FindAsync(id);
            if (singleurun is null)
                return null;
            _context.tblUrunler.Remove(singleurun);
            await _context.SaveChangesAsync();
            return await _context.tblUrunler.ToListAsync();
        }

        public async Task<List<Urunler>> GetAllUruns()
        {
            var singleurun = await _context.tblUrunler.ToListAsync();
            return singleurun;
        }

        public async Task<Urunler?> GetSingleUrun(int id)
        {
            var singleurun = await _context.tblUrunler.FindAsync(id);
            if (singleurun is null)
                return null;
            return singleurun;
        }

        public async Task<List<Urunler>?> UpdateUrun(int id, Urunler request)
        {
            var singleurun = await _context.tblUrunler.FindAsync(id);
            if (singleurun is null)
                return null;

            singleurun.Urun = request.Urun;
            singleurun.UrunKategori = request.UrunKategori;
            singleurun.UrunFiyati = request.UrunFiyati;
            singleurun.UrunAdi = request.UrunAdi;
            singleurun.UrunAdeti = request.UrunAdeti;



            await _context.SaveChangesAsync();
            return await _context.tblUrunler.ToListAsync();

        }
    }
}

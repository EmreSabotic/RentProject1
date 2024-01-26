using RentProjectAPI.Models;

namespace RentProjectAPI.Services.CariService
{
    public class CariService : ICariService
    {
        private readonly DataContext _context;
        public CariService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Cari>> AddCari(Cari singlecari)
        {
            _context.tblCari.Add(singlecari);
            await _context.SaveChangesAsync();
            return await _context.tblCari.ToListAsync();
        }

        public async Task<List<Cari>?> DeleteCari(int id)
        {
            var singlecari = await _context.tblCari.FindAsync(id);
            if (singlecari is null)
                return null;
            _context.tblCari.Remove(singlecari);
            await _context.SaveChangesAsync();
            return await _context.tblCari.ToListAsync();
        }

        public async Task<List<Cari>> GetAllCaris()
        {
            var singlecari = await _context.tblCari.ToListAsync();
            return singlecari;
        }

        public async Task<Cari?> GetSingleCari(int id)
        {
            var singlecari = await _context.tblCari.FindAsync(id);
            if (singlecari is null)
                return null;
            return singlecari;
        }

        public async Task<List<Cari>?> UpdateCari(int id, Cari request)
        {
            var singlecari = await _context.tblCari.FindAsync(id);
            if (singlecari is null)
                return null;

            singlecari.CustomerID = request.CustomerID;
            singlecari.BelgeTarihi = request.BelgeTarihi;
            singlecari.DokumanSaati = request.DokumanSaati;
            singlecari.Alacak = request.Alacak;
            singlecari.Borç = request.Borç;
            singlecari.Bakiye = request.Bakiye;
            singlecari.Aciklama = request.Aciklama;



            await _context.SaveChangesAsync();
            return await _context.tblCari.ToListAsync();
        }
    }
}

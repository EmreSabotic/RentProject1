using RentProjectAPI.Models;

namespace RentProjectAPI.Services.HareketService
{
    public class HareketService : IHareketService
    {
        private readonly DataContext _context;
        public HareketService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Hareket>> AddHareket(Hareket singlehareket)
        {
            _context.tblHareket.Add(singlehareket);
            await _context.SaveChangesAsync();
            return await _context.tblHareket.ToListAsync();
        }

        public async Task<List<Hareket>?> DeleteHareket(int id)
        {
            var singlehareket = await _context.tblHareket.FindAsync(id);
            if (singlehareket is null)
                return null;
            _context.tblHareket.Remove(singlehareket);
            await _context.SaveChangesAsync();
            return await _context.tblHareket.ToListAsync();
        }

        public async Task<List<Hareket>> GetAllHarekets()
        {
            var singlehareket = await _context.tblHareket.ToListAsync();
            return singlehareket ;
        }

        public async Task<Hareket?> GetSingleHareket(int id)
        {
            var singlehareket = await _context.tblHareket.FindAsync(id);
            if (singlehareket is null)
                return null;
            return singlehareket;
        }

        public async Task<List<Hareket>?> UpdateHareket(int id, Hareket request)
        {
            var singlehareket = await _context.tblHareket.FindAsync(id);
            if (singlehareket is null)
                return null;

            singlehareket.UrunID = request.UrunID;
            singlehareket.CustomerID = request.CustomerID;
            singlehareket.SatanPersonelID = request.SatanPersonelID;
            singlehareket.KategoriID = request.KategoriID;
            singlehareket.SatisTuru = request.SatisTuru;
            singlehareket.Fiyat = request.Fiyat;
            singlehareket.Adet = request.Adet;



            await _context.SaveChangesAsync();
            return await _context.tblHareket.ToListAsync();
        }
    }
}

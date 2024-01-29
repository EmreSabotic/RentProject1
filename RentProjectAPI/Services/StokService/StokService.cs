
using RentProjectAPI.Models;

namespace RentProjectAPI.Services.StokService
{
    public class StokService : IStokService
    {
        private readonly DataContext _context;
        public StokService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Stok>> AddStok(Stok singlestok)
        {
            _context.tblStok.Add(singlestok);
            await _context.SaveChangesAsync();
            return await _context.tblStok.ToListAsync();
        }

        public async Task<List<Stok>?> DeleteStok(int id)
        {
            var singlestok = await _context.tblStok.FindAsync(id);
            if (singlestok is null)
                return null;
            _context.tblStok.Remove(singlestok);
            await _context.SaveChangesAsync();
            return await _context.tblStok.ToListAsync();
        }

        public async Task<List<Stok>> GetAllStoks()
        {
            var singlestok = await _context.tblStok.ToListAsync();
            return singlestok;
        }

        public async Task<Stok?> GetSingleStok(int id)
        {
            var singlestok = await _context.tblStok.FindAsync(id);
            if (singlestok is null)
                return null;
            return singlestok;
        }

        public async Task<List<Stok>?> UpdateStok(int id, Stok request)
        {
            var singlestok = await _context.tblStok.FindAsync(id);
            if (singlestok is null)
                return null;

            singlestok.StokKodu = request.StokKodu;
            singlestok.StokAdi = request.StokAdi;
            singlestok.Aktiflik = request.Aktiflik;
            singlestok.Birim = request.Birim;
            singlestok.BirimCarpan = request.BirimCarpan;
            singlestok.PerakendeKDVID = request.PerakendeKDVID;
            singlestok.ToptanKDVID = request.ToptanKDVID;
            singlestok.AsgariSure = request.AsgariSure;
            singlestok.AzamiSure = request.AzamiSure;
            singlestok.CreateDateTime = request.CreateDateTime;
            singlestok.FiyatID = request.FiyatID;



            await _context.SaveChangesAsync();
            return await _context.tblStok.ToListAsync();
        }
    }
}

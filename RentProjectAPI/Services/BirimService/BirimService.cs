using RentProjectAPI.Models;

namespace RentProjectAPI.Services.BirimService
{
    public class BirimService : IBirimService
    {
        private readonly DataContext _context;
        public BirimService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Birim>> AddBirim(Birim singlebirim)
        {
            _context.tblBirim.Add(singlebirim);
            await _context.SaveChangesAsync();
            return await _context.tblBirim.ToListAsync();
        }

        public async Task<List<Birim>?> DeleteBirim(int id)
        {
            var singlebirim = await _context.tblBirim.FindAsync(id);
            if (singlebirim is null)
                return null;
            _context.tblBirim.Remove(singlebirim);
            await _context.SaveChangesAsync();
            return await _context.tblBirim.ToListAsync();
        }

        public async Task<List<Birim>> GetAllBirims()
        {
            var singlebirim = await _context.tblBirim.ToListAsync();
            return singlebirim;
        }

        public async Task<Birim?> GetSingleBirim(int id)
        {
            var singlebirim = await _context.tblBirim.FindAsync(id);
            if (singlebirim is null)
                return null;
            return singlebirim;
        }

        public async Task<List<Birim>?> UpdateBirim(int id, Birim request)
        {
            var singlebirim = await _context.tblBirim.FindAsync(id);
            if (singlebirim is null)
                return null;

            singlebirim.BirimKodu = request.BirimKodu;
            singlebirim.BirimAdi = request.BirimAdi;
            singlebirim.CreateDateTime = request.CreateDateTime;
          
            

            await _context.SaveChangesAsync();
            return await _context.tblBirim.ToListAsync();
        }
    }
}

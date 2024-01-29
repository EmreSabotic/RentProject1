using RentProjectAPI.Models;

namespace RentProjectAPI.Services.KasaService
{
    public class KasaService : IKasaService
    {
        private readonly DataContext _context;
        public KasaService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Kasa>> AddKasa(Kasa singlekasa)
        {
            _context.tblKasa.Add(singlekasa);
            await _context.SaveChangesAsync();
            return await _context.tblKasa.ToListAsync();
        }

        public async Task<List<Kasa>?> DeleteKasa(int id)
        {
            var singlekasa = await _context.tblKasa.FindAsync(id);
            if (singlekasa is null)
                return null;
            _context.tblKasa.Remove(singlekasa);
            await _context.SaveChangesAsync();
            return await _context.tblKasa.ToListAsync();
        }

        public async Task<List<Kasa>> GetAllKasas()
        {
            var singlekasa = await _context.tblKasa.ToListAsync();
            return singlekasa;
        }

        public async Task<Kasa?> GetSingleKasa(int id)
        {
            var singlekasa = await _context.tblKasa.FindAsync(id);
            if (singlekasa is null)
                return null;
            return singlekasa;
        }

        public async Task<List<Kasa>?> UpdateKasa(int id, Kasa request)
        {
            var singlekasa = await _context.tblKasa.FindAsync(id);
            if (singlekasa is null)
                return null;

            singlekasa.CustomerID = request.CustomerID;
            singlekasa.İslemTuru = request.İslemTuru;
            singlekasa.İslemTutari = request.İslemTutari;
            singlekasa.CreateDateTime = request.CreateDateTime;
            singlekasa.Aciklama = request.Aciklama;



            await _context.SaveChangesAsync();
            return await _context.tblKasa.ToListAsync();
        }
    }
}

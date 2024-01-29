using RentProjectAPI.Models;

namespace RentProjectAPI.Services.DepoService
{
    public class DepoService : IDepoService
    {
        private readonly DataContext _context;
        public DepoService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Depo>> AddDepo(Depo singledepo)
        {
            _context.tblDepo.Add(singledepo);
            await _context.SaveChangesAsync();
            return await _context.tblDepo.ToListAsync();
        }

        public async Task<List<Depo>?> DeleteDepo(int id)
        {
            var singledepo = await _context.tblDepo.FindAsync(id);
            if (singledepo is null)
                return null;
            _context.tblDepo.Remove(singledepo);
            await _context.SaveChangesAsync();
            return await _context.tblDepo.ToListAsync();
        }

        public async Task<List<Depo>> GetAllDepos()
        {
            var singledepo = await _context.tblDepo.ToListAsync();
            return singledepo;
        }

        public async Task<Depo?> GetSingleDepo(int id)
        {
            var singledepo = await _context.tblDepo.FindAsync(id);
            if (singledepo is null)
                return null;
            return singledepo;
        }

        public async Task<List<Depo>?> UpdateDepo(int id, Depo request)
        {
            var singledepo = await _context.tblDepo.FindAsync(id);
            if (singledepo is null)
                return null;

            singledepo.Adres = request.Adres;
            singledepo.DepoKodu = request.DepoKodu;
            singledepo.DepoAdi = request.DepoAdi;
            singledepo.CreateDateTime = request.CreateDateTime;
          



            await _context.SaveChangesAsync();
            return await _context.tblDepo.ToListAsync();
        }

    }
}

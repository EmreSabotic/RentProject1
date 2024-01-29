using RentProjectAPI.Models;

namespace RentProjectAPI.Services.PcMasterService
{
    public class PcMasterService : IPcMasterService
    {
        private readonly DataContext _context;
        public PcMasterService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<PcMaster>> AddPcMaster(PcMaster singlepcmaster)
        {
            _context.tblPcMaster.Add(singlepcmaster);
            await _context.SaveChangesAsync();
            return await _context.tblPcMaster.ToListAsync();
        }

        public async Task<List<PcMaster>?> DeletePcMaster(int id)
        {
            var singlepcmaster = await _context.tblPcMaster.FindAsync(id);
            if (singlepcmaster is null)
                return null;
            _context.tblPcMaster.Remove(singlepcmaster);
            await _context.SaveChangesAsync();
            return await _context.tblPcMaster.ToListAsync();
        
        }

        public async Task<List<PcMaster>> GetAllPcMasters()
        {
            var singlepcmaster = await _context.tblPcMaster.ToListAsync();
            return singlepcmaster;
        }

        public async Task<PcMaster?> GetSinglePcMaster(int id)
        {
            var singlepcmaster = await _context.tblPcMaster.FindAsync(id);
            if (singlepcmaster is null)
                return null;
            return singlepcmaster;
        }

        public async Task<List<PcMaster>?> UpdatePcMaster(int id, PcMaster request)
        {
            var singlepcmaster = await _context.tblPcMaster.FindAsync(id);
            if (singlepcmaster is null)
                return null;

            singlepcmaster.BelgeKodu = request.BelgeKodu;
            singlepcmaster.BelgeTarihi = request.BelgeTarihi;
            singlepcmaster.HareketTuru = request.HareketTuru;
            singlepcmaster.KasaID = request.KasaID;
            singlepcmaster.CariID = request.CariID;
            singlepcmaster.Adres = request.Adres;
            singlepcmaster.DetayIskontoTutari = request.DetayIskontoTutari;
            singlepcmaster.TutarIskontosu = request.TutarIskontosu;
            singlepcmaster.YuzdeIskontosu = request.YuzdeIskontosu;
            singlepcmaster.DovizID = request.DovizID;
            singlepcmaster.DovizKuru = request.DovizKuru;
            singlepcmaster.Aciklama = request.Aciklama;
            singlepcmaster.DepoID = request.DepoID;
            singlepcmaster.ChangedUserID = request.ChangedUserID;
            singlepcmaster.ChangedDateTime = request.ChangedDateTime;
            singlepcmaster.EndDayDateTime = request.EndDayDateTime;
            singlepcmaster.CreateDateTime = request.CreateDateTime;
            singlepcmaster.IsCancel = request.IsCancel;
            singlepcmaster.Is3rdPartySend = request.Is3rdPartySend;
            singlepcmaster.SatisTuru = request.SatisTuru;


            await _context.SaveChangesAsync();
            return await _context.tblPcMaster.ToListAsync();
        }
    }
}

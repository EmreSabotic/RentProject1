using RentProjectAPI.Models;

namespace RentProjectAPI.Services.PcPosMasterService
{
    public class PcPosMasterService : IPcPosMasterService
    {
        private readonly DataContext _context;
        public PcPosMasterService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<PcPosMaster>> AddPcPosMaster(PcPosMaster singlepcposmaster)
        {
            _context.tblPcPosMasterDetail.Add(singlepcposmaster);
            await _context.SaveChangesAsync();
            return await _context.tblPcPosMasterDetail.ToListAsync();
        }

        public async Task<List<PcPosMaster>?> DeletePcPosMaster(int id)
        {
            var singlepcposmaster = await _context.tblPcPosMasterDetail.FindAsync(id);
            if (singlepcposmaster is null)
                return null;
            _context.tblPcPosMasterDetail.Remove(singlepcposmaster);
            await _context.SaveChangesAsync();
            return await _context.tblPcPosMasterDetail.ToListAsync();
        }

        public async Task<List<PcPosMaster>> GetAllPcPosMasters()
        {
            var singlepcposmaster = await _context.tblPcPosMasterDetail.ToListAsync();
            return singlepcposmaster;
        }

        public async Task<PcPosMaster?> GetSinglePcPosMaster(int id)
        {
            var singlepcposmaster = await _context.tblPcPosMasterDetail.FindAsync(id);
            if (singlepcposmaster is null)
                return null;
            return singlepcposmaster;
        }

        public async Task<List<PcPosMaster>?> UpdatePcPosMaster(int id, PcPosMaster request)
        {
            var singlepcposmaster = await _context.tblPcPosMasterDetail.FindAsync(id);
            if (singlepcposmaster is null)
                return null;

            singlepcposmaster.PcMasterID = request.PcMasterID;
            singlepcposmaster.StokID = request.StokID;
            singlepcposmaster.BirimID = request.BirimID;
            singlepcposmaster.BirimFiyat = request.BirimFiyat;
            singlepcposmaster.KDVOrani = request.KDVOrani;
            singlepcposmaster.IskontoYuzde = request.IskontoYuzde;
            singlepcposmaster.IskontoTutar = request.IskontoTutar;
            singlepcposmaster.DovizID = request.DovizID;
            singlepcposmaster.DovizKuru = request.DovizKuru;
            singlepcposmaster.Giren = request.Giren;
            singlepcposmaster.Cikan = request.Cikan;
            singlepcposmaster.RowNo = request.RowNo;
            singlepcposmaster.CreateDateTime = request.CreateDateTime;
            singlepcposmaster.ChangedUserID = request.ChangedUserID;
            singlepcposmaster.GunSonuBirimFiyati = request.GunSonuBirimFiyati;
            singlepcposmaster.PlasiyerID = request.PlasiyerID;
            singlepcposmaster.ArttirimYuzde = request.ArttirimYuzde;
            singlepcposmaster.ArttirimTutar = request.ArttirimTutar;
            singlepcposmaster.UrunAciklama = request.UrunAciklama;
            singlepcposmaster.IadeNedeniID = request.IadeNedeniID;
            singlepcposmaster.IadeAciklama = request.IadeAciklama;


            await _context.SaveChangesAsync();
            return await _context.tblPcPosMasterDetail.ToListAsync();
        }
    }
}

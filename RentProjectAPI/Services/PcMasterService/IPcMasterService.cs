namespace RentProjectAPI.Services.PcMasterService
{
    public interface IPcMasterService
    {
        Task<List<PcMaster>> GetAllPcMasters();
        Task<PcMaster?> GetSinglePcMaster(int id);

        Task<List<PcMaster>> AddPcMaster(PcMaster singlepcmaster);
        Task<List<PcMaster>?> UpdatePcMaster(int id, PcMaster request);
        Task<List<PcMaster>?> DeletePcMaster(int id);
    }
}

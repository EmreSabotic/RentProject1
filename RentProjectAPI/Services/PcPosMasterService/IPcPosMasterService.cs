namespace RentProjectAPI.Services.PcPosMasterService
{
    public interface IPcPosMasterService
    {
        Task<List<PcPosMaster>> GetAllPcPosMasters();
        Task<PcPosMaster?> GetSinglePcPosMaster(int id);

        Task<List<PcPosMaster>> AddPcPosMaster(PcPosMaster singlepcposmaster);
        Task<List<PcPosMaster>?> UpdatePcPosMaster(int id, PcPosMaster request);
        Task<List<PcPosMaster>?> DeletePcPosMaster(int id);
    }
}

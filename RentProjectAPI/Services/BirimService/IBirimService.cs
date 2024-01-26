namespace RentProjectAPI.Services.BirimService
{
    public interface IBirimService
    {
        Task<List<Birim>> GetAllBirims();
        Task<Birim?> GetSingleBirim(int id);

        Task<List<Birim>> AddBirim(Birim singlebirim);
        Task<List<Birim>?> UpdateBirim(int id, Birim request);
        Task<List<Birim>?> DeleteBirim(int id);
    }
}

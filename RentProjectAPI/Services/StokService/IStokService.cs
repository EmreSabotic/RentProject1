namespace RentProjectAPI.Services.StokService
{
    public interface IStokService
    {
        Task<List<Stok>> GetAllStoks();
        Task<Stok?> GetSingleStok(int id);

        Task<List<Stok>> AddStok(Stok singlestok);
        Task<List<Stok>?> UpdateStok(int id, Stok request);
        Task<List<Stok>?> DeleteStok(int id);
    }
}

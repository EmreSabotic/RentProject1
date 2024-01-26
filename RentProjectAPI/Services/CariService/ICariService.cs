namespace RentProjectAPI.Services.CariService
{
    public interface ICariService 
    {
        Task<List<Cari>> GetAllCaris();
        Task<Cari?> GetSingleCari(int id);

        Task<List<Cari>> AddCari(Cari singlecari);
        Task<List<Cari>?> UpdateCari(int id, Cari request);
        Task<List<Cari>?> DeleteCari(int id);
    }
}

namespace RentProjectAPI.Services.HareketService
{
    public interface IHareketService
    {
        Task<List<Hareket>> GetAllHarekets();
        Task<Hareket?> GetSingleHareket(int id);

        Task<List<Hareket>> AddHareket(Hareket singlehareket);
        Task<List<Hareket>?> UpdateHareket(int id, Hareket request);
        Task<List<Hareket>?> DeleteHareket(int id);
    }
}

namespace RentProjectAPI.Services.DövizService
{
    public interface IDövizService
    {
        Task<List<Döviz>> GetAllDövizs();
        Task<Döviz?> GetSingleDöviz(int id);

        Task<List<Döviz>> AddDöviz(Döviz singledöviz);
        Task<List<Döviz>?> UpdateDöviz(int id, Döviz request);
        Task<List<Döviz>?> DeleteDöviz(int id);
    }
}

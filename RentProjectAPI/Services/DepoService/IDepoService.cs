namespace RentProjectAPI.Services.DepoService
{
    public interface IDepoService
    {
        Task<List<Depo>> GetAllDepos();
        Task<Depo?> GetSingleDepo(int id);

        Task<List<Depo>> AddDepo(Depo singledepo);
        Task<List<Depo>?> UpdateDepo(int id, Depo request);
        Task<List<Depo>?> DeleteDepo(int id);
    }
}

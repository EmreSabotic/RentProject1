namespace RentProjectAPI.Services.KasaService
{
    public interface IKasaService
    {
        Task<List<Kasa>> GetAllKasas();
        Task<Kasa?> GetSingleKasa(int id);

        Task<List<Kasa>> AddKasa(Kasa singlekasa);
        Task<List<Kasa>?> UpdateKasa(int id, Kasa request);
        Task<List<Kasa>?> DeleteKasa(int id);
    }
}

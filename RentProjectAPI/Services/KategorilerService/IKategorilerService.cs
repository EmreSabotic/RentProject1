namespace RentProjectAPI.Services.KategorilerService
{
    public interface IKategorilerService 
    {
        Task<List<Kategoriler>> GetAllKategoris();
        Task<Kategoriler?> GetSingleKategori(int id);

        Task<List<Kategoriler>> AddKategori(Kategoriler singlekategori);
        Task<List<Kategoriler>?> UpdateKategori(int id, Kategoriler request);
        Task<List<Kategoriler>?> DeleteKategori(int id);
    }
}

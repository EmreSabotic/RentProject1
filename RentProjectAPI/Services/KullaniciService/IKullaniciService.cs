namespace RentProjectAPI.Services.KullaniciService
{
    public interface IKullaniciService
    {
        Task<List<Kullanici>> GetAllKullanicis();
        Task<Kullanici?> GetSingleKullanici(int id);

        Task<List<Kullanici>> AddKullanici(Kullanici singlekullanici);
        Task<List<Kullanici>?> UpdateKullanici(int id, Kullanici request);
        Task<List<Kullanici>?> DeleteKullanici(int id);
    }
}

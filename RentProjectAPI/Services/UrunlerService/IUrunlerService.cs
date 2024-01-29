namespace RentProjectAPI.Services.UrunlerService
{
    public interface IUrunlerService
    {
        Task<List<Urunler>> GetAllUruns();
        Task<Urunler?> GetSingleUrun(int id);

        Task<List<Urunler>> AddUrun(Urunler singleurun);
        Task<List<Urunler>?> UpdateUrun(int id, Urunler request);
        Task<List<Urunler>?> DeleteUrun(int id);
    }
}


namespace RentProjectAPI.Services.İadeService
{
    public interface IİadeService
    {
        Task<List<İade>> GetAllİades();
        Task<İade?> GetSingleİade(int id);

        Task<List<İade>> Addİade(İade singleiade);
        Task<List<İade>?> Updateİade(int id, İade request);
        Task<List<İade>?> Deleteİade(int id);
    }
}

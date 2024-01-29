using RentProjectAPI.Models;

namespace RentProjectAPI.Services.İadeService
{
    public class İadeService : IİadeService
    {
        private readonly DataContext _context;
        public İadeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<İade>> Addİade(İade singleiade)
        {
            _context.tblİade.Add(singleiade);
            await _context.SaveChangesAsync();
            return await _context.tblİade.ToListAsync();
        }

        public async Task<List<İade>?> Deleteİade(int id)
        {
            var singleiade = await _context.tblİade.FindAsync(id);
            if (singleiade is null)
                return null;
            _context.tblİade.Remove(singleiade);
            await _context.SaveChangesAsync();
            return await _context.tblİade.ToListAsync();
        }

        public async Task<List<İade>> GetAllİades()
        {
            var singleiade = await _context.tblİade.ToListAsync();
            return singleiade;
        }

        public async Task<İade?> GetSingleİade(int id)
        {
            var singleiade = await _context.tblİade.FindAsync(id);
            if (singleiade is null)
                return null;
            return singleiade;
        }

        public async Task<List<İade>?> Updateİade(int id, İade request)
        {
            var singleiade = await _context.tblİade.FindAsync(id);
            if (singleiade is null)
                return null;

            singleiade.Aciklama = request.Aciklama;
            singleiade.PersonelID = request.PersonelID;
            singleiade.CustomerID = request.CustomerID;
        


            await _context.SaveChangesAsync();
            return await _context.tblİade.ToListAsync();
        }
    }

}

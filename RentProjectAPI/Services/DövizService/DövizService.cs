using Microsoft.EntityFrameworkCore;
using RentProjectAPI.Models;

namespace RentProjectAPI.Services.DövizService
{
    public class DövizService : IDövizService
    {
        private readonly DataContext _context;
        public DövizService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Döviz>> AddDöviz(Döviz singledöviz)
        {
            _context.tblDöviz.Add(singledöviz);
            await _context.SaveChangesAsync();
            return await _context.tblDöviz.ToListAsync();
        }

        public async Task<List<Döviz>?> DeleteDöviz(int id)
        {
            var singledöviz = await _context.tblDöviz.FindAsync(id);
            if (singledöviz is null)
                return null;
            _context.tblDöviz.Remove(singledöviz);
            await _context.SaveChangesAsync();
            return await _context.tblDöviz.ToListAsync();
        }

        public async Task<List<Döviz>> GetAllDövizs()
        {
            var singledöviz = await _context.tblDöviz.ToListAsync();
            return singledöviz;
        }

        public async Task<Döviz?> GetSingleDöviz(int id)
        {
            var singledöviz = await _context.tblDöviz.FindAsync(id);
            if (singledöviz is null)
                return null;
            return singledöviz;
        }

        public async Task<List<Döviz>?> UpdateDöviz(int id, Döviz request)
        {
            var singledöviz = await _context.tblDöviz.FindAsync(id);
            if (singledöviz is null)
                return null;

            singledöviz.DövizKuru = request.DövizKuru;
            singledöviz.DövizAdi = request.DövizAdi;
            singledöviz.DövizKodu = request.DövizKodu;
            singledöviz.CreateDateTime = request.CreateDateTime;



            await _context.SaveChangesAsync();
            return await _context.tblDöviz.ToListAsync();
        }
    }
}

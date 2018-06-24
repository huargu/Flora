using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flora.Api.Data;
using Flora.Api.Interfaces;
using Flora.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Flora.Api.Database
{
    public class FloraRepository : IFloraRepository
    {
        private readonly DataContext _context;
        public FloraRepository(DataContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T: class
        {
            this._context.Add(entity);
        }

        public void Delete<T>(T entity) where T: class
        {
            this._context.Remove(entity);
        }
        
        public async Task<IEnumerable<Material>> GetMaterials()
        {

            return await _context.Materials
                .Include(m => m.MaterialSpecifications)
                .ThenInclude(z => z.Specification)
                .ToListAsync();
        }

        public async Task<IEnumerable<Bouquet>> GetBouquets()
        {
            return await _context.Bouquet
                .Include(b => b.BouquetTypes)
                .ThenInclude(d => d.Materials)
                .ThenInclude(a => a.Material)
                .ToListAsync();
        }

        public async Task<Bouquet> GetBouquet(int id) 
        {
            return await _context.Bouquet
                .Where(b => b.BouquetId == id)
                .Include(b => b.BouquetTypes)
                .ThenInclude(d => d.Materials)
                .ThenInclude(a => a.Material)
                .FirstOrDefaultAsync();
        }
    }
}
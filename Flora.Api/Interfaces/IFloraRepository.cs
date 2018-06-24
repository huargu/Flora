using System.Collections.Generic;
using System.Threading.Tasks;
using Flora.Api.Models;

namespace Flora.Api.Interfaces
{
    public interface IFloraRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         Task<IEnumerable<Material>> GetMaterials();
         Task<IEnumerable<Bouquet>> GetBouquets();
         Task<Bouquet> GetBouquet(int id);
    }
}
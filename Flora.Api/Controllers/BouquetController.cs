using System.Threading.Tasks;
using Flora.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flora.Api.Controllers
{
    [Route("api/[controller]")]
    public class BouquetController : Controller
    {
        private readonly IFloraRepository _repo;
        public BouquetController(IFloraRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetBouquets()
        {
            var bouquets = await _repo.GetBouquets();

            return Ok(bouquets);
        }

        [HttpGet("{id}", Name = "GetBouquet")]
        public async Task<IActionResult> GetBouquet(int id)
        {
            var bouquet = await _repo.GetBouquet(id);

            return Ok(bouquet);
        }
    }
}
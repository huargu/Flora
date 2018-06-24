using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Flora.Api.Dtos;
using Flora.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flora.Api.Controllers
{
    [Route("api/[controller]")]
    public class BouquetController : Controller
    {
        private readonly IFloraRepository _repo;
        private readonly IMapper _mapper;
        public BouquetController(IFloraRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetBouquets()
        {
            var bouquets = await _repo.GetBouquets();

            var bouquetsToReturn = _mapper.Map<IEnumerable<BouquetDTO>>(bouquets);

            return Ok(bouquetsToReturn);
        }

        [HttpGet("{id}", Name = "GetBouquet")]
        public async Task<IActionResult> GetBouquet(int id)
        {
            var bouquet = await _repo.GetBouquet(id);

            var bouquetToReturn = _mapper.Map<BouquetDTO>(bouquet);

            return Ok(bouquetToReturn);
        }
    }
}
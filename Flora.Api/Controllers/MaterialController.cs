using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Flora.Api.Dtos;
using Flora.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flora.Api.Controllers
{
    [Route("api/[controller]")]
    public class MaterialController : Controller
    {
        private readonly IFloraRepository _repo;
        private readonly IMapper _mapper;
        public MaterialController(IFloraRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetMaterials()
        {
            var materials = await _repo.GetMaterials();

            var materialToReturn = _mapper.Map<IEnumerable<MaterialDTO>>(materials);

            return Ok(materialToReturn);
        }
    }
}
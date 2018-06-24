using System.Threading.Tasks;
using Flora.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flora.Api.Controllers
{
    [Route("api/[controller]")]
    public class MaterialController : Controller
    {
        private readonly IFloraRepository _repo;
        public MaterialController(IFloraRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetMaterials()
        {
            var materials = await _repo.GetMaterials();

            return Ok(materials);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using OwnedBluRays.API.Repository;

namespace OwnedBluRays.API.Controllers
{
    [Route("api/[controller]")]
    public class BluRayController : Controller
    {
        private readonly BluRayRepository _bluRayRepository;

        public BluRayController(BluRayRepository bluRayRepository)
        {
            _bluRayRepository = bluRayRepository;
        }

        [HttpGet]
        public IActionResult GetAllOwnedBluRays()
        {
            return Ok(_bluRayRepository.GetAllOwnedBluRays());
        }

        [HttpGet("{id}")]
        public IActionResult GetBluRayById(int id)
        {
            return Ok(_bluRayRepository.GetOwnedBluRayById(id));
        }
    }
}
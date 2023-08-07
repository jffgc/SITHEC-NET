using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SITHEC.Domain;
using SITHECH.Api.Mock;

namespace SITHECH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanMockController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var humanRepository = new HumanRepository();
            var humans = humanRepository.GetAll();
            return Ok(humans);
        }
    }
}

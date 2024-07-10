using Api.Dtos;
using Api.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;

        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RolDto rol)
        {

            return Ok(await _rolService.CreateAsync(rol));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_rolService.GetAsync().Result);
        }

    }
}

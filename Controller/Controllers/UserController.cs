using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("token")]
        public IActionResult GetToken()
        {
            return Ok(TokenService.GerarToken(1, "yuri"));
        }

        [HttpGet]
        [Authorize("Bearer")]
        public IActionResult GetAll()
        {
            return Ok("{[1,2,3,4,5,6,7,8,9,10]}");
        }

        [HttpGet("id")]
        [Authorize]
        public IActionResult GetById()
        {
            return Ok("{1}");
        }
    }
}
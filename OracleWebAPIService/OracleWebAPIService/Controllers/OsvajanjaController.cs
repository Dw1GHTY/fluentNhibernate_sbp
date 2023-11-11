using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class OsvajanjaController : Controller
    {

        [HttpPost] 
        [Route("DodajOsvajanje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddOsvajanje([FromBody] DTOOsvajanje osvajanje)
        {
            try
            {
                DataProvider.DodajOsvajanje(osvajanje);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

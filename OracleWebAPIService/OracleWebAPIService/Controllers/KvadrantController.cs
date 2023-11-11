using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class KvadrantController : Controller
    {
        [HttpGet]
        [Route("PreuzmiKvadranteIzGalaksije/{galaksijaID}")]
        public IActionResult GetKvadranti(int galaksijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKvadranteIzGalaksije(galaksijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost] 
        [Route("DodajKvadrant")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddKvadrant([FromBody] DTOKvadrant kvadrant)  
        {
            try
            {
                DataProvider.DodajKvadrant(kvadrant);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

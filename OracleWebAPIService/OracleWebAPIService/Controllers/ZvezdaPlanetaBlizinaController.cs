using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ZvezdaPlanetaBlizinaController : Controller
    {

        [HttpGet]
        [Route("PreuzmiZPB")]
        public IActionResult GetZPB()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZPB());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajZPB")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddZPB([FromBody] DTOZvezdaPlanetaBlizina zpb)
        {
            try
            {
                DataProvider.DodajZvezdaPlanetaBlizina(zpb);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiZPB/{zpbID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteZvezda(int zpbID)
        {
            try
            {
                DataProvider.ObrisiZvezdaPlanetaBlizina(zpbID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

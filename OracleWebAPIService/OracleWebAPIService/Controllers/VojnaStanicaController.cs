using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class VojnaStanicaController : Controller
    {
        [HttpGet]
        [Route("PreuzmiVojneStanicePlanete/{planetaID}")]
        public IActionResult GetVojneStanicePlanete(int planetaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiVojneStanicePlanete(planetaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajVojnuStanicu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddVojnaStanica([FromBody] DTOVojnaStanica stanica)
        {
            try
            {
                DataProvider.DodajVojnuStanicu(stanica);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVojnuStanicu/{stanicaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteVojnaStanica(int stanicaID) 
        {
            try
            {
                DataProvider.ObrisiVojnuStanicu(stanicaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

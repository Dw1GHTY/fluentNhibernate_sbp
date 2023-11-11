using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PlanetaPojavaBlizinaController : Controller
    {

        [HttpGet]
        [Route("PreuzmiPPB/{specPojavaID}")]
        public IActionResult GetPPB(int specPojavaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPlanetePojaveBlizine(specPojavaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajPPB")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPPB([FromBody] DTOPlanetaPojavaBlizina ppb)
        {
            try
            {
                DataProvider.DodajPojavaPlanetaBlizina(ppb);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPPB/{ppbID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeletePPB(int ppbID)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.ObrisiPlanetaPojavaBlizina(ppbID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class BrodController : Controller
    {
        [HttpGet]
        [Route("VratiBrodoveIgraca/{igracID}")]
        public IActionResult GetBrodoveIgraca(int igracID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveBrodoveZaIgraca(igracID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiBrodoveSaveza/{savezID}")]
        public IActionResult GetBrodoveSaveza(int savezID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveBrodoveZaSavez(savezID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiBrodovePlanete/{planetaID}")]
        public IActionResult GetBrodovePlanete(int planetaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiBrodovePlanete(planetaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajBrod")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddSavez([FromBody] DTOBrod brod)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.DodajBrodIgracu(brod);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniBrod")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeSavez([FromBody] DTOBrod brod)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.AzurirajBrod(brod);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiBrod/{brodID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteBrod(int brodID)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.ObrisiBrodPlanete(brodID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

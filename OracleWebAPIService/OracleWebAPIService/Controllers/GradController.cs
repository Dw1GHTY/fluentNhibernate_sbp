using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    public class GradController : Controller
    {
        [HttpGet]
        [Route("PreuzmiGradovePlanete/{planetaID}")]
        public IActionResult GetGradove(int planetaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiGradovePlanete(planetaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajGradPlaneti")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddGradPlaneti([FromBody] DTOGrad grad)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.DodajGradPlaneti(grad);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiGrad/{gradID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteGrad(int gradID)
        {
            try
            {
                DataProvider.ObrisiSavez(gradID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

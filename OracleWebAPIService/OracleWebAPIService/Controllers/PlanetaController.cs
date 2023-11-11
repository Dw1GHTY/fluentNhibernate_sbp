using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PlanetaController : Controller
    {
        [HttpGet]
        [Route("PreuzmiPlanete")]
        public IActionResult GetPlanete()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePlanete());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPlaneteIzGalaksije/{galaksijaID}")]
        public IActionResult GetPlaneteIzGalaksije(int galaksijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPlaneteizGalaksije(galaksijaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajPlanetu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPlaneta([FromBody] DTOPlaneta planeta)
        {
            try
            {
                DataProvider.DodajPlanetu(planeta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPlanetu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangePlaneta([FromBody] DTOPlaneta planeta)
        {
            try
            {
                DataProvider.AzurirajPlanetu(planeta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiPlanetu/{planetaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeletePlaneta(int planetaID)  
        {
            try
            {
                DataProvider.ObrisiPlanetu(planetaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

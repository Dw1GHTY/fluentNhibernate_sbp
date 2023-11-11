using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PrirodniSatelitController : Controller
    {
        [HttpGet]
        [Route("PreuzmiSatelitePlanete/{planetaID}")]
        public IActionResult GetPrirodneSatelite(int planetaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSatelitePlanete(planetaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] 
        [Route("DodajSatelit")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddSatelit([FromBody] DTOPrirodniSatelit satelit)
        {
            try
            {
                DataProvider.DodajPrirodniSatelit(satelit);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSatelit/{satelitID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteSatelit(int satelitID)  
        {
            try
            {
                DataProvider.ObrisiPrirodniSatelit(satelitID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

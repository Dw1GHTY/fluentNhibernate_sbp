using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class SpecPojavaController : Controller
    {

        [HttpGet]
        [Route("PreuzmiSpecPojave/{igracID}")]
        public IActionResult GetSpecPojave()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSpecPojave());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] 
        [Route("DodajPojavu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPojava([FromBody] DTOSpecPojava specPojava)
        {
            try
            {
                DataProvider.DodajSpecPojavu(specPojava);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiSpecPojavu/{pojavaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteSpecPojava(int pojavaID) 
        {
            try
            {
                DataProvider.ObrisiPojavu(pojavaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

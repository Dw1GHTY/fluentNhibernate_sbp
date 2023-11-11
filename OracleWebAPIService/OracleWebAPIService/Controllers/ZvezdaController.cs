using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ZvezdaController : Controller
    {
        [HttpGet]
        [Route("PreuzmiZvezde")]
        public IActionResult GetZvezde()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZvezde());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] 
        [Route("DodajZvezdu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddZvezda([FromBody] DTOZvezda zvezda)
        {
            try
            {
                DataProvider.DodajZvezdu(zvezda);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiZvezdu/{zvezdaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteZvezda(int zvezdaID)
        {
            try
            {
                DataProvider.ObrisiZvezdu(zvezdaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

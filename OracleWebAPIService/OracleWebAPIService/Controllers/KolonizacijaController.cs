using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    public class KolonizacijaController : Controller
    {
        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajKolonizaciju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddKolonizacija([FromBody] DTOKolonizacija kolonizacija)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.DodajKolonizaciju(kolonizacija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

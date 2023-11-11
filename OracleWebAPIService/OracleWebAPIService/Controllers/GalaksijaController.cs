using DeathstarLibrary;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    

        [ApiController]
        [Route("[controller]")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public class GalaksijaController : ControllerBase
        {

            [HttpGet]
            [Route("PreuzmiGalaksije")]
            public IActionResult GetGalaksije()
            {
                try
                {
                    return new JsonResult(DataProvider.VratiSveGalaksije());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPost] //post za dodavanje put za azuriranje(update)
            [Route("DodajGalaksiju")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public IActionResult AddGalaksija([FromBody] DTOGalaksija galaksija)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
            {
                try
                {
                    DataProvider.DodajGalaksiju(galaksija);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }


            [HttpDelete]
            [Route("ObrisiGalaksiju/{galaksijaID}")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public IActionResult DeleteGalaksija(int galaksijaID)
            {
                try
                {
                    DataProvider.ObrisiSavez(galaksijaID);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
        }
    }


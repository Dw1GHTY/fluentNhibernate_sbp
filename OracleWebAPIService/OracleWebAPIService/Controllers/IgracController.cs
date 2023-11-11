using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Deathstar;
using DeathstarLibrary;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class IgracController : Controller
    {

        [HttpGet]
        [Route("PreuzmiIgrace")]
        public IActionResult GetIgraci()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIgrace());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiKolonizacijeIgraca/{igracID}")]
        public IActionResult GetKolonizacijeIgraca(int igracID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKolonizacijeIgraca(igracID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOsvajanjaIgraca/{igracID}")]
        public IActionResult GetOsvajanjaIgraca(int igracID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiOsvajanjaIgraca(igracID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajIgraca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddIgrac([FromBody] DTOIgrac igrac)  
        {
            try
            {
                DataProvider.DodajIgraca(igrac);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniIgraca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeIgrac([FromBody] DTOIgrac igrac)  
        {
            try
            {
                DataProvider.AzurirajIgraca(igrac);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIgraca/{igracID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteIgrac(int igracID)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.ObrisiIgraca(igracID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

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
    public class SavezController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiSaveze")]
        public IActionResult GetSaveze()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSaveze());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost] //post za dodavanje put za azuriranje(update)
        [Route("DodajSavez")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddSavez([FromBody] DTOSavez savez)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try 
            {
                DataProvider.DodajSavez(savez);
                return Ok();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniSavez")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeSavez([FromBody] DTOSavez savez)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.AzurirajSavez(savez);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSavez/{savezID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteSavez(int savezID)  //deserijalizuje sto se pisalo u body na klijentu i poslali serveru u objekat u koji je moguce deserijalizovati na serv.
        {
            try
            {
                DataProvider.ObrisiSavez(savezID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
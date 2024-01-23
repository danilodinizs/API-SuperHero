using APISuperHero.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APISuperHero.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        public readonly IHeroService _heroService;

        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet("{id}/powerstats")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarHeroPorId([FromRoute] string id)
        {
            var response = await _heroService.BuscarHeroPorId(id);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("search/{nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarHeroPorNome([FromRoute] string nome)
        {
            var response = await _heroService.BuscarHeroPorNome(nome);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}

using APISuperHero.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APISuperHero.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        public readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("busca/image")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarHeroPorIdImage([FromRoute] string id)
        {
            var response = await _imageService.BuscarHeroPorIdImage(id);

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

using APISuperHero.Dtos;

namespace APISuperHero.Interfaces
{
    public interface IImageService
    {
        Task<ResponseGenerico<ImageResponse>> BuscarHeroPorIdImage(string id);
    }
}

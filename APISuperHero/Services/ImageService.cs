using APISuperHero.Dtos;
using APISuperHero.Interfaces;
using AutoMapper;

namespace APISuperHero.Services
{
    public class ImageService : IImageService
    {
        private readonly IMapper _mapper;
        private readonly ISuperHeroAPI _superHeroAPI;

        public ImageService(IMapper mapper, ISuperHeroAPI superHeroAPI)
        {
            _mapper = mapper;
            _superHeroAPI = superHeroAPI;
        }

        public async Task<ResponseGenerico<ImageResponse>> BuscarHeroPorIdImage(string id)
        {
            var image = await _superHeroAPI.BuscarHeroPorIdImage(id);
            return _mapper.Map<ResponseGenerico<ImageResponse>>(image);
        }
    }
}

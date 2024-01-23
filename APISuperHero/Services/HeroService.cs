using APISuperHero.Dtos;
using APISuperHero.Interfaces;
using AutoMapper;

namespace APISuperHero.Services
{
    public class HeroService : IHeroService
    {

        private readonly IMapper _mapper;
        private readonly ISuperHeroAPI _superHeroApi;

        public HeroService(IMapper mapper, ISuperHeroAPI superHeroApi)
        {
            _mapper = mapper;
            _superHeroApi = superHeroApi;
        }

        public async Task<ResponseGenerico<HeroResponse>> BuscarHeroPorId(string id)
        {
            var hero = await _superHeroApi.BuscarHeroPorId(id);
            return _mapper.Map<ResponseGenerico<HeroResponse>>(hero);
        }

        public async Task<ResponseGenerico<HeroResponse>> BuscarHeroPorNome(string nome)
        {
            var hero = await _superHeroApi.BuscarHeroPorNome(nome);
            return _mapper.Map<ResponseGenerico<HeroResponse>>(hero);
        }
    }
}

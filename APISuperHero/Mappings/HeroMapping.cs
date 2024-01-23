using APISuperHero.Dtos;
using APISuperHero.Models;
using AutoMapper;

namespace APISuperHero.Mappings
{
    public class HeroMapping : Profile
    {
        public HeroMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<HeroResponse, HeroModel>();
            CreateMap<HeroModel, HeroResponse>();
        }
    }
}

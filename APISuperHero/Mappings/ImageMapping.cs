using APISuperHero.Dtos;
using APISuperHero.Models;
using AutoMapper;

namespace APISuperHero.Mappings
{
    public class ImageMapping : Profile
    {
        public ImageMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<ImageResponse, ImageModel>();
            CreateMap<ImageModel, ImageResponse>();
        }
    }
}

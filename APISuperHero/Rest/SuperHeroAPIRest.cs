using APISuperHero.Dtos;
using APISuperHero.Interfaces;
using APISuperHero.Models;
using System.Dynamic;
using System.Text.Json;

namespace APISuperHero.Rest
{
    public class SuperHeroAPIRest : ISuperHeroAPI
    {
        public async Task<ResponseGenerico<HeroModel>> BuscarHeroPorId(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://superheroapi.com/api.php/2346524325557604/{id}/powerstats");

            var response = new ResponseGenerico<HeroModel>();
            using (var client = new HttpClient())
            {
                var responseSuperHeroAPI = await client.SendAsync(request);
                var contentResp = await responseSuperHeroAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<HeroModel>(contentResp, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (responseSuperHeroAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<HeroModel>> BuscarHeroPorNome(string nome)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://superheroapi.com/api.php/2346524325557604/search/{nome}");

            var response = new ResponseGenerico<HeroModel>();
            using (var client = new HttpClient())
            {
                var responseSuperHeroAPI = await client.SendAsync(request);
                var contentResp = await responseSuperHeroAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<HeroModel>(contentResp, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (responseSuperHeroAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<ImageModel>> BuscarHeroPorIdImage(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://superheroapi.com/api.php/2346524325557604/{id}/image");

            var response = new ResponseGenerico<ImageModel>();
            using (var client = new HttpClient())
            {
                var responseSuperHeroAPI = await client.SendAsync(request);
                var contentResp = await responseSuperHeroAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<ImageModel>(contentResp, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (responseSuperHeroAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseSuperHeroAPI.StatusCode;
                }
            }
            return response;
        }
    }
}

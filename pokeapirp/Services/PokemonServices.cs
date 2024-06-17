using pokeapirp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace pokeapirp.Services
{

    public class PokemonServices
    {
        public HttpClient _httpClient;
        public PokemonServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<PokemosItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            string json = await _httpClient.GetStringAsync(url);
            ListaPokemons lista_pokemos = JsonConvert.DeserializeObject<ListaPokemons>(json);

            return lista_pokemos.results;
        }

        public async Task<PokemonInfo> DevuelveCaracteristicasPokemon(string url)
        {
            string json = await _httpClient.GetStringAsync(url);
            PokemonInfo caracteristicas = JsonConvert.DeserializeObject<PokemonInfo>(json);
            return caracteristicas;
        }
    }
}

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Eksik olan using bildirimi eklendi
using RickAndMortyAPI.Models; // Modellerin bulunduğu namespace (örneğin, RickAndMortyAPI.Models)

public class RickAndMortyService
{
    private readonly HttpClient _httpClient;

    public RickAndMortyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Episode>> GetEpisodesAsync()
    {
        var response = await _httpClient.GetStringAsync("https://rickandmortyapi.com/api/episode");
        var episodes = JsonConvert.DeserializeObject<ApiResponse<Episode>>(response).Results;
        return episodes;
    }

    public async Task<List<Character>> GetCharactersAsync()
    {
        var response = await _httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");
        var characters = JsonConvert.DeserializeObject<ApiResponse<Character>>(response).Results;
        return characters;
    }
}

public class ApiResponse<T>
{
    public List<T> Results { get; set; }
}

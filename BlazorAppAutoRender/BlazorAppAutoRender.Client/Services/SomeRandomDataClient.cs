
using System.Net.Http.Json;

namespace BlazorAppAutoRender.Client.Services
{
    public class SomeRandomDataClient : ISomeRandomData
    {
        private readonly HttpClient _httpClient;

        public SomeRandomDataClient(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }

        public async Task<string[]> GetDummyData()
        {
            var result = await _httpClient.GetFromJsonAsync<string[]>("api/Randoms");

            return result;
        }
    }
}

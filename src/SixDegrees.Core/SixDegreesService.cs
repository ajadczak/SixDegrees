using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SixDegrees.Common.Models;

namespace SixDegrees.Core
{
    public class SixDegreesService : ISixDegreesService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<MovieResult> GetMovieById(string id)
        {
            var content = new MovieResult();
            var uri = "http://www.omdbapi.com/?";
            var message = new HttpRequestMessage(HttpMethod.Get, $"{uri}i={id}");
            var result = await _client.SendAsync(message);
            if (result.IsSuccessStatusCode)
            {
                content = JsonConvert.DeserializeObject<MovieResult>(await result.Content.ReadAsStringAsync());
            }
            return content;
        }
    }
}

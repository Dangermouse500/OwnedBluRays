using Newtonsoft.Json;
using OwnedBluRays.API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OwnedBluRays.API.Repository
{
    public class BluRayRepositoryWeb
    {
        public async Task<List<BluRay>> GetAllOwnedBluRays()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application.json"));

            var responseMessage = await httpClient.GetAsync("http://192.168.1.35/api/blurays");

            if (!responseMessage.IsSuccessStatusCode) return null;

            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var blurays = JsonConvert.DeserializeObject<IEnumerable<BluRay>>(jsonResult);

            return blurays.ToList();
        }

        public async Task<BluRay> GetOwnedBluRayById(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application.json"));

            var responseMessage = await httpClient.GetAsync("http://192.168.1.35/api/blurays/" + id);

            if (!responseMessage.IsSuccessStatusCode) return null;

            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var bluray = JsonConvert.DeserializeObject<BluRay>(jsonResult);

            return bluray;
        }
    }
}
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NasaPictures.Model
{
    public class ApodService
    {
        public ApodService() { }

        private string apodServiceUrl;

        public string APODServiceUrl
        {
            get
            {
                if(string.IsNullOrEmpty(apodServiceUrl))
                {
                    apodServiceUrl = "https://api.nasa.gov/planetary/apod";
                }
                return apodServiceUrl;
            }
            set
            {
                apodServiceUrl = value;
            }
        }

        public async Task<SpaceImageDTO> GetImage(DateTime dt)
        {
            SpaceImageDTO dto = null;
            HttpResponseMessage response = null;

            string requestUrl = APODServiceUrl + "?date=" + dt.ToString("yyyy-MM-dd") +
                "&api_key=" + App.ApiKey;
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

                HttpClient client = ServiceInterface.Instance.GetClient();

                response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dto = JsonConvert.DeserializeObject<SpaceImageDTO>(json); ;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
            return dto;
        }
    }
}

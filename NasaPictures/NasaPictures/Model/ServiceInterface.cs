using System.Net.Http;

namespace NasaPictures.Model
{
    public class ServiceInterface
    {
        //private static string token;
        private static ServiceInterface instance = new ServiceInterface();
        private static HttpClient client; 

        private ServiceInterface(){}
        public static ServiceInterface Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceInterface();
                }
               return instance;
            }
        }

        public HttpClient GetClient()
        {

            if (client == null)
            {
                client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            }
            return client;
        }
    }
}

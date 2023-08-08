using RestSharp;

namespace WatchCatalogWeb.Repository
{
    public class ServiceRepository
    {
        int Timeout { get; set; }
        public HttpClient HClient { get; set; }
        private RestClient client;
        private RestClientOptions options;
        IConfigurationRoot root;

        private IConfigurationRoot InitializeConnection()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
            root = builder.Build();
            return root;
        }
        public ServiceRepository(string Url = "AppSettings:ServiceURL")
        {
            if (root == null)
            {
                InitializeConnection();
            }
            client = new RestClient(root[Url]);
        }
        public T Execute<T>(RestRequest request) where T : new()
        {
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var Exception = new Exception(message, response.ErrorException);
                throw Exception;
            }
            return response.Data;

        }
    }
}

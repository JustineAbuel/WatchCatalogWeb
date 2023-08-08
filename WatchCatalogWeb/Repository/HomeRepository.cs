using RestSharp;
using WatchCatalogAPI.Model;

namespace WatchCatalogWeb.Repository
{
    public class HomeRepository: IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected bool Disposed { get; private set; }
        protected virtual void Dispose(bool disposing)
        {
            Disposed = true;
        }

        ServiceRepository Service = null;

        public HomeRepository()
        {

        }
        public HomeRepository(ServiceRepository API)
        {
            Service = API;
        }

        public WatchInfoModelList GetAllWatchInfo()
        {
            RestRequest listRequest = new RestRequest($"GET_ALL_WATCHINFO", Method.Get);
            WatchInfoModelList listResult = Service.Execute<WatchInfoModelList>(listRequest);
            return listResult;
        }
    }
}

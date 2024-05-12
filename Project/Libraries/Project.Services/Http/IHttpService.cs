using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Project.Services.Http
{
    public interface IHttpService
    {
        #region Methods

        Task<HttpResponseMessage> GetMessageAsyc(string requestUri);
        Task<HttpResponseMessage> GetAsync(string requestUri, IDictionary<string, string> parameters, IDictionary<string, string> headers = null);
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent httpContent = null, IDictionary<string, string> headers = null);
        Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent httpContent = null, IDictionary<string, string> headers = null);

        #endregion
    }
}

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PinnacleFrameworkExcercise.Helpers
{
    class HttpClientHelper
    {
        internal async Task <HttpStatusCode> getStatusCodeFromHttpCall(string source)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            response = await client.GetAsync(source);
            return response.StatusCode;     
        }
    }
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace BaseApplication
{
    public class ActionResult<TResponse> : IHttpActionResult
    {
        private TResponse _value;
        private HttpRequestMessage _request;

        public ActionResult(TResponse value, HttpRequestMessage request)
        {
            _value = value;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(_value)),
                RequestMessage = _request
            };
            return Task.FromResult(response);
        }
    }
}